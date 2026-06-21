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
        private void LoadPatientCareSummary(HospitalDbContext db)
        {
            if (patientAppointmentSummary == null || lblVitalHeartRate == null)
            {
                return;
            }

            if (currentPatientId == 0)
            {
                ShowAppointmentPlaceholder(patientAppointmentSummary, "No patient profile is linked to this user.");
                ShowVitalsPlaceholder("No vitals recorded yet.");
                return;
            }

            DateTime today = DateTime.Today;
            List<Appointment> patientAppointments = GetScopedAppointmentsQuery(db)
                .Where(appointment =>
                    appointment.PatientId == currentPatientId &&
                    appointment.AppointmentDateTime >= today)
                .OrderBy(appointment => appointment.AppointmentDateTime)
                .ToList();

            Appointment nextAppointment = patientAppointments
                .Where(appointment => !IsCancelledAppointment(appointment) && !IsCompletedAppointment(appointment))
                .FirstOrDefault();

            if (nextAppointment == null)
            {
                ShowAppointmentPlaceholder(patientAppointmentSummary, "No upcoming appointments are scheduled.");
            }
            else
            {
                ShowAppointmentSummary(patientAppointmentSummary, nextAppointment, false);
            }

            PatientVitals latestVitals = GetScopedVitalsQuery(db)
                .Where(record => record.PatientId == currentPatientId)
                .OrderByDescending(record => record.UpdatedAt)
                .FirstOrDefault();

            if (latestVitals == null)
            {
                ShowVitalsPlaceholder("No vitals recorded yet.");
            }
            else
            {
                ShowVitalsSummary(latestVitals);
            }
        }

        private void ShowVitalsSummary(PatientVitals vitals)
        {
            lblPatientVitalsPlaceholder.Visible = false;
            lblVitalHeartRate.Text = vitals.HeartRate.ToString() + " bpm";
            lblVitalBloodPressure.Text = String.IsNullOrWhiteSpace(vitals.BloodPressure) ? "Not recorded" : vitals.BloodPressure;
            lblVitalOxygen.Text = vitals.OxygenLevel.ToString() + "%";
            lblVitalTemperature.Text = vitals.Temperature.ToString("0.0") + " F";
            lblVitalStatus.Text = String.IsNullOrWhiteSpace(vitals.VitalsStatus) ? "Unknown" : vitals.VitalsStatus;
            lblVitalUpdated.Text = vitals.UpdatedAt.ToString("g");
            lblVitalNotes.Text = "Notes: " + (String.IsNullOrWhiteSpace(vitals.Notes) ? "No notes recorded." : vitals.Notes);
            ApplyStatusStyle(lblVitalStatus, null, vitals.VitalsStatus);
        }

        private void ShowVitalsPlaceholder(string message)
        {
            lblPatientVitalsPlaceholder.Text = message;
            lblPatientVitalsPlaceholder.Visible = true;
            lblVitalHeartRate.Text = "--";
            lblVitalBloodPressure.Text = "--";
            lblVitalOxygen.Text = "--";
            lblVitalTemperature.Text = "--";
            lblVitalStatus.Text = "--";
            lblVitalStatus.BackColor = SystemColors.Window;
            lblVitalUpdated.Text = "--";
            lblVitalNotes.Text = "Notes: --";
        }
    }
}
