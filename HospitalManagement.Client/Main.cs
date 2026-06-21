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
    public partial class Main : Form
    {
        private User currentUser;

        private HubConnection hospitalHubConnection;

        private int selectedAppointmentId = 0;

        private int selectedPatientVitalsId = 0;

        private int selectedInventoryItemId = 0;

        private int currentDoctorProfileId = 0;

        private int currentPatientId = 0;

        private string currentPatientName = "";

        private string currentDoctorDisplayName = "";

        private AppointmentSummaryControls patientAppointmentSummary;

        private AppointmentSummaryControls doctorLastVisitSummary;

        private AppointmentSummaryControls doctorNextVisitSummary;

        private bool loadingDoctorVisitsGrid;

        private readonly List<NotificationDisplayItem> notificationDisplayItems = new List<NotificationDisplayItem>();

        private readonly List<ChatDisplayItem> messageDisplayItems = new List<ChatDisplayItem>();

        private readonly List<ChatDisplayItem> patientMessageDisplayItems = new List<ChatDisplayItem>();

        private Notifications notificationsWindow;

        private NotifyIcon notificationTrayIcon;

        private string messageDisplayEmptyText = "Select a conversation to view messages.";

        private string patientMessageDisplayEmptyText = "Your patient messages will appear here.";

        private const int WrappingDisplayItemLimit = 50;

        private class ListItem
        {
            public int Id { get; set; }
            public int PatientId { get; set; }
            public string Name { get; set; }
            public string PatientName { get; set; }
            public string ConversationType { get; set; }
            public string UserId { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private class ChatDisplayItem
        {
            public ChatDisplayItem(string senderName, string senderRole, string messageText, DateTime createdAt, bool isCurrentUserMessage)
            {
                string cleanSenderName = String.IsNullOrWhiteSpace(senderName) ? "Unknown sender" : senderName.Trim();
                string cleanSenderRole = String.IsNullOrWhiteSpace(senderRole) ? "" : senderRole.Trim();

                Title = cleanSenderRole == "" ? cleanSenderName : cleanSenderName + " (" + cleanSenderRole + ")";
                Message = String.IsNullOrWhiteSpace(messageText) ? "" : messageText.Trim();
                CreatedAt = createdAt;
                IsCurrentUserMessage = isCurrentUserMessage;
            }

            public string Title { get; }
            public string Message { get; }
            public DateTime CreatedAt { get; }
            public bool IsCurrentUserMessage { get; }
        }

        private class AppointmentSummaryControls
        {
            public Label Placeholder { get; set; }
            public Label Date { get; set; }
            public Label Time { get; set; }
            public Label Person { get; set; }
            public Label Status { get; set; }
            public Label Reason { get; set; }
            public Label Notes { get; set; }
            public Panel StatusStrip { get; set; }
            public Button TextPatientButton { get; set; }
            public bool Compact { get; set; }
        }

        public Main()
        {
            InitializeComponent();
            BindDesignerControlReferences();
            InitializeDesktopNotifications();

            // Set up tab defaults and load starting data
            SetupPatientTab();
            SetupAppointmentTab();
            SetupInventoryTab();
            SetupAnalyticsTab();
            SetupCommunicationTab();
            SetupPatientMessagesTab();
            SetupMonitoringTab();
            RefreshDashboardCounts();
            ApplyRolePermissions();

            Load += Main_Load;
            FormClosing += Main_FormClosing;
        }

        public Main(User loggedInUser)
        {
            InitializeComponent();
            BindDesignerControlReferences();
            InitializeDesktopNotifications();

            // Save logged in user
            currentUser = loggedInUser;

            InitializeCurrentUserContext();

            // Set up tab defaults and load starting data
            SetupPatientTab();
            SetupAppointmentTab();
            SetupInventoryTab();
            SetupAnalyticsTab();
            SetupCommunicationTab();
            SetupPatientMessagesTab();
            SetupMonitoringTab();
            RefreshDashboardCounts();

            Load += Main_Load;
            FormClosing += Main_FormClosing;

            // Show logged in user and role on dashboard
            lblLoggedInUser.Text = "User: " + GetCurrentUserName();
            lblRole.Text = "Role: " + currentUser.Role;

            // Apply simple role permissions
            ApplyRolePermissions();
        }

        private void BindDesignerControlReferences()
        {
            BindRoleSummaryControls();
        }

        private string GetSqlConnectionString()
        {
            return AppConnections.GetSqlConnectionString();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await StartSignalRConnectionAsync();
        }

        private async void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notificationsWindow != null && !notificationsWindow.IsDisposed)
            {
                notificationsWindow.Close();
            }

            DisposeDesktopNotifications();

            if (hospitalHubConnection != null)
            {
                await hospitalHubConnection.DisposeAsync();
            }
        }

        private HospitalDbContext CreateHospitalDbContext()
        {
            return new HospitalDbContext(GetSqlConnectionString());
        }

        private string GetCurrentUserName()
        {
            if (currentUser != null && !String.IsNullOrWhiteSpace(currentUser.Username))
            {
                if (!String.IsNullOrWhiteSpace(currentUser.DisplayName))
                {
                    return currentUser.DisplayName;
                }

                return currentUser.Username;
            }

            return Environment.UserName;
        }

        private string GetCurrentUserId()
        {
            if (currentUser != null && !String.IsNullOrWhiteSpace(currentUser.UserId))
            {
                return currentUser.UserId;
            }

            return "";
        }

        private string GetCurrentUserRole()
        {
            if (currentUser != null && !String.IsNullOrWhiteSpace(currentUser.Role))
            {
                return currentUser.Role;
            }

            return "Local User";
        }

        private void InitializeCurrentUserContext()
        {
            currentDoctorProfileId = 0;
            currentPatientId = 0;
            currentPatientName = "";
            currentDoctorDisplayName = "";

            if (currentUser == null)
            {
                return;
            }

            try
            {
                SqlUserProfileSync.SyncUserProfile(currentUser);

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (IsDoctorUser())
                    {
                        DoctorProfile doctorProfile = db.DoctorProfiles
                            .FirstOrDefault(profile => profile.UserId == GetCurrentUserId() && profile.IsActive);

                        if (doctorProfile != null)
                        {
                            currentDoctorProfileId = doctorProfile.DoctorProfileId;
                            currentDoctorDisplayName = doctorProfile.DisplayName;
                        }
                    }

                    if (IsPatientUser())
                    {
                        Patient patient = db.Patients
                            .FirstOrDefault(record => record.PatientUserId == GetCurrentUserId());

                        if (patient != null)
                        {
                            currentPatientId = patient.PatientId;
                            currentPatientName = patient.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Current user SQL profile could not be loaded: " + ex.Message;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close dashboard and return to login form
            this.Close();
        }

        private void patientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblVitalStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
