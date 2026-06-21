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
        private void LoadDoctorVisitSummary(HospitalDbContext db)
        {
            if (doctorLastVisitSummary == null || doctorNextVisitSummary == null || doctorVisitsGrid == null)
            {
                return;
            }

            btnTextLastVisitPatient.Tag = null;
            btnTextLastVisitPatient.Enabled = false;
            btnTextNextVisitPatient.Tag = null;
            btnTextNextVisitPatient.Enabled = false;

            if (currentDoctorProfileId == 0)
            {
                ShowAppointmentPlaceholder(doctorLastVisitSummary, "No doctor profile is linked to this user.");
                ShowAppointmentPlaceholder(doctorNextVisitSummary, "No doctor profile is linked to this user.");
                LoadDoctorVisitsGrid(new List<Appointment>());
                return;
            }

            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            List<Appointment> doctorAppointments = GetScopedAppointmentsQuery(db)
                .Where(appointment => appointment.DoctorProfileId == currentDoctorProfileId)
                .OrderByDescending(appointment => appointment.AppointmentDateTime)
                .ToList();

            Appointment mostRecentVisit = doctorAppointments
                .Where(IsCompletedAppointment)
                .FirstOrDefault();

            List<Appointment> todayVisits = doctorAppointments
                .Where(appointment =>
                    appointment.AppointmentDateTime >= today &&
                    appointment.AppointmentDateTime < tomorrow &&
                    !IsCancelledAppointment(appointment) &&
                    !IsCompletedAppointment(appointment))
                .OrderBy(appointment => appointment.AppointmentDateTime)
                .ToList();

            LoadDoctorVisitsGrid(todayVisits);

            if (mostRecentVisit == null)
            {
                ShowAppointmentPlaceholder(doctorLastVisitSummary, "No completed visits found for this doctor.");
            }
            else
            {
                ShowAppointmentSummary(doctorLastVisitSummary, mostRecentVisit, true);
                btnTextLastVisitPatient.Tag = mostRecentVisit.PatientId;
                btnTextLastVisitPatient.Enabled = true;
            }

            if (todayVisits.Count == 0)
            {
                ShowAppointmentPlaceholder(doctorNextVisitSummary, "No remaining visits are scheduled for today.");
            }
            else
            {
                ShowDoctorTodayVisit(todayVisits[0]);
            }
        }

        private void LoadDoctorVisitsGrid(List<Appointment> appointments)
        {
            loadingDoctorVisitsGrid = true;
            doctorVisitsGrid.Rows.Clear();

            foreach (Appointment appointment in appointments)
            {
                int rowIndex = doctorVisitsGrid.Rows.Add(
                    appointment.AppointmentDateTime.ToString("t"),
                    appointment.Patient == null ? "Unknown patient" : appointment.Patient.Name,
                    appointment.AppointmentStatus,
                    appointment.VisitReason
                );

                doctorVisitsGrid.Rows[rowIndex].Tag = appointment.AppointmentId;
                doctorVisitsGrid.Rows[rowIndex].DefaultCellStyle.BackColor = GetStatusBackColor(appointment.AppointmentStatus);
            }

            loadingDoctorVisitsGrid = false;

            if (doctorVisitsGrid.Rows.Count > 0)
            {
                doctorVisitsGrid.ClearSelection();
                doctorVisitsGrid.Rows[0].Selected = true;
                doctorVisitsGrid.CurrentCell = doctorVisitsGrid.Rows[0].Cells[0];
            }
        }

        private void doctorVisitsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (loadingDoctorVisitsGrid || doctorVisitsGrid == null || doctorVisitsGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = doctorVisitsGrid.SelectedRows[0];

            if (selectedRow.Tag == null)
            {
                return;
            }

            int appointmentId = Convert.ToInt32(selectedRow.Tag);

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    Appointment appointment = GetScopedAppointmentsQuery(db)
                        .FirstOrDefault(record => record.AppointmentId == appointmentId);

                    if (appointment == null)
                    {
                        ShowAppointmentPlaceholder(doctorNextVisitSummary, "This visit could not be loaded.");
                        return;
                    }

                    ShowDoctorTodayVisit(appointment);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Today visit details could not be loaded: " + ex.Message;
            }
        }

        private void ShowDoctorTodayVisit(Appointment appointment)
        {
            if (appointment == null)
            {
                ShowAppointmentPlaceholder(doctorNextVisitSummary, "Select a visit to view details.");
                return;
            }

            ShowAppointmentSummary(doctorNextVisitSummary, appointment, true);
            btnTextNextVisitPatient.Tag = appointment.PatientId;
            btnTextNextVisitPatient.Enabled = true;
        }

        private void btnTextVisitPatient_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == null || button.Tag == null)
            {
                MessageBox.Show("No patient is available for this visit.");
                return;
            }

            int patientId = Convert.ToInt32(button.Tag);
            OpenPatientConversationFromVisit(patientId);
        }

        private void OpenPatientConversationFromVisit(int patientId)
        {
            if (patientId == 0)
            {
                MessageBox.Show("No patient is available for this visit.");
                return;
            }

            try
            {
                string patientName;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (!CanCurrentUserAccessPatient(db, patientId))
                    {
                        MessageBox.Show("This user does not have access to that patient conversation.");
                        return;
                    }

                    patientName = GetPatientName(db, patientId);
                }

                if (String.IsNullOrWhiteSpace(patientName))
                {
                    MessageBox.Show("The selected patient could not be found.");
                    return;
                }

                EnsurePatientConversation(patientId, patientName);
                LoadConversations();

                for (int index = 0; index < lstConversations.Items.Count; index++)
                {
                    ListItem item = lstConversations.Items[index] as ListItem;

                    if (item != null && item.PatientId == patientId)
                    {
                        lstConversations.SelectedIndex = index;
                        break;
                    }
                }

                if (mainTabs.TabPages.Contains(communicationTab))
                {
                    mainTabs.SelectedTab = communicationTab;
                }

                LoadChatMessages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Patient chat could not be opened.\n\n" + ex.Message);
            }
        }
    }
}
