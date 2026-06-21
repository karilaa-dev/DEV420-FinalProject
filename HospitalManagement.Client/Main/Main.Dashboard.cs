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
        private void RefreshDashboardCounts()
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    txtDashboardPatients.Text = GetScopedPatientCount(db).ToString();
                    txtDashboardAppointments.Text = GetScopedTodayAppointmentCount(db).ToString();
                    txtDashboardLowStock.Text = IsAdminUser()
                        ? db.InventoryItems.Count(item => item.Quantity <= item.ReorderLevel).ToString()
                        : "0";

                    txtDashboardEmergencies.Text = GetScopedCriticalVitalsCount(db).ToString();

                    LoadCriticalStatusList(db);
                    LoadNotificationList(db);
                    LoadRoleSummaryViews(db);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Dashboard counts could not be loaded: " + ex.Message;
            }
        }

        private void LoadRoleSummaryViews(HospitalDbContext db)
        {
            if (IsPatientUser())
            {
                LoadPatientCareSummary(db);
            }
            else if (IsDoctorUser())
            {
                LoadDoctorVisitSummary(db);
            }
        }

        private int GetScopedPatientCount(HospitalDbContext db)
        {
            return GetScopedPatientsQuery(db).Count();
        }

        private int GetScopedTodayAppointmentCount(HospitalDbContext db)
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            return GetScopedAppointmentsQuery(db)
                .Count(appointment =>
                    appointment.AppointmentDateTime >= today &&
                    appointment.AppointmentDateTime < tomorrow &&
                    appointment.AppointmentStatus != "Cancelled");
        }

        private int GetScopedCriticalVitalsCount(HospitalDbContext db)
        {
            DateTime recentThreshold = DateTime.Now.AddDays(-1);

            return GetScopedVitalsQuery(db)
                .Count(record =>
                    record.VitalsStatus == "Critical" &&
                    record.UpdatedAt >= recentThreshold);
        }

        private void LoadCriticalStatusList(HospitalDbContext db)
        {
            currentAlertsGrid.Rows.Clear();

            List<PatientVitals> vitalAlerts = GetScopedVitalsQuery(db)
                .Where(record => record.VitalsStatus == "Warning" || record.VitalsStatus == "Critical")
                .OrderByDescending(record => record.UpdatedAt)
                .Take(10)
                .ToList();

            foreach (PatientVitals vitalAlert in vitalAlerts)
            {
                int rowIndex = currentAlertsGrid.Rows.Add(
                    vitalAlert.VitalsStatus,
                    vitalAlert.Patient == null ? "Unknown patient" : vitalAlert.Patient.Name,
                    "HR " +
                    vitalAlert.HeartRate.ToString() +
                    ", O2 " +
                    vitalAlert.OxygenLevel.ToString() +
                    "%, Temp " +
                    vitalAlert.Temperature.ToString("0.0") +
                    " F",
                    vitalAlert.UpdatedAt.ToString("g"));

                currentAlertsGrid.Rows[rowIndex].DefaultCellStyle.BackColor = GetStatusBackColor(vitalAlert.VitalsStatus);
            }

            if (IsAdminUser())
            {
                List<InventoryItem> lowStockItems = db.InventoryItems
                    .Where(item => item.Quantity <= item.ReorderLevel)
                    .OrderBy(item => item.Quantity)
                    .Take(10)
                    .ToList();

                foreach (InventoryItem lowStockItem in lowStockItems)
                {
                    int rowIndex = currentAlertsGrid.Rows.Add(
                        "Low stock",
                        lowStockItem.ItemName,
                        lowStockItem.Quantity.ToString() +
                        " remaining, reorder level " +
                        lowStockItem.ReorderLevel.ToString(),
                        lowStockItem.UpdatedAt.ToString("g"));

                    currentAlertsGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }

            if (currentAlertsGrid.Rows.Count == 0)
            {
                currentAlertsGrid.Rows.Add("None", "", "No active critical alerts.", "");
            }
        }

        private void LoadNotificationList(HospitalDbContext db)
        {
            List<NotificationDisplayItem> visibleNotifications = new List<NotificationDisplayItem>();

            List<SystemNotification> notifications = db.SystemNotifications
                .OrderByDescending(notification => notification.CreatedAt)
                .Take(30)
                .ToList();

            foreach (SystemNotification notification in notifications)
            {
                if (!CanCurrentUserSeeNotificationMessage(notification.MessageText) && notification.NotificationType != "System")
                {
                    continue;
                }

                visibleNotifications.Add(new NotificationDisplayItem(
                    notification.NotificationType,
                    notification.MessageText,
                    notification.CreatedAt));
            }

            SetNotificationDisplayItems(visibleNotifications);
        }
    }
}
