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
        private void SetupPatientTab()
        {
            // Set grid selection behavior
            patientGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientGrid.MultiSelect = false;
            txtPatientId.ReadOnly = true;

            // Set default dropdown choices
            if (cmbPatientGender.Items.Count > 0 && cmbPatientGender.SelectedIndex == -1)
            {
                cmbPatientGender.SelectedIndex = 0;
            }

            if (cmbPatientFilter.Items.Count > 0 && cmbPatientFilter.SelectedIndex == -1)
            {
                cmbPatientFilter.SelectedIndex = 0;
            }

            ApplyPatientFormPermissions();

            // Load patient records when dashboard opens
            LoadPatients();
        }

        private void ApplyPatientFormPermissions()
        {
            bool canManagePatients = CanManagePatients();
            bool patientCanEditOwnProfile = CanEditOwnPatientProfile();
            bool canEditPatientFields = canManagePatients || patientCanEditOwnProfile;

            btnAddPatient.Enabled = canManagePatients;
            btnUpdatePatient.Enabled = canEditPatientFields;
            btnDeletePatient.Enabled = canManagePatients;
            btnClearPatient.Enabled = canManagePatients;

            txtPatientName.ReadOnly = !canEditPatientFields;
            txtPatientPhone.ReadOnly = !canEditPatientFields;
            txtPatientNotes.ReadOnly = !canEditPatientFields;
            cmbPatientGender.Enabled = canEditPatientFields;
            dtpPatientDob.Enabled = canEditPatientFields;
            chkPatientAdmitted.Enabled = canManagePatients;
        }

        private void LoadPatients()
        {
            // Clear old grid rows
            patientGrid.Rows.Clear();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    var patientRows = GetScopedPatientsQuery(db)
                        .OrderBy(patient => patient.PatientId)
                        .Select(patient => new
                        {
                            patient.PatientId,
                            patient.Name,
                            patient.IsAdmitted,
                            AssignedDoctor = patient.Appointments
                                .OrderByDescending(appointment => appointment.AppointmentDateTime)
                                .Select(appointment => appointment.DoctorProfile.DisplayName)
                                .FirstOrDefault()
                        })
                        .ToList();

                    foreach (var patient in patientRows)
                    {
                        string admittedText = patient.IsAdmitted ? "Admitted" : "Outpatient";

                        patientGrid.Rows.Add(
                            patient.PatientId.ToString(),
                            patient.Name,
                            admittedText,
                            patient.AssignedDoctor ?? "Not assigned"
                        );
                    }
                }

                statusText.Text = "Patient records loaded.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Patient records could not be loaded: " + ex.Message;
                MessageBox.Show("Patient records could not be loaded. Check the SQL Server connection string and database setup.\n\n" + ex.Message);
            }
        }

        private void SearchPatients()
        {
            // Clear old grid rows
            patientGrid.Rows.Clear();

            string searchText = txtPatientSearch.Text.Trim();
            string filter = cmbPatientFilter.Text;
            int searchPatientId;
            bool searchTextIsId = Int32.TryParse(searchText, out searchPatientId);

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    IQueryable<Patient> patients = GetScopedPatientsQuery(db);

                    if (searchText != "")
                    {
                        patients = patients.Where(patient =>
                            (searchTextIsId && patient.PatientId == searchPatientId) ||
                            patient.Name.Contains(searchText));
                    }

                    if (filter == "Admitted")
                    {
                        patients = patients.Where(patient => patient.IsAdmitted);
                    }
                    else if (filter == "Outpatient")
                    {
                        patients = patients.Where(patient => !patient.IsAdmitted);
                    }
                    else if (filter == "Discharged")
                    {
                        patients = patients.Where(patient => patient.Notes != null && patient.Notes.Contains("discharged"));
                    }

                    var patientRows = patients
                        .OrderBy(patient => patient.PatientId)
                        .Select(patient => new
                        {
                            patient.PatientId,
                            patient.Name,
                            patient.IsAdmitted,
                            AssignedDoctor = patient.Appointments
                                .OrderByDescending(appointment => appointment.AppointmentDateTime)
                                .Select(appointment => appointment.DoctorProfile.DisplayName)
                                .FirstOrDefault()
                        })
                        .ToList();

                    foreach (var patient in patientRows)
                    {
                        string admittedText = patient.IsAdmitted ? "Admitted" : "Outpatient";

                        patientGrid.Rows.Add(
                            patient.PatientId.ToString(),
                            patient.Name,
                            admittedText,
                            patient.AssignedDoctor ?? "Not assigned"
                        );
                    }
                }

                statusText.Text = "Patient search completed.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Patient search failed: " + ex.Message;
                MessageBox.Show("Patient search failed.\n\n" + ex.Message);
            }
        }

        private void LoadPatientDetails(string patientId)
        {
            try
            {
                int parsedPatientId = Convert.ToInt32(patientId);

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Patient patient = GetScopedPatientsQuery(db)
                        .FirstOrDefault(record => record.PatientId == parsedPatientId);

                    if (patient != null)
                    {
                        txtPatientId.Text = patient.PatientId.ToString();
                        txtPatientName.Text = patient.Name;
                        cmbPatientGender.Text = patient.Gender ?? "";
                        dtpPatientDob.Value = patient.DateOfBirth ?? DateTime.Today;
                        txtPatientPhone.Text = patient.Phone ?? "";
                        chkPatientAdmitted.Checked = patient.IsAdmitted;
                        txtPatientNotes.Text = patient.Notes ?? "";
                    }
                    else
                    {
                        MessageBox.Show("This user does not have access to that patient record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Patient details could not be loaded.\n\n" + ex.Message);
            }
        }

        private void ClearPatientForm()
        {
            // Clear patient input fields
            txtPatientId.Clear();
            txtPatientName.Clear();
            txtPatientPhone.Clear();
            txtPatientNotes.Clear();
            chkPatientAdmitted.Checked = false;
            dtpPatientDob.Value = DateTime.Today;

            if (cmbPatientGender.Items.Count > 0)
            {
                cmbPatientGender.SelectedIndex = 0;
            }

            patientGrid.ClearSelection();

            if (txtPatientName.CanFocus)
            {
                txtPatientName.Focus();
            }
        }

        private async void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (!CanManagePatients())
            {
                MessageBox.Show("Only nurses and administrative staff can create patient records.");
                return;
            }

            // Validate required fields
            if (txtPatientName.Text == "")
            {
                MessageBox.Show("Patient Name is required.");
                return;
            }

            string patientName = txtPatientName.Text.Trim();

            try
            {
                int patientId;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Patient patient = new Patient
                    {
                        Name = txtPatientName.Text,
                        Gender = cmbPatientGender.Text,
                        DateOfBirth = dtpPatientDob.Value.Date,
                        Phone = txtPatientPhone.Text,
                        IsAdmitted = chkPatientAdmitted.Checked,
                        Notes = txtPatientNotes.Text
                    };

                    db.Patients.Add(patient);
                    db.SaveChanges();
                    patientId = patient.PatientId;
                }

                EnsurePatientConversation(patientId, patientName);
                RefreshVisibleChatView();
                SaveNotification("Patient", "Patient added: " + patientName + ".");
                MessageBox.Show("Patient added successfully.");
                ClearPatientForm();
                LoadPatients();
                ConfigurePatientAutoComplete();
                RefreshDashboardCounts();
                await SendPatientChangeAsync("Patient added: " + patientName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private async void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (!CanManagePatients() && !CanEditOwnPatientProfile())
            {
                MessageBox.Show("This user cannot update patient records.");
                return;
            }

            // Validate required fields
            if (txtPatientId.Text == "" || txtPatientName.Text == "")
            {
                MessageBox.Show("Patient ID and Patient Name are required.");
                return;
            }

            string patientName = txtPatientName.Text.Trim();

            try
            {
                int patientId = Convert.ToInt32(txtPatientId.Text);

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Patient patient = IsPatientUser()
                        ? db.Patients.FirstOrDefault(record => record.PatientId == patientId && record.PatientUserId == GetCurrentUserId())
                        : db.Patients.FirstOrDefault(record => record.PatientId == patientId);

                    if (patient == null)
                    {
                        MessageBox.Show("No patient found with that ID.");
                        return;
                    }

                    patient.Name = txtPatientName.Text;
                    patient.Gender = cmbPatientGender.Text;
                    patient.DateOfBirth = dtpPatientDob.Value.Date;
                    patient.Phone = txtPatientPhone.Text;
                    patient.IsAdmitted = chkPatientAdmitted.Checked;
                    patient.Notes = txtPatientNotes.Text;
                    db.SaveChanges();
                }

                EnsurePatientConversation(Convert.ToInt32(txtPatientId.Text), patientName);
                InitializeCurrentUserContext();
                RefreshVisibleChatView();
                SaveNotification("Patient", "Patient updated: " + patientName + ".");
                MessageBox.Show("Patient updated successfully.");
                if (CanManagePatients())
                {
                    ClearPatientForm();
                }
                LoadPatients();
                ConfigurePatientAutoComplete();
                RefreshDashboardCounts();
                await SendPatientChangeAsync("Patient updated: " + patientName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message);
            }
        }

        private async void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (!CanManagePatients())
            {
                MessageBox.Show("Only nurses and administrative staff can delete patient records.");
                return;
            }

            // Validate patient ID
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Enter or select a Patient ID first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string patientName = txtPatientName.Text.Trim();

            if (patientName == "")
            {
                patientName = txtPatientId.Text.Trim();
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    int patientId = Convert.ToInt32(txtPatientId.Text);
                    Patient patient = db.Patients.FirstOrDefault(record => record.PatientId == patientId);

                    if (patient == null)
                    {
                        MessageBox.Show("No patient found with that ID.");
                        return;
                    }

                    db.Patients.Remove(patient);
                    db.SaveChanges();
                }

                SaveNotification("Patient", "Patient deleted: " + patientName + ".");
                MessageBox.Show("Patient deleted successfully.");
                ClearPatientForm();
                LoadPatients();
                ConfigurePatientAutoComplete();
                RefreshDashboardCounts();
                await SendPatientChangeAsync("Patient deleted: " + patientName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message);
            }
        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            // Clear patient input fields
            ClearPatientForm();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            // Search patient records
            SearchPatients();
        }

        private void btnPatientRefresh_Click(object sender, EventArgs e)
        {
            // Reload all patient records
            txtPatientSearch.Clear();

            if (cmbPatientFilter.Items.Count > 0)
            {
                cmbPatientFilter.SelectedIndex = 0;
            }

            LoadPatients();
            ConfigurePatientAutoComplete();
        }

        private void patientGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0)
            {
                return;
            }

            string patientId = patientGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Load selected patient into form fields
            LoadPatientDetails(patientId);
        }
    }
}
