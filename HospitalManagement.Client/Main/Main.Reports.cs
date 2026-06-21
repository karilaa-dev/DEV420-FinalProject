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
        private void SetupAnalyticsTab()
        {
            if (currentUser != null && !IsAdminUser())
            {
                return;
            }

            reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportGrid.MultiSelect = false;

            dtpReportStart.Value = DateTime.Today.AddDays(-30);
            dtpReportEnd.Value = DateTime.Today;

            if (cmbReportType.Items.Count > 0 && cmbReportType.SelectedIndex == -1)
            {
                cmbReportType.SelectedIndex = 0;
            }

            LoadAnalyticsSummary();
        }

        private void LoadAnalyticsSummary()
        {
            if (currentUser != null && !IsAdminUser())
            {
                return;
            }

            DateTime startDate = dtpReportStart.Value.Date;
            DateTime endDate = dtpReportEnd.Value.Date.AddDays(1);

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    txtAnalyticsVisits.Text = db.Appointments
                        .Count(appointment =>
                            appointment.AppointmentDateTime >= startDate &&
                            appointment.AppointmentDateTime < endDate &&
                            appointment.AppointmentStatus != "Cancelled")
                        .ToString() + " visits";

                    var topAilment = db.Appointments
                        .Where(appointment =>
                            appointment.AppointmentDateTime >= startDate &&
                            appointment.AppointmentDateTime < endDate)
                        .GroupBy(appointment => appointment.VisitReason)
                        .Select(group => new { MetricName = group.Key, MetricCount = group.Count() })
                        .OrderByDescending(metric => metric.MetricCount)
                        .FirstOrDefault();
                    txtAnalyticsCommonAilment.Text = FormatTopReportValue(topAilment == null ? null : topAilment.MetricName, topAilment == null ? 0 : topAilment.MetricCount);

                    var topMedication = db.InventoryTransactions
                        .Where(transaction =>
                            transaction.CreatedAt >= startDate &&
                            transaction.CreatedAt < endDate &&
                            transaction.Category == "Medication" &&
                            transaction.QuantityChange < 0)
                        .GroupBy(transaction => transaction.ItemName)
                        .Select(group => new { MetricName = group.Key, MetricCount = group.Sum(transaction => -transaction.QuantityChange) })
                        .OrderByDescending(metric => metric.MetricCount)
                        .FirstOrDefault();
                    txtAnalyticsMedicationUsage.Text = FormatTopReportValue(topMedication == null ? null : topMedication.MetricName, topMedication == null ? 0 : topMedication.MetricCount);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Analytics summary could not be loaded: " + ex.Message;
            }
        }

        private string FormatTopReportValue(string metricName, int metricCount)
        {
            return String.IsNullOrWhiteSpace(metricName)
                ? "No data"
                : metricName + " (" + metricCount.ToString() + ")";
        }

        private void GenerateAnalyticsReport()
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Analytics reports are available to administrative staff only.");
                return;
            }

            DateTime startDate = dtpReportStart.Value.Date;
            DateTime endDate = dtpReportEnd.Value.Date.AddDays(1);
            int days = Math.Max(1, (endDate - startDate).Days);
            DateTime previousStartDate = startDate.AddDays(-days);
            DateTime previousEndDate = startDate;

            reportGrid.Rows.Clear();
            lstReportOutput.Items.Clear();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (cmbReportType.Text == "Patient Visits")
                    {
                        GeneratePatientVisitsReport(db, startDate, endDate, previousStartDate, previousEndDate);
                    }
                    else if (cmbReportType.Text == "Common Ailments")
                    {
                        GenerateCommonAilmentsReport(db, startDate, endDate, previousStartDate, previousEndDate);
                    }
                    else if (cmbReportType.Text == "Medication Usage")
                    {
                        GenerateMedicationUsageReport(db, startDate, endDate, previousStartDate, previousEndDate);
                    }
                    else
                    {
                        GenerateDepartmentLoadReport(db);
                    }
                }

                LoadAnalyticsSummary();
                statusText.Text = "Analytics report generated.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Analytics report failed: " + ex.Message;
                MessageBox.Show("Analytics report failed.\n\n" + ex.Message);
            }
        }

        private void GeneratePatientVisitsReport(HospitalDbContext db, DateTime startDate, DateTime endDate, DateTime previousStartDate, DateTime previousEndDate)
        {
            int currentVisits = db.Appointments.Count(appointment =>
                appointment.AppointmentDateTime >= startDate &&
                appointment.AppointmentDateTime < endDate &&
                appointment.AppointmentStatus != "Cancelled");
            int previousVisits = db.Appointments.Count(appointment =>
                appointment.AppointmentDateTime >= previousStartDate &&
                appointment.AppointmentDateTime < previousEndDate &&
                appointment.AppointmentStatus != "Cancelled");
            int cancelledVisits = db.Appointments.Count(appointment =>
                appointment.AppointmentDateTime >= startDate &&
                appointment.AppointmentDateTime < endDate &&
                appointment.AppointmentStatus == "Cancelled");
            int admittedPatients = db.Patients.Count(patient => patient.IsAdmitted);

            AddReportRow("Completed or scheduled visits", currentVisits, previousVisits);
            AddReportRow("Cancelled appointments", cancelledVisits, 0);
            AddReportRow("Currently admitted patients", admittedPatients.ToString(), "Current", "N/A");
            AddAppointmentStatusRows(db, startDate, endDate);
            AddDoctorWorkloadRows(db, startDate, endDate);

            lstReportOutput.Items.Add("Patient visit report generated for the selected date range.");
            lstReportOutput.Items.Add("Current period starts " + startDate.ToShortDateString() + " and ends " + endDate.AddDays(-1).ToShortDateString() + ".");
        }

        private void AddAppointmentStatusRows(HospitalDbContext db, DateTime startDate, DateTime endDate)
        {
            var statusRows = db.Appointments
                .Where(appointment =>
                    appointment.AppointmentDateTime >= startDate &&
                    appointment.AppointmentDateTime < endDate)
                .GroupBy(appointment => appointment.AppointmentStatus)
                .Select(group => new { AppointmentStatus = group.Key, StatusCount = group.Count() })
                .OrderByDescending(row => row.StatusCount)
                .ThenBy(row => row.AppointmentStatus)
                .ToList();

            foreach (var statusRow in statusRows)
            {
                AddReportRow(
                    "Status: " + statusRow.AppointmentStatus,
                    statusRow.StatusCount.ToString(),
                    "Current",
                    "N/A"
                );
            }
        }

        private void AddDoctorWorkloadRows(HospitalDbContext db, DateTime startDate, DateTime endDate)
        {
            var doctorRows = db.Appointments
                .Where(appointment =>
                    appointment.AppointmentDateTime >= startDate &&
                    appointment.AppointmentDateTime < endDate &&
                    appointment.AppointmentStatus != "Cancelled")
                .GroupBy(appointment => appointment.DoctorProfile.DisplayName)
                .Select(group => new { DisplayName = group.Key, AppointmentCount = group.Count() })
                .OrderByDescending(row => row.AppointmentCount)
                .ThenBy(row => row.DisplayName)
                .Take(5)
                .ToList();

            foreach (var doctorRow in doctorRows)
            {
                AddReportRow(
                    "Doctor workload: " + doctorRow.DisplayName,
                    doctorRow.AppointmentCount.ToString() + " appointments",
                    "Current",
                    "N/A"
                );
            }
        }

        private void GenerateCommonAilmentsReport(HospitalDbContext db, DateTime startDate, DateTime endDate, DateTime previousStartDate, DateTime previousEndDate)
        {
            var reasonRows = db.Appointments
                .Where(appointment =>
                    appointment.AppointmentDateTime >= startDate &&
                    appointment.AppointmentDateTime < endDate)
                .GroupBy(appointment => appointment.VisitReason)
                .Select(group => new { VisitReason = group.Key, ReasonCount = group.Count() })
                .OrderByDescending(row => row.ReasonCount)
                .ThenBy(row => row.VisitReason)
                .Take(10)
                .ToList();

            foreach (var reasonRow in reasonRows)
            {
                int previousCount = GetReasonCount(db, reasonRow.VisitReason, previousStartDate, previousEndDate);
                AddReportRow(reasonRow.VisitReason, reasonRow.ReasonCount, previousCount);
            }

            if (reportGrid.Rows.Count == 0)
            {
                AddReportRow("No appointment reasons found", "0", "0", "0");
            }

            lstReportOutput.Items.Add("Common ailments are estimated from appointment visit reasons.");
        }

        private int GetReasonCount(HospitalDbContext db, string reason, DateTime startDate, DateTime endDate)
        {
            return db.Appointments.Count(appointment =>
                appointment.AppointmentDateTime >= startDate &&
                appointment.AppointmentDateTime < endDate &&
                appointment.VisitReason == reason);
        }

        private void GenerateMedicationUsageReport(HospitalDbContext db, DateTime startDate, DateTime endDate, DateTime previousStartDate, DateTime previousEndDate)
        {
            var medicationRows = db.InventoryTransactions
                .Where(transaction =>
                    transaction.CreatedAt >= startDate &&
                    transaction.CreatedAt < endDate &&
                    transaction.Category == "Medication" &&
                    transaction.QuantityChange < 0)
                .GroupBy(transaction => transaction.ItemName)
                .Select(group => new { ItemName = group.Key, UsedQuantity = group.Sum(transaction => -transaction.QuantityChange) })
                .OrderByDescending(row => row.UsedQuantity)
                .ThenBy(row => row.ItemName)
                .Take(10)
                .ToList();

            foreach (var medicationRow in medicationRows)
            {
                int previousCount = GetMedicationUsageCount(db, medicationRow.ItemName, previousStartDate, previousEndDate);
                AddReportRow(medicationRow.ItemName, medicationRow.UsedQuantity, previousCount);
            }

            if (reportGrid.Rows.Count == 0)
            {
                AddReportRow("No medication usage transactions found", "0", "0", "0");
            }

            lstReportOutput.Items.Add("Medication usage is calculated from inventory quantity decreases.");
        }

        private int GetMedicationUsageCount(HospitalDbContext db, string itemName, DateTime startDate, DateTime endDate)
        {
            return db.InventoryTransactions
                .Where(transaction =>
                    transaction.CreatedAt >= startDate &&
                    transaction.CreatedAt < endDate &&
                    transaction.Category == "Medication" &&
                    transaction.QuantityChange < 0 &&
                    transaction.ItemName == itemName)
                .Sum(transaction => (int?)(-transaction.QuantityChange)) ?? 0;
        }

        private void GenerateDepartmentLoadReport(HospitalDbContext db)
        {
            var departmentRows = db.Patients
                .GroupBy(patient => patient.Department)
                .Select(group => new
                {
                    Department = group.Key,
                    PatientCount = group.Count(),
                    AdmittedCount = group.Count(patient => patient.IsAdmitted)
                })
                .OrderByDescending(row => row.PatientCount)
                .ThenBy(row => row.Department)
                .ToList();

            foreach (var departmentRow in departmentRows)
            {
                AddReportRow(
                    departmentRow.Department,
                    departmentRow.PatientCount.ToString() + " patients",
                    departmentRow.AdmittedCount.ToString() + " admitted",
                    "Current"
                );
            }

            if (reportGrid.Rows.Count == 0)
            {
                AddReportRow("No department data found", "0", "0", "0");
            }

            lstReportOutput.Items.Add("Department load uses current patient records.");
        }

        private void AddReportRow(string metric, int currentValue, int previousValue)
        {
            AddReportRow(metric, currentValue.ToString(), previousValue.ToString(), FormatChange(currentValue, previousValue));
        }

        private void AddReportRow(string metric, string currentValue, string previousValue, string changeValue)
        {
            reportGrid.Rows.Add(metric, currentValue, previousValue, changeValue);
        }

        private string FormatChange(int currentValue, int previousValue)
        {
            int change = currentValue - previousValue;

            if (change > 0)
            {
                return "+" + change.ToString();
            }

            return change.ToString();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (dtpReportStart.Value.Date > dtpReportEnd.Value.Date)
            {
                MessageBox.Show("Start Date must be before or equal to End Date.");
                return;
            }

            GenerateAnalyticsReport();
        }
    }
}
