using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    public partial class Main
    {
        private void SetupMonitoringTab()
        {
            vitalsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vitalsGrid.MultiSelect = false;

            numHeartRate.Value = 80;
            numOxygenLevel.Value = 98;
            numTemperature.Value = 98.6M;

            ConfigurePatientAutoComplete();
            ApplyMonitoringPermissions();

            LoadVitals();
        }

        private void ApplyMonitoringPermissions()
        {
            bool canUpdateVitals = CanUpdateVitals();

            btnAddVitals.Enabled = canUpdateVitals;
            btnUpdateVitals.Enabled = canUpdateVitals;
            btnClearVitals.Enabled = true;
            cmbMonitoringPatientPicker.Enabled = canUpdateVitals;
            numHeartRate.Enabled = canUpdateVitals;
            txtBloodPressure.ReadOnly = !canUpdateVitals;
            numOxygenLevel.Enabled = canUpdateVitals;
            numTemperature.Enabled = canUpdateVitals;
            txtMonitoringNotes.ReadOnly = !canUpdateVitals;

            if (IsPatientUser() && currentPatientId > 0)
            {
                SelectPatientInPicker(cmbMonitoringPatientPicker, currentPatientId, currentPatientName);
                cmbMonitoringPatientPicker.Enabled = false;
            }
        }

        private void LoadVitals()
        {
            vitalsGrid.Rows.Clear();
            lstMonitoringAlerts.Items.Clear();
            selectedPatientVitalsId = 0;

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<PatientVitals> vitals = GetScopedVitalsQuery(db)
                        .OrderByDescending(record => record.UpdatedAt)
                        .Take(100)
                        .ToList();

                    foreach (PatientVitals vital in vitals)
                    {
                        string status = vital.VitalsStatus;
                        int rowIndex = vitalsGrid.Rows.Add(
                            vital.Patient.Name,
                            vital.Room,
                            vital.HeartRate.ToString(),
                            vital.BloodPressure,
                            vital.OxygenLevel.ToString() + "%",
                            status
                        );

                        vitalsGrid.Rows[rowIndex].Tag = vital.PatientVitalsId;

                        if (status == "Critical")
                        {
                            vitalsGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                            lstMonitoringAlerts.Items.Add(
                                "Critical: " +
                                vital.Patient.Name +
                                " HR " +
                                vital.HeartRate.ToString() +
                                ", O2 " +
                                vital.OxygenLevel.ToString() +
                                "%, Temp " +
                                vital.Temperature.ToString()
                            );
                        }
                        else if (status == "Warning")
                        {
                            vitalsGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LemonChiffon;
                            lstMonitoringAlerts.Items.Add(
                                "Warning: " +
                                vital.Patient.Name +
                                " needs review"
                            );
                        }
                    }
                }

                if (lstMonitoringAlerts.Items.Count == 0)
                {
                    lstMonitoringAlerts.Items.Add("No active critical care alerts.");
                }

                statusText.Text = "Vitals loaded.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Vitals could not be loaded: " + ex.Message;
            }
        }

        private void LoadVitalDetails(int patientVitalsId)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    PatientVitals vitals = GetScopedVitalsQuery(db)
                        .FirstOrDefault(record => record.PatientVitalsId == patientVitalsId);

                    if (vitals != null)
                    {
                        selectedPatientVitalsId = patientVitalsId;
                        SelectPatientInPicker(cmbMonitoringPatientPicker, vitals.PatientId, vitals.Patient.Name);
                        numHeartRate.Value = Convert.ToDecimal(vitals.HeartRate);
                        txtBloodPressure.Text = vitals.BloodPressure ?? "";
                        numOxygenLevel.Value = Convert.ToDecimal(vitals.OxygenLevel);
                        numTemperature.Value = Convert.ToDecimal(vitals.Temperature);
                        txtMonitoringNotes.Text = vitals.Notes ?? "";
                    }
                    else
                    {
                        MessageBox.Show("This user does not have access to that vitals record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vitals details could not be loaded.\n\n" + ex.Message);
            }
        }

        private string GetPatientRoomLabel(HospitalDbContext db, int patientId)
        {
            string department = db.Patients
                .Where(patient => patient.PatientId == patientId)
                .Select(patient => patient.Department)
                .FirstOrDefault();

            if (String.IsNullOrWhiteSpace(department))
            {
                return "Unassigned";
            }

            return department + " Monitoring";
        }

        private string EvaluateVitalsStatus(int heartRate, string bloodPressure, int oxygenLevel, decimal temperature)
        {
            int systolicPressure;
            bool hasSystolicPressure = TryGetSystolicPressure(bloodPressure, out systolicPressure);

            if (heartRate < 40 || heartRate > 130 || oxygenLevel < 90 || temperature < 95M || temperature > 103M)
            {
                return "Critical";
            }

            if (hasSystolicPressure && systolicPressure >= 180)
            {
                return "Critical";
            }

            if (heartRate < 50 || heartRate > 110 || oxygenLevel < 95 || temperature < 97M || temperature > 100.4M)
            {
                return "Warning";
            }

            if (hasSystolicPressure && systolicPressure >= 140)
            {
                return "Warning";
            }

            return "Normal";
        }

        private bool TryGetSystolicPressure(string bloodPressure, out int systolicPressure)
        {
            systolicPressure = 0;

            if (String.IsNullOrWhiteSpace(bloodPressure))
            {
                return false;
            }

            string[] parts = bloodPressure.Split('/');

            if (parts.Length == 0)
            {
                return false;
            }

            return Int32.TryParse(parts[0].Trim(), out systolicPressure);
        }

        private void ClearVitalsForm()
        {
            selectedPatientVitalsId = 0;
            numHeartRate.Value = 80;
            txtBloodPressure.Clear();
            numOxygenLevel.Value = 98;
            numTemperature.Value = 98.6M;
            txtMonitoringNotes.Clear();

            if (IsPatientUser() && currentPatientId > 0)
            {
                SelectPatientInPicker(cmbMonitoringPatientPicker, currentPatientId, currentPatientName);
            }
            else
            {
                ClearPatientPickerSelection(cmbMonitoringPatientPicker);
            }
        }

        private bool TryReadVitalsForm(
            HospitalDbContext db,
            out int patientId,
            out string patientName,
            out int heartRate,
            out string bloodPressure,
            out int oxygenLevel,
            out decimal temperature,
            out string status)
        {
            patientId = 0;
            patientName = "";
            heartRate = Convert.ToInt32(numHeartRate.Value);
            bloodPressure = txtBloodPressure.Text.Trim();
            oxygenLevel = Convert.ToInt32(numOxygenLevel.Value);
            temperature = numTemperature.Value;
            status = EvaluateVitalsStatus(heartRate, bloodPressure, oxygenLevel, temperature);

            if (GetSelectedPatientPickerId(cmbMonitoringPatientPicker) == 0)
            {
                MessageBox.Show("Patient name is required.");
                return false;
            }

            patientId = ResolveSelectedPatientId(db, cmbMonitoringPatientPicker, out patientName);

            if (patientId == 0 || !CanCurrentUserAccessPatient(db, patientId))
            {
                MessageBox.Show("Choose an existing patient this user can access.");
                return false;
            }

            return true;
        }

        private async void btnAddVitals_Click(object sender, EventArgs e)
        {
            if (!CanUpdateVitals())
            {
                MessageBox.Show("This user cannot update patient vitals.");
                return;
            }

            try
            {
                int patientId;
                string patientName;
                int heartRate;
                string bloodPressure;
                int oxygenLevel;
                decimal temperature;
                string status;
                string message;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (!TryReadVitalsForm(
                        db,
                        out patientId,
                        out patientName,
                        out heartRate,
                        out bloodPressure,
                        out oxygenLevel,
                        out temperature,
                        out status))
                    {
                        return;
                    }

                    message = "Vitals added for " + patientName + " (" + status + ").";

                    db.PatientVitals.Add(new PatientVitals
                    {
                        PatientId = patientId,
                        Room = GetPatientRoomLabel(db, patientId),
                        HeartRate = heartRate,
                        BloodPressure = bloodPressure,
                        OxygenLevel = oxygenLevel,
                        Temperature = temperature,
                        VitalsStatus = status,
                        Notes = txtMonitoringNotes.Text,
                        UpdatedAt = DateTime.Now
                    });
                    db.SaveChanges();
                }

                MessageBox.Show("Vitals added successfully.");
                ClearVitalsForm();
                LoadVitals();
                RefreshDashboardCounts();
                SaveNotification(status == "Critical" ? "Emergency" : "Vitals", message);
                await SendVitalsChangeAsync(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vitals could not be added.\n\n" + ex.Message);
            }
        }

        private async void btnUpdateVitals_Click(object sender, EventArgs e)
        {
            if (selectedPatientVitalsId == 0)
            {
                MessageBox.Show("Double-click a vitals record before updating it.");
                return;
            }

            if (!CanUpdateVitals())
            {
                MessageBox.Show("This user cannot update patient vitals.");
                return;
            }

            try
            {
                int patientVitalsId = selectedPatientVitalsId;
                int patientId;
                string patientName;
                int heartRate;
                string bloodPressure;
                int oxygenLevel;
                decimal temperature;
                string status;
                string message;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    PatientVitals vitals = GetScopedVitalsQuery(db)
                        .FirstOrDefault(record => record.PatientVitalsId == patientVitalsId);

                    if (vitals == null)
                    {
                        MessageBox.Show("This user does not have access to that vitals record.");
                        return;
                    }

                    if (!TryReadVitalsForm(
                        db,
                        out patientId,
                        out patientName,
                        out heartRate,
                        out bloodPressure,
                        out oxygenLevel,
                        out temperature,
                        out status))
                    {
                        return;
                    }

                    message = "Vitals updated for " + patientName + " (" + status + ").";

                    vitals.PatientId = patientId;
                    vitals.Room = GetPatientRoomLabel(db, patientId);
                    vitals.HeartRate = heartRate;
                    vitals.BloodPressure = bloodPressure;
                    vitals.OxygenLevel = oxygenLevel;
                    vitals.Temperature = temperature;
                    vitals.VitalsStatus = status;
                    vitals.Notes = txtMonitoringNotes.Text;
                    vitals.UpdatedAt = DateTime.Now;
                    db.SaveChanges();
                }

                MessageBox.Show("Vitals updated successfully.");
                ClearVitalsForm();
                LoadVitals();
                RefreshDashboardCounts();
                SaveNotification(status == "Critical" ? "Emergency" : "Vitals", message);
                await SendVitalsChangeAsync(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vitals could not be updated.\n\n" + ex.Message);
            }
        }

        private void btnMonitoringRefresh_Click(object sender, EventArgs e)
        {
            ConfigurePatientAutoComplete();
            LoadVitals();
            RefreshDashboardCounts();
        }

        private void btnClearVitals_Click(object sender, EventArgs e)
        {
            ClearVitalsForm();
        }

        private void vitalsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || vitalsGrid.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            int patientVitalsId = Convert.ToInt32(vitalsGrid.Rows[e.RowIndex].Tag);
            LoadVitalDetails(patientVitalsId);
        }
    }
}
