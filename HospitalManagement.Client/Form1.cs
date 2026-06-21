using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    public partial class Form1 : Form
    {
        private User currentUser;
        private HubConnection hospitalHubConnection;
        private int selectedAppointmentId = 0;
        private int selectedInventoryItemId = 0;
        private int selectedVitalsId = 0;
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

        public Form1()
        {
            InitializeComponent();
            BindDesignerControlReferences();

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

            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        public Form1(User loggedInUser)
        {
            InitializeComponent();
            BindDesignerControlReferences();

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

            Load += Form1_Load;
            FormClosing += Form1_FormClosing;

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

        private void SetNotificationDisplayItems(IEnumerable<NotificationDisplayItem> items)
        {
            notificationDisplayItems.Clear();

            foreach (NotificationDisplayItem item in items.Where(item => item != null).Take(WrappingDisplayItemLimit))
            {
                notificationDisplayItems.Add(item);
            }

            RefreshNotificationsWindowDisplay();
        }

        private void AddNotificationDisplayItem(NotificationDisplayItem item)
        {
            if (item == null)
            {
                return;
            }

            notificationDisplayItems.Insert(0, item);

            while (notificationDisplayItems.Count > WrappingDisplayItemLimit)
            {
                notificationDisplayItems.RemoveAt(notificationDisplayItems.Count - 1);
            }

            RefreshNotificationsWindowDisplay();
        }

        private void RefreshNotificationsWindowDisplay()
        {
            if (notificationsWindow == null || notificationsWindow.IsDisposed)
            {
                return;
            }

            notificationsWindow.SetNotifications(notificationDisplayItems);
        }

        private void SetConnectionStatus(string text)
        {
            if (connectionStatusText != null)
            {
                connectionStatusText.Text = text;
            }
        }

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

            if (cmbPatientDepartment.Items.Count > 0 && cmbPatientDepartment.SelectedIndex == -1)
            {
                cmbPatientDepartment.SelectedIndex = 0;
            }

            if (cmbPatientFilter.Items.Count > 0 && cmbPatientFilter.SelectedIndex == -1)
            {
                cmbPatientFilter.SelectedIndex = 0;
            }

            ApplyPatientFormPermissions();

            // Load patient records when dashboard opens
            LoadPatients();
        }

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

        private void SetupInventoryTab()
        {
            if (currentUser != null && !IsAdminUser())
            {
                return;
            }

            // Set grid selection behavior
            inventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventoryGrid.MultiSelect = false;

            if (cmbInventoryCategory.Items.Count > 0 && cmbInventoryCategory.SelectedIndex == -1)
            {
                cmbInventoryCategory.SelectedIndex = 0;
            }

            LoadInventoryItems();
        }

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

        private void SetupCommunicationTab()
        {
            messageDisplayEmptyText = "Select a conversation to view messages.";
            SetMessageDisplayEmpty(messageHistoryFlowPanel, messageDisplayItems, messageDisplayEmptyText);

            if (IsPatientUser())
            {
                btnNewConversation.Enabled = false;
                lstConversations.Items.Clear();
                lstConversations.Items.Add("Patient users use My Messages.");
                return;
            }
            else
            {
                btnNewConversation.Enabled = true;
            }

            LoadConversations();
        }

        private void SetupPatientMessagesTab()
        {
            patientMessageDisplayEmptyText = "Your patient messages will appear here.";
            SetMessageDisplayEmpty(patientMessageHistoryFlowPanel, patientMessageDisplayItems, patientMessageDisplayEmptyText);

            if (IsPatientUser())
            {
                LoadPatientChatMessages();
            }
        }

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

        private string GetSqlConnectionString()
        {
            return AppConnections.GetSqlConnectionString();
        }

        private string GetSignalRHubUrl()
        {
            return AppConnections.GetSignalRHubUrl();
        }

        private string GetSignalRHubUrlForCurrentUser()
        {
            string hubUrl = GetSignalRHubUrl();
            string userId = GetCurrentUserId();

            if (String.IsNullOrWhiteSpace(userId))
            {
                return hubUrl;
            }

            string separator = hubUrl.Contains("?") ? "&" : "?";
            return hubUrl + separator + "userId=" + Uri.EscapeDataString(userId);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await StartSignalRConnectionAsync();
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notificationsWindow != null && !notificationsWindow.IsDisposed)
            {
                notificationsWindow.Close();
            }

            if (hospitalHubConnection != null)
            {
                await hospitalHubConnection.DisposeAsync();
            }
        }

        private void ShowNotificationsWindow()
        {
            if (notificationsWindow != null && !notificationsWindow.IsDisposed)
            {
                if (notificationsWindow.WindowState == FormWindowState.Minimized)
                {
                    notificationsWindow.WindowState = FormWindowState.Normal;
                }

                notificationsWindow.BringToFront();
                notificationsWindow.Activate();
                return;
            }

            notificationsWindow = new Notifications();
            notificationsWindow.FormClosed += (sender, args) =>
            {
                notificationsWindow = null;
            };

            RefreshNotificationsWindowDisplay();
            notificationsWindow.Show(this);
        }

        private async Task StartSignalRConnectionAsync()
        {
            if (hospitalHubConnection != null)
            {
                return;
            }

            hospitalHubConnection = new HubConnectionBuilder()
                .WithUrl(GetSignalRHubUrlForCurrentUser())
                .WithAutomaticReconnect()
                .Build();

            hospitalHubConnection.Reconnecting += error =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Reconnecting");
                    statusText.Text = "SignalR connection lost. Reconnecting...";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.Reconnected += connectionId =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Connected");
                    statusText.Text = "SignalR connection restored.";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.Closed += error =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Disconnected");
                    statusText.Text = "SignalR connection closed.";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.On<string>("AppointmentChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadAppointments();
                    RefreshDashboardCounts();
                    statusText.Text = "Appointment update received.";
                });
            });

            hospitalHubConnection.On<string>("InventoryChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!IsAdminUser())
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadInventoryItems();
                    RefreshDashboardCounts();
                    statusText.Text = "Inventory update received.";
                });
            });

            hospitalHubConnection.On<string>("PatientChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadPatients();
                    RefreshDashboardCounts();
                    statusText.Text = "Patient update received.";
                });
            });

            hospitalHubConnection.On<string, string, string>("ChatMessageReceived", (conversationName, senderName, message) =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserAccessConversationName(conversationName))
                    {
                        return;
                    }

                    AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");

                    if (IsPatientUser())
                    {
                        if (IsCurrentPatientConversationName(conversationName))
                        {
                            LoadPatientChatMessages();
                        }
                    }
                    else
                    {
                        LoadConversations();

                        if (GetSelectedConversationName() == conversationName)
                        {
                            LoadChatMessages();
                        }
                    }

                    RefreshDashboardCounts();
                    statusText.Text = "Chat message received.";
                });
            });

            hospitalHubConnection.On<string>("VitalsChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadVitals();
                    RefreshDashboardCounts();
                    statusText.Text = "Vitals update received.";
                });
            });

            hospitalHubConnection.On<string>("DashboardChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (IsPatientUser())
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    RefreshDashboardCounts();
                    statusText.Text = "Dashboard update received.";
                });
            });

            hospitalHubConnection.On<string>("NotificationReceived", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    RefreshDashboardCounts();
                    statusText.Text = "Notification received.";
                });
            });

            try
            {
                await hospitalHubConnection.StartAsync();
                SetConnectionStatus("Connection: Connected");
                statusText.Text = "SignalR connection started.";
            }
            catch (Exception ex)
            {
                SetConnectionStatus("Connection: Unavailable");
                statusText.Text = "Could not connect to SignalR server: " + ex.Message;
            }
        }

        private async Task SendPatientChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendPatientChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Patient saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendChatMessageAsync(string conversationName, string senderName, string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendChatMessage", conversationName, senderName, message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");
                    statusText.Text = "Message saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendVitalsChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendVitalsChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Vitals saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendDashboardChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendDashboardChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Dashboard saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendNotificationAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendNotification", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Notification saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private void RunOnUiThread(Action action)
        {
            if (IsDisposed)
            {
                return;
            }

            if (InvokeRequired)
            {
                try
                {
                    BeginInvoke(new MethodInvoker(() => action()));
                }
                catch (InvalidOperationException)
                {
                    // Form is closing while a background SignalR callback is finishing.
                }

                return;
            }

            action();
        }

        private void AddRealTimeUpdate(string message)
        {
            DateTime updateTime = DateTime.Now;
            AddNotificationDisplayItem(new NotificationDisplayItem("Live Update", message, updateTime));
        }

        private async Task SendAppointmentChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendAppointmentChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Appointment saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendInventoryChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendInventoryChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Inventory saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
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

        private bool IsStaffUser()
        {
            return !IsPatientUser();
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

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ShowNotificationsWindow();
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
            cmbPatientDepartment.Enabled = canManagePatients;
            chkPatientAdmitted.Enabled = canManagePatients;
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

        private void ApplyMonitoringPermissions()
        {
            bool canUpdateVitals = CanUpdateVitals();

            btnUpdateVitals.Enabled = canUpdateVitals;
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

        private int ResolvePatientId(HospitalDbContext db, string patientName, out string resolvedPatientName)
        {
            resolvedPatientName = patientName.Trim();

            if (IsPatientUser())
            {
                resolvedPatientName = currentPatientName;
                return currentPatientId;
            }

            if (String.IsNullOrWhiteSpace(patientName))
            {
                return 0;
            }

            Patient patient = GetScopedPatientsQuery(db)
                .OrderBy(record => record.PatientId)
                .FirstOrDefault(record => record.Name == patientName.Trim());

            if (patient == null)
            {
                return 0;
            }

            resolvedPatientName = patient.Name;
            return patient.PatientId;
        }

        private string GetPatientName(HospitalDbContext db, int patientId)
        {
            return db.Patients
                .Where(patient => patient.PatientId == patientId)
                .Select(patient => patient.Name)
                .FirstOrDefault() ?? "";
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

        private string NormalizePatientConversationName(string patientName)
        {
            return "Patient: " + patientName.Trim();
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

        private int EnsurePatientConversation(int patientId, string patientName)
        {
            patientName = patientName.Trim();

            if (patientId == 0 || patientName == "")
            {
                return 0;
            }

            string conversationName = NormalizePatientConversationName(patientName);
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    ChatConversation conversation = db.ChatConversations
                        .FirstOrDefault(record => record.PatientId == patientId);

                    if (conversation == null)
                    {
                        conversation = new ChatConversation
                        {
                            ConversationName = conversationName,
                            PatientId = patientId,
                            ConversationType = "Patient",
                            CreatedAt = DateTime.Now
                        };
                        db.ChatConversations.Add(conversation);
                    }
                    else
                    {
                        conversation.ConversationName = conversationName;
                        conversation.ConversationType = "Patient";
                    }

                    db.SaveChanges();
                    return conversation.ChatConversationId;
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Patient chat could not be created: " + ex.Message;
                return 0;
            }
        }

        private int GetPatientConversationId(int patientId)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    return db.ChatConversations
                        .Where(conversation =>
                            conversation.PatientId == patientId &&
                            conversation.ConversationType == "Patient")
                        .Select(conversation => conversation.ChatConversationId)
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Patient chat lookup failed: " + ex.Message;
                return 0;
            }
        }

        private void SaveNotification(string notificationType, string messageText)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    db.SystemNotifications.Add(new SystemNotification
                    {
                        NotificationType = notificationType,
                        MessageText = messageText,
                        CreatedAt = DateTime.Now
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Notification could not be saved: " + ex.Message;
            }
        }

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

                    txtDashboardOpenBeds.Text = (db.BedStatuses.Sum(bed => (int?)bed.OpenBeds) ?? 0).ToString();
                    txtDashboardEmergencies.Text = GetScopedCriticalVitalsCount(db).ToString();

                    LoadBedStatusList(db);
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

        private void LoadBedStatusList(HospitalDbContext db)
        {
            bedStatusGrid.Rows.Clear();

            List<BedStatus> bedStatuses = db.BedStatuses
                .OrderBy(bed => bed.Department)
                .ToList();

            foreach (BedStatus bedStatus in bedStatuses)
            {
                bedStatusGrid.Rows.Add(
                    bedStatus.Department,
                    bedStatus.OpenBeds.ToString(),
                    bedStatus.TotalBeds.ToString(),
                    bedStatus.UpdatedAt.ToString("g"));
            }

            if (bedStatusGrid.Rows.Count == 0)
            {
                bedStatusGrid.Rows.Add("No bed status records found.", "", "", "");
            }
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
                    "Room " +
                    vitalAlert.Room +
                    " | HR " +
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
                            patient.Department,
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
                            patient.Department,
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
                    else if (filter == "Critical Care")
                    {
                        patients = patients.Where(patient => patient.Department == "ICU");
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
                            patient.Department,
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
                            patient.Department,
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
                        cmbPatientDepartment.Text = patient.Department ?? "";
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

            if (cmbPatientDepartment.Items.Count > 0)
            {
                cmbPatientDepartment.SelectedIndex = 0;
            }

            patientGrid.ClearSelection();

            if (txtPatientName.CanFocus)
            {
                txtPatientName.Focus();
            }
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

        private void LoadInventoryItems()
        {
            inventoryGrid.Rows.Clear();
            lstLowStock.Items.Clear();
            selectedInventoryItemId = 0;

            if (currentUser != null && !IsAdminUser())
            {
                lstLowStock.Items.Add("Inventory is available to administrative staff only.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<InventoryItem> inventoryItems = db.InventoryItems
                        .OrderBy(item => item.ItemName)
                        .ToList();

                    foreach (InventoryItem inventoryItem in inventoryItems)
                    {
                        int rowIndex = inventoryGrid.Rows.Add(
                            inventoryItem.ItemName,
                            inventoryItem.Category,
                            inventoryItem.Quantity.ToString(),
                            inventoryItem.ReorderLevel.ToString(),
                            inventoryItem.StorageLocation ?? ""
                        );

                        inventoryGrid.Rows[rowIndex].Tag = inventoryItem.InventoryItemId;

                        if (inventoryItem.Quantity <= inventoryItem.ReorderLevel)
                        {
                            inventoryGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                            lstLowStock.Items.Add(
                                inventoryItem.ItemName +
                                " is low: " +
                                inventoryItem.Quantity.ToString() +
                                " remaining, reorder at " +
                                inventoryItem.ReorderLevel.ToString()
                            );
                        }
                    }
                }

                if (lstLowStock.Items.Count == 0)
                {
                    lstLowStock.Items.Add("No items are currently below reorder level.");
                }

                statusText.Text = "Inventory records loaded.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Error loading inventory: " + ex.Message;
            }
        }

        private void LoadInventoryDetails(int inventoryItemId)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem item = db.InventoryItems
                        .FirstOrDefault(record => record.InventoryItemId == inventoryItemId);

                    if (item != null)
                    {
                        selectedInventoryItemId = inventoryItemId;
                        txtInventoryItem.Text = item.ItemName;
                        cmbInventoryCategory.Text = item.Category;
                        numInventoryQuantity.Value = Convert.ToDecimal(item.Quantity);
                        numInventoryReorder.Value = Convert.ToDecimal(item.ReorderLevel);
                        txtInventoryLocation.Text = item.StorageLocation ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory item details: " + ex.Message);
            }
        }

        private void ClearInventoryForm()
        {
            selectedInventoryItemId = 0;
            txtInventoryItem.Clear();
            txtInventoryLocation.Clear();
            numInventoryQuantity.Value = 0;
            numInventoryReorder.Value = 0;

            if (cmbInventoryCategory.Items.Count > 0)
            {
                cmbInventoryCategory.SelectedIndex = 0;
            }
        }

        private void UpdateBedStatusesFromPatients()
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<BedStatus> bedStatuses = db.BedStatuses.ToList();

                    foreach (BedStatus bedStatus in bedStatuses)
                    {
                        int admittedCount = db.Patients.Count(patient =>
                            patient.Department == bedStatus.Department &&
                            patient.IsAdmitted);
                        bedStatus.OpenBeds = Math.Max(0, bedStatus.TotalBeds - admittedCount);
                        bedStatus.UpdatedAt = DateTime.Now;
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Bed status could not be recalculated: " + ex.Message;
            }
        }

        private void LogInventoryTransaction(
            HospitalDbContext db,
            int? inventoryItemId,
            string itemName,
            string category,
            int quantityChange,
            string reason)
        {
            db.InventoryTransactions.Add(new InventoryTransaction
            {
                InventoryItemId = inventoryItemId,
                ItemName = itemName,
                Category = category,
                QuantityChange = quantityChange,
                TransactionReason = reason,
                CreatedAt = DateTime.Now
            });
        }

        private int GetInventoryQuantity(HospitalDbContext db, int inventoryItemId)
        {
            return db.InventoryItems
                .Where(item => item.InventoryItemId == inventoryItemId)
                .Select(item => item.Quantity)
                .FirstOrDefault();
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

        private ListItem GetSelectedConversation()
        {
            return lstConversations.SelectedItem as ListItem;
        }

        private string GetSelectedConversationName()
        {
            ListItem selectedConversation = GetSelectedConversation();

            if (selectedConversation == null)
            {
                return "";
            }

            return selectedConversation.Name;
        }

        private string GetCurrentPatientConversationName()
        {
            if (currentPatientId == 0 || String.IsNullOrWhiteSpace(currentPatientName))
            {
                return "";
            }

            return NormalizePatientConversationName(currentPatientName);
        }

        private bool IsCurrentPatientConversationName(string conversationName)
        {
            return GetCurrentPatientConversationName() == conversationName;
        }

        private int GetCurrentPatientConversationId()
        {
            if (!IsPatientUser() || currentPatientId == 0)
            {
                return 0;
            }

            return EnsurePatientConversation(currentPatientId, currentPatientName);
        }

        private void LoadMessagesForConversation(int conversationId, string emptyMessage, bool patientMessages)
        {
            List<ChatDisplayItem> chatItems = new List<ChatDisplayItem>();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<ChatMessage> messages = db.ChatMessages
                        .Where(message => message.ChatConversationId == conversationId)
                        .OrderBy(message => message.CreatedAt)
                        .ToList();

                    foreach (ChatMessage message in messages)
                    {
                        chatItems.Add(new ChatDisplayItem(
                            message.SenderName,
                            message.SenderRole,
                            message.MessageText,
                            message.CreatedAt,
                            IsCurrentUserMessage(message.SenderName, message.SenderRole)));
                    }
                }

                if (patientMessages)
                {
                    patientMessageDisplayEmptyText = emptyMessage;
                    SetMessageDisplayItems(patientMessageHistoryFlowPanel, patientMessageDisplayItems, chatItems, patientMessageDisplayEmptyText);
                }
                else
                {
                    messageDisplayEmptyText = emptyMessage;
                    SetMessageDisplayItems(messageHistoryFlowPanel, messageDisplayItems, chatItems, messageDisplayEmptyText);
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Messages could not be loaded: " + ex.Message;
            }
        }

        private bool IsCurrentUserMessage(string senderName, string senderRole)
        {
            return String.Equals((senderName ?? "").Trim(), GetCurrentUserName().Trim(), StringComparison.OrdinalIgnoreCase) &&
                   String.Equals((senderRole ?? "").Trim(), GetCurrentUserRole().Trim(), StringComparison.OrdinalIgnoreCase);
        }

        private void LoadConversations()
        {
            string selectedName = GetSelectedConversationName();
            lstConversations.Items.Clear();

            if (IsPatientUser() && currentPatientId > 0)
            {
                EnsurePatientConversation(currentPatientId, currentPatientName);
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<ChatConversation> conversations = db.ChatConversations
                        .Include(conversation => conversation.Patient)
                        .Where(conversation =>
                            conversation.ConversationType == "Patient" &&
                            conversation.ConversationName.StartsWith("Patient: "))
                        .OrderBy(conversation => conversation.Patient.Name)
                        .ThenBy(conversation => conversation.ConversationName)
                        .ToList();

                    foreach (ChatConversation conversation in conversations)
                    {
                        ListItem item = new ListItem
                        {
                            Id = conversation.ChatConversationId,
                            PatientId = conversation.PatientId,
                            Name = conversation.ConversationName,
                            PatientName = conversation.Patient == null ? "" : conversation.Patient.Name,
                            ConversationType = conversation.ConversationType
                        };

                        if (CanCurrentUserAccessConversation(item))
                        {
                            lstConversations.Items.Add(item);

                            if (item.Name == selectedName)
                            {
                                lstConversations.SelectedItem = item;
                            }
                        }
                    }
                }

                if (lstConversations.SelectedIndex == -1 && lstConversations.Items.Count > 0)
                {
                    lstConversations.SelectedIndex = 0;
                }

                LoadChatMessages();
            }
            catch (Exception ex)
            {
                statusText.Text = "Conversations could not be loaded: " + ex.Message;
            }
        }

        private void LoadChatMessages()
        {
            ListItem selectedConversation = GetSelectedConversation();

            if (selectedConversation == null)
            {
                messageDisplayEmptyText = "No conversation selected.";
                SetMessageDisplayEmpty(messageHistoryFlowPanel, messageDisplayItems, messageDisplayEmptyText);
                return;
            }

            if (!CanCurrentUserAccessConversation(selectedConversation))
            {
                messageDisplayEmptyText = "This user can only access patient chats.";
                SetMessageDisplayEmpty(messageHistoryFlowPanel, messageDisplayItems, messageDisplayEmptyText);
                return;
            }

            LoadMessagesForConversation(
                selectedConversation.Id,
                "No messages in this conversation yet.",
                false);
        }

        private void LoadPatientChatMessages()
        {
            if (!IsPatientUser())
            {
                patientMessageDisplayEmptyText = "Patient messages are available to patient users.";
                SetMessageDisplayEmpty(patientMessageHistoryFlowPanel, patientMessageDisplayItems, patientMessageDisplayEmptyText);
                return;
            }

            int conversationId = GetCurrentPatientConversationId();

            if (conversationId == 0)
            {
                patientMessageDisplayEmptyText = "Your patient chat could not be opened.";
                SetMessageDisplayEmpty(patientMessageHistoryFlowPanel, patientMessageDisplayItems, patientMessageDisplayEmptyText);
                return;
            }

            LoadMessagesForConversation(
                conversationId,
                "No messages in your patient chat yet.",
                true);
        }

        private void RefreshVisibleChatView()
        {
            if (IsPatientUser())
            {
                LoadPatientChatMessages();
            }
            else
            {
                LoadConversations();
            }
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

        private void SaveChatMessage(int conversationId, string senderName, string senderRole, string messageText)
        {
            using (HospitalDbContext db = CreateHospitalDbContext())
            {
                db.ChatMessages.Add(new ChatMessage
                {
                    ChatConversationId = conversationId,
                    SenderName = senderName,
                    SenderRole = senderRole,
                    MessageText = messageText,
                    CreatedAt = DateTime.Now
                });
                db.SaveChanges();
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

        private List<ListItem> GetAvailablePatientChatItems()
        {
            using (HospitalDbContext db = CreateHospitalDbContext())
            {
                List<int> existingChatPatientIds = db.ChatConversations
                    .Where(conversation => conversation.ConversationType == "Patient")
                    .Select(conversation => conversation.PatientId)
                    .ToList();

                List<Patient> patients = GetScopedPatientsQuery(db)
                    .Where(patient => !existingChatPatientIds.Contains(patient.PatientId))
                    .OrderBy(patient => patient.Name)
                    .ToList();

                return patients
                    .Select(patient => new ListItem
                    {
                        Id = patient.PatientId,
                        PatientId = patient.PatientId,
                        Name = patient.Name,
                        PatientName = patient.Name,
                        ConversationType = "Patient"
                    })
                    .ToList();
            }
        }

        private ListItem ShowPatientChatPickerDialog(List<ListItem> patients)
        {
            using (Form dialog = new Form())
            using (Label label = new Label())
            using (ComboBox patientPicker = new ComboBox())
            using (Button okButton = new Button())
            using (Button cancelButton = new Button())
            {
                dialog.Text = "Start Patient Chat";
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MinimizeBox = false;
                dialog.MaximizeBox = false;
                dialog.ClientSize = new Size(420, 145);

                label.Text = "Choose a patient";
                label.Location = new Point(12, 15);
                label.Size = new Size(390, 24);

                patientPicker.DropDownStyle = ComboBoxStyle.DropDownList;
                patientPicker.Location = new Point(12, 47);
                patientPicker.Size = new Size(390, 23);

                foreach (ListItem patient in patients)
                {
                    patientPicker.Items.Add(patient);
                }

                if (patientPicker.Items.Count > 0)
                {
                    patientPicker.SelectedIndex = 0;
                }

                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(226, 92);
                okButton.Size = new Size(82, 34);

                cancelButton.Text = "Cancel";
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Location = new Point(320, 92);
                cancelButton.Size = new Size(82, 34);

                dialog.Controls.Add(label);
                dialog.Controls.Add(patientPicker);
                dialog.Controls.Add(okButton);
                dialog.Controls.Add(cancelButton);
                dialog.AcceptButton = okButton;
                dialog.CancelButton = cancelButton;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    return patientPicker.SelectedItem as ListItem;
                }
            }

            return null;
        }

        private void LoadVitals()
        {
            vitalsGrid.Rows.Clear();
            lstMonitoringAlerts.Items.Clear();
            selectedVitalsId = 0;

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
                        selectedVitalsId = patientVitalsId;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close dashboard and return to login form
            this.Close();
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
                        Department = cmbPatientDepartment.Text,
                        IsAdmitted = chkPatientAdmitted.Checked,
                        Notes = txtPatientNotes.Text
                    };

                    db.Patients.Add(patient);
                    db.SaveChanges();
                    patientId = patient.PatientId;
                }

                UpdateBedStatusesFromPatients();
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
                    patient.Department = cmbPatientDepartment.Text;
                    patient.IsAdmitted = chkPatientAdmitted.Checked;
                    patient.Notes = txtPatientNotes.Text;
                    db.SaveChanges();
                }

                UpdateBedStatusesFromPatients();
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

                UpdateBedStatusesFromPatients();
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

        private async void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();
            string storageLocation = txtInventoryLocation.Text.Trim();
            int quantity = Convert.ToInt32(numInventoryQuantity.Value);
            int reorderLevel = Convert.ToInt32(numInventoryReorder.Value);

            if (itemName == "" || category == "")
            {
                MessageBox.Show("Item Name and Category are required.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = new InventoryItem
                    {
                        ItemName = itemName,
                        Category = category,
                        Quantity = quantity,
                        ReorderLevel = reorderLevel,
                        StorageLocation = storageLocation,
                        UpdatedAt = DateTime.Now
                    };

                    db.InventoryItems.Add(inventoryItem);
                    db.SaveChanges();

                    if (quantity != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            inventoryItem.InventoryItemId,
                            itemName,
                            category,
                            quantity,
                            "Initial stock"
                        );
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Inventory item added successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory item added: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory item added: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding inventory item: " + ex.Message);
            }
        }

        private async void btnInventoryUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            if (selectedInventoryItemId == 0)
            {
                MessageBox.Show("Double-click an inventory item before updating it.");
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();
            string storageLocation = txtInventoryLocation.Text.Trim();
            int quantity = Convert.ToInt32(numInventoryQuantity.Value);
            int reorderLevel = Convert.ToInt32(numInventoryReorder.Value);

            if (itemName == "" || category == "")
            {
                MessageBox.Show("Item Name and Category are required.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = db.InventoryItems
                        .FirstOrDefault(item => item.InventoryItemId == selectedInventoryItemId);

                    if (inventoryItem == null)
                    {
                        MessageBox.Show("No inventory item found for the selected row.");
                        return;
                    }

                    int previousQuantity = inventoryItem.Quantity;
                    inventoryItem.ItemName = itemName;
                    inventoryItem.Category = category;
                    inventoryItem.Quantity = quantity;
                    inventoryItem.ReorderLevel = reorderLevel;
                    inventoryItem.StorageLocation = storageLocation;
                    inventoryItem.UpdatedAt = DateTime.Now;

                    int quantityChange = quantity - previousQuantity;

                    if (quantityChange != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            selectedInventoryItemId,
                            itemName,
                            category,
                            quantityChange,
                            "Stock update"
                        );
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Inventory item updated successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory stock updated: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory stock updated: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory item: " + ex.Message);
            }
        }

        private async void btnInventoryRemove_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            if (selectedInventoryItemId == 0)
            {
                MessageBox.Show("Double-click an inventory item before removing it.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this inventory item?",
                "Confirm Remove",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = db.InventoryItems
                        .FirstOrDefault(item => item.InventoryItemId == selectedInventoryItemId);

                    if (inventoryItem == null)
                    {
                        MessageBox.Show("No inventory item found for the selected row.");
                        return;
                    }

                    int previousQuantity = GetInventoryQuantity(db, selectedInventoryItemId);
                    db.InventoryItems.Remove(inventoryItem);

                    if (previousQuantity != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            null,
                            itemName,
                            category,
                            -previousQuantity,
                            "Item removed"
                        );
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Inventory item removed successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory item removed: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory item removed: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing inventory item: " + ex.Message);
            }
        }

        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryItems();
            RefreshDashboardCounts();
        }

        private void inventoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || inventoryGrid.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            int inventoryItemId = Convert.ToInt32(inventoryGrid.Rows[e.RowIndex].Tag);
            LoadInventoryDetails(inventoryItemId);
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

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            ListItem selectedConversation = GetSelectedConversation();

            if (selectedConversation == null)
            {
                MessageBox.Show("Select a conversation before sending a message.");
                return;
            }

            if (!CanCurrentUserAccessConversation(selectedConversation))
            {
                MessageBox.Show("Chat is only available between staff and patients.");
                return;
            }

            string messageText = txtMessageInput.Text.Trim();

            if (messageText == "")
            {
                MessageBox.Show("Enter a message first.");
                return;
            }

            string senderName = GetCurrentUserName();
            string senderRole = GetCurrentUserRole();

            try
            {
                SaveChatMessage(selectedConversation.Id, senderName, senderRole, messageText);

                txtMessageInput.Clear();
                LoadChatMessages();
                SaveNotification("Chat", senderName + " sent a message in " + selectedConversation.Name + ".");
                await SendChatMessageAsync(selectedConversation.Name, senderName, messageText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message could not be sent.\n\n" + ex.Message);
            }
        }

        private async void btnSendPatientMessage_Click(object sender, EventArgs e)
        {
            if (!IsPatientUser())
            {
                MessageBox.Show("Patient messages are available to patient users.");
                return;
            }

            int conversationId = GetCurrentPatientConversationId();

            if (conversationId == 0)
            {
                MessageBox.Show("Your patient chat could not be opened.");
                return;
            }

            string messageText = txtPatientMessageInput.Text.Trim();

            if (messageText == "")
            {
                MessageBox.Show("Enter a message first.");
                return;
            }

            string senderName = GetCurrentUserName();
            string senderRole = GetCurrentUserRole();
            string conversationName = GetCurrentPatientConversationName();

            try
            {
                SaveChatMessage(conversationId, senderName, senderRole, messageText);

                txtPatientMessageInput.Clear();
                LoadPatientChatMessages();
                SaveNotification("Chat", senderName + " sent a message in " + conversationName + ".");
                await SendChatMessageAsync(conversationName, senderName, messageText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message could not be sent.\n\n" + ex.Message);
            }
        }

        private async void btnNewConversation_Click(object sender, EventArgs e)
        {
            if (IsPatientUser())
            {
                MessageBox.Show("Your patient chat is created automatically.");
                return;
            }

            try
            {
                List<ListItem> availablePatients = GetAvailablePatientChatItems();

                if (availablePatients.Count == 0)
                {
                    MessageBox.Show("There are no new patients to talk to.");
                    return;
                }

                ListItem selectedPatient = ShowPatientChatPickerDialog(availablePatients);

                if (selectedPatient == null)
                {
                    return;
                }

                int patientId = selectedPatient.PatientId > 0 ? selectedPatient.PatientId : selectedPatient.Id;
                string patientName = String.IsNullOrWhiteSpace(selectedPatient.PatientName)
                    ? selectedPatient.Name
                    : selectedPatient.PatientName;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    if (patientId == 0 || !CanCurrentUserAccessPatient(db, patientId))
                    {
                        MessageBox.Show("Choose an existing patient this user can access.");
                        return;
                    }

                    if (db.ChatConversations.Any(conversation =>
                        conversation.PatientId == patientId &&
                        conversation.ConversationType == "Patient"))
                    {
                        MessageBox.Show("That patient already has a chat.");
                        LoadConversations();
                        return;
                    }

                    string currentPatientName = GetPatientName(db, patientId);

                    if (!String.IsNullOrWhiteSpace(currentPatientName))
                    {
                        patientName = currentPatientName;
                    }
                }

                int conversationId = EnsurePatientConversation(patientId, patientName);

                if (conversationId == 0)
                {
                    MessageBox.Show("Patient chat could not be opened.");
                    return;
                }

                string conversationName = NormalizePatientConversationName(patientName);

                LoadConversations();

                for (int index = 0; index < lstConversations.Items.Count; index++)
                {
                    ListItem item = lstConversations.Items[index] as ListItem;

                    if (item != null && item.Name == conversationName)
                    {
                        lstConversations.SelectedIndex = index;
                        break;
                    }
                }

                SaveNotification("Chat", "Conversation available: " + conversationName + ".");
                await SendNotificationAsync("Conversation available: " + conversationName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conversation could not be created.\n\n" + ex.Message);
            }
        }

        private void lstConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChatMessages();
        }

        private async void btnUpdateVitals_Click(object sender, EventArgs e)
        {
            if (!CanUpdateVitals())
            {
                MessageBox.Show("This user cannot update patient vitals.");
                return;
            }

            int heartRate = Convert.ToInt32(numHeartRate.Value);
            int oxygenLevel = Convert.ToInt32(numOxygenLevel.Value);
            decimal temperature = numTemperature.Value;
            string bloodPressure = txtBloodPressure.Text.Trim();
            string status = EvaluateVitalsStatus(heartRate, bloodPressure, oxygenLevel, temperature);
            int selectedPatientId = GetSelectedPatientPickerId(cmbMonitoringPatientPicker);

            if (selectedPatientId == 0)
            {
                MessageBox.Show("Patient name is required.");
                return;
            }

            string patientName = GetSelectedPatientPickerName(cmbMonitoringPatientPicker);
            string message = "Vitals updated for " + patientName + " (" + status + ").";

            try
            {
                int patientId;

                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    patientId = ResolveSelectedPatientId(db, cmbMonitoringPatientPicker, out patientName);

                    if (patientId == 0 || !CanCurrentUserAccessPatient(db, patientId))
                    {
                        MessageBox.Show("Choose an existing patient this user can access.");
                        return;
                    }

                    message = "Vitals updated for " + patientName + " (" + status + ").";

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

        private void vitalsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || vitalsGrid.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            int patientVitalsId = Convert.ToInt32(vitalsGrid.Rows[e.RowIndex].Tag);
            LoadVitalDetails(patientVitalsId);
        }

        private void lblVitalNotes_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientVitalsPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void grpPatientLatestVitals_Enter(object sender, EventArgs e)
        {

        }

        private void lblVitalBloodPressureCaption_Click(object sender, EventArgs e)
        {

        }

        private void doctorVisitsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDoctorTodayVisitPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void patientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void inventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAnalyticsVisits_Click(object sender, EventArgs e)
        {

        }
    }
}
