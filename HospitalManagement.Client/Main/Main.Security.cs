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
        private bool IsAdminUser()
        {
            return GetCurrentUserRole() == HospitalRoles.AdministrativeStaff;
        }

        private bool IsDoctorUser()
        {
            return GetCurrentUserRole() == HospitalRoles.Doctor;
        }

        private bool IsNurseUser()
        {
            return GetCurrentUserRole() == HospitalRoles.Nurse;
        }

        private bool IsPatientUser()
        {
            return GetCurrentUserRole() == HospitalRoles.Patient;
        }

        private bool CanManagePatients()
        {
            return IsAdminUser() || IsNurseUser();
        }

        private bool CanEditOwnPatientProfile()
        {
            return IsPatientUser() && currentPatientId > 0;
        }

        private bool CanManageAppointments()
        {
            return IsAdminUser() || IsNurseUser();
        }

        private bool CanCreateAppointments()
        {
            return IsAdminUser() || IsNurseUser() || IsPatientUser();
        }

        private bool CanUpdateVitals()
        {
            return IsAdminUser() || IsNurseUser() || IsDoctorUser();
        }

        private IQueryable<Patient> GetScopedPatientsQuery(HospitalDbContext db)
        {
            if (IsAdminUser() || IsNurseUser())
            {
                return db.Patients;
            }

            if (IsPatientUser())
            {
                string currentUserId = GetCurrentUserId();
                return db.Patients.Where(patient => patient.PatientUserId == currentUserId);
            }

            if (IsDoctorUser())
            {
                int doctorProfileId = currentDoctorProfileId;
                return db.Patients.Where(patient =>
                    patient.Appointments.Any(appointment => appointment.DoctorProfileId == doctorProfileId));
            }

            return db.Patients.Where(patient => patient.PatientId == -1);
        }

        private IQueryable<Appointment> GetScopedAppointmentsQuery(HospitalDbContext db)
        {
            IQueryable<Appointment> appointments = db.Appointments
                .Include(appointment => appointment.Patient)
                .Include(appointment => appointment.DoctorProfile);

            if (IsAdminUser() || IsNurseUser())
            {
                return appointments;
            }

            if (IsPatientUser())
            {
                int patientId = currentPatientId;
                return appointments.Where(appointment => appointment.PatientId == patientId);
            }

            if (IsDoctorUser())
            {
                int doctorProfileId = currentDoctorProfileId;
                return appointments.Where(appointment => appointment.DoctorProfileId == doctorProfileId);
            }

            return appointments.Where(appointment => appointment.AppointmentId == -1);
        }

        private IQueryable<PatientVitals> GetScopedVitalsQuery(HospitalDbContext db)
        {
            IQueryable<PatientVitals> vitals = db.PatientVitals
                .Include(record => record.Patient);

            if (IsAdminUser() || IsNurseUser())
            {
                return vitals;
            }

            if (IsPatientUser())
            {
                int patientId = currentPatientId;
                return vitals.Where(record => record.PatientId == patientId);
            }

            if (IsDoctorUser())
            {
                int doctorProfileId = currentDoctorProfileId;
                return vitals.Where(record =>
                    record.Patient.Appointments.Any(appointment => appointment.DoctorProfileId == doctorProfileId));
            }

            return vitals.Where(record => record.PatientVitalsId == -1);
        }

        private bool CanCurrentUserAccessPatient(HospitalDbContext db, int patientId)
        {
            if (IsAdminUser() || IsNurseUser())
            {
                return true;
            }

            if (IsPatientUser())
            {
                return patientId == currentPatientId;
            }

            if (IsDoctorUser())
            {
                int doctorProfileId = currentDoctorProfileId;
                return db.Appointments.Any(appointment =>
                    appointment.PatientId == patientId &&
                    appointment.DoctorProfileId == doctorProfileId);
            }

            return false;
        }

        private bool CanCurrentUserAccessAppointment(HospitalDbContext db, int appointmentId)
        {
            return GetScopedAppointmentsQuery(db)
                .Any(appointment => appointment.AppointmentId == appointmentId);
        }

        private List<string> GetAssignedPatientNames()
        {
            List<string> patientNames = new List<string>();

            if (!IsDoctorUser() || currentDoctorProfileId == 0)
            {
                return patientNames;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    int doctorProfileId = currentDoctorProfileId;
                    patientNames = db.Appointments
                        .Where(appointment => appointment.DoctorProfileId == doctorProfileId)
                        .Select(appointment => appointment.Patient.Name)
                        .Distinct()
                        .ToList();
                }
            }
            catch
            {
                // Notification filtering should not break live update handling.
            }

            return patientNames;
        }

        private bool CanCurrentUserSeeNotificationMessage(string message)
        {
            if (IsAdminUser() || IsNurseUser())
            {
                return true;
            }

            if (IsPatientUser())
            {
                return !String.IsNullOrWhiteSpace(currentPatientName) &&
                       message.IndexOf(currentPatientName, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            if (IsDoctorUser())
            {
                if (!String.IsNullOrWhiteSpace(currentDoctorDisplayName) &&
                    message.IndexOf(currentDoctorDisplayName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return true;
                }

                foreach (string patientName in GetAssignedPatientNames())
                {
                    if (message.IndexOf(patientName, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return true;
                    }
                }

                return false;
            }

            return false;
        }

        private bool IsPatientConversation(string conversationName)
        {
            return !String.IsNullOrWhiteSpace(conversationName) &&
                   conversationName.StartsWith("Patient: ", StringComparison.OrdinalIgnoreCase);
        }

        private bool CanCurrentUserAccessConversation(ListItem conversation)
        {
            if (conversation == null)
            {
                return false;
            }

            if (conversation.ConversationType != "Patient" || !IsPatientConversation(conversation.Name))
            {
                return false;
            }

            if (IsAdminUser() || IsNurseUser())
            {
                return true;
            }

            if (IsPatientUser())
            {
                return conversation.PatientId == currentPatientId;
            }

            if (IsDoctorUser())
            {
                try
                {
                    using (HospitalDbContext db = CreateHospitalDbContext())
                    {
                        return CanCurrentUserAccessPatient(db, conversation.PatientId);
                    }
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        private bool CanCurrentUserAccessConversationName(string conversationName)
        {
            if (!IsPatientConversation(conversationName))
            {
                return false;
            }

            if (IsAdminUser() || IsNurseUser())
            {
                return true;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    int? patientId = db.ChatConversations
                        .Where(conversation =>
                            conversation.ConversationName == conversationName &&
                            conversation.ConversationType == "Patient")
                        .Select(conversation => (int?)conversation.PatientId)
                        .FirstOrDefault();

                    if (!patientId.HasValue)
                    {
                        return false;
                    }

                    return CanCurrentUserAccessPatient(db, patientId.Value);
                }
            }
            catch
            {
                return false;
            }
        }

        private void ApplyRolePermissions()
        {
            // Patient users get only their care summary, appointments, and messages.
            if (IsPatientUser())
            {
                RemoveTabIfPresent(doctorVisitsTab);
                RemoveTabIfPresent(dashboardTab);
                RemoveTabIfPresent(patientsTab);
                RemoveTabIfPresent(communicationTab);
                RemoveTabIfPresent(inventoryTab);
                RemoveTabIfPresent(analyticsTab);
                RemoveTabIfPresent(monitoringTab);
                SelectTabIfPresent(patientCareTab);
                return;
            }

            RemoveTabIfPresent(patientCareTab);
            RemoveTabIfPresent(patientMessagesTab);

            // Administrative Staff keeps the dashboard and staff tools.
            if (IsAdminUser())
            {
                RemoveTabIfPresent(doctorVisitsTab);
                return;
            }

            // Doctor gets a visit summary plus scoped patients, appointments, messages, and vitals.
            if (IsDoctorUser())
            {
                RemoveTabIfPresent(dashboardTab);
                RemoveTabIfPresent(inventoryTab);
                RemoveTabIfPresent(analyticsTab);
                SelectTabIfPresent(doctorVisitsTab);
                return;
            }

            RemoveTabIfPresent(doctorVisitsTab);

            // Nurse keeps the dashboard, patients, appointments, messages, and vitals.
            if (IsNurseUser())
            {
                RemoveTabIfPresent(inventoryTab);
                RemoveTabIfPresent(analyticsTab);
            }
        }

        private void RemoveTabIfPresent(TabPage tabPage)
        {
            if (tabPage != null && mainTabs.TabPages.Contains(tabPage))
            {
                mainTabs.TabPages.Remove(tabPage);
            }
        }

        private void SelectTabIfPresent(TabPage tabPage)
        {
            if (tabPage != null && mainTabs.TabPages.Contains(tabPage))
            {
                mainTabs.SelectedTab = tabPage;
            }
        }
    }
}
