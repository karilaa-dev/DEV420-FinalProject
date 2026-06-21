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
        private void BindRoleSummaryControls()
        {
            patientAppointmentSummary = CreateAppointmentSummaryBinding(
                lblPatientAppointmentPlaceholder,
                lblPatientAppointmentDateValue,
                lblPatientAppointmentTimeValue,
                lblPatientAppointmentDoctorValue,
                lblPatientAppointmentStatusValue,
                lblPatientAppointmentReasonValue,
                lblPatientAppointmentNotesValue,
                pnlPatientAppointmentStatus,
                null,
                false);

            doctorLastVisitSummary = CreateAppointmentSummaryBinding(
                lblDoctorLastVisitPlaceholder,
                lblDoctorLastVisitDateValue,
                lblDoctorLastVisitTimeValue,
                lblDoctorLastVisitPatientValue,
                lblDoctorLastVisitStatusValue,
                lblDoctorLastVisitReasonValue,
                lblDoctorLastVisitNotesValue,
                pnlDoctorLastVisitStatus,
                btnTextLastVisitPatient,
                true);

            doctorNextVisitSummary = CreateAppointmentSummaryBinding(
                lblDoctorTodayVisitPlaceholder,
                lblDoctorTodayVisitDateValue,
                lblDoctorTodayVisitTimeValue,
                lblDoctorTodayVisitPatientValue,
                lblDoctorTodayVisitStatusValue,
                lblDoctorTodayVisitReasonValue,
                lblDoctorTodayVisitNotesValue,
                pnlDoctorTodayVisitStatus,
                btnTextNextVisitPatient,
                true);
        }

        private AppointmentSummaryControls CreateAppointmentSummaryBinding(
            Label placeholder,
            Label date,
            Label time,
            Label person,
            Label status,
            Label reason,
            Label notes,
            Panel statusStrip,
            Button textPatientButton,
            bool compact)
        {
            return new AppointmentSummaryControls
            {
                Placeholder = placeholder,
                Date = date,
                Time = time,
                Person = person,
                Status = status,
                Reason = reason,
                Notes = notes,
                StatusStrip = statusStrip,
                TextPatientButton = textPatientButton,
                Compact = compact
            };
        }

        private void SetMessageDisplayEmpty(FlowLayoutPanel flowPanel, List<ChatDisplayItem> displayItems, string emptyText)
        {
            displayItems.Clear();
            RenderMessageDisplay(flowPanel, displayItems, emptyText);
        }

        private void SetMessageDisplayItems(FlowLayoutPanel flowPanel, List<ChatDisplayItem> displayItems, IEnumerable<ChatDisplayItem> items, string emptyText)
        {
            displayItems.Clear();

            foreach (ChatDisplayItem item in items.Where(item => item != null))
            {
                displayItems.Add(item);
            }

            RenderMessageDisplay(flowPanel, displayItems, emptyText);
        }

        private void RenderMessageDisplay(FlowLayoutPanel flowPanel, List<ChatDisplayItem> displayItems, string emptyText)
        {
            if (flowPanel == null)
            {
                return;
            }

            flowPanel.SuspendLayout();

            try
            {
                DisplayBlockRenderer.ClearBlocks(flowPanel);
                int blockWidth = DisplayBlockRenderer.GetBlockWidth(flowPanel);

                if (displayItems.Count == 0)
                {
                    flowPanel.Controls.Add(DisplayBlockRenderer.CreateEmptyBlock(emptyText, blockWidth));
                    return;
                }

                foreach (ChatDisplayItem item in displayItems)
                {
                    flowPanel.Controls.Add(
                        DisplayBlockRenderer.CreateTextBlock(
                            item.Title,
                            item.CreatedAt.ToString("g"),
                            item.Message,
                            Font,
                            blockWidth,
                            item.IsCurrentUserMessage));
                }
            }
            finally
            {
                flowPanel.ResumeLayout();
            }
        }

        private void ConfigurePatientAutoComplete()
        {
            int selectedAppointmentPatientId = GetSelectedPatientPickerId(cmbAppointmentPatientPicker);
            int selectedMonitoringPatientId = GetSelectedPatientPickerId(cmbMonitoringPatientPicker);

            try
            {
                List<Patient> patients;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    patients = GetScopedPatientsQuery(db)
                        .OrderBy(patient => patient.Name)
                        .ToList();
                }

                PopulatePatientPicker(cmbAppointmentPatientPicker, patients, selectedAppointmentPatientId);
                PopulatePatientPicker(cmbMonitoringPatientPicker, patients, selectedMonitoringPatientId);

                if (IsPatientUser() && currentPatientId > 0)
                {
                    SelectPatientInPicker(cmbAppointmentPatientPicker, currentPatientId, currentPatientName);
                    SelectPatientInPicker(cmbMonitoringPatientPicker, currentPatientId, currentPatientName);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Patient lists could not be loaded: " + ex.Message;
            }
        }

        private void PopulatePatientPicker(ComboBox comboBox, List<Patient> patients, int selectedPatientId)
        {
            if (comboBox == null)
            {
                return;
            }

            try
            {
                comboBox.BeginUpdate();
                comboBox.Items.Clear();

                foreach (Patient patient in patients)
                {
                    comboBox.Items.Add(new ListItem
                    {
                        Id = patient.PatientId,
                        PatientId = patient.PatientId,
                        Name = patient.Name,
                        PatientName = patient.Name
                    });
                }
            }
            finally
            {
                comboBox.EndUpdate();
            }

            if (selectedPatientId > 0)
            {
                SelectPatientInPicker(comboBox, selectedPatientId, "");
            }
        }

        private void SelectPatientInPicker(ComboBox comboBox, int patientId, string patientName)
        {
            if (comboBox == null)
            {
                return;
            }

            for (int index = 0; index < comboBox.Items.Count; index++)
            {
                ListItem item = comboBox.Items[index] as ListItem;

                if (item != null && item.PatientId == patientId)
                {
                    comboBox.SelectedIndex = index;
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(patientName))
            {
                comboBox.Items.Add(new ListItem
                {
                    Id = patientId,
                    PatientId = patientId,
                    Name = patientName,
                    PatientName = patientName
                });
                comboBox.SelectedIndex = comboBox.Items.Count - 1;
            }
        }

        private void ClearPatientPickerSelection(ComboBox comboBox)
        {
            if (comboBox == null)
            {
                return;
            }

            comboBox.SelectedIndex = -1;
        }

        private int GetSelectedPatientPickerId(ComboBox comboBox)
        {
            ListItem selectedPatient = comboBox == null ? null : comboBox.SelectedItem as ListItem;

            if (selectedPatient == null)
            {
                return 0;
            }

            return selectedPatient.PatientId > 0 ? selectedPatient.PatientId : selectedPatient.Id;
        }

        private string GetSelectedPatientPickerName(ComboBox comboBox)
        {
            ListItem selectedPatient = comboBox == null ? null : comboBox.SelectedItem as ListItem;

            if (selectedPatient == null)
            {
                return "";
            }

            if (!String.IsNullOrWhiteSpace(selectedPatient.PatientName))
            {
                return selectedPatient.PatientName;
            }

            return selectedPatient.Name ?? "";
        }

        private int ResolveSelectedPatientId(HospitalDbContext db, ComboBox comboBox, out string resolvedPatientName)
        {
            int selectedPatientId = GetSelectedPatientPickerId(comboBox);
            resolvedPatientName = GetSelectedPatientPickerName(comboBox);

            if (IsPatientUser())
            {
                resolvedPatientName = currentPatientName;
                return currentPatientId;
            }

            if (selectedPatientId > 0)
            {
                Patient selectedPatient = GetScopedPatientsQuery(db)
                    .FirstOrDefault(patient => patient.PatientId == selectedPatientId);

                if (selectedPatient == null)
                {
                    resolvedPatientName = "";
                    return 0;
                }

                resolvedPatientName = selectedPatient.Name;
                return selectedPatient.PatientId;
            }

            resolvedPatientName = "";
            return 0;
        }

        private void ShowAppointmentSummary(AppointmentSummaryControls controls, Appointment appointment, bool showPatient)
        {
            controls.Placeholder.Visible = false;
            controls.Date.Text = controls.Compact
                ? appointment.AppointmentDateTime.ToString("ddd, MMM d")
                : appointment.AppointmentDateTime.ToString("D");
            controls.Time.Text = appointment.AppointmentDateTime.ToString("t");
            controls.Person.Text = showPatient
                ? (appointment.Patient == null ? "Unknown patient" : appointment.Patient.Name)
                : (appointment.DoctorProfile == null ? "Not assigned" : appointment.DoctorProfile.DisplayName);
            controls.Status.Text = String.IsNullOrWhiteSpace(appointment.AppointmentStatus) ? "Unknown" : appointment.AppointmentStatus;
            controls.Reason.Text = String.IsNullOrWhiteSpace(appointment.VisitReason) ? "Not recorded" : appointment.VisitReason;
            controls.Notes.Text = String.IsNullOrWhiteSpace(appointment.Notes) ? "No notes recorded." : appointment.Notes;
            ApplyStatusStyle(controls.Status, controls.StatusStrip, appointment.AppointmentStatus);
        }

        private void ShowAppointmentPlaceholder(AppointmentSummaryControls controls, string message)
        {
            controls.Placeholder.Text = message;
            controls.Placeholder.Visible = true;
            controls.Date.Text = "";
            controls.Time.Text = "";
            controls.Person.Text = "";
            controls.Status.Text = "";
            controls.Reason.Text = "";
            controls.Notes.Text = "";
            controls.StatusStrip.BackColor = SystemColors.ControlDark;

            if (controls.TextPatientButton != null)
            {
                controls.TextPatientButton.Tag = null;
                controls.TextPatientButton.Enabled = false;
            }
        }

        private bool IsCancelledAppointment(Appointment appointment)
        {
            return StatusEquals(appointment.AppointmentStatus, "Cancelled");
        }

        private bool IsCompletedAppointment(Appointment appointment)
        {
            return StatusEquals(appointment.AppointmentStatus, "Completed");
        }

        private bool StatusEquals(string status, string expectedStatus)
        {
            return String.Equals(status ?? "", expectedStatus, StringComparison.OrdinalIgnoreCase);
        }

        private void ApplyStatusStyle(Label statusLabel, Panel statusStrip, string status)
        {
            Color backColor = GetStatusBackColor(status);
            Color foreColor = SystemColors.ControlText;

            if (IsDarkStatus(status))
            {
                foreColor = Color.DarkRed;
            }

            statusLabel.BackColor = backColor;
            statusLabel.ForeColor = foreColor;
            statusLabel.BorderStyle = BorderStyle.FixedSingle;

            if (statusStrip != null)
            {
                statusStrip.BackColor = backColor == SystemColors.Window ? SystemColors.ControlDark : backColor;
            }
        }

        private Color GetStatusBackColor(string status)
        {
            string normalizedStatus = (status ?? "").Trim().ToLowerInvariant();

            if (normalizedStatus == "critical")
            {
                return Color.MistyRose;
            }

            if (normalizedStatus == "warning" || normalizedStatus == "checked in")
            {
                return Color.LemonChiffon;
            }

            if (normalizedStatus == "completed")
            {
                return Color.Honeydew;
            }

            if (normalizedStatus == "cancelled")
            {
                return Color.Gainsboro;
            }

            if (normalizedStatus == "rescheduled")
            {
                return Color.AliceBlue;
            }

            return SystemColors.Window;
        }

        private bool IsDarkStatus(string status)
        {
            string normalizedStatus = (status ?? "").Trim().ToLowerInvariant();
            return normalizedStatus == "critical";
        }
    }
}
