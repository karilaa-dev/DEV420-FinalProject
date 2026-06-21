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
        private void SetupAppointmentTab()
        {
            // Set grid selection behavior
            appointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentGrid.MultiSelect = false;

            LoadDoctorChoices();
            ConfigurePatientAutoComplete();

            if (cmbAppointmentStatus.Items.Count > 0 && cmbAppointmentStatus.SelectedIndex == -1)
            {
                cmbAppointmentStatus.SelectedIndex = 0;
            }

            dtpAppointmentDate.Value = DateTime.Today;
            dtpAppointmentTime.Value = DateTime.Now;

            ApplyAppointmentFormPermissions();

            LoadAppointments();
        }

        private void ApplyAppointmentFormPermissions()
        {
            bool canCreateAppointments = CanCreateAppointments();
            bool canManageAppointments = CanManageAppointments();
            bool isDoctor = IsDoctorUser();
            bool isPatient = IsPatientUser();

            btnAddAppointment.Enabled = canCreateAppointments && !isDoctor;
            btnUpdateAppointment.Enabled = canManageAppointments || isDoctor;
            btnClearAppointment.Enabled = true;

            cmbAppointmentPatientPicker.Enabled = !isDoctor && !isPatient;
            cmbAppointmentDoctor.Enabled = !isDoctor;
            cmbAppointmentStatus.Enabled = !isPatient;
            txtAppointmentReason.ReadOnly = isDoctor;
            dtpAppointmentDate.Enabled = !isDoctor;
            dtpAppointmentTime.Enabled = !isDoctor;

            if (isPatient && currentPatientId > 0)
            {
                SelectPatientInPicker(cmbAppointmentPatientPicker, currentPatientId, currentPatientName);
            }
            else if (isDoctor)
            {
                ClearPatientPickerSelection(cmbAppointmentPatientPicker);
            }
        }

        private void SyncDoctorProfilesFromMongo()
        {
            try
            {
                List<User> doctorUsers = AppConnections
                    .GetUsersCollection()
                    .Find(u => u.Role == HospitalRoles.Doctor)
                    .ToList();

                foreach (User doctorUser in doctorUsers)
                {
                    UserRepository.EnsureStableUserId(doctorUser);
                    SqlUserProfileSync.EnsureDoctorProfile(doctorUser);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Doctor user sync failed: " + ex.Message;
            }
        }

        private void LoadDoctorChoices()
        {
            string selectedUserId = "";
            ListItem selectedDoctor = cmbAppointmentDoctor.SelectedItem as ListItem;

            if (selectedDoctor != null)
            {
                selectedUserId = selectedDoctor.UserId;
            }

            cmbAppointmentDoctor.Items.Clear();
            SyncDoctorProfilesFromMongo();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<DoctorProfile> doctorProfiles = db.DoctorProfiles
                        .Where(profile => profile.IsActive)
                        .OrderBy(profile => profile.DisplayName)
                        .ToList();

                    foreach (DoctorProfile doctorProfile in doctorProfiles)
                    {
                        ListItem item = new ListItem
                        {
                            Id = doctorProfile.DoctorProfileId,
                            UserId = doctorProfile.UserId,
                            Name = doctorProfile.DisplayName
                        };

                        cmbAppointmentDoctor.Items.Add(item);

                        if (item.UserId == selectedUserId || item.Id == currentDoctorProfileId)
                        {
                            cmbAppointmentDoctor.SelectedItem = item;
                        }
                    }
                }

                if (cmbAppointmentDoctor.SelectedIndex == -1 && cmbAppointmentDoctor.Items.Count > 0)
                {
                    cmbAppointmentDoctor.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Doctor list could not be loaded: " + ex.Message;
            }
        }

        private int GetSelectedDoctorProfileId()
        {
            ListItem selectedDoctor = cmbAppointmentDoctor.SelectedItem as ListItem;

            if (selectedDoctor == null)
            {
                return 0;
            }

            return selectedDoctor.Id;
        }

        private void SelectDoctorProfile(int doctorProfileId)
        {
            for (int index = 0; index < cmbAppointmentDoctor.Items.Count; index++)
            {
                ListItem item = cmbAppointmentDoctor.Items[index] as ListItem;

                if (item != null && item.Id == doctorProfileId)
                {
                    cmbAppointmentDoctor.SelectedIndex = index;
                    return;
                }
            }
        }

        private string GetAppointmentPatientName(HospitalDbContext db, int appointmentId)
        {
            return db.Appointments
                .Where(appointment => appointment.AppointmentId == appointmentId)
                .Select(appointment => appointment.Patient.Name)
                .FirstOrDefault() ?? "";
        }

        private int GetAppointmentPatientId(HospitalDbContext db, int appointmentId)
        {
            return db.Appointments
                .Where(appointment => appointment.AppointmentId == appointmentId)
                .Select(appointment => appointment.PatientId)
                .FirstOrDefault();
        }

        private DateTime GetAppointmentDateTime()
        {
            return dtpAppointmentDate.Value.Date.Add(dtpAppointmentTime.Value.TimeOfDay);
        }

        private void LoadAppointments()
        {
            appointmentGrid.Rows.Clear();
            selectedAppointmentId = 0;

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<Appointment> appointments = GetScopedAppointmentsQuery(db)
                        .OrderBy(appointment => appointment.AppointmentDateTime)
                        .ToList();

                    foreach (Appointment appointment in appointments)
                    {
                        int rowIndex = appointmentGrid.Rows.Add(
                            appointment.AppointmentDateTime.ToString("g"),
                            appointment.Patient.Name,
                            appointment.DoctorProfile.DisplayName,
                            appointment.VisitReason,
                            appointment.AppointmentStatus
                        );

                        appointmentGrid.Rows[rowIndex].Tag = appointment.AppointmentId;
                    }
                }

                statusText.Text = "Appointment records loaded.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Error loading appointments: " + ex.Message;
            }
        }

        private void LoadAppointmentDetails(int appointmentId)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Appointment appointment = GetScopedAppointmentsQuery(db)
                        .FirstOrDefault(record => record.AppointmentId == appointmentId);

                    if (appointment != null)
                    {
                        selectedAppointmentId = appointmentId;
                        SelectPatientInPicker(cmbAppointmentPatientPicker, appointment.PatientId, appointment.Patient.Name);
                        SelectDoctorProfile(appointment.DoctorProfileId);
                        txtAppointmentReason.Text = appointment.VisitReason;
                        dtpAppointmentDate.Value = appointment.AppointmentDateTime.Date;
                        dtpAppointmentTime.Value = DateTime.Today.Add(appointment.AppointmentDateTime.TimeOfDay);
                        cmbAppointmentStatus.Text = appointment.AppointmentStatus;
                        txtAppointmentNotes.Text = appointment.Notes ?? "";
                    }
                    else
                    {
                        MessageBox.Show("This user does not have access to that appointment.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment details: " + ex.Message);
            }
        }

        private void ClearAppointmentForm()
        {
            selectedAppointmentId = 0;
            txtAppointmentReason.Clear();
            txtAppointmentNotes.Clear();
            dtpAppointmentDate.Value = DateTime.Today;
            dtpAppointmentTime.Value = DateTime.Now;

            if (IsPatientUser())
            {
                SelectPatientInPicker(cmbAppointmentPatientPicker, currentPatientId, currentPatientName);
            }
            else
            {
                ClearPatientPickerSelection(cmbAppointmentPatientPicker);
            }

            if (cmbAppointmentDoctor.Items.Count > 0)
            {
                cmbAppointmentDoctor.SelectedIndex = 0;
            }

            if (cmbAppointmentStatus.Items.Count > 0)
            {
                cmbAppointmentStatus.SelectedIndex = 0;
            }
        }

        private async Task SendAutomatedVisitMessageIfNeededAsync(int appointmentId, int patientId, string patientName, string appointmentStatus)
        {
            if (appointmentStatus != "Completed" || patientId == 0)
            {
                return;
            }

            int conversationId = EnsurePatientConversation(patientId, patientName);

            if (conversationId == 0)
            {
                return;
            }

            string conversationName = NormalizePatientConversationName(patientName);
            string messageText = "Thank you for visiting. Please contact hospital staff here if you have follow-up questions.";
            try
            {
                bool messageWasSent;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Appointment appointment = db.Appointments
                        .FirstOrDefault(record =>
                            record.AppointmentId == appointmentId &&
                            !record.CompletionMessageSent);

                    if (appointment == null)
                    {
                        messageWasSent = false;
                    }
                    else
                    {
                        db.ChatMessages.Add(new ChatMessage
                        {
                            ChatConversationId = conversationId,
                            SenderName = "Hospital System",
                            SenderRole = "System",
                            MessageText = messageText,
                            CreatedAt = DateTime.Now
                        });
                        appointment.CompletionMessageSent = true;
                        db.SaveChanges();
                        messageWasSent = true;
                    }
                }

                if (!messageWasSent)
                {
                    return;
                }

                if (IsPatientUser() && IsCurrentPatientConversationName(conversationName))
                {
                    LoadPatientChatMessages();
                }
                else if (GetSelectedConversationName() == conversationName)
                {
                    LoadChatMessages();
                }

                SaveNotification("Chat", "Automated visit follow-up sent to " + patientName + ".");
                await SendChatMessageAsync(conversationName, "Hospital System", messageText);
            }
            catch (Exception ex)
            {
                statusText.Text = "Automated visit message failed: " + ex.Message;
            }
        }

        private async void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (!CanCreateAppointments() || IsDoctorUser())
            {
                MessageBox.Show("This user cannot create appointments.");
                return;
            }

            int doctorProfileId = GetSelectedDoctorProfileId();
            string visitReason = txtAppointmentReason.Text.Trim();
            string appointmentStatus = cmbAppointmentStatus.Text.Trim();
            int selectedPatientId = GetSelectedPatientPickerId(cmbAppointmentPatientPicker);

            if ((!IsPatientUser() && selectedPatientId == 0) || doctorProfileId == 0 || visitReason == "")
            {
                MessageBox.Show("Patient, Doctor, and Visit Reason are required.");
                return;
            }

            if (IsPatientUser() || appointmentStatus == "")
            {
                appointmentStatus = "Scheduled";
            }

            try
            {
                int appointmentId;
                int patientId;
                string patientName;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    patientId = ResolveSelectedPatientId(db, cmbAppointmentPatientPicker, out patientName);

                    if (patientId == 0)
                    {
                        MessageBox.Show("Choose an existing patient before scheduling an appointment.");
                        return;
                    }

                    Appointment appointment = new Appointment
                    {
                        PatientId = patientId,
                        DoctorProfileId = doctorProfileId,
                        VisitReason = visitReason,
                        AppointmentDateTime = GetAppointmentDateTime(),
                        AppointmentStatus = appointmentStatus,
                        Notes = txtAppointmentNotes.Text,
                        CompletionMessageSent = false,
                        CreatedAt = DateTime.Now
                    };

                    db.Appointments.Add(appointment);
                    db.SaveChanges();
                    appointmentId = appointment.AppointmentId;
                }

                EnsurePatientConversation(patientId, patientName);
                RefreshVisibleChatView();
                MessageBox.Show("Appointment added successfully.");
                ClearAppointmentForm();
                LoadAppointments();
                RefreshDashboardCounts();
                SaveNotification("Appointment", "Appointment added for " + patientName + ".");
                await SendAppointmentChangeAsync("Appointment added for " + patientName + ".");
                await SendAutomatedVisitMessageIfNeededAsync(appointmentId, patientId, patientName, appointmentStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message);
            }
        }

        private async void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == 0)
            {
                MessageBox.Show("Double-click an appointment before updating it.");
                return;
            }

            int doctorProfileId = GetSelectedDoctorProfileId();
            string visitReason = txtAppointmentReason.Text.Trim();
            string appointmentStatus = cmbAppointmentStatus.Text.Trim();
            int appointmentId = selectedAppointmentId;

            if (appointmentStatus == "")
            {
                MessageBox.Show("Appointment Status is required.");
                return;
            }

            try
            {
                int patientId = 0;
                string patientName = GetSelectedPatientPickerName(cmbAppointmentPatientPicker);

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (!CanCurrentUserAccessAppointment(db, appointmentId))
                    {
                        MessageBox.Show("This user does not have access to that appointment.");
                        return;
                    }

                    Appointment appointment = db.Appointments.FirstOrDefault(record => record.AppointmentId == appointmentId);

                    if (appointment == null)
                    {
                        MessageBox.Show("No appointment found for the selected row.");
                        return;
                    }

                    if (IsDoctorUser())
                    {
                        patientId = GetAppointmentPatientId(db, appointmentId);
                        patientName = GetAppointmentPatientName(db, appointmentId);
                        appointment.AppointmentStatus = appointmentStatus;
                        appointment.Notes = txtAppointmentNotes.Text;
                    }
                    else if (CanManageAppointments())
                    {
                        if (patientName == "" || doctorProfileId == 0 || visitReason == "")
                        {
                            MessageBox.Show("Patient, Doctor, Visit Reason, and Status are required.");
                            return;
                        }

                        patientId = ResolveSelectedPatientId(db, cmbAppointmentPatientPicker, out patientName);

                        if (patientId == 0)
                        {
                            MessageBox.Show("Choose an existing patient before updating an appointment.");
                            return;
                        }

                        appointment.PatientId = patientId;
                        appointment.DoctorProfileId = doctorProfileId;
                        appointment.VisitReason = visitReason;
                        appointment.AppointmentDateTime = GetAppointmentDateTime();
                        appointment.AppointmentStatus = appointmentStatus;
                        appointment.Notes = txtAppointmentNotes.Text;
                    }
                    else
                    {
                        MessageBox.Show("This user cannot update appointments.");
                        return;
                    }

                    db.SaveChanges();
                }

                if (patientId > 0)
                {
                    EnsurePatientConversation(patientId, patientName);
                }
                RefreshVisibleChatView();
                MessageBox.Show("Appointment updated successfully.");
                ClearAppointmentForm();
                LoadAppointments();
                RefreshDashboardCounts();
                SaveNotification("Appointment", "Appointment updated for " + patientName + ".");
                await SendAppointmentChangeAsync("Appointment updated for " + patientName + ".");
                await SendAutomatedVisitMessageIfNeededAsync(appointmentId, patientId, patientName, appointmentStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating appointment: " + ex.Message);
            }
        }

        private void btnAppointmentRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            RefreshDashboardCounts();
        }

        private void btnClearAppointment_Click(object sender, EventArgs e)
        {
            ClearAppointmentForm();
        }

        private void appointmentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || appointmentGrid.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            int appointmentId = Convert.ToInt32(appointmentGrid.Rows[e.RowIndex].Tag);
            LoadAppointmentDetails(appointmentId);
        }
    }
}
