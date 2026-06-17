namespace HospitalManagement.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new System.Windows.Forms.Panel();
            btnLogout = new System.Windows.Forms.Button();
            lblNotifications = new System.Windows.Forms.Label();
            lblConnection = new System.Windows.Forms.Label();
            lblRole = new System.Windows.Forms.Label();
            lblLoggedInUser = new System.Windows.Forms.Label();
            lblSystemTitle = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusText = new System.Windows.Forms.ToolStripStatusLabel();
            mainTabs = new System.Windows.Forms.TabControl();
            dashboardTab = new System.Windows.Forms.TabPage();
            grpCriticalStatus = new System.Windows.Forms.GroupBox();
            lstCriticalStatus = new System.Windows.Forms.ListBox();
            grpBedStatus = new System.Windows.Forms.GroupBox();
            lstBedStatus = new System.Windows.Forms.ListBox();
            grpRealTimeUpdates = new System.Windows.Forms.GroupBox();
            lstRealTimeUpdates = new System.Windows.Forms.ListBox();
            grpQuickCounts = new System.Windows.Forms.GroupBox();
            txtDashboardEmergencies = new System.Windows.Forms.TextBox();
            lblDashboardEmergencies = new System.Windows.Forms.Label();
            txtDashboardLowStock = new System.Windows.Forms.TextBox();
            lblDashboardLowStock = new System.Windows.Forms.Label();
            txtDashboardOpenBeds = new System.Windows.Forms.TextBox();
            lblDashboardOpenBeds = new System.Windows.Forms.Label();
            txtDashboardAppointments = new System.Windows.Forms.TextBox();
            lblDashboardAppointments = new System.Windows.Forms.Label();
            txtDashboardPatients = new System.Windows.Forms.TextBox();
            lblDashboardPatients = new System.Windows.Forms.Label();
            patientsTab = new System.Windows.Forms.TabPage();
            grpPatientDetails = new System.Windows.Forms.GroupBox();
            btnClearPatient = new System.Windows.Forms.Button();
            btnDeletePatient = new System.Windows.Forms.Button();
            btnUpdatePatient = new System.Windows.Forms.Button();
            btnAddPatient = new System.Windows.Forms.Button();
            chkPatientAdmitted = new System.Windows.Forms.CheckBox();
            cmbPatientDepartment = new System.Windows.Forms.ComboBox();
            lblPatientDepartment = new System.Windows.Forms.Label();
            txtPatientNotes = new System.Windows.Forms.TextBox();
            lblPatientNotes = new System.Windows.Forms.Label();
            txtPatientPhone = new System.Windows.Forms.TextBox();
            lblPatientPhone = new System.Windows.Forms.Label();
            dtpPatientDob = new System.Windows.Forms.DateTimePicker();
            lblPatientDob = new System.Windows.Forms.Label();
            cmbPatientGender = new System.Windows.Forms.ComboBox();
            lblPatientGender = new System.Windows.Forms.Label();
            txtPatientName = new System.Windows.Forms.TextBox();
            lblPatientName = new System.Windows.Forms.Label();
            txtPatientId = new System.Windows.Forms.TextBox();
            lblPatientId = new System.Windows.Forms.Label();
            patientGrid = new System.Windows.Forms.DataGridView();
            patientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientDepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientDoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpPatientSearch = new System.Windows.Forms.GroupBox();
            btnPatientRefresh = new System.Windows.Forms.Button();
            btnPatientSearch = new System.Windows.Forms.Button();
            cmbPatientFilter = new System.Windows.Forms.ComboBox();
            lblPatientFilter = new System.Windows.Forms.Label();
            txtPatientSearch = new System.Windows.Forms.TextBox();
            lblPatientSearch = new System.Windows.Forms.Label();
            appointmentsTab = new System.Windows.Forms.TabPage();
            appointmentGrid = new System.Windows.Forms.DataGridView();
            appointmentTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentPatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentDoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            btnAppointmentRefresh = new System.Windows.Forms.Button();
            btnCancelAppointment = new System.Windows.Forms.Button();
            btnUpdateAppointment = new System.Windows.Forms.Button();
            btnAddAppointment = new System.Windows.Forms.Button();
            txtAppointmentNotes = new System.Windows.Forms.TextBox();
            lblAppointmentNotes = new System.Windows.Forms.Label();
            cmbAppointmentStatus = new System.Windows.Forms.ComboBox();
            lblAppointmentStatus = new System.Windows.Forms.Label();
            dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            lblAppointmentTime = new System.Windows.Forms.Label();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            lblAppointmentDate = new System.Windows.Forms.Label();
            txtAppointmentReason = new System.Windows.Forms.TextBox();
            lblAppointmentReason = new System.Windows.Forms.Label();
            cmbAppointmentDoctor = new System.Windows.Forms.ComboBox();
            lblAppointmentDoctor = new System.Windows.Forms.Label();
            txtAppointmentPatient = new System.Windows.Forms.TextBox();
            lblAppointmentPatient = new System.Windows.Forms.Label();
            inventoryTab = new System.Windows.Forms.TabPage();
            grpLowStock = new System.Windows.Forms.GroupBox();
            lstLowStock = new System.Windows.Forms.ListBox();
            inventoryGrid = new System.Windows.Forms.DataGridView();
            inventoryItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inventoryCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inventoryQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inventoryReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inventoryLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpInventoryDetails = new System.Windows.Forms.GroupBox();
            btnInventoryRefresh = new System.Windows.Forms.Button();
            btnInventoryRemove = new System.Windows.Forms.Button();
            btnInventoryUpdate = new System.Windows.Forms.Button();
            btnInventoryAdd = new System.Windows.Forms.Button();
            numInventoryReorder = new System.Windows.Forms.NumericUpDown();
            lblInventoryReorder = new System.Windows.Forms.Label();
            numInventoryQuantity = new System.Windows.Forms.NumericUpDown();
            lblInventoryQuantity = new System.Windows.Forms.Label();
            txtInventoryLocation = new System.Windows.Forms.TextBox();
            lblInventoryLocation = new System.Windows.Forms.Label();
            cmbInventoryCategory = new System.Windows.Forms.ComboBox();
            lblInventoryCategory = new System.Windows.Forms.Label();
            txtInventoryItem = new System.Windows.Forms.TextBox();
            lblInventoryItem = new System.Windows.Forms.Label();
            analyticsTab = new System.Windows.Forms.TabPage();
            reportGrid = new System.Windows.Forms.DataGridView();
            reportMetricColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reportCurrentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reportPreviousColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reportChangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpReportOutput = new System.Windows.Forms.GroupBox();
            lstReportOutput = new System.Windows.Forms.ListBox();
            grpAnalyticsSummary = new System.Windows.Forms.GroupBox();
            txtAnalyticsMedicationUsage = new System.Windows.Forms.TextBox();
            lblAnalyticsMedicationUsage = new System.Windows.Forms.Label();
            txtAnalyticsCommonAilment = new System.Windows.Forms.TextBox();
            lblAnalyticsCommonAilment = new System.Windows.Forms.Label();
            txtAnalyticsVisits = new System.Windows.Forms.TextBox();
            lblAnalyticsVisits = new System.Windows.Forms.Label();
            grpAnalyticsFilters = new System.Windows.Forms.GroupBox();
            btnGenerateReport = new System.Windows.Forms.Button();
            cmbReportType = new System.Windows.Forms.ComboBox();
            lblReportType = new System.Windows.Forms.Label();
            dtpReportEnd = new System.Windows.Forms.DateTimePicker();
            lblReportEnd = new System.Windows.Forms.Label();
            dtpReportStart = new System.Windows.Forms.DateTimePicker();
            lblReportStart = new System.Windows.Forms.Label();
            communicationTab = new System.Windows.Forms.TabPage();
            grpNotifications = new System.Windows.Forms.GroupBox();
            lstNotifications = new System.Windows.Forms.ListBox();
            grpMessageHistory = new System.Windows.Forms.GroupBox();
            txtMessageInput = new System.Windows.Forms.TextBox();
            btnSendMessage = new System.Windows.Forms.Button();
            lstMessageHistory = new System.Windows.Forms.ListBox();
            grpConversations = new System.Windows.Forms.GroupBox();
            btnNewConversation = new System.Windows.Forms.Button();
            lstConversations = new System.Windows.Forms.ListBox();
            monitoringTab = new System.Windows.Forms.TabPage();
            grpMonitoringAlerts = new System.Windows.Forms.GroupBox();
            lstMonitoringAlerts = new System.Windows.Forms.ListBox();
            grpVitalsEntry = new System.Windows.Forms.GroupBox();
            btnMonitoringRefresh = new System.Windows.Forms.Button();
            btnUpdateVitals = new System.Windows.Forms.Button();
            txtMonitoringNotes = new System.Windows.Forms.TextBox();
            lblMonitoringNotes = new System.Windows.Forms.Label();
            numOxygenLevel = new System.Windows.Forms.NumericUpDown();
            lblOxygenLevel = new System.Windows.Forms.Label();
            numTemperature = new System.Windows.Forms.NumericUpDown();
            lblTemperature = new System.Windows.Forms.Label();
            txtBloodPressure = new System.Windows.Forms.TextBox();
            lblBloodPressure = new System.Windows.Forms.Label();
            numHeartRate = new System.Windows.Forms.NumericUpDown();
            lblHeartRate = new System.Windows.Forms.Label();
            txtMonitoringPatient = new System.Windows.Forms.TextBox();
            lblMonitoringPatient = new System.Windows.Forms.Label();
            vitalsGrid = new System.Windows.Forms.DataGridView();
            vitalsPatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vitalsRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vitalsHeartRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vitalsBloodPressureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vitalsOxygenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vitalsStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            headerPanel.SuspendLayout();
            statusStrip.SuspendLayout();
            mainTabs.SuspendLayout();
            dashboardTab.SuspendLayout();
            grpCriticalStatus.SuspendLayout();
            grpBedStatus.SuspendLayout();
            grpRealTimeUpdates.SuspendLayout();
            grpQuickCounts.SuspendLayout();
            patientsTab.SuspendLayout();
            grpPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientGrid).BeginInit();
            grpPatientSearch.SuspendLayout();
            appointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentGrid).BeginInit();
            grpAppointmentDetails.SuspendLayout();
            inventoryTab.SuspendLayout();
            grpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            grpInventoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInventoryReorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInventoryQuantity).BeginInit();
            analyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
            grpReportOutput.SuspendLayout();
            grpAnalyticsSummary.SuspendLayout();
            grpAnalyticsFilters.SuspendLayout();
            communicationTab.SuspendLayout();
            grpNotifications.SuspendLayout();
            grpMessageHistory.SuspendLayout();
            grpConversations.SuspendLayout();
            monitoringTab.SuspendLayout();
            grpMonitoringAlerts.SuspendLayout();
            grpVitalsEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOxygenLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTemperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeartRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vitalsGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(btnLogout);
            headerPanel.Controls.Add(lblNotifications);
            headerPanel.Controls.Add(lblConnection);
            headerPanel.Controls.Add(lblRole);
            headerPanel.Controls.Add(lblLoggedInUser);
            headerPanel.Controls.Add(lblSystemTitle);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(0, 0);
            headerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(1579, 111);
            headerPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(248, 53);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(145, 39);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Location = new System.Drawing.Point(1176, 62);
            lblNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new System.Drawing.Size(235, 20);
            lblNotifications.TabIndex = 4;
            lblNotifications.Text = "Notifications: 3 pending | 1 urgent";
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new System.Drawing.Point(861, 62);
            lblConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new System.Drawing.Size(196, 20);
            lblConnection.TabIndex = 3;
            lblConnection.Text = "SignalR Connection: Waiting";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(521, 62);
            lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(177, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role: Administrative Staff";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Location = new System.Drawing.Point(32, 62);
            lblLoggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new System.Drawing.Size(182, 20);
            lblLoggedInUser.TabIndex = 1;
            lblLoggedInUser.Text = "Logged in as: Current User";
            // 
            // lblSystemTitle
            // 
            lblSystemTitle.AutoSize = true;
            lblSystemTitle.Location = new System.Drawing.Point(32, 25);
            lblSystemTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new System.Drawing.Size(208, 20);
            lblSystemTitle.TabIndex = 0;
            lblSystemTitle.Text = "Hospital Management System";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusText });
            statusStrip.Location = new System.Drawing.Point(0, 1145);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            statusStrip.Size = new System.Drawing.Size(1579, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // statusText
            // 
            statusText.Name = "statusText";
            statusText.Size = new System.Drawing.Size(421, 20);
            statusText.Text = "Ready | Client dashboard design only | No live data connected";
            // 
            // mainTabs
            // 
            mainTabs.Controls.Add(dashboardTab);
            mainTabs.Controls.Add(patientsTab);
            mainTabs.Controls.Add(appointmentsTab);
            mainTabs.Controls.Add(inventoryTab);
            mainTabs.Controls.Add(analyticsTab);
            mainTabs.Controls.Add(communicationTab);
            mainTabs.Controls.Add(monitoringTab);
            mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            mainTabs.Location = new System.Drawing.Point(0, 111);
            mainTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            mainTabs.Name = "mainTabs";
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new System.Drawing.Size(1579, 1034);
            mainTabs.TabIndex = 1;
            // 
            // dashboardTab
            // 
            dashboardTab.Controls.Add(grpCriticalStatus);
            dashboardTab.Controls.Add(grpBedStatus);
            dashboardTab.Controls.Add(grpRealTimeUpdates);
            dashboardTab.Controls.Add(grpQuickCounts);
            dashboardTab.Location = new System.Drawing.Point(4, 29);
            dashboardTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dashboardTab.Name = "dashboardTab";
            dashboardTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dashboardTab.Size = new System.Drawing.Size(1571, 1001);
            dashboardTab.TabIndex = 0;
            dashboardTab.Text = "Dashboard";
            dashboardTab.UseVisualStyleBackColor = true;
            // 
            // grpCriticalStatus
            // 
            grpCriticalStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpCriticalStatus.Controls.Add(lstCriticalStatus);
            grpCriticalStatus.Location = new System.Drawing.Point(32, 660);
            grpCriticalStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpCriticalStatus.Name = "grpCriticalStatus";
            grpCriticalStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpCriticalStatus.Size = new System.Drawing.Size(1504, 292);
            grpCriticalStatus.TabIndex = 3;
            grpCriticalStatus.TabStop = false;
            grpCriticalStatus.Text = "Emergency and Critical Status";
            // 
            // lstCriticalStatus
            // 
            lstCriticalStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstCriticalStatus.FormattingEnabled = true;
            lstCriticalStatus.Location = new System.Drawing.Point(21, 37);
            lstCriticalStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstCriticalStatus.Name = "lstCriticalStatus";
            lstCriticalStatus.Size = new System.Drawing.Size(1460, 224);
            lstCriticalStatus.TabIndex = 0;
            // 
            // grpBedStatus
            // 
            grpBedStatus.Controls.Add(lstBedStatus);
            grpBedStatus.Location = new System.Drawing.Point(32, 357);
            grpBedStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpBedStatus.Name = "grpBedStatus";
            grpBedStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpBedStatus.Size = new System.Drawing.Size(440, 271);
            grpBedStatus.TabIndex = 1;
            grpBedStatus.TabStop = false;
            grpBedStatus.Text = "Bed Availability";
            // 
            // lstBedStatus
            // 
            lstBedStatus.FormattingEnabled = true;
            lstBedStatus.Items.AddRange(new object[] { "Emergency: 6 beds available", "ICU: 2 beds available", "Pediatrics: 8 beds available", "Surgery Recovery: 4 beds available", "General Ward: 19 beds available" });
            lstBedStatus.Location = new System.Drawing.Point(21, 37);
            lstBedStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstBedStatus.Name = "lstBedStatus";
            lstBedStatus.Size = new System.Drawing.Size(393, 204);
            lstBedStatus.TabIndex = 0;
            // 
            // grpRealTimeUpdates
            // 
            grpRealTimeUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpRealTimeUpdates.Controls.Add(lstRealTimeUpdates);
            grpRealTimeUpdates.Location = new System.Drawing.Point(499, 37);
            grpRealTimeUpdates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpRealTimeUpdates.Name = "grpRealTimeUpdates";
            grpRealTimeUpdates.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpRealTimeUpdates.Size = new System.Drawing.Size(1037, 591);
            grpRealTimeUpdates.TabIndex = 2;
            grpRealTimeUpdates.TabStop = false;
            grpRealTimeUpdates.Text = "Real-Time Updates";
            // 
            // lstRealTimeUpdates
            // 
            lstRealTimeUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstRealTimeUpdates.FormattingEnabled = true;
            lstRealTimeUpdates.Items.AddRange(new object[] { "Appointment update feed will appear here.", "Inventory alerts will appear here.", "Emergency broadcasts will appear here.", "Patient monitoring updates will appear here." });
            lstRealTimeUpdates.Location = new System.Drawing.Point(21, 37);
            lstRealTimeUpdates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstRealTimeUpdates.Name = "lstRealTimeUpdates";
            lstRealTimeUpdates.Size = new System.Drawing.Size(993, 524);
            lstRealTimeUpdates.TabIndex = 0;
            // 
            // grpQuickCounts
            // 
            grpQuickCounts.Controls.Add(txtDashboardEmergencies);
            grpQuickCounts.Controls.Add(lblDashboardEmergencies);
            grpQuickCounts.Controls.Add(txtDashboardLowStock);
            grpQuickCounts.Controls.Add(lblDashboardLowStock);
            grpQuickCounts.Controls.Add(txtDashboardOpenBeds);
            grpQuickCounts.Controls.Add(lblDashboardOpenBeds);
            grpQuickCounts.Controls.Add(txtDashboardAppointments);
            grpQuickCounts.Controls.Add(lblDashboardAppointments);
            grpQuickCounts.Controls.Add(txtDashboardPatients);
            grpQuickCounts.Controls.Add(lblDashboardPatients);
            grpQuickCounts.Location = new System.Drawing.Point(32, 37);
            grpQuickCounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpQuickCounts.Name = "grpQuickCounts";
            grpQuickCounts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpQuickCounts.Size = new System.Drawing.Size(440, 295);
            grpQuickCounts.TabIndex = 0;
            grpQuickCounts.TabStop = false;
            grpQuickCounts.Text = "Today Overview";
            // 
            // txtDashboardEmergencies
            // 
            txtDashboardEmergencies.Location = new System.Drawing.Point(245, 222);
            txtDashboardEmergencies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDashboardEmergencies.Name = "txtDashboardEmergencies";
            txtDashboardEmergencies.ReadOnly = true;
            txtDashboardEmergencies.Size = new System.Drawing.Size(169, 27);
            txtDashboardEmergencies.TabIndex = 9;
            txtDashboardEmergencies.Text = "1";
            // 
            // lblDashboardEmergencies
            // 
            lblDashboardEmergencies.AutoSize = true;
            lblDashboardEmergencies.Location = new System.Drawing.Point(21, 226);
            lblDashboardEmergencies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardEmergencies.Name = "lblDashboardEmergencies";
            lblDashboardEmergencies.Size = new System.Drawing.Size(124, 20);
            lblDashboardEmergencies.TabIndex = 8;
            lblDashboardEmergencies.Text = "Emergency Alerts";
            // 
            // txtDashboardLowStock
            // 
            txtDashboardLowStock.Location = new System.Drawing.Point(245, 178);
            txtDashboardLowStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDashboardLowStock.Name = "txtDashboardLowStock";
            txtDashboardLowStock.ReadOnly = true;
            txtDashboardLowStock.Size = new System.Drawing.Size(169, 27);
            txtDashboardLowStock.TabIndex = 7;
            txtDashboardLowStock.Text = "7";
            // 
            // lblDashboardLowStock
            // 
            lblDashboardLowStock.AutoSize = true;
            lblDashboardLowStock.Location = new System.Drawing.Point(21, 183);
            lblDashboardLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardLowStock.Name = "lblDashboardLowStock";
            lblDashboardLowStock.Size = new System.Drawing.Size(116, 20);
            lblDashboardLowStock.TabIndex = 6;
            lblDashboardLowStock.Text = "Low Stock Items";
            // 
            // txtDashboardOpenBeds
            // 
            txtDashboardOpenBeds.Location = new System.Drawing.Point(245, 135);
            txtDashboardOpenBeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDashboardOpenBeds.Name = "txtDashboardOpenBeds";
            txtDashboardOpenBeds.ReadOnly = true;
            txtDashboardOpenBeds.Size = new System.Drawing.Size(169, 27);
            txtDashboardOpenBeds.TabIndex = 5;
            txtDashboardOpenBeds.Text = "39";
            // 
            // lblDashboardOpenBeds
            // 
            lblDashboardOpenBeds.AutoSize = true;
            lblDashboardOpenBeds.Location = new System.Drawing.Point(21, 140);
            lblDashboardOpenBeds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardOpenBeds.Name = "lblDashboardOpenBeds";
            lblDashboardOpenBeds.Size = new System.Drawing.Size(81, 20);
            lblDashboardOpenBeds.TabIndex = 4;
            lblDashboardOpenBeds.Text = "Open Beds";
            // 
            // txtDashboardAppointments
            // 
            txtDashboardAppointments.Location = new System.Drawing.Point(245, 92);
            txtDashboardAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDashboardAppointments.Name = "txtDashboardAppointments";
            txtDashboardAppointments.ReadOnly = true;
            txtDashboardAppointments.Size = new System.Drawing.Size(169, 27);
            txtDashboardAppointments.TabIndex = 3;
            txtDashboardAppointments.Text = "24";
            // 
            // lblDashboardAppointments
            // 
            lblDashboardAppointments.AutoSize = true;
            lblDashboardAppointments.Location = new System.Drawing.Point(21, 97);
            lblDashboardAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardAppointments.Name = "lblDashboardAppointments";
            lblDashboardAppointments.Size = new System.Drawing.Size(147, 20);
            lblDashboardAppointments.TabIndex = 2;
            lblDashboardAppointments.Text = "Appointments Today";
            // 
            // txtDashboardPatients
            // 
            txtDashboardPatients.Location = new System.Drawing.Point(245, 49);
            txtDashboardPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDashboardPatients.Name = "txtDashboardPatients";
            txtDashboardPatients.ReadOnly = true;
            txtDashboardPatients.Size = new System.Drawing.Size(169, 27);
            txtDashboardPatients.TabIndex = 1;
            txtDashboardPatients.Text = "126";
            // 
            // lblDashboardPatients
            // 
            lblDashboardPatients.AutoSize = true;
            lblDashboardPatients.Location = new System.Drawing.Point(21, 54);
            lblDashboardPatients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardPatients.Name = "lblDashboardPatients";
            lblDashboardPatients.Size = new System.Drawing.Size(105, 20);
            lblDashboardPatients.TabIndex = 0;
            lblDashboardPatients.Text = "Active Patients";
            // 
            // patientsTab
            // 
            patientsTab.Controls.Add(grpPatientDetails);
            patientsTab.Controls.Add(patientGrid);
            patientsTab.Controls.Add(grpPatientSearch);
            patientsTab.Location = new System.Drawing.Point(4, 29);
            patientsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            patientsTab.Name = "patientsTab";
            patientsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            patientsTab.Size = new System.Drawing.Size(1571, 1001);
            patientsTab.TabIndex = 1;
            patientsTab.Text = "Patients";
            patientsTab.UseVisualStyleBackColor = true;
            // 
            // grpPatientDetails
            // 
            grpPatientDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            grpPatientDetails.Controls.Add(btnClearPatient);
            grpPatientDetails.Controls.Add(btnDeletePatient);
            grpPatientDetails.Controls.Add(btnUpdatePatient);
            grpPatientDetails.Controls.Add(btnAddPatient);
            grpPatientDetails.Controls.Add(chkPatientAdmitted);
            grpPatientDetails.Controls.Add(cmbPatientDepartment);
            grpPatientDetails.Controls.Add(lblPatientDepartment);
            grpPatientDetails.Controls.Add(txtPatientNotes);
            grpPatientDetails.Controls.Add(lblPatientNotes);
            grpPatientDetails.Controls.Add(txtPatientPhone);
            grpPatientDetails.Controls.Add(lblPatientPhone);
            grpPatientDetails.Controls.Add(dtpPatientDob);
            grpPatientDetails.Controls.Add(lblPatientDob);
            grpPatientDetails.Controls.Add(cmbPatientGender);
            grpPatientDetails.Controls.Add(lblPatientGender);
            grpPatientDetails.Controls.Add(txtPatientName);
            grpPatientDetails.Controls.Add(lblPatientName);
            grpPatientDetails.Controls.Add(txtPatientId);
            grpPatientDetails.Controls.Add(lblPatientId);
            grpPatientDetails.Location = new System.Drawing.Point(1109, 148);
            grpPatientDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpPatientDetails.Name = "grpPatientDetails";
            grpPatientDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpPatientDetails.Size = new System.Drawing.Size(427, 808);
            grpPatientDetails.TabIndex = 2;
            grpPatientDetails.TabStop = false;
            grpPatientDetails.Text = "Patient Details";
            // 
            // btnClearPatient
            // 
            btnClearPatient.Location = new System.Drawing.Point(224, 720);
            btnClearPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnClearPatient.Name = "btnClearPatient";
            btnClearPatient.Size = new System.Drawing.Size(171, 43);
            btnClearPatient.TabIndex = 18;
            btnClearPatient.Text = "Clear";
            btnClearPatient.UseVisualStyleBackColor = true;
            btnClearPatient.Click += btnClearPatient_Click;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new System.Drawing.Point(32, 720);
            btnDeletePatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new System.Drawing.Size(171, 43);
            btnDeletePatient.TabIndex = 17;
            btnDeletePatient.Text = "Delete Patient";
            btnDeletePatient.UseVisualStyleBackColor = true;
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // btnUpdatePatient
            // 
            btnUpdatePatient.Location = new System.Drawing.Point(224, 665);
            btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdatePatient.Name = "btnUpdatePatient";
            btnUpdatePatient.Size = new System.Drawing.Size(171, 43);
            btnUpdatePatient.TabIndex = 16;
            btnUpdatePatient.Text = "Update";
            btnUpdatePatient.UseVisualStyleBackColor = true;
            btnUpdatePatient.Click += btnUpdatePatient_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new System.Drawing.Point(32, 665);
            btnAddPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new System.Drawing.Size(171, 43);
            btnAddPatient.TabIndex = 15;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // chkPatientAdmitted
            // 
            chkPatientAdmitted.AutoSize = true;
            chkPatientAdmitted.Location = new System.Drawing.Point(32, 535);
            chkPatientAdmitted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkPatientAdmitted.Name = "chkPatientAdmitted";
            chkPatientAdmitted.Size = new System.Drawing.Size(157, 24);
            chkPatientAdmitted.TabIndex = 14;
            chkPatientAdmitted.Text = "Currently Admitted";
            chkPatientAdmitted.UseVisualStyleBackColor = true;
            // 
            // cmbPatientDepartment
            // 
            cmbPatientDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatientDepartment.FormattingEnabled = true;
            cmbPatientDepartment.Items.AddRange(new object[] { "Emergency", "General Medicine", "ICU", "Pediatrics", "Surgery", "Radiology" });
            cmbPatientDepartment.Location = new System.Drawing.Point(32, 480);
            cmbPatientDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbPatientDepartment.Name = "cmbPatientDepartment";
            cmbPatientDepartment.Size = new System.Drawing.Size(361, 28);
            cmbPatientDepartment.TabIndex = 13;
            // 
            // lblPatientDepartment
            // 
            lblPatientDepartment.AutoSize = true;
            lblPatientDepartment.Location = new System.Drawing.Point(32, 455);
            lblPatientDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientDepartment.Name = "lblPatientDepartment";
            lblPatientDepartment.Size = new System.Drawing.Size(89, 20);
            lblPatientDepartment.TabIndex = 12;
            lblPatientDepartment.Text = "Department";
            // 
            // txtPatientNotes
            // 
            txtPatientNotes.Location = new System.Drawing.Point(32, 591);
            txtPatientNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPatientNotes.Multiline = true;
            txtPatientNotes.Name = "txtPatientNotes";
            txtPatientNotes.Size = new System.Drawing.Size(361, 47);
            txtPatientNotes.TabIndex = 11;
            // 
            // lblPatientNotes
            // 
            lblPatientNotes.AutoSize = true;
            lblPatientNotes.Location = new System.Drawing.Point(32, 566);
            lblPatientNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientNotes.Name = "lblPatientNotes";
            lblPatientNotes.Size = new System.Drawing.Size(105, 20);
            lblPatientNotes.TabIndex = 10;
            lblPatientNotes.Text = "Medical Notes";
            // 
            // txtPatientPhone
            // 
            txtPatientPhone.Location = new System.Drawing.Point(32, 406);
            txtPatientPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPatientPhone.Name = "txtPatientPhone";
            txtPatientPhone.Size = new System.Drawing.Size(361, 27);
            txtPatientPhone.TabIndex = 9;
            // 
            // lblPatientPhone
            // 
            lblPatientPhone.AutoSize = true;
            lblPatientPhone.Location = new System.Drawing.Point(32, 382);
            lblPatientPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientPhone.Name = "lblPatientPhone";
            lblPatientPhone.Size = new System.Drawing.Size(108, 20);
            lblPatientPhone.TabIndex = 8;
            lblPatientPhone.Text = "Phone Number";
            // 
            // dtpPatientDob
            // 
            dtpPatientDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPatientDob.Location = new System.Drawing.Point(32, 332);
            dtpPatientDob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpPatientDob.Name = "dtpPatientDob";
            dtpPatientDob.Size = new System.Drawing.Size(361, 27);
            dtpPatientDob.TabIndex = 7;
            // 
            // lblPatientDob
            // 
            lblPatientDob.AutoSize = true;
            lblPatientDob.Location = new System.Drawing.Point(32, 308);
            lblPatientDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientDob.Name = "lblPatientDob";
            lblPatientDob.Size = new System.Drawing.Size(94, 20);
            lblPatientDob.TabIndex = 6;
            lblPatientDob.Text = "Date of Birth";
            // 
            // cmbPatientGender
            // 
            cmbPatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatientGender.FormattingEnabled = true;
            cmbPatientGender.Items.AddRange(new object[] { "Female", "Male", "Other", "Prefer not to say" });
            cmbPatientGender.Location = new System.Drawing.Point(32, 258);
            cmbPatientGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbPatientGender.Name = "cmbPatientGender";
            cmbPatientGender.Size = new System.Drawing.Size(361, 28);
            cmbPatientGender.TabIndex = 5;
            // 
            // lblPatientGender
            // 
            lblPatientGender.AutoSize = true;
            lblPatientGender.Location = new System.Drawing.Point(32, 234);
            lblPatientGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientGender.Name = "lblPatientGender";
            lblPatientGender.Size = new System.Drawing.Size(57, 20);
            lblPatientGender.TabIndex = 4;
            lblPatientGender.Text = "Gender";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new System.Drawing.Point(32, 185);
            txtPatientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new System.Drawing.Size(361, 27);
            txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new System.Drawing.Point(32, 160);
            lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new System.Drawing.Size(98, 20);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Patient Name";
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new System.Drawing.Point(32, 111);
            txtPatientId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new System.Drawing.Size(361, 27);
            txtPatientId.TabIndex = 1;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new System.Drawing.Point(32, 86);
            lblPatientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new System.Drawing.Size(73, 20);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Patient ID";
            // 
            // patientGrid
            // 
            patientGrid.AllowUserToAddRows = false;
            patientGrid.AllowUserToDeleteRows = false;
            patientGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            patientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { patientIdColumn, patientNameColumn, patientDepartmentColumn, patientStatusColumn, patientDoctorColumn });
            patientGrid.Location = new System.Drawing.Point(32, 148);
            patientGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            patientGrid.Name = "patientGrid";
            patientGrid.ReadOnly = true;
            patientGrid.RowHeadersWidth = 51;
            patientGrid.Size = new System.Drawing.Size(1045, 808);
            patientGrid.TabIndex = 1;
            patientGrid.CellDoubleClick += patientGrid_CellDoubleClick;
            // 
            // patientIdColumn
            // 
            patientIdColumn.HeaderText = "Patient ID";
            patientIdColumn.MinimumWidth = 6;
            patientIdColumn.Name = "patientIdColumn";
            patientIdColumn.ReadOnly = true;
            patientIdColumn.Width = 125;
            // 
            // patientNameColumn
            // 
            patientNameColumn.HeaderText = "Name";
            patientNameColumn.MinimumWidth = 6;
            patientNameColumn.Name = "patientNameColumn";
            patientNameColumn.ReadOnly = true;
            patientNameColumn.Width = 180;
            // 
            // patientDepartmentColumn
            // 
            patientDepartmentColumn.HeaderText = "Department";
            patientDepartmentColumn.MinimumWidth = 6;
            patientDepartmentColumn.Name = "patientDepartmentColumn";
            patientDepartmentColumn.ReadOnly = true;
            patientDepartmentColumn.Width = 150;
            // 
            // patientStatusColumn
            // 
            patientStatusColumn.HeaderText = "Status";
            patientStatusColumn.MinimumWidth = 6;
            patientStatusColumn.Name = "patientStatusColumn";
            patientStatusColumn.ReadOnly = true;
            patientStatusColumn.Width = 120;
            // 
            // patientDoctorColumn
            // 
            patientDoctorColumn.HeaderText = "Assigned Doctor";
            patientDoctorColumn.MinimumWidth = 6;
            patientDoctorColumn.Name = "patientDoctorColumn";
            patientDoctorColumn.ReadOnly = true;
            patientDoctorColumn.Width = 170;
            // 
            // grpPatientSearch
            // 
            grpPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpPatientSearch.Controls.Add(btnPatientRefresh);
            grpPatientSearch.Controls.Add(btnPatientSearch);
            grpPatientSearch.Controls.Add(cmbPatientFilter);
            grpPatientSearch.Controls.Add(lblPatientFilter);
            grpPatientSearch.Controls.Add(txtPatientSearch);
            grpPatientSearch.Controls.Add(lblPatientSearch);
            grpPatientSearch.Location = new System.Drawing.Point(32, 31);
            grpPatientSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpPatientSearch.Name = "grpPatientSearch";
            grpPatientSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpPatientSearch.Size = new System.Drawing.Size(1504, 92);
            grpPatientSearch.TabIndex = 0;
            grpPatientSearch.TabStop = false;
            grpPatientSearch.Text = "Patient Search";
            // 
            // btnPatientRefresh
            // 
            btnPatientRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPatientRefresh.Location = new System.Drawing.Point(1355, 31);
            btnPatientRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPatientRefresh.Name = "btnPatientRefresh";
            btnPatientRefresh.Size = new System.Drawing.Size(117, 37);
            btnPatientRefresh.TabIndex = 5;
            btnPatientRefresh.Text = "Refresh";
            btnPatientRefresh.UseVisualStyleBackColor = true;
            btnPatientRefresh.Click += btnPatientRefresh_Click;
            // 
            // btnPatientSearch
            // 
            btnPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPatientSearch.Location = new System.Drawing.Point(1227, 31);
            btnPatientSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPatientSearch.Name = "btnPatientSearch";
            btnPatientSearch.Size = new System.Drawing.Size(117, 37);
            btnPatientSearch.TabIndex = 4;
            btnPatientSearch.Text = "Search";
            btnPatientSearch.UseVisualStyleBackColor = true;
            btnPatientSearch.Click += btnPatientSearch_Click;
            // 
            // cmbPatientFilter
            // 
            cmbPatientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatientFilter.FormattingEnabled = true;
            cmbPatientFilter.Items.AddRange(new object[] { "All Patients", "Admitted", "Outpatient", "Critical Care", "Discharged" });
            cmbPatientFilter.Location = new System.Drawing.Point(651, 34);
            cmbPatientFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbPatientFilter.Name = "cmbPatientFilter";
            cmbPatientFilter.Size = new System.Drawing.Size(244, 28);
            cmbPatientFilter.TabIndex = 3;
            // 
            // lblPatientFilter
            // 
            lblPatientFilter.AutoSize = true;
            lblPatientFilter.Location = new System.Drawing.Point(576, 40);
            lblPatientFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientFilter.Name = "lblPatientFilter";
            lblPatientFilter.Size = new System.Drawing.Size(42, 20);
            lblPatientFilter.TabIndex = 2;
            lblPatientFilter.Text = "Filter";
            // 
            // txtPatientSearch
            // 
            txtPatientSearch.Location = new System.Drawing.Point(139, 34);
            txtPatientSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPatientSearch.Name = "txtPatientSearch";
            txtPatientSearch.Size = new System.Drawing.Size(372, 27);
            txtPatientSearch.TabIndex = 1;
            // 
            // lblPatientSearch
            // 
            lblPatientSearch.AutoSize = true;
            lblPatientSearch.Location = new System.Drawing.Point(21, 40);
            lblPatientSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientSearch.Name = "lblPatientSearch";
            lblPatientSearch.Size = new System.Drawing.Size(86, 20);
            lblPatientSearch.TabIndex = 0;
            lblPatientSearch.Text = "Name or ID";
            // 
            // appointmentsTab
            // 
            appointmentsTab.Controls.Add(appointmentGrid);
            appointmentsTab.Controls.Add(grpAppointmentDetails);
            appointmentsTab.Location = new System.Drawing.Point(4, 29);
            appointmentsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            appointmentsTab.Name = "appointmentsTab";
            appointmentsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            appointmentsTab.Size = new System.Drawing.Size(1571, 1001);
            appointmentsTab.TabIndex = 2;
            appointmentsTab.Text = "Appointments";
            appointmentsTab.UseVisualStyleBackColor = true;
            // 
            // appointmentGrid
            // 
            appointmentGrid.AllowUserToAddRows = false;
            appointmentGrid.AllowUserToDeleteRows = false;
            appointmentGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            appointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { appointmentTimeColumn, appointmentPatientColumn, appointmentDoctorColumn, appointmentReasonColumn, appointmentStatusColumn });
            appointmentGrid.Location = new System.Drawing.Point(501, 37);
            appointmentGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            appointmentGrid.Name = "appointmentGrid";
            appointmentGrid.ReadOnly = true;
            appointmentGrid.RowHeadersWidth = 51;
            appointmentGrid.Size = new System.Drawing.Size(1035, 919);
            appointmentGrid.TabIndex = 1;
            // 
            // appointmentTimeColumn
            // 
            appointmentTimeColumn.HeaderText = "Date and Time";
            appointmentTimeColumn.MinimumWidth = 6;
            appointmentTimeColumn.Name = "appointmentTimeColumn";
            appointmentTimeColumn.ReadOnly = true;
            appointmentTimeColumn.Width = 150;
            // 
            // appointmentPatientColumn
            // 
            appointmentPatientColumn.HeaderText = "Patient";
            appointmentPatientColumn.MinimumWidth = 6;
            appointmentPatientColumn.Name = "appointmentPatientColumn";
            appointmentPatientColumn.ReadOnly = true;
            appointmentPatientColumn.Width = 160;
            // 
            // appointmentDoctorColumn
            // 
            appointmentDoctorColumn.HeaderText = "Doctor";
            appointmentDoctorColumn.MinimumWidth = 6;
            appointmentDoctorColumn.Name = "appointmentDoctorColumn";
            appointmentDoctorColumn.ReadOnly = true;
            appointmentDoctorColumn.Width = 160;
            // 
            // appointmentReasonColumn
            // 
            appointmentReasonColumn.HeaderText = "Reason";
            appointmentReasonColumn.MinimumWidth = 6;
            appointmentReasonColumn.Name = "appointmentReasonColumn";
            appointmentReasonColumn.ReadOnly = true;
            appointmentReasonColumn.Width = 170;
            // 
            // appointmentStatusColumn
            // 
            appointmentStatusColumn.HeaderText = "Status";
            appointmentStatusColumn.MinimumWidth = 6;
            appointmentStatusColumn.Name = "appointmentStatusColumn";
            appointmentStatusColumn.ReadOnly = true;
            appointmentStatusColumn.Width = 120;
            // 
            // grpAppointmentDetails
            // 
            grpAppointmentDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            grpAppointmentDetails.Controls.Add(btnAppointmentRefresh);
            grpAppointmentDetails.Controls.Add(btnCancelAppointment);
            grpAppointmentDetails.Controls.Add(btnUpdateAppointment);
            grpAppointmentDetails.Controls.Add(btnAddAppointment);
            grpAppointmentDetails.Controls.Add(txtAppointmentNotes);
            grpAppointmentDetails.Controls.Add(lblAppointmentNotes);
            grpAppointmentDetails.Controls.Add(cmbAppointmentStatus);
            grpAppointmentDetails.Controls.Add(lblAppointmentStatus);
            grpAppointmentDetails.Controls.Add(dtpAppointmentTime);
            grpAppointmentDetails.Controls.Add(lblAppointmentTime);
            grpAppointmentDetails.Controls.Add(dtpAppointmentDate);
            grpAppointmentDetails.Controls.Add(lblAppointmentDate);
            grpAppointmentDetails.Controls.Add(txtAppointmentReason);
            grpAppointmentDetails.Controls.Add(lblAppointmentReason);
            grpAppointmentDetails.Controls.Add(cmbAppointmentDoctor);
            grpAppointmentDetails.Controls.Add(lblAppointmentDoctor);
            grpAppointmentDetails.Controls.Add(txtAppointmentPatient);
            grpAppointmentDetails.Controls.Add(lblAppointmentPatient);
            grpAppointmentDetails.Location = new System.Drawing.Point(32, 37);
            grpAppointmentDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAppointmentDetails.Name = "grpAppointmentDetails";
            grpAppointmentDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAppointmentDetails.Size = new System.Drawing.Size(437, 919);
            grpAppointmentDetails.TabIndex = 0;
            grpAppointmentDetails.TabStop = false;
            grpAppointmentDetails.Text = "Schedule Appointment";
            // 
            // btnAppointmentRefresh
            // 
            btnAppointmentRefresh.Location = new System.Drawing.Point(235, 806);
            btnAppointmentRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAppointmentRefresh.Name = "btnAppointmentRefresh";
            btnAppointmentRefresh.Size = new System.Drawing.Size(171, 43);
            btnAppointmentRefresh.TabIndex = 17;
            btnAppointmentRefresh.Text = "Refresh";
            btnAppointmentRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.Location = new System.Drawing.Point(43, 806);
            btnCancelAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new System.Drawing.Size(171, 43);
            btnCancelAppointment.TabIndex = 16;
            btnCancelAppointment.Text = "Cancel Appointment";
            btnCancelAppointment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Location = new System.Drawing.Point(235, 751);
            btnUpdateAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new System.Drawing.Size(171, 43);
            btnUpdateAppointment.TabIndex = 15;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new System.Drawing.Point(43, 751);
            btnAddAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new System.Drawing.Size(171, 43);
            btnAddAppointment.TabIndex = 14;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // txtAppointmentNotes
            // 
            txtAppointmentNotes.Location = new System.Drawing.Point(43, 578);
            txtAppointmentNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAppointmentNotes.Multiline = true;
            txtAppointmentNotes.Name = "txtAppointmentNotes";
            txtAppointmentNotes.Size = new System.Drawing.Size(361, 133);
            txtAppointmentNotes.TabIndex = 13;
            // 
            // lblAppointmentNotes
            // 
            lblAppointmentNotes.AutoSize = true;
            lblAppointmentNotes.Location = new System.Drawing.Point(43, 554);
            lblAppointmentNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentNotes.Name = "lblAppointmentNotes";
            lblAppointmentNotes.Size = new System.Drawing.Size(48, 20);
            lblAppointmentNotes.TabIndex = 12;
            lblAppointmentNotes.Text = "Notes";
            // 
            // cmbAppointmentStatus
            // 
            cmbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAppointmentStatus.FormattingEnabled = true;
            cmbAppointmentStatus.Items.AddRange(new object[] { "Scheduled", "Checked In", "Completed", "Cancelled", "Rescheduled" });
            cmbAppointmentStatus.Location = new System.Drawing.Point(43, 492);
            cmbAppointmentStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbAppointmentStatus.Name = "cmbAppointmentStatus";
            cmbAppointmentStatus.Size = new System.Drawing.Size(361, 28);
            cmbAppointmentStatus.TabIndex = 11;
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Location = new System.Drawing.Point(43, 468);
            lblAppointmentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new System.Drawing.Size(49, 20);
            lblAppointmentStatus.TabIndex = 10;
            lblAppointmentStatus.Text = "Status";
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new System.Drawing.Point(43, 406);
            dtpAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.ShowUpDown = true;
            dtpAppointmentTime.Size = new System.Drawing.Size(361, 27);
            dtpAppointmentTime.TabIndex = 9;
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new System.Drawing.Point(43, 382);
            lblAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new System.Drawing.Size(42, 20);
            lblAppointmentTime.TabIndex = 8;
            lblAppointmentTime.Text = "Time";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new System.Drawing.Point(43, 320);
            dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(361, 27);
            dtpAppointmentDate.TabIndex = 7;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new System.Drawing.Point(43, 295);
            lblAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new System.Drawing.Size(41, 20);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "Date";
            // 
            // txtAppointmentReason
            // 
            txtAppointmentReason.Location = new System.Drawing.Point(43, 234);
            txtAppointmentReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAppointmentReason.Name = "txtAppointmentReason";
            txtAppointmentReason.Size = new System.Drawing.Size(361, 27);
            txtAppointmentReason.TabIndex = 5;
            // 
            // lblAppointmentReason
            // 
            lblAppointmentReason.AutoSize = true;
            lblAppointmentReason.Location = new System.Drawing.Point(43, 209);
            lblAppointmentReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentReason.Name = "lblAppointmentReason";
            lblAppointmentReason.Size = new System.Drawing.Size(89, 20);
            lblAppointmentReason.TabIndex = 4;
            lblAppointmentReason.Text = "Visit Reason";
            // 
            // cmbAppointmentDoctor
            // 
            cmbAppointmentDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAppointmentDoctor.FormattingEnabled = true;
            cmbAppointmentDoctor.Items.AddRange(new object[] { "Dr. Adams", "Dr. Chen", "Dr. Patel", "Dr. Rivera", "Nurse Station" });
            cmbAppointmentDoctor.Location = new System.Drawing.Point(43, 148);
            cmbAppointmentDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            cmbAppointmentDoctor.Size = new System.Drawing.Size(361, 28);
            cmbAppointmentDoctor.TabIndex = 3;
            // 
            // lblAppointmentDoctor
            // 
            lblAppointmentDoctor.AutoSize = true;
            lblAppointmentDoctor.Location = new System.Drawing.Point(43, 123);
            lblAppointmentDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentDoctor.Name = "lblAppointmentDoctor";
            lblAppointmentDoctor.Size = new System.Drawing.Size(55, 20);
            lblAppointmentDoctor.TabIndex = 2;
            lblAppointmentDoctor.Text = "Doctor";
            // 
            // txtAppointmentPatient
            // 
            txtAppointmentPatient.Location = new System.Drawing.Point(43, 62);
            txtAppointmentPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAppointmentPatient.Name = "txtAppointmentPatient";
            txtAppointmentPatient.Size = new System.Drawing.Size(361, 27);
            txtAppointmentPatient.TabIndex = 1;
            // 
            // lblAppointmentPatient
            // 
            lblAppointmentPatient.AutoSize = true;
            lblAppointmentPatient.Location = new System.Drawing.Point(43, 37);
            lblAppointmentPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentPatient.Name = "lblAppointmentPatient";
            lblAppointmentPatient.Size = new System.Drawing.Size(54, 20);
            lblAppointmentPatient.TabIndex = 0;
            lblAppointmentPatient.Text = "Patient";
            // 
            // inventoryTab
            // 
            inventoryTab.Controls.Add(grpLowStock);
            inventoryTab.Controls.Add(inventoryGrid);
            inventoryTab.Controls.Add(grpInventoryDetails);
            inventoryTab.Location = new System.Drawing.Point(4, 29);
            inventoryTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            inventoryTab.Name = "inventoryTab";
            inventoryTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            inventoryTab.Size = new System.Drawing.Size(1571, 1001);
            inventoryTab.TabIndex = 3;
            inventoryTab.Text = "Inventory";
            inventoryTab.UseVisualStyleBackColor = true;
            // 
            // grpLowStock
            // 
            grpLowStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpLowStock.Controls.Add(lstLowStock);
            grpLowStock.Location = new System.Drawing.Point(501, 710);
            grpLowStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpLowStock.Name = "grpLowStock";
            grpLowStock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpLowStock.Size = new System.Drawing.Size(1035, 246);
            grpLowStock.TabIndex = 2;
            grpLowStock.TabStop = false;
            grpLowStock.Text = "Low Stock Alerts";
            // 
            // lstLowStock
            // 
            lstLowStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstLowStock.FormattingEnabled = true;
            lstLowStock.Items.AddRange(new object[] { "Insulin pens below reorder level", "IV saline bags below reorder level", "Sterile gloves below reorder level" });
            lstLowStock.Location = new System.Drawing.Point(21, 37);
            lstLowStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstLowStock.Name = "lstLowStock";
            lstLowStock.Size = new System.Drawing.Size(991, 184);
            lstLowStock.TabIndex = 0;
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToDeleteRows = false;
            inventoryGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { inventoryItemColumn, inventoryCategoryColumn, inventoryQuantityColumn, inventoryReorderColumn, inventoryLocationColumn });
            inventoryGrid.Location = new System.Drawing.Point(501, 37);
            inventoryGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.ReadOnly = true;
            inventoryGrid.RowHeadersWidth = 51;
            inventoryGrid.Size = new System.Drawing.Size(1035, 648);
            inventoryGrid.TabIndex = 1;
            // 
            // inventoryItemColumn
            // 
            inventoryItemColumn.HeaderText = "Item";
            inventoryItemColumn.MinimumWidth = 6;
            inventoryItemColumn.Name = "inventoryItemColumn";
            inventoryItemColumn.ReadOnly = true;
            inventoryItemColumn.Width = 200;
            // 
            // inventoryCategoryColumn
            // 
            inventoryCategoryColumn.HeaderText = "Category";
            inventoryCategoryColumn.MinimumWidth = 6;
            inventoryCategoryColumn.Name = "inventoryCategoryColumn";
            inventoryCategoryColumn.ReadOnly = true;
            inventoryCategoryColumn.Width = 140;
            // 
            // inventoryQuantityColumn
            // 
            inventoryQuantityColumn.HeaderText = "Quantity";
            inventoryQuantityColumn.MinimumWidth = 6;
            inventoryQuantityColumn.Name = "inventoryQuantityColumn";
            inventoryQuantityColumn.ReadOnly = true;
            inventoryQuantityColumn.Width = 125;
            // 
            // inventoryReorderColumn
            // 
            inventoryReorderColumn.HeaderText = "Reorder Level";
            inventoryReorderColumn.MinimumWidth = 6;
            inventoryReorderColumn.Name = "inventoryReorderColumn";
            inventoryReorderColumn.ReadOnly = true;
            inventoryReorderColumn.Width = 120;
            // 
            // inventoryLocationColumn
            // 
            inventoryLocationColumn.HeaderText = "Storage Location";
            inventoryLocationColumn.MinimumWidth = 6;
            inventoryLocationColumn.Name = "inventoryLocationColumn";
            inventoryLocationColumn.ReadOnly = true;
            inventoryLocationColumn.Width = 150;
            // 
            // grpInventoryDetails
            // 
            grpInventoryDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            grpInventoryDetails.Controls.Add(btnInventoryRefresh);
            grpInventoryDetails.Controls.Add(btnInventoryRemove);
            grpInventoryDetails.Controls.Add(btnInventoryUpdate);
            grpInventoryDetails.Controls.Add(btnInventoryAdd);
            grpInventoryDetails.Controls.Add(numInventoryReorder);
            grpInventoryDetails.Controls.Add(lblInventoryReorder);
            grpInventoryDetails.Controls.Add(numInventoryQuantity);
            grpInventoryDetails.Controls.Add(lblInventoryQuantity);
            grpInventoryDetails.Controls.Add(txtInventoryLocation);
            grpInventoryDetails.Controls.Add(lblInventoryLocation);
            grpInventoryDetails.Controls.Add(cmbInventoryCategory);
            grpInventoryDetails.Controls.Add(lblInventoryCategory);
            grpInventoryDetails.Controls.Add(txtInventoryItem);
            grpInventoryDetails.Controls.Add(lblInventoryItem);
            grpInventoryDetails.Location = new System.Drawing.Point(32, 37);
            grpInventoryDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpInventoryDetails.Name = "grpInventoryDetails";
            grpInventoryDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpInventoryDetails.Size = new System.Drawing.Size(437, 919);
            grpInventoryDetails.TabIndex = 0;
            grpInventoryDetails.TabStop = false;
            grpInventoryDetails.Text = "Medication and Supply Details";
            // 
            // btnInventoryRefresh
            // 
            btnInventoryRefresh.Location = new System.Drawing.Point(235, 628);
            btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnInventoryRefresh.Name = "btnInventoryRefresh";
            btnInventoryRefresh.Size = new System.Drawing.Size(171, 43);
            btnInventoryRefresh.TabIndex = 13;
            btnInventoryRefresh.Text = "Refresh";
            btnInventoryRefresh.UseVisualStyleBackColor = true;
            // 
            // btnInventoryRemove
            // 
            btnInventoryRemove.Location = new System.Drawing.Point(43, 628);
            btnInventoryRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnInventoryRemove.Name = "btnInventoryRemove";
            btnInventoryRemove.Size = new System.Drawing.Size(171, 43);
            btnInventoryRemove.TabIndex = 12;
            btnInventoryRemove.Text = "Remove Item";
            btnInventoryRemove.UseVisualStyleBackColor = true;
            // 
            // btnInventoryUpdate
            // 
            btnInventoryUpdate.Location = new System.Drawing.Point(235, 572);
            btnInventoryUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnInventoryUpdate.Name = "btnInventoryUpdate";
            btnInventoryUpdate.Size = new System.Drawing.Size(171, 43);
            btnInventoryUpdate.TabIndex = 11;
            btnInventoryUpdate.Text = "Update Stock";
            btnInventoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInventoryAdd
            // 
            btnInventoryAdd.Location = new System.Drawing.Point(43, 572);
            btnInventoryAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnInventoryAdd.Name = "btnInventoryAdd";
            btnInventoryAdd.Size = new System.Drawing.Size(171, 43);
            btnInventoryAdd.TabIndex = 10;
            btnInventoryAdd.Text = "Add Item";
            btnInventoryAdd.UseVisualStyleBackColor = true;
            // 
            // numInventoryReorder
            // 
            numInventoryReorder.Location = new System.Drawing.Point(43, 468);
            numInventoryReorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numInventoryReorder.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInventoryReorder.Name = "numInventoryReorder";
            numInventoryReorder.Size = new System.Drawing.Size(363, 27);
            numInventoryReorder.TabIndex = 9;
            // 
            // lblInventoryReorder
            // 
            lblInventoryReorder.AutoSize = true;
            lblInventoryReorder.Location = new System.Drawing.Point(43, 443);
            lblInventoryReorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryReorder.Name = "lblInventoryReorder";
            lblInventoryReorder.Size = new System.Drawing.Size(100, 20);
            lblInventoryReorder.TabIndex = 8;
            lblInventoryReorder.Text = "Reorder Level";
            // 
            // numInventoryQuantity
            // 
            numInventoryQuantity.Location = new System.Drawing.Point(43, 382);
            numInventoryQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numInventoryQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInventoryQuantity.Name = "numInventoryQuantity";
            numInventoryQuantity.Size = new System.Drawing.Size(363, 27);
            numInventoryQuantity.TabIndex = 7;
            // 
            // lblInventoryQuantity
            // 
            lblInventoryQuantity.AutoSize = true;
            lblInventoryQuantity.Location = new System.Drawing.Point(43, 357);
            lblInventoryQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryQuantity.Name = "lblInventoryQuantity";
            lblInventoryQuantity.Size = new System.Drawing.Size(65, 20);
            lblInventoryQuantity.TabIndex = 6;
            lblInventoryQuantity.Text = "Quantity";
            // 
            // txtInventoryLocation
            // 
            txtInventoryLocation.Location = new System.Drawing.Point(43, 295);
            txtInventoryLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInventoryLocation.Name = "txtInventoryLocation";
            txtInventoryLocation.Size = new System.Drawing.Size(361, 27);
            txtInventoryLocation.TabIndex = 5;
            // 
            // lblInventoryLocation
            // 
            lblInventoryLocation.AutoSize = true;
            lblInventoryLocation.Location = new System.Drawing.Point(43, 271);
            lblInventoryLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryLocation.Name = "lblInventoryLocation";
            lblInventoryLocation.Size = new System.Drawing.Size(122, 20);
            lblInventoryLocation.TabIndex = 4;
            lblInventoryLocation.Text = "Storage Location";
            // 
            // cmbInventoryCategory
            // 
            cmbInventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbInventoryCategory.FormattingEnabled = true;
            cmbInventoryCategory.Items.AddRange(new object[] { "Medication", "Surgical Supply", "Lab Supply", "General Supply", "Equipment" });
            cmbInventoryCategory.Location = new System.Drawing.Point(43, 209);
            cmbInventoryCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbInventoryCategory.Name = "cmbInventoryCategory";
            cmbInventoryCategory.Size = new System.Drawing.Size(361, 28);
            cmbInventoryCategory.TabIndex = 3;
            // 
            // lblInventoryCategory
            // 
            lblInventoryCategory.AutoSize = true;
            lblInventoryCategory.Location = new System.Drawing.Point(43, 185);
            lblInventoryCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryCategory.Name = "lblInventoryCategory";
            lblInventoryCategory.Size = new System.Drawing.Size(69, 20);
            lblInventoryCategory.TabIndex = 2;
            lblInventoryCategory.Text = "Category";
            // 
            // txtInventoryItem
            // 
            txtInventoryItem.Location = new System.Drawing.Point(43, 123);
            txtInventoryItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInventoryItem.Name = "txtInventoryItem";
            txtInventoryItem.Size = new System.Drawing.Size(361, 27);
            txtInventoryItem.TabIndex = 1;
            // 
            // lblInventoryItem
            // 
            lblInventoryItem.AutoSize = true;
            lblInventoryItem.Location = new System.Drawing.Point(43, 98);
            lblInventoryItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryItem.Name = "lblInventoryItem";
            lblInventoryItem.Size = new System.Drawing.Size(83, 20);
            lblInventoryItem.TabIndex = 0;
            lblInventoryItem.Text = "Item Name";
            // 
            // analyticsTab
            // 
            analyticsTab.Controls.Add(reportGrid);
            analyticsTab.Controls.Add(grpReportOutput);
            analyticsTab.Controls.Add(grpAnalyticsSummary);
            analyticsTab.Controls.Add(grpAnalyticsFilters);
            analyticsTab.Location = new System.Drawing.Point(4, 29);
            analyticsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            analyticsTab.Name = "analyticsTab";
            analyticsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            analyticsTab.Size = new System.Drawing.Size(1571, 1001);
            analyticsTab.TabIndex = 4;
            analyticsTab.Text = "Analytics";
            analyticsTab.UseVisualStyleBackColor = true;
            // 
            // reportGrid
            // 
            reportGrid.AllowUserToAddRows = false;
            reportGrid.AllowUserToDeleteRows = false;
            reportGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { reportMetricColumn, reportCurrentColumn, reportPreviousColumn, reportChangeColumn });
            reportGrid.Location = new System.Drawing.Point(512, 172);
            reportGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            reportGrid.Name = "reportGrid";
            reportGrid.ReadOnly = true;
            reportGrid.RowHeadersWidth = 51;
            reportGrid.Size = new System.Drawing.Size(1024, 525);
            reportGrid.TabIndex = 2;
            // 
            // reportMetricColumn
            // 
            reportMetricColumn.HeaderText = "Metric";
            reportMetricColumn.MinimumWidth = 6;
            reportMetricColumn.Name = "reportMetricColumn";
            reportMetricColumn.ReadOnly = true;
            reportMetricColumn.Width = 220;
            // 
            // reportCurrentColumn
            // 
            reportCurrentColumn.HeaderText = "Current Period";
            reportCurrentColumn.MinimumWidth = 6;
            reportCurrentColumn.Name = "reportCurrentColumn";
            reportCurrentColumn.ReadOnly = true;
            reportCurrentColumn.Width = 150;
            // 
            // reportPreviousColumn
            // 
            reportPreviousColumn.HeaderText = "Previous Period";
            reportPreviousColumn.MinimumWidth = 6;
            reportPreviousColumn.Name = "reportPreviousColumn";
            reportPreviousColumn.ReadOnly = true;
            reportPreviousColumn.Width = 150;
            // 
            // reportChangeColumn
            // 
            reportChangeColumn.HeaderText = "Change";
            reportChangeColumn.MinimumWidth = 6;
            reportChangeColumn.Name = "reportChangeColumn";
            reportChangeColumn.ReadOnly = true;
            reportChangeColumn.Width = 120;
            // 
            // grpReportOutput
            // 
            grpReportOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpReportOutput.Controls.Add(lstReportOutput);
            grpReportOutput.Location = new System.Drawing.Point(32, 722);
            grpReportOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpReportOutput.Name = "grpReportOutput";
            grpReportOutput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpReportOutput.Size = new System.Drawing.Size(1504, 234);
            grpReportOutput.TabIndex = 3;
            grpReportOutput.TabStop = false;
            grpReportOutput.Text = "Report Notes";
            // 
            // lstReportOutput
            // 
            lstReportOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstReportOutput.FormattingEnabled = true;
            lstReportOutput.Items.AddRange(new object[] { "Generated report highlights will appear here.", "Trends for patient visits, common ailments, and medication usage will appear here." });
            lstReportOutput.Location = new System.Drawing.Point(21, 37);
            lstReportOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstReportOutput.Name = "lstReportOutput";
            lstReportOutput.Size = new System.Drawing.Size(1460, 164);
            lstReportOutput.TabIndex = 0;
            // 
            // grpAnalyticsSummary
            // 
            grpAnalyticsSummary.Controls.Add(txtAnalyticsMedicationUsage);
            grpAnalyticsSummary.Controls.Add(lblAnalyticsMedicationUsage);
            grpAnalyticsSummary.Controls.Add(txtAnalyticsCommonAilment);
            grpAnalyticsSummary.Controls.Add(lblAnalyticsCommonAilment);
            grpAnalyticsSummary.Controls.Add(txtAnalyticsVisits);
            grpAnalyticsSummary.Controls.Add(lblAnalyticsVisits);
            grpAnalyticsSummary.Location = new System.Drawing.Point(32, 172);
            grpAnalyticsSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAnalyticsSummary.Name = "grpAnalyticsSummary";
            grpAnalyticsSummary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAnalyticsSummary.Size = new System.Drawing.Size(448, 517);
            grpAnalyticsSummary.TabIndex = 1;
            grpAnalyticsSummary.TabStop = false;
            grpAnalyticsSummary.Text = "Summary";
            // 
            // txtAnalyticsMedicationUsage
            // 
            txtAnalyticsMedicationUsage.Location = new System.Drawing.Point(43, 357);
            txtAnalyticsMedicationUsage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAnalyticsMedicationUsage.Name = "txtAnalyticsMedicationUsage";
            txtAnalyticsMedicationUsage.ReadOnly = true;
            txtAnalyticsMedicationUsage.Size = new System.Drawing.Size(361, 27);
            txtAnalyticsMedicationUsage.TabIndex = 5;
            txtAnalyticsMedicationUsage.Text = "Antibiotics";
            // 
            // lblAnalyticsMedicationUsage
            // 
            lblAnalyticsMedicationUsage.AutoSize = true;
            lblAnalyticsMedicationUsage.Location = new System.Drawing.Point(43, 332);
            lblAnalyticsMedicationUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsMedicationUsage.Name = "lblAnalyticsMedicationUsage";
            lblAnalyticsMedicationUsage.Size = new System.Drawing.Size(158, 20);
            lblAnalyticsMedicationUsage.TabIndex = 4;
            lblAnalyticsMedicationUsage.Text = "Top Medication Usage";
            // 
            // txtAnalyticsCommonAilment
            // 
            txtAnalyticsCommonAilment.Location = new System.Drawing.Point(43, 234);
            txtAnalyticsCommonAilment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAnalyticsCommonAilment.Name = "txtAnalyticsCommonAilment";
            txtAnalyticsCommonAilment.ReadOnly = true;
            txtAnalyticsCommonAilment.Size = new System.Drawing.Size(361, 27);
            txtAnalyticsCommonAilment.TabIndex = 3;
            txtAnalyticsCommonAilment.Text = "Respiratory Infection";
            // 
            // lblAnalyticsCommonAilment
            // 
            lblAnalyticsCommonAilment.AutoSize = true;
            lblAnalyticsCommonAilment.Location = new System.Drawing.Point(43, 209);
            lblAnalyticsCommonAilment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsCommonAilment.Name = "lblAnalyticsCommonAilment";
            lblAnalyticsCommonAilment.Size = new System.Drawing.Size(126, 20);
            lblAnalyticsCommonAilment.TabIndex = 2;
            lblAnalyticsCommonAilment.Text = "Common Ailment";
            // 
            // txtAnalyticsVisits
            // 
            txtAnalyticsVisits.Location = new System.Drawing.Point(43, 111);
            txtAnalyticsVisits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAnalyticsVisits.Name = "txtAnalyticsVisits";
            txtAnalyticsVisits.ReadOnly = true;
            txtAnalyticsVisits.Size = new System.Drawing.Size(361, 27);
            txtAnalyticsVisits.TabIndex = 1;
            txtAnalyticsVisits.Text = "284 visits";
            // 
            // lblAnalyticsVisits
            // 
            lblAnalyticsVisits.AutoSize = true;
            lblAnalyticsVisits.Location = new System.Drawing.Point(43, 86);
            lblAnalyticsVisits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsVisits.Name = "lblAnalyticsVisits";
            lblAnalyticsVisits.Size = new System.Drawing.Size(92, 20);
            lblAnalyticsVisits.TabIndex = 0;
            lblAnalyticsVisits.Text = "Patient Visits";
            // 
            // grpAnalyticsFilters
            // 
            grpAnalyticsFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpAnalyticsFilters.Controls.Add(btnGenerateReport);
            grpAnalyticsFilters.Controls.Add(cmbReportType);
            grpAnalyticsFilters.Controls.Add(lblReportType);
            grpAnalyticsFilters.Controls.Add(dtpReportEnd);
            grpAnalyticsFilters.Controls.Add(lblReportEnd);
            grpAnalyticsFilters.Controls.Add(dtpReportStart);
            grpAnalyticsFilters.Controls.Add(lblReportStart);
            grpAnalyticsFilters.Location = new System.Drawing.Point(32, 37);
            grpAnalyticsFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAnalyticsFilters.Name = "grpAnalyticsFilters";
            grpAnalyticsFilters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAnalyticsFilters.Size = new System.Drawing.Size(1504, 111);
            grpAnalyticsFilters.TabIndex = 0;
            grpAnalyticsFilters.TabStop = false;
            grpAnalyticsFilters.Text = "Report Filters";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGenerateReport.Location = new System.Drawing.Point(1301, 43);
            btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new System.Drawing.Size(171, 43);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Patient Visits", "Common Ailments", "Medication Usage", "Department Load" });
            cmbReportType.Location = new System.Drawing.Point(875, 49);
            cmbReportType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new System.Drawing.Size(265, 28);
            cmbReportType.TabIndex = 5;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Location = new System.Drawing.Point(779, 55);
            lblReportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new System.Drawing.Size(89, 20);
            lblReportType.TabIndex = 4;
            lblReportType.Text = "Report Type";
            // 
            // dtpReportEnd
            // 
            dtpReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReportEnd.Location = new System.Drawing.Point(480, 49);
            dtpReportEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpReportEnd.Name = "dtpReportEnd";
            dtpReportEnd.Size = new System.Drawing.Size(212, 27);
            dtpReportEnd.TabIndex = 3;
            // 
            // lblReportEnd
            // 
            lblReportEnd.AutoSize = true;
            lblReportEnd.Location = new System.Drawing.Point(384, 55);
            lblReportEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportEnd.Name = "lblReportEnd";
            lblReportEnd.Size = new System.Drawing.Size(70, 20);
            lblReportEnd.TabIndex = 2;
            lblReportEnd.Text = "End Date";
            // 
            // dtpReportStart
            // 
            dtpReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReportStart.Location = new System.Drawing.Point(128, 49);
            dtpReportStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpReportStart.Name = "dtpReportStart";
            dtpReportStart.Size = new System.Drawing.Size(212, 27);
            dtpReportStart.TabIndex = 1;
            // 
            // lblReportStart
            // 
            lblReportStart.AutoSize = true;
            lblReportStart.Location = new System.Drawing.Point(21, 55);
            lblReportStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportStart.Name = "lblReportStart";
            lblReportStart.Size = new System.Drawing.Size(76, 20);
            lblReportStart.TabIndex = 0;
            lblReportStart.Text = "Start Date";
            // 
            // communicationTab
            // 
            communicationTab.Controls.Add(grpNotifications);
            communicationTab.Controls.Add(grpMessageHistory);
            communicationTab.Controls.Add(grpConversations);
            communicationTab.Location = new System.Drawing.Point(4, 29);
            communicationTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            communicationTab.Name = "communicationTab";
            communicationTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            communicationTab.Size = new System.Drawing.Size(1571, 1001);
            communicationTab.TabIndex = 5;
            communicationTab.Text = "Communication";
            communicationTab.UseVisualStyleBackColor = true;
            // 
            // grpNotifications
            // 
            grpNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            grpNotifications.Controls.Add(lstNotifications);
            grpNotifications.Location = new System.Drawing.Point(1152, 37);
            grpNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpNotifications.Name = "grpNotifications";
            grpNotifications.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpNotifications.Size = new System.Drawing.Size(384, 919);
            grpNotifications.TabIndex = 2;
            grpNotifications.TabStop = false;
            grpNotifications.Text = "Notifications";
            // 
            // lstNotifications
            // 
            lstNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstNotifications.FormattingEnabled = true;
            lstNotifications.Items.AddRange(new object[] { "Appointment rescheduled", "Emergency broadcast", "Medication stock update", "Patient vitals changed" });
            lstNotifications.Location = new System.Drawing.Point(21, 37);
            lstNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new System.Drawing.Size(340, 844);
            lstNotifications.TabIndex = 0;
            // 
            // grpMessageHistory
            // 
            grpMessageHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMessageHistory.Controls.Add(txtMessageInput);
            grpMessageHistory.Controls.Add(btnSendMessage);
            grpMessageHistory.Controls.Add(lstMessageHistory);
            grpMessageHistory.Location = new System.Drawing.Point(427, 37);
            grpMessageHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpMessageHistory.Name = "grpMessageHistory";
            grpMessageHistory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpMessageHistory.Size = new System.Drawing.Size(693, 919);
            grpMessageHistory.TabIndex = 1;
            grpMessageHistory.TabStop = false;
            grpMessageHistory.Text = "Message History";
            // 
            // txtMessageInput
            // 
            txtMessageInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMessageInput.Location = new System.Drawing.Point(21, 826);
            txtMessageInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMessageInput.Name = "txtMessageInput";
            txtMessageInput.Size = new System.Drawing.Size(500, 27);
            txtMessageInput.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSendMessage.Location = new System.Drawing.Point(544, 820);
            btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new System.Drawing.Size(117, 43);
            btnSendMessage.TabIndex = 2;
            btnSendMessage.Text = "Send";
            btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // lstMessageHistory
            // 
            lstMessageHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstMessageHistory.FormattingEnabled = true;
            lstMessageHistory.Items.AddRange(new object[] { "Selected conversation messages will appear here." });
            lstMessageHistory.Location = new System.Drawing.Point(21, 37);
            lstMessageHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstMessageHistory.Name = "lstMessageHistory";
            lstMessageHistory.Size = new System.Drawing.Size(639, 744);
            lstMessageHistory.TabIndex = 0;
            // 
            // grpConversations
            // 
            grpConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            grpConversations.Controls.Add(btnNewConversation);
            grpConversations.Controls.Add(lstConversations);
            grpConversations.Location = new System.Drawing.Point(32, 37);
            grpConversations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpConversations.Name = "grpConversations";
            grpConversations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpConversations.Size = new System.Drawing.Size(363, 919);
            grpConversations.TabIndex = 0;
            grpConversations.TabStop = false;
            grpConversations.Text = "Conversations";
            // 
            // btnNewConversation
            // 
            btnNewConversation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNewConversation.Location = new System.Drawing.Point(21, 820);
            btnNewConversation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnNewConversation.Name = "btnNewConversation";
            btnNewConversation.Size = new System.Drawing.Size(320, 43);
            btnNewConversation.TabIndex = 1;
            btnNewConversation.Text = "New Conversation";
            btnNewConversation.UseVisualStyleBackColor = true;
            // 
            // lstConversations
            // 
            lstConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstConversations.FormattingEnabled = true;
            lstConversations.Items.AddRange(new object[] { "Nurse Station", "Dr. Adams", "Patient Support", "Emergency Team" });
            lstConversations.Location = new System.Drawing.Point(21, 37);
            lstConversations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstConversations.Name = "lstConversations";
            lstConversations.Size = new System.Drawing.Size(319, 744);
            lstConversations.TabIndex = 0;
            // 
            // monitoringTab
            // 
            monitoringTab.Controls.Add(grpMonitoringAlerts);
            monitoringTab.Controls.Add(grpVitalsEntry);
            monitoringTab.Controls.Add(vitalsGrid);
            monitoringTab.Location = new System.Drawing.Point(4, 29);
            monitoringTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            monitoringTab.Name = "monitoringTab";
            monitoringTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            monitoringTab.Size = new System.Drawing.Size(1571, 1001);
            monitoringTab.TabIndex = 6;
            monitoringTab.Text = "Monitoring";
            monitoringTab.UseVisualStyleBackColor = true;
            // 
            // grpMonitoringAlerts
            // 
            grpMonitoringAlerts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMonitoringAlerts.Controls.Add(lstMonitoringAlerts);
            grpMonitoringAlerts.Location = new System.Drawing.Point(32, 722);
            grpMonitoringAlerts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpMonitoringAlerts.Name = "grpMonitoringAlerts";
            grpMonitoringAlerts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpMonitoringAlerts.Size = new System.Drawing.Size(1067, 234);
            grpMonitoringAlerts.TabIndex = 1;
            grpMonitoringAlerts.TabStop = false;
            grpMonitoringAlerts.Text = "Critical Care Alerts";
            // 
            // lstMonitoringAlerts
            // 
            lstMonitoringAlerts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstMonitoringAlerts.FormattingEnabled = true;
            lstMonitoringAlerts.Items.AddRange(new object[] { "Vitals outside normal range will appear here.", "Critical care patient updates will appear here." });
            lstMonitoringAlerts.Location = new System.Drawing.Point(21, 37);
            lstMonitoringAlerts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstMonitoringAlerts.Name = "lstMonitoringAlerts";
            lstMonitoringAlerts.Size = new System.Drawing.Size(1023, 164);
            lstMonitoringAlerts.TabIndex = 0;
            // 
            // grpVitalsEntry
            // 
            grpVitalsEntry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            grpVitalsEntry.Controls.Add(btnMonitoringRefresh);
            grpVitalsEntry.Controls.Add(btnUpdateVitals);
            grpVitalsEntry.Controls.Add(txtMonitoringNotes);
            grpVitalsEntry.Controls.Add(lblMonitoringNotes);
            grpVitalsEntry.Controls.Add(numOxygenLevel);
            grpVitalsEntry.Controls.Add(lblOxygenLevel);
            grpVitalsEntry.Controls.Add(numTemperature);
            grpVitalsEntry.Controls.Add(lblTemperature);
            grpVitalsEntry.Controls.Add(txtBloodPressure);
            grpVitalsEntry.Controls.Add(lblBloodPressure);
            grpVitalsEntry.Controls.Add(numHeartRate);
            grpVitalsEntry.Controls.Add(lblHeartRate);
            grpVitalsEntry.Controls.Add(txtMonitoringPatient);
            grpVitalsEntry.Controls.Add(lblMonitoringPatient);
            grpVitalsEntry.Location = new System.Drawing.Point(1131, 37);
            grpVitalsEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpVitalsEntry.Name = "grpVitalsEntry";
            grpVitalsEntry.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpVitalsEntry.Size = new System.Drawing.Size(405, 919);
            grpVitalsEntry.TabIndex = 2;
            grpVitalsEntry.TabStop = false;
            grpVitalsEntry.Text = "Patient Vitals";
            // 
            // btnMonitoringRefresh
            // 
            btnMonitoringRefresh.Location = new System.Drawing.Point(213, 726);
            btnMonitoringRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnMonitoringRefresh.Name = "btnMonitoringRefresh";
            btnMonitoringRefresh.Size = new System.Drawing.Size(160, 43);
            btnMonitoringRefresh.TabIndex = 13;
            btnMonitoringRefresh.Text = "Refresh";
            btnMonitoringRefresh.UseVisualStyleBackColor = true;
            // 
            // btnUpdateVitals
            // 
            btnUpdateVitals.Location = new System.Drawing.Point(32, 726);
            btnUpdateVitals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdateVitals.Name = "btnUpdateVitals";
            btnUpdateVitals.Size = new System.Drawing.Size(160, 43);
            btnUpdateVitals.TabIndex = 12;
            btnUpdateVitals.Text = "Update Vitals";
            btnUpdateVitals.UseVisualStyleBackColor = true;
            // 
            // txtMonitoringNotes
            // 
            txtMonitoringNotes.Location = new System.Drawing.Point(32, 542);
            txtMonitoringNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMonitoringNotes.Multiline = true;
            txtMonitoringNotes.Name = "txtMonitoringNotes";
            txtMonitoringNotes.Size = new System.Drawing.Size(340, 133);
            txtMonitoringNotes.TabIndex = 11;
            // 
            // lblMonitoringNotes
            // 
            lblMonitoringNotes.AutoSize = true;
            lblMonitoringNotes.Location = new System.Drawing.Point(32, 517);
            lblMonitoringNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMonitoringNotes.Name = "lblMonitoringNotes";
            lblMonitoringNotes.Size = new System.Drawing.Size(126, 20);
            lblMonitoringNotes.TabIndex = 10;
            lblMonitoringNotes.Text = "Monitoring Notes";
            // 
            // numOxygenLevel
            // 
            numOxygenLevel.Location = new System.Drawing.Point(32, 455);
            numOxygenLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numOxygenLevel.Name = "numOxygenLevel";
            numOxygenLevel.Size = new System.Drawing.Size(341, 27);
            numOxygenLevel.TabIndex = 9;
            // 
            // lblOxygenLevel
            // 
            lblOxygenLevel.AutoSize = true;
            lblOxygenLevel.Location = new System.Drawing.Point(32, 431);
            lblOxygenLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOxygenLevel.Name = "lblOxygenLevel";
            lblOxygenLevel.Size = new System.Drawing.Size(97, 20);
            lblOxygenLevel.TabIndex = 8;
            lblOxygenLevel.Text = "Oxygen Level";
            // 
            // numTemperature
            // 
            numTemperature.DecimalPlaces = 1;
            numTemperature.Location = new System.Drawing.Point(32, 369);
            numTemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numTemperature.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numTemperature.Name = "numTemperature";
            numTemperature.Size = new System.Drawing.Size(341, 27);
            numTemperature.TabIndex = 7;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new System.Drawing.Point(32, 345);
            lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new System.Drawing.Size(93, 20);
            lblTemperature.TabIndex = 6;
            lblTemperature.Text = "Temperature";
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.Location = new System.Drawing.Point(32, 283);
            txtBloodPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new System.Drawing.Size(340, 27);
            txtBloodPressure.TabIndex = 5;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Location = new System.Drawing.Point(32, 258);
            lblBloodPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new System.Drawing.Size(107, 20);
            lblBloodPressure.TabIndex = 4;
            lblBloodPressure.Text = "Blood Pressure";
            // 
            // numHeartRate
            // 
            numHeartRate.Location = new System.Drawing.Point(32, 197);
            numHeartRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numHeartRate.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeartRate.Name = "numHeartRate";
            numHeartRate.Size = new System.Drawing.Size(341, 27);
            numHeartRate.TabIndex = 3;
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Location = new System.Drawing.Point(32, 172);
            lblHeartRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new System.Drawing.Size(80, 20);
            lblHeartRate.TabIndex = 2;
            lblHeartRate.Text = "Heart Rate";
            // 
            // txtMonitoringPatient
            // 
            txtMonitoringPatient.Location = new System.Drawing.Point(32, 111);
            txtMonitoringPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMonitoringPatient.Name = "txtMonitoringPatient";
            txtMonitoringPatient.Size = new System.Drawing.Size(340, 27);
            txtMonitoringPatient.TabIndex = 1;
            // 
            // lblMonitoringPatient
            // 
            lblMonitoringPatient.AutoSize = true;
            lblMonitoringPatient.Location = new System.Drawing.Point(32, 86);
            lblMonitoringPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMonitoringPatient.Name = "lblMonitoringPatient";
            lblMonitoringPatient.Size = new System.Drawing.Size(54, 20);
            lblMonitoringPatient.TabIndex = 0;
            lblMonitoringPatient.Text = "Patient";
            // 
            // vitalsGrid
            // 
            vitalsGrid.AllowUserToAddRows = false;
            vitalsGrid.AllowUserToDeleteRows = false;
            vitalsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            vitalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vitalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { vitalsPatientColumn, vitalsRoomColumn, vitalsHeartRateColumn, vitalsBloodPressureColumn, vitalsOxygenColumn, vitalsStatusColumn });
            vitalsGrid.Location = new System.Drawing.Point(32, 37);
            vitalsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            vitalsGrid.Name = "vitalsGrid";
            vitalsGrid.ReadOnly = true;
            vitalsGrid.RowHeadersWidth = 51;
            vitalsGrid.Size = new System.Drawing.Size(1067, 660);
            vitalsGrid.TabIndex = 0;
            // 
            // vitalsPatientColumn
            // 
            vitalsPatientColumn.HeaderText = "Patient";
            vitalsPatientColumn.MinimumWidth = 6;
            vitalsPatientColumn.Name = "vitalsPatientColumn";
            vitalsPatientColumn.ReadOnly = true;
            vitalsPatientColumn.Width = 160;
            // 
            // vitalsRoomColumn
            // 
            vitalsRoomColumn.HeaderText = "Room";
            vitalsRoomColumn.MinimumWidth = 6;
            vitalsRoomColumn.Name = "vitalsRoomColumn";
            vitalsRoomColumn.ReadOnly = true;
            vitalsRoomColumn.Width = 125;
            // 
            // vitalsHeartRateColumn
            // 
            vitalsHeartRateColumn.HeaderText = "Heart Rate";
            vitalsHeartRateColumn.MinimumWidth = 6;
            vitalsHeartRateColumn.Name = "vitalsHeartRateColumn";
            vitalsHeartRateColumn.ReadOnly = true;
            vitalsHeartRateColumn.Width = 125;
            // 
            // vitalsBloodPressureColumn
            // 
            vitalsBloodPressureColumn.HeaderText = "Blood Pressure";
            vitalsBloodPressureColumn.MinimumWidth = 6;
            vitalsBloodPressureColumn.Name = "vitalsBloodPressureColumn";
            vitalsBloodPressureColumn.ReadOnly = true;
            vitalsBloodPressureColumn.Width = 120;
            // 
            // vitalsOxygenColumn
            // 
            vitalsOxygenColumn.HeaderText = "Oxygen";
            vitalsOxygenColumn.MinimumWidth = 6;
            vitalsOxygenColumn.Name = "vitalsOxygenColumn";
            vitalsOxygenColumn.ReadOnly = true;
            vitalsOxygenColumn.Width = 125;
            // 
            // vitalsStatusColumn
            // 
            vitalsStatusColumn.HeaderText = "Status";
            vitalsStatusColumn.MinimumWidth = 6;
            vitalsStatusColumn.Name = "vitalsStatusColumn";
            vitalsStatusColumn.ReadOnly = true;
            vitalsStatusColumn.Width = 160;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1579, 1171);
            Controls.Add(mainTabs);
            Controls.Add(statusStrip);
            Controls.Add(headerPanel);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinimumSize = new System.Drawing.Size(1327, 975);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            mainTabs.ResumeLayout(false);
            dashboardTab.ResumeLayout(false);
            grpCriticalStatus.ResumeLayout(false);
            grpBedStatus.ResumeLayout(false);
            grpRealTimeUpdates.ResumeLayout(false);
            grpQuickCounts.ResumeLayout(false);
            grpQuickCounts.PerformLayout();
            patientsTab.ResumeLayout(false);
            grpPatientDetails.ResumeLayout(false);
            grpPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientGrid).EndInit();
            grpPatientSearch.ResumeLayout(false);
            grpPatientSearch.PerformLayout();
            appointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentGrid).EndInit();
            grpAppointmentDetails.ResumeLayout(false);
            grpAppointmentDetails.PerformLayout();
            inventoryTab.ResumeLayout(false);
            grpLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            grpInventoryDetails.ResumeLayout(false);
            grpInventoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInventoryReorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInventoryQuantity).EndInit();
            analyticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
            grpReportOutput.ResumeLayout(false);
            grpAnalyticsSummary.ResumeLayout(false);
            grpAnalyticsSummary.PerformLayout();
            grpAnalyticsFilters.ResumeLayout(false);
            grpAnalyticsFilters.PerformLayout();
            communicationTab.ResumeLayout(false);
            grpNotifications.ResumeLayout(false);
            grpMessageHistory.ResumeLayout(false);
            grpMessageHistory.PerformLayout();
            grpConversations.ResumeLayout(false);
            monitoringTab.ResumeLayout(false);
            grpMonitoringAlerts.ResumeLayout(false);
            grpVitalsEntry.ResumeLayout(false);
            grpVitalsEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOxygenLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTemperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeartRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)vitalsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.GroupBox grpCriticalStatus;
        private System.Windows.Forms.ListBox lstCriticalStatus;
        private System.Windows.Forms.GroupBox grpBedStatus;
        private System.Windows.Forms.ListBox lstBedStatus;
        private System.Windows.Forms.GroupBox grpRealTimeUpdates;
        private System.Windows.Forms.ListBox lstRealTimeUpdates;
        private System.Windows.Forms.GroupBox grpQuickCounts;
        private System.Windows.Forms.TextBox txtDashboardEmergencies;
        private System.Windows.Forms.Label lblDashboardEmergencies;
        private System.Windows.Forms.TextBox txtDashboardLowStock;
        private System.Windows.Forms.Label lblDashboardLowStock;
        private System.Windows.Forms.TextBox txtDashboardOpenBeds;
        private System.Windows.Forms.Label lblDashboardOpenBeds;
        private System.Windows.Forms.TextBox txtDashboardAppointments;
        private System.Windows.Forms.Label lblDashboardAppointments;
        private System.Windows.Forms.TextBox txtDashboardPatients;
        private System.Windows.Forms.Label lblDashboardPatients;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.Button btnClearPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.CheckBox chkPatientAdmitted;
        private System.Windows.Forms.ComboBox cmbPatientDepartment;
        private System.Windows.Forms.Label lblPatientDepartment;
        private System.Windows.Forms.TextBox txtPatientNotes;
        private System.Windows.Forms.Label lblPatientNotes;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.DateTimePicker dtpPatientDob;
        private System.Windows.Forms.Label lblPatientDob;
        private System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.DataGridView patientGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDoctorColumn;
        private System.Windows.Forms.GroupBox grpPatientSearch;
        private System.Windows.Forms.Button btnPatientRefresh;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.ComboBox cmbPatientFilter;
        private System.Windows.Forms.Label lblPatientFilter;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Label lblPatientSearch;
        private System.Windows.Forms.TabPage appointmentsTab;
        private System.Windows.Forms.DataGridView appointmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentPatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDoctorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentReasonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStatusColumn;
        private System.Windows.Forms.GroupBox grpAppointmentDetails;
        private System.Windows.Forms.Button btnAppointmentRefresh;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.TextBox txtAppointmentNotes;
        private System.Windows.Forms.Label lblAppointmentNotes;
        private System.Windows.Forms.ComboBox cmbAppointmentStatus;
        private System.Windows.Forms.Label lblAppointmentStatus;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.TextBox txtAppointmentReason;
        private System.Windows.Forms.Label lblAppointmentReason;
        private System.Windows.Forms.ComboBox cmbAppointmentDoctor;
        private System.Windows.Forms.Label lblAppointmentDoctor;
        private System.Windows.Forms.TextBox txtAppointmentPatient;
        private System.Windows.Forms.Label lblAppointmentPatient;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.GroupBox grpLowStock;
        private System.Windows.Forms.ListBox lstLowStock;
        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryReorderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryLocationColumn;
        private System.Windows.Forms.GroupBox grpInventoryDetails;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Button btnInventoryRemove;
        private System.Windows.Forms.Button btnInventoryUpdate;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.NumericUpDown numInventoryReorder;
        private System.Windows.Forms.Label lblInventoryReorder;
        private System.Windows.Forms.NumericUpDown numInventoryQuantity;
        private System.Windows.Forms.Label lblInventoryQuantity;
        private System.Windows.Forms.TextBox txtInventoryLocation;
        private System.Windows.Forms.Label lblInventoryLocation;
        private System.Windows.Forms.ComboBox cmbInventoryCategory;
        private System.Windows.Forms.Label lblInventoryCategory;
        private System.Windows.Forms.TextBox txtInventoryItem;
        private System.Windows.Forms.Label lblInventoryItem;
        private System.Windows.Forms.TabPage analyticsTab;
        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportMetricColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportCurrentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportPreviousColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportChangeColumn;
        private System.Windows.Forms.GroupBox grpReportOutput;
        private System.Windows.Forms.ListBox lstReportOutput;
        private System.Windows.Forms.GroupBox grpAnalyticsSummary;
        private System.Windows.Forms.TextBox txtAnalyticsMedicationUsage;
        private System.Windows.Forms.Label lblAnalyticsMedicationUsage;
        private System.Windows.Forms.TextBox txtAnalyticsCommonAilment;
        private System.Windows.Forms.Label lblAnalyticsCommonAilment;
        private System.Windows.Forms.TextBox txtAnalyticsVisits;
        private System.Windows.Forms.Label lblAnalyticsVisits;
        private System.Windows.Forms.GroupBox grpAnalyticsFilters;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.DateTimePicker dtpReportEnd;
        private System.Windows.Forms.Label lblReportEnd;
        private System.Windows.Forms.DateTimePicker dtpReportStart;
        private System.Windows.Forms.Label lblReportStart;
        private System.Windows.Forms.TabPage communicationTab;
        private System.Windows.Forms.GroupBox grpNotifications;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.GroupBox grpMessageHistory;
        private System.Windows.Forms.TextBox txtMessageInput;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ListBox lstMessageHistory;
        private System.Windows.Forms.GroupBox grpConversations;
        private System.Windows.Forms.Button btnNewConversation;
        private System.Windows.Forms.ListBox lstConversations;
        private System.Windows.Forms.TabPage monitoringTab;
        private System.Windows.Forms.GroupBox grpMonitoringAlerts;
        private System.Windows.Forms.ListBox lstMonitoringAlerts;
        private System.Windows.Forms.GroupBox grpVitalsEntry;
        private System.Windows.Forms.Button btnMonitoringRefresh;
        private System.Windows.Forms.Button btnUpdateVitals;
        private System.Windows.Forms.TextBox txtMonitoringNotes;
        private System.Windows.Forms.Label lblMonitoringNotes;
        private System.Windows.Forms.NumericUpDown numOxygenLevel;
        private System.Windows.Forms.Label lblOxygenLevel;
        private System.Windows.Forms.NumericUpDown numTemperature;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.NumericUpDown numHeartRate;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.TextBox txtMonitoringPatient;
        private System.Windows.Forms.Label lblMonitoringPatient;
        private System.Windows.Forms.DataGridView vitalsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsPatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsRoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsHeartRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsBloodPressureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsOxygenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsStatusColumn;
        private System.Windows.Forms.Button btnLogout;
    }
}
