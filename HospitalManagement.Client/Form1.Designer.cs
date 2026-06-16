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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.grpCriticalStatus = new System.Windows.Forms.GroupBox();
            this.lstCriticalStatus = new System.Windows.Forms.ListBox();
            this.grpBedStatus = new System.Windows.Forms.GroupBox();
            this.lstBedStatus = new System.Windows.Forms.ListBox();
            this.grpRealTimeUpdates = new System.Windows.Forms.GroupBox();
            this.lstRealTimeUpdates = new System.Windows.Forms.ListBox();
            this.grpQuickCounts = new System.Windows.Forms.GroupBox();
            this.txtDashboardEmergencies = new System.Windows.Forms.TextBox();
            this.lblDashboardEmergencies = new System.Windows.Forms.Label();
            this.txtDashboardLowStock = new System.Windows.Forms.TextBox();
            this.lblDashboardLowStock = new System.Windows.Forms.Label();
            this.txtDashboardOpenBeds = new System.Windows.Forms.TextBox();
            this.lblDashboardOpenBeds = new System.Windows.Forms.Label();
            this.txtDashboardAppointments = new System.Windows.Forms.TextBox();
            this.lblDashboardAppointments = new System.Windows.Forms.Label();
            this.txtDashboardPatients = new System.Windows.Forms.TextBox();
            this.lblDashboardPatients = new System.Windows.Forms.Label();
            this.patientsTab = new System.Windows.Forms.TabPage();
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.btnClearPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.chkPatientAdmitted = new System.Windows.Forms.CheckBox();
            this.cmbPatientDepartment = new System.Windows.Forms.ComboBox();
            this.lblPatientDepartment = new System.Windows.Forms.Label();
            this.txtPatientNotes = new System.Windows.Forms.TextBox();
            this.lblPatientNotes = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.dtpPatientDob = new System.Windows.Forms.DateTimePicker();
            this.lblPatientDob = new System.Windows.Forms.Label();
            this.cmbPatientGender = new System.Windows.Forms.ComboBox();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.patientGrid = new System.Windows.Forms.DataGridView();
            this.patientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPatientSearch = new System.Windows.Forms.GroupBox();
            this.btnPatientRefresh = new System.Windows.Forms.Button();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.cmbPatientFilter = new System.Windows.Forms.ComboBox();
            this.lblPatientFilter = new System.Windows.Forms.Label();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.lblPatientSearch = new System.Windows.Forms.Label();
            this.appointmentsTab = new System.Windows.Forms.TabPage();
            this.appointmentGrid = new System.Windows.Forms.DataGridView();
            this.appointmentTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentPatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.btnAppointmentRefresh = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.txtAppointmentNotes = new System.Windows.Forms.TextBox();
            this.lblAppointmentNotes = new System.Windows.Forms.Label();
            this.cmbAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.txtAppointmentReason = new System.Windows.Forms.TextBox();
            this.lblAppointmentReason = new System.Windows.Forms.Label();
            this.cmbAppointmentDoctor = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDoctor = new System.Windows.Forms.Label();
            this.txtAppointmentPatient = new System.Windows.Forms.TextBox();
            this.lblAppointmentPatient = new System.Windows.Forms.Label();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.grpLowStock = new System.Windows.Forms.GroupBox();
            this.lstLowStock = new System.Windows.Forms.ListBox();
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.inventoryItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryReorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInventoryDetails = new System.Windows.Forms.GroupBox();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            this.btnInventoryRemove = new System.Windows.Forms.Button();
            this.btnInventoryUpdate = new System.Windows.Forms.Button();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.numInventoryReorder = new System.Windows.Forms.NumericUpDown();
            this.lblInventoryReorder = new System.Windows.Forms.Label();
            this.numInventoryQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblInventoryQuantity = new System.Windows.Forms.Label();
            this.txtInventoryLocation = new System.Windows.Forms.TextBox();
            this.lblInventoryLocation = new System.Windows.Forms.Label();
            this.cmbInventoryCategory = new System.Windows.Forms.ComboBox();
            this.lblInventoryCategory = new System.Windows.Forms.Label();
            this.txtInventoryItem = new System.Windows.Forms.TextBox();
            this.lblInventoryItem = new System.Windows.Forms.Label();
            this.analyticsTab = new System.Windows.Forms.TabPage();
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.reportMetricColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportCurrentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPreviousColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportChangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReportOutput = new System.Windows.Forms.GroupBox();
            this.lstReportOutput = new System.Windows.Forms.ListBox();
            this.grpAnalyticsSummary = new System.Windows.Forms.GroupBox();
            this.txtAnalyticsMedicationUsage = new System.Windows.Forms.TextBox();
            this.lblAnalyticsMedicationUsage = new System.Windows.Forms.Label();
            this.txtAnalyticsCommonAilment = new System.Windows.Forms.TextBox();
            this.lblAnalyticsCommonAilment = new System.Windows.Forms.Label();
            this.txtAnalyticsVisits = new System.Windows.Forms.TextBox();
            this.lblAnalyticsVisits = new System.Windows.Forms.Label();
            this.grpAnalyticsFilters = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.dtpReportEnd = new System.Windows.Forms.DateTimePicker();
            this.lblReportEnd = new System.Windows.Forms.Label();
            this.dtpReportStart = new System.Windows.Forms.DateTimePicker();
            this.lblReportStart = new System.Windows.Forms.Label();
            this.communicationTab = new System.Windows.Forms.TabPage();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.grpMessageHistory = new System.Windows.Forms.GroupBox();
            this.txtMessageInput = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lstMessageHistory = new System.Windows.Forms.ListBox();
            this.grpConversations = new System.Windows.Forms.GroupBox();
            this.btnNewConversation = new System.Windows.Forms.Button();
            this.lstConversations = new System.Windows.Forms.ListBox();
            this.monitoringTab = new System.Windows.Forms.TabPage();
            this.grpMonitoringAlerts = new System.Windows.Forms.GroupBox();
            this.lstMonitoringAlerts = new System.Windows.Forms.ListBox();
            this.grpVitalsEntry = new System.Windows.Forms.GroupBox();
            this.btnMonitoringRefresh = new System.Windows.Forms.Button();
            this.btnUpdateVitals = new System.Windows.Forms.Button();
            this.txtMonitoringNotes = new System.Windows.Forms.TextBox();
            this.lblMonitoringNotes = new System.Windows.Forms.Label();
            this.numOxygenLevel = new System.Windows.Forms.NumericUpDown();
            this.lblOxygenLevel = new System.Windows.Forms.Label();
            this.numTemperature = new System.Windows.Forms.NumericUpDown();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtBloodPressure = new System.Windows.Forms.TextBox();
            this.lblBloodPressure = new System.Windows.Forms.Label();
            this.numHeartRate = new System.Windows.Forms.NumericUpDown();
            this.lblHeartRate = new System.Windows.Forms.Label();
            this.txtMonitoringPatient = new System.Windows.Forms.TextBox();
            this.lblMonitoringPatient = new System.Windows.Forms.Label();
            this.vitalsGrid = new System.Windows.Forms.DataGridView();
            this.vitalsPatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitalsRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitalsHeartRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitalsBloodPressureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitalsOxygenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitalsStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.grpCriticalStatus.SuspendLayout();
            this.grpBedStatus.SuspendLayout();
            this.grpRealTimeUpdates.SuspendLayout();
            this.grpQuickCounts.SuspendLayout();
            this.patientsTab.SuspendLayout();
            this.grpPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).BeginInit();
            this.grpPatientSearch.SuspendLayout();
            this.appointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).BeginInit();
            this.grpAppointmentDetails.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.grpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.grpInventoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInventoryReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventoryQuantity)).BeginInit();
            this.analyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.grpReportOutput.SuspendLayout();
            this.grpAnalyticsSummary.SuspendLayout();
            this.grpAnalyticsFilters.SuspendLayout();
            this.communicationTab.SuspendLayout();
            this.grpNotifications.SuspendLayout();
            this.grpMessageHistory.SuspendLayout();
            this.grpConversations.SuspendLayout();
            this.monitoringTab.SuspendLayout();
            this.grpMonitoringAlerts.SuspendLayout();
            this.grpVitalsEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOxygenLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalsGrid)).BeginInit();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.Controls.Add(this.lblNotifications);
            this.headerPanel.Controls.Add(this.lblConnection);
            this.headerPanel.Controls.Add(this.lblRole);
            this.headerPanel.Controls.Add(this.lblLoggedInUser);
            this.headerPanel.Controls.Add(this.lblSystemTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1184, 72);
            this.headerPanel.TabIndex = 0;
            //
            // lblNotifications
            //
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(882, 40);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(178, 13);
            this.lblNotifications.TabIndex = 4;
            this.lblNotifications.Text = "Notifications: 3 pending | 1 urgent";
            //
            // lblConnection
            //
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(646, 40);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(159, 13);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "SignalR Connection: Waiting";
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(391, 40);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(166, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role: Administrative Staff";
            //
            // lblLoggedInUser
            //
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Location = new System.Drawing.Point(24, 40);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(160, 13);
            this.lblLoggedInUser.TabIndex = 1;
            this.lblLoggedInUser.Text = "Logged in as: Current User";
            //
            // lblSystemTitle
            //
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Location = new System.Drawing.Point(24, 16);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(196, 13);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "Hospital Management System";
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip.Location = new System.Drawing.Point(0, 739);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            //
            // statusText
            //
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(312, 17);
            this.statusText.Text = "Ready | Client dashboard design only | No live data connected";
            //
            // mainTabs
            //
            this.mainTabs.Controls.Add(this.dashboardTab);
            this.mainTabs.Controls.Add(this.patientsTab);
            this.mainTabs.Controls.Add(this.appointmentsTab);
            this.mainTabs.Controls.Add(this.inventoryTab);
            this.mainTabs.Controls.Add(this.analyticsTab);
            this.mainTabs.Controls.Add(this.communicationTab);
            this.mainTabs.Controls.Add(this.monitoringTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 72);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1184, 667);
            this.mainTabs.TabIndex = 1;
            //
            // dashboardTab
            //
            this.dashboardTab.Controls.Add(this.grpCriticalStatus);
            this.dashboardTab.Controls.Add(this.grpBedStatus);
            this.dashboardTab.Controls.Add(this.grpRealTimeUpdates);
            this.dashboardTab.Controls.Add(this.grpQuickCounts);
            this.dashboardTab.Location = new System.Drawing.Point(4, 22);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(1176, 641);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            //
            // grpCriticalStatus
            //
            this.grpCriticalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCriticalStatus.Controls.Add(this.lstCriticalStatus);
            this.grpCriticalStatus.Location = new System.Drawing.Point(24, 424);
            this.grpCriticalStatus.Name = "grpCriticalStatus";
            this.grpCriticalStatus.Size = new System.Drawing.Size(1128, 190);
            this.grpCriticalStatus.TabIndex = 3;
            this.grpCriticalStatus.TabStop = false;
            this.grpCriticalStatus.Text = "Emergency and Critical Status";
            //
            // lstCriticalStatus
            //
            this.lstCriticalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCriticalStatus.FormattingEnabled = true;
            this.lstCriticalStatus.Location = new System.Drawing.Point(16, 24);
            this.lstCriticalStatus.Name = "lstCriticalStatus";
            this.lstCriticalStatus.Size = new System.Drawing.Size(1096, 147);
            this.lstCriticalStatus.TabIndex = 0;
            //
            // grpBedStatus
            //
            this.grpBedStatus.Controls.Add(this.lstBedStatus);
            this.grpBedStatus.Location = new System.Drawing.Point(24, 232);
            this.grpBedStatus.Name = "grpBedStatus";
            this.grpBedStatus.Size = new System.Drawing.Size(330, 176);
            this.grpBedStatus.TabIndex = 1;
            this.grpBedStatus.TabStop = false;
            this.grpBedStatus.Text = "Bed Availability";
            //
            // lstBedStatus
            //
            this.lstBedStatus.FormattingEnabled = true;
            this.lstBedStatus.Items.AddRange(new object[] {
            "Emergency: 6 beds available",
            "ICU: 2 beds available",
            "Pediatrics: 8 beds available",
            "Surgery Recovery: 4 beds available",
            "General Ward: 19 beds available"});
            this.lstBedStatus.Location = new System.Drawing.Point(16, 24);
            this.lstBedStatus.Name = "lstBedStatus";
            this.lstBedStatus.Size = new System.Drawing.Size(296, 134);
            this.lstBedStatus.TabIndex = 0;
            //
            // grpRealTimeUpdates
            //
            this.grpRealTimeUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRealTimeUpdates.Controls.Add(this.lstRealTimeUpdates);
            this.grpRealTimeUpdates.Location = new System.Drawing.Point(374, 24);
            this.grpRealTimeUpdates.Name = "grpRealTimeUpdates";
            this.grpRealTimeUpdates.Size = new System.Drawing.Size(778, 384);
            this.grpRealTimeUpdates.TabIndex = 2;
            this.grpRealTimeUpdates.TabStop = false;
            this.grpRealTimeUpdates.Text = "Real-Time Updates";
            //
            // lstRealTimeUpdates
            //
            this.lstRealTimeUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRealTimeUpdates.FormattingEnabled = true;
            this.lstRealTimeUpdates.Items.AddRange(new object[] {
            "Appointment update feed will appear here.",
            "Inventory alerts will appear here.",
            "Emergency broadcasts will appear here.",
            "Patient monitoring updates will appear here."});
            this.lstRealTimeUpdates.Location = new System.Drawing.Point(16, 24);
            this.lstRealTimeUpdates.Name = "lstRealTimeUpdates";
            this.lstRealTimeUpdates.Size = new System.Drawing.Size(746, 342);
            this.lstRealTimeUpdates.TabIndex = 0;
            //
            // grpQuickCounts
            //
            this.grpQuickCounts.Controls.Add(this.txtDashboardEmergencies);
            this.grpQuickCounts.Controls.Add(this.lblDashboardEmergencies);
            this.grpQuickCounts.Controls.Add(this.txtDashboardLowStock);
            this.grpQuickCounts.Controls.Add(this.lblDashboardLowStock);
            this.grpQuickCounts.Controls.Add(this.txtDashboardOpenBeds);
            this.grpQuickCounts.Controls.Add(this.lblDashboardOpenBeds);
            this.grpQuickCounts.Controls.Add(this.txtDashboardAppointments);
            this.grpQuickCounts.Controls.Add(this.lblDashboardAppointments);
            this.grpQuickCounts.Controls.Add(this.txtDashboardPatients);
            this.grpQuickCounts.Controls.Add(this.lblDashboardPatients);
            this.grpQuickCounts.Location = new System.Drawing.Point(24, 24);
            this.grpQuickCounts.Name = "grpQuickCounts";
            this.grpQuickCounts.Size = new System.Drawing.Size(330, 192);
            this.grpQuickCounts.TabIndex = 0;
            this.grpQuickCounts.TabStop = false;
            this.grpQuickCounts.Text = "Today Overview";
            //
            // txtDashboardEmergencies
            //
            this.txtDashboardEmergencies.Location = new System.Drawing.Point(184, 144);
            this.txtDashboardEmergencies.Name = "txtDashboardEmergencies";
            this.txtDashboardEmergencies.ReadOnly = true;
            this.txtDashboardEmergencies.Size = new System.Drawing.Size(128, 20);
            this.txtDashboardEmergencies.TabIndex = 9;
            this.txtDashboardEmergencies.Text = "1";
            //
            // lblDashboardEmergencies
            //
            this.lblDashboardEmergencies.AutoSize = true;
            this.lblDashboardEmergencies.Location = new System.Drawing.Point(16, 147);
            this.lblDashboardEmergencies.Name = "lblDashboardEmergencies";
            this.lblDashboardEmergencies.Size = new System.Drawing.Size(107, 13);
            this.lblDashboardEmergencies.TabIndex = 8;
            this.lblDashboardEmergencies.Text = "Emergency Alerts";
            //
            // txtDashboardLowStock
            //
            this.txtDashboardLowStock.Location = new System.Drawing.Point(184, 116);
            this.txtDashboardLowStock.Name = "txtDashboardLowStock";
            this.txtDashboardLowStock.ReadOnly = true;
            this.txtDashboardLowStock.Size = new System.Drawing.Size(128, 20);
            this.txtDashboardLowStock.TabIndex = 7;
            this.txtDashboardLowStock.Text = "7";
            //
            // lblDashboardLowStock
            //
            this.lblDashboardLowStock.AutoSize = true;
            this.lblDashboardLowStock.Location = new System.Drawing.Point(16, 119);
            this.lblDashboardLowStock.Name = "lblDashboardLowStock";
            this.lblDashboardLowStock.Size = new System.Drawing.Size(94, 13);
            this.lblDashboardLowStock.TabIndex = 6;
            this.lblDashboardLowStock.Text = "Low Stock Items";
            //
            // txtDashboardOpenBeds
            //
            this.txtDashboardOpenBeds.Location = new System.Drawing.Point(184, 88);
            this.txtDashboardOpenBeds.Name = "txtDashboardOpenBeds";
            this.txtDashboardOpenBeds.ReadOnly = true;
            this.txtDashboardOpenBeds.Size = new System.Drawing.Size(128, 20);
            this.txtDashboardOpenBeds.TabIndex = 5;
            this.txtDashboardOpenBeds.Text = "39";
            //
            // lblDashboardOpenBeds
            //
            this.lblDashboardOpenBeds.AutoSize = true;
            this.lblDashboardOpenBeds.Location = new System.Drawing.Point(16, 91);
            this.lblDashboardOpenBeds.Name = "lblDashboardOpenBeds";
            this.lblDashboardOpenBeds.Size = new System.Drawing.Size(91, 13);
            this.lblDashboardOpenBeds.TabIndex = 4;
            this.lblDashboardOpenBeds.Text = "Open Beds";
            //
            // txtDashboardAppointments
            //
            this.txtDashboardAppointments.Location = new System.Drawing.Point(184, 60);
            this.txtDashboardAppointments.Name = "txtDashboardAppointments";
            this.txtDashboardAppointments.ReadOnly = true;
            this.txtDashboardAppointments.Size = new System.Drawing.Size(128, 20);
            this.txtDashboardAppointments.TabIndex = 3;
            this.txtDashboardAppointments.Text = "24";
            //
            // lblDashboardAppointments
            //
            this.lblDashboardAppointments.AutoSize = true;
            this.lblDashboardAppointments.Location = new System.Drawing.Point(16, 63);
            this.lblDashboardAppointments.Name = "lblDashboardAppointments";
            this.lblDashboardAppointments.Size = new System.Drawing.Size(118, 13);
            this.lblDashboardAppointments.TabIndex = 2;
            this.lblDashboardAppointments.Text = "Appointments Today";
            //
            // txtDashboardPatients
            //
            this.txtDashboardPatients.Location = new System.Drawing.Point(184, 32);
            this.txtDashboardPatients.Name = "txtDashboardPatients";
            this.txtDashboardPatients.ReadOnly = true;
            this.txtDashboardPatients.Size = new System.Drawing.Size(128, 20);
            this.txtDashboardPatients.TabIndex = 1;
            this.txtDashboardPatients.Text = "126";
            //
            // lblDashboardPatients
            //
            this.lblDashboardPatients.AutoSize = true;
            this.lblDashboardPatients.Location = new System.Drawing.Point(16, 35);
            this.lblDashboardPatients.Name = "lblDashboardPatients";
            this.lblDashboardPatients.Size = new System.Drawing.Size(86, 13);
            this.lblDashboardPatients.TabIndex = 0;
            this.lblDashboardPatients.Text = "Active Patients";
            //
            // patientsTab
            //
            this.patientsTab.Controls.Add(this.grpPatientDetails);
            this.patientsTab.Controls.Add(this.patientGrid);
            this.patientsTab.Controls.Add(this.grpPatientSearch);
            this.patientsTab.Location = new System.Drawing.Point(4, 22);
            this.patientsTab.Name = "patientsTab";
            this.patientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTab.Size = new System.Drawing.Size(1176, 641);
            this.patientsTab.TabIndex = 1;
            this.patientsTab.Text = "Patients";
            this.patientsTab.UseVisualStyleBackColor = true;
            //
            // grpPatientDetails
            //
            this.grpPatientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientDetails.Controls.Add(this.btnClearPatient);
            this.grpPatientDetails.Controls.Add(this.btnDeletePatient);
            this.grpPatientDetails.Controls.Add(this.btnUpdatePatient);
            this.grpPatientDetails.Controls.Add(this.btnAddPatient);
            this.grpPatientDetails.Controls.Add(this.chkPatientAdmitted);
            this.grpPatientDetails.Controls.Add(this.cmbPatientDepartment);
            this.grpPatientDetails.Controls.Add(this.lblPatientDepartment);
            this.grpPatientDetails.Controls.Add(this.txtPatientNotes);
            this.grpPatientDetails.Controls.Add(this.lblPatientNotes);
            this.grpPatientDetails.Controls.Add(this.txtPatientPhone);
            this.grpPatientDetails.Controls.Add(this.lblPatientPhone);
            this.grpPatientDetails.Controls.Add(this.dtpPatientDob);
            this.grpPatientDetails.Controls.Add(this.lblPatientDob);
            this.grpPatientDetails.Controls.Add(this.cmbPatientGender);
            this.grpPatientDetails.Controls.Add(this.lblPatientGender);
            this.grpPatientDetails.Controls.Add(this.txtPatientName);
            this.grpPatientDetails.Controls.Add(this.lblPatientName);
            this.grpPatientDetails.Controls.Add(this.txtPatientId);
            this.grpPatientDetails.Controls.Add(this.lblPatientId);
            this.grpPatientDetails.Location = new System.Drawing.Point(832, 96);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(320, 520);
            this.grpPatientDetails.TabIndex = 2;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details";
            //
            // btnClearPatient
            //
            this.btnClearPatient.Location = new System.Drawing.Point(168, 468);
            this.btnClearPatient.Name = "btnClearPatient";
            this.btnClearPatient.Size = new System.Drawing.Size(128, 28);
            this.btnClearPatient.TabIndex = 18;
            this.btnClearPatient.Text = "Clear";
            this.btnClearPatient.UseVisualStyleBackColor = true;
            //
            // btnDeletePatient
            //
            this.btnDeletePatient.Location = new System.Drawing.Point(24, 468);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(128, 28);
            this.btnDeletePatient.TabIndex = 17;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            //
            // btnUpdatePatient
            //
            this.btnUpdatePatient.Location = new System.Drawing.Point(168, 432);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(128, 28);
            this.btnUpdatePatient.TabIndex = 16;
            this.btnUpdatePatient.Text = "Update";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            //
            // btnAddPatient
            //
            this.btnAddPatient.Location = new System.Drawing.Point(24, 432);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(128, 28);
            this.btnAddPatient.TabIndex = 15;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            //
            // chkPatientAdmitted
            //
            this.chkPatientAdmitted.AutoSize = true;
            this.chkPatientAdmitted.Location = new System.Drawing.Point(24, 348);
            this.chkPatientAdmitted.Name = "chkPatientAdmitted";
            this.chkPatientAdmitted.Size = new System.Drawing.Size(117, 17);
            this.chkPatientAdmitted.TabIndex = 14;
            this.chkPatientAdmitted.Text = "Currently Admitted";
            this.chkPatientAdmitted.UseVisualStyleBackColor = true;
            //
            // cmbPatientDepartment
            //
            this.cmbPatientDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientDepartment.FormattingEnabled = true;
            this.cmbPatientDepartment.Items.AddRange(new object[] {
            "Emergency",
            "General Medicine",
            "ICU",
            "Pediatrics",
            "Surgery",
            "Radiology"});
            this.cmbPatientDepartment.Location = new System.Drawing.Point(24, 312);
            this.cmbPatientDepartment.Name = "cmbPatientDepartment";
            this.cmbPatientDepartment.Size = new System.Drawing.Size(272, 21);
            this.cmbPatientDepartment.TabIndex = 13;
            //
            // lblPatientDepartment
            //
            this.lblPatientDepartment.AutoSize = true;
            this.lblPatientDepartment.Location = new System.Drawing.Point(24, 296);
            this.lblPatientDepartment.Name = "lblPatientDepartment";
            this.lblPatientDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblPatientDepartment.TabIndex = 12;
            this.lblPatientDepartment.Text = "Department";
            //
            // txtPatientNotes
            //
            this.txtPatientNotes.Location = new System.Drawing.Point(24, 384);
            this.txtPatientNotes.Multiline = true;
            this.txtPatientNotes.Name = "txtPatientNotes";
            this.txtPatientNotes.Size = new System.Drawing.Size(272, 32);
            this.txtPatientNotes.TabIndex = 11;
            //
            // lblPatientNotes
            //
            this.lblPatientNotes.AutoSize = true;
            this.lblPatientNotes.Location = new System.Drawing.Point(24, 368);
            this.lblPatientNotes.Name = "lblPatientNotes";
            this.lblPatientNotes.Size = new System.Drawing.Size(95, 13);
            this.lblPatientNotes.TabIndex = 10;
            this.lblPatientNotes.Text = "Medical Notes";
            //
            // txtPatientPhone
            //
            this.txtPatientPhone.Location = new System.Drawing.Point(24, 264);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(272, 20);
            this.txtPatientPhone.TabIndex = 9;
            //
            // lblPatientPhone
            //
            this.lblPatientPhone.AutoSize = true;
            this.lblPatientPhone.Location = new System.Drawing.Point(24, 248);
            this.lblPatientPhone.Name = "lblPatientPhone";
            this.lblPatientPhone.Size = new System.Drawing.Size(84, 13);
            this.lblPatientPhone.TabIndex = 8;
            this.lblPatientPhone.Text = "Phone Number";
            //
            // dtpPatientDob
            //
            this.dtpPatientDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientDob.Location = new System.Drawing.Point(24, 216);
            this.dtpPatientDob.Name = "dtpPatientDob";
            this.dtpPatientDob.Size = new System.Drawing.Size(272, 20);
            this.dtpPatientDob.TabIndex = 7;
            //
            // lblPatientDob
            //
            this.lblPatientDob.AutoSize = true;
            this.lblPatientDob.Location = new System.Drawing.Point(24, 200);
            this.lblPatientDob.Name = "lblPatientDob";
            this.lblPatientDob.Size = new System.Drawing.Size(66, 13);
            this.lblPatientDob.TabIndex = 6;
            this.lblPatientDob.Text = "Date of Birth";
            //
            // cmbPatientGender
            //
            this.cmbPatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other",
            "Prefer not to say"});
            this.cmbPatientGender.Location = new System.Drawing.Point(24, 168);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(272, 21);
            this.cmbPatientGender.TabIndex = 5;
            //
            // lblPatientGender
            //
            this.lblPatientGender.AutoSize = true;
            this.lblPatientGender.Location = new System.Drawing.Point(24, 152);
            this.lblPatientGender.Name = "lblPatientGender";
            this.lblPatientGender.Size = new System.Drawing.Size(42, 13);
            this.lblPatientGender.TabIndex = 4;
            this.lblPatientGender.Text = "Gender";
            //
            // txtPatientName
            //
            this.txtPatientName.Location = new System.Drawing.Point(24, 120);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(272, 20);
            this.txtPatientName.TabIndex = 3;
            //
            // lblPatientName
            //
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(24, 104);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name";
            //
            // txtPatientId
            //
            this.txtPatientId.Location = new System.Drawing.Point(24, 72);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(272, 20);
            this.txtPatientId.TabIndex = 1;
            //
            // lblPatientId
            //
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(24, 56);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(54, 13);
            this.lblPatientId.TabIndex = 0;
            this.lblPatientId.Text = "Patient ID";
            //
            // patientGrid
            //
            this.patientGrid.AllowUserToAddRows = false;
            this.patientGrid.AllowUserToDeleteRows = false;
            this.patientGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdColumn,
            this.patientNameColumn,
            this.patientDepartmentColumn,
            this.patientStatusColumn,
            this.patientDoctorColumn});
            this.patientGrid.Location = new System.Drawing.Point(24, 96);
            this.patientGrid.Name = "patientGrid";
            this.patientGrid.ReadOnly = true;
            this.patientGrid.Size = new System.Drawing.Size(784, 520);
            this.patientGrid.TabIndex = 1;
            //
            // patientIdColumn
            //
            this.patientIdColumn.HeaderText = "Patient ID";
            this.patientIdColumn.Name = "patientIdColumn";
            this.patientIdColumn.ReadOnly = true;
            //
            // patientNameColumn
            //
            this.patientNameColumn.HeaderText = "Name";
            this.patientNameColumn.Name = "patientNameColumn";
            this.patientNameColumn.ReadOnly = true;
            this.patientNameColumn.Width = 180;
            //
            // patientDepartmentColumn
            //
            this.patientDepartmentColumn.HeaderText = "Department";
            this.patientDepartmentColumn.Name = "patientDepartmentColumn";
            this.patientDepartmentColumn.ReadOnly = true;
            this.patientDepartmentColumn.Width = 150;
            //
            // patientStatusColumn
            //
            this.patientStatusColumn.HeaderText = "Status";
            this.patientStatusColumn.Name = "patientStatusColumn";
            this.patientStatusColumn.ReadOnly = true;
            this.patientStatusColumn.Width = 120;
            //
            // patientDoctorColumn
            //
            this.patientDoctorColumn.HeaderText = "Assigned Doctor";
            this.patientDoctorColumn.Name = "patientDoctorColumn";
            this.patientDoctorColumn.ReadOnly = true;
            this.patientDoctorColumn.Width = 170;
            //
            // grpPatientSearch
            //
            this.grpPatientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientSearch.Controls.Add(this.btnPatientRefresh);
            this.grpPatientSearch.Controls.Add(this.btnPatientSearch);
            this.grpPatientSearch.Controls.Add(this.cmbPatientFilter);
            this.grpPatientSearch.Controls.Add(this.lblPatientFilter);
            this.grpPatientSearch.Controls.Add(this.txtPatientSearch);
            this.grpPatientSearch.Controls.Add(this.lblPatientSearch);
            this.grpPatientSearch.Location = new System.Drawing.Point(24, 20);
            this.grpPatientSearch.Name = "grpPatientSearch";
            this.grpPatientSearch.Size = new System.Drawing.Size(1128, 60);
            this.grpPatientSearch.TabIndex = 0;
            this.grpPatientSearch.TabStop = false;
            this.grpPatientSearch.Text = "Patient Search";
            //
            // btnPatientRefresh
            //
            this.btnPatientRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientRefresh.Location = new System.Drawing.Point(1016, 20);
            this.btnPatientRefresh.Name = "btnPatientRefresh";
            this.btnPatientRefresh.Size = new System.Drawing.Size(88, 24);
            this.btnPatientRefresh.TabIndex = 5;
            this.btnPatientRefresh.Text = "Refresh";
            this.btnPatientRefresh.UseVisualStyleBackColor = true;
            //
            // btnPatientSearch
            //
            this.btnPatientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientSearch.Location = new System.Drawing.Point(920, 20);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(88, 24);
            this.btnPatientSearch.TabIndex = 4;
            this.btnPatientSearch.Text = "Search";
            this.btnPatientSearch.UseVisualStyleBackColor = true;
            //
            // cmbPatientFilter
            //
            this.cmbPatientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientFilter.FormattingEnabled = true;
            this.cmbPatientFilter.Items.AddRange(new object[] {
            "All Patients",
            "Admitted",
            "Outpatient",
            "Critical Care",
            "Discharged"});
            this.cmbPatientFilter.Location = new System.Drawing.Point(488, 22);
            this.cmbPatientFilter.Name = "cmbPatientFilter";
            this.cmbPatientFilter.Size = new System.Drawing.Size(184, 21);
            this.cmbPatientFilter.TabIndex = 3;
            //
            // lblPatientFilter
            //
            this.lblPatientFilter.AutoSize = true;
            this.lblPatientFilter.Location = new System.Drawing.Point(432, 26);
            this.lblPatientFilter.Name = "lblPatientFilter";
            this.lblPatientFilter.Size = new System.Drawing.Size(29, 13);
            this.lblPatientFilter.TabIndex = 2;
            this.lblPatientFilter.Text = "Filter";
            //
            // txtPatientSearch
            //
            this.txtPatientSearch.Location = new System.Drawing.Point(104, 22);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(280, 20);
            this.txtPatientSearch.TabIndex = 1;
            //
            // lblPatientSearch
            //
            this.lblPatientSearch.AutoSize = true;
            this.lblPatientSearch.Location = new System.Drawing.Point(16, 26);
            this.lblPatientSearch.Name = "lblPatientSearch";
            this.lblPatientSearch.Size = new System.Drawing.Size(71, 13);
            this.lblPatientSearch.TabIndex = 0;
            this.lblPatientSearch.Text = "Name or ID";
            //
            // appointmentsTab
            //
            this.appointmentsTab.Controls.Add(this.appointmentGrid);
            this.appointmentsTab.Controls.Add(this.grpAppointmentDetails);
            this.appointmentsTab.Location = new System.Drawing.Point(4, 22);
            this.appointmentsTab.Name = "appointmentsTab";
            this.appointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentsTab.Size = new System.Drawing.Size(1176, 641);
            this.appointmentsTab.TabIndex = 2;
            this.appointmentsTab.Text = "Appointments";
            this.appointmentsTab.UseVisualStyleBackColor = true;
            //
            // appointmentGrid
            //
            this.appointmentGrid.AllowUserToAddRows = false;
            this.appointmentGrid.AllowUserToDeleteRows = false;
            this.appointmentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentTimeColumn,
            this.appointmentPatientColumn,
            this.appointmentDoctorColumn,
            this.appointmentReasonColumn,
            this.appointmentStatusColumn});
            this.appointmentGrid.Location = new System.Drawing.Point(376, 24);
            this.appointmentGrid.Name = "appointmentGrid";
            this.appointmentGrid.ReadOnly = true;
            this.appointmentGrid.Size = new System.Drawing.Size(776, 592);
            this.appointmentGrid.TabIndex = 1;
            //
            // appointmentTimeColumn
            //
            this.appointmentTimeColumn.HeaderText = "Date and Time";
            this.appointmentTimeColumn.Name = "appointmentTimeColumn";
            this.appointmentTimeColumn.ReadOnly = true;
            this.appointmentTimeColumn.Width = 150;
            //
            // appointmentPatientColumn
            //
            this.appointmentPatientColumn.HeaderText = "Patient";
            this.appointmentPatientColumn.Name = "appointmentPatientColumn";
            this.appointmentPatientColumn.ReadOnly = true;
            this.appointmentPatientColumn.Width = 160;
            //
            // appointmentDoctorColumn
            //
            this.appointmentDoctorColumn.HeaderText = "Doctor";
            this.appointmentDoctorColumn.Name = "appointmentDoctorColumn";
            this.appointmentDoctorColumn.ReadOnly = true;
            this.appointmentDoctorColumn.Width = 160;
            //
            // appointmentReasonColumn
            //
            this.appointmentReasonColumn.HeaderText = "Reason";
            this.appointmentReasonColumn.Name = "appointmentReasonColumn";
            this.appointmentReasonColumn.ReadOnly = true;
            this.appointmentReasonColumn.Width = 170;
            //
            // appointmentStatusColumn
            //
            this.appointmentStatusColumn.HeaderText = "Status";
            this.appointmentStatusColumn.Name = "appointmentStatusColumn";
            this.appointmentStatusColumn.ReadOnly = true;
            this.appointmentStatusColumn.Width = 120;
            //
            // grpAppointmentDetails
            //
            this.grpAppointmentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAppointmentDetails.Controls.Add(this.btnAppointmentRefresh);
            this.grpAppointmentDetails.Controls.Add(this.btnCancelAppointment);
            this.grpAppointmentDetails.Controls.Add(this.btnUpdateAppointment);
            this.grpAppointmentDetails.Controls.Add(this.btnAddAppointment);
            this.grpAppointmentDetails.Controls.Add(this.txtAppointmentNotes);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentNotes);
            this.grpAppointmentDetails.Controls.Add(this.cmbAppointmentStatus);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentStatus);
            this.grpAppointmentDetails.Controls.Add(this.dtpAppointmentTime);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentTime);
            this.grpAppointmentDetails.Controls.Add(this.dtpAppointmentDate);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentDate);
            this.grpAppointmentDetails.Controls.Add(this.txtAppointmentReason);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentReason);
            this.grpAppointmentDetails.Controls.Add(this.cmbAppointmentDoctor);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentDoctor);
            this.grpAppointmentDetails.Controls.Add(this.txtAppointmentPatient);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentPatient);
            this.grpAppointmentDetails.Location = new System.Drawing.Point(24, 24);
            this.grpAppointmentDetails.Name = "grpAppointmentDetails";
            this.grpAppointmentDetails.Size = new System.Drawing.Size(328, 592);
            this.grpAppointmentDetails.TabIndex = 0;
            this.grpAppointmentDetails.TabStop = false;
            this.grpAppointmentDetails.Text = "Schedule Appointment";
            //
            // btnAppointmentRefresh
            //
            this.btnAppointmentRefresh.Location = new System.Drawing.Point(176, 524);
            this.btnAppointmentRefresh.Name = "btnAppointmentRefresh";
            this.btnAppointmentRefresh.Size = new System.Drawing.Size(128, 28);
            this.btnAppointmentRefresh.TabIndex = 17;
            this.btnAppointmentRefresh.Text = "Refresh";
            this.btnAppointmentRefresh.UseVisualStyleBackColor = true;
            //
            // btnCancelAppointment
            //
            this.btnCancelAppointment.Location = new System.Drawing.Point(32, 524);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(128, 28);
            this.btnCancelAppointment.TabIndex = 16;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            //
            // btnUpdateAppointment
            //
            this.btnUpdateAppointment.Location = new System.Drawing.Point(176, 488);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(128, 28);
            this.btnUpdateAppointment.TabIndex = 15;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            //
            // btnAddAppointment
            //
            this.btnAddAppointment.Location = new System.Drawing.Point(32, 488);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(128, 28);
            this.btnAddAppointment.TabIndex = 14;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            //
            // txtAppointmentNotes
            //
            this.txtAppointmentNotes.Location = new System.Drawing.Point(32, 376);
            this.txtAppointmentNotes.Multiline = true;
            this.txtAppointmentNotes.Name = "txtAppointmentNotes";
            this.txtAppointmentNotes.Size = new System.Drawing.Size(272, 88);
            this.txtAppointmentNotes.TabIndex = 13;
            //
            // lblAppointmentNotes
            //
            this.lblAppointmentNotes.AutoSize = true;
            this.lblAppointmentNotes.Location = new System.Drawing.Point(32, 360);
            this.lblAppointmentNotes.Name = "lblAppointmentNotes";
            this.lblAppointmentNotes.Size = new System.Drawing.Size(35, 13);
            this.lblAppointmentNotes.TabIndex = 12;
            this.lblAppointmentNotes.Text = "Notes";
            //
            // cmbAppointmentStatus
            //
            this.cmbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentStatus.FormattingEnabled = true;
            this.cmbAppointmentStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Checked In",
            "Completed",
            "Cancelled",
            "Rescheduled"});
            this.cmbAppointmentStatus.Location = new System.Drawing.Point(32, 320);
            this.cmbAppointmentStatus.Name = "cmbAppointmentStatus";
            this.cmbAppointmentStatus.Size = new System.Drawing.Size(272, 21);
            this.cmbAppointmentStatus.TabIndex = 11;
            //
            // lblAppointmentStatus
            //
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Location = new System.Drawing.Point(32, 304);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(37, 13);
            this.lblAppointmentStatus.TabIndex = 10;
            this.lblAppointmentStatus.Text = "Status";
            //
            // dtpAppointmentTime
            //
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(32, 264);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(272, 20);
            this.dtpAppointmentTime.TabIndex = 9;
            //
            // lblAppointmentTime
            //
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(32, 248);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(30, 13);
            this.lblAppointmentTime.TabIndex = 8;
            this.lblAppointmentTime.Text = "Time";
            //
            // dtpAppointmentDate
            //
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(32, 208);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(272, 20);
            this.dtpAppointmentDate.TabIndex = 7;
            //
            // lblAppointmentDate
            //
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(32, 192);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(30, 13);
            this.lblAppointmentDate.TabIndex = 6;
            this.lblAppointmentDate.Text = "Date";
            //
            // txtAppointmentReason
            //
            this.txtAppointmentReason.Location = new System.Drawing.Point(32, 152);
            this.txtAppointmentReason.Name = "txtAppointmentReason";
            this.txtAppointmentReason.Size = new System.Drawing.Size(272, 20);
            this.txtAppointmentReason.TabIndex = 5;
            //
            // lblAppointmentReason
            //
            this.lblAppointmentReason.AutoSize = true;
            this.lblAppointmentReason.Location = new System.Drawing.Point(32, 136);
            this.lblAppointmentReason.Name = "lblAppointmentReason";
            this.lblAppointmentReason.Size = new System.Drawing.Size(86, 13);
            this.lblAppointmentReason.TabIndex = 4;
            this.lblAppointmentReason.Text = "Visit Reason";
            //
            // cmbAppointmentDoctor
            //
            this.cmbAppointmentDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentDoctor.FormattingEnabled = true;
            this.cmbAppointmentDoctor.Items.AddRange(new object[] {
            "Dr. Adams",
            "Dr. Chen",
            "Dr. Patel",
            "Dr. Rivera",
            "Nurse Station"});
            this.cmbAppointmentDoctor.Location = new System.Drawing.Point(32, 96);
            this.cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            this.cmbAppointmentDoctor.Size = new System.Drawing.Size(272, 21);
            this.cmbAppointmentDoctor.TabIndex = 3;
            //
            // lblAppointmentDoctor
            //
            this.lblAppointmentDoctor.AutoSize = true;
            this.lblAppointmentDoctor.Location = new System.Drawing.Point(32, 80);
            this.lblAppointmentDoctor.Name = "lblAppointmentDoctor";
            this.lblAppointmentDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblAppointmentDoctor.TabIndex = 2;
            this.lblAppointmentDoctor.Text = "Doctor";
            //
            // txtAppointmentPatient
            //
            this.txtAppointmentPatient.Location = new System.Drawing.Point(32, 40);
            this.txtAppointmentPatient.Name = "txtAppointmentPatient";
            this.txtAppointmentPatient.Size = new System.Drawing.Size(272, 20);
            this.txtAppointmentPatient.TabIndex = 1;
            //
            // lblAppointmentPatient
            //
            this.lblAppointmentPatient.AutoSize = true;
            this.lblAppointmentPatient.Location = new System.Drawing.Point(32, 24);
            this.lblAppointmentPatient.Name = "lblAppointmentPatient";
            this.lblAppointmentPatient.Size = new System.Drawing.Size(43, 13);
            this.lblAppointmentPatient.TabIndex = 0;
            this.lblAppointmentPatient.Text = "Patient";
            //
            // inventoryTab
            //
            this.inventoryTab.Controls.Add(this.grpLowStock);
            this.inventoryTab.Controls.Add(this.inventoryGrid);
            this.inventoryTab.Controls.Add(this.grpInventoryDetails);
            this.inventoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(1176, 641);
            this.inventoryTab.TabIndex = 3;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            //
            // grpLowStock
            //
            this.grpLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLowStock.Controls.Add(this.lstLowStock);
            this.grpLowStock.Location = new System.Drawing.Point(376, 456);
            this.grpLowStock.Name = "grpLowStock";
            this.grpLowStock.Size = new System.Drawing.Size(776, 160);
            this.grpLowStock.TabIndex = 2;
            this.grpLowStock.TabStop = false;
            this.grpLowStock.Text = "Low Stock Alerts";
            //
            // lstLowStock
            //
            this.lstLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLowStock.FormattingEnabled = true;
            this.lstLowStock.Items.AddRange(new object[] {
            "Insulin pens below reorder level",
            "IV saline bags below reorder level",
            "Sterile gloves below reorder level"});
            this.lstLowStock.Location = new System.Drawing.Point(16, 24);
            this.lstLowStock.Name = "lstLowStock";
            this.lstLowStock.Size = new System.Drawing.Size(744, 121);
            this.lstLowStock.TabIndex = 0;
            //
            // inventoryGrid
            //
            this.inventoryGrid.AllowUserToAddRows = false;
            this.inventoryGrid.AllowUserToDeleteRows = false;
            this.inventoryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryItemColumn,
            this.inventoryCategoryColumn,
            this.inventoryQuantityColumn,
            this.inventoryReorderColumn,
            this.inventoryLocationColumn});
            this.inventoryGrid.Location = new System.Drawing.Point(376, 24);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.Size = new System.Drawing.Size(776, 416);
            this.inventoryGrid.TabIndex = 1;
            //
            // inventoryItemColumn
            //
            this.inventoryItemColumn.HeaderText = "Item";
            this.inventoryItemColumn.Name = "inventoryItemColumn";
            this.inventoryItemColumn.ReadOnly = true;
            this.inventoryItemColumn.Width = 200;
            //
            // inventoryCategoryColumn
            //
            this.inventoryCategoryColumn.HeaderText = "Category";
            this.inventoryCategoryColumn.Name = "inventoryCategoryColumn";
            this.inventoryCategoryColumn.ReadOnly = true;
            this.inventoryCategoryColumn.Width = 140;
            //
            // inventoryQuantityColumn
            //
            this.inventoryQuantityColumn.HeaderText = "Quantity";
            this.inventoryQuantityColumn.Name = "inventoryQuantityColumn";
            this.inventoryQuantityColumn.ReadOnly = true;
            //
            // inventoryReorderColumn
            //
            this.inventoryReorderColumn.HeaderText = "Reorder Level";
            this.inventoryReorderColumn.Name = "inventoryReorderColumn";
            this.inventoryReorderColumn.ReadOnly = true;
            this.inventoryReorderColumn.Width = 120;
            //
            // inventoryLocationColumn
            //
            this.inventoryLocationColumn.HeaderText = "Storage Location";
            this.inventoryLocationColumn.Name = "inventoryLocationColumn";
            this.inventoryLocationColumn.ReadOnly = true;
            this.inventoryLocationColumn.Width = 150;
            //
            // grpInventoryDetails
            //
            this.grpInventoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpInventoryDetails.Controls.Add(this.btnInventoryRefresh);
            this.grpInventoryDetails.Controls.Add(this.btnInventoryRemove);
            this.grpInventoryDetails.Controls.Add(this.btnInventoryUpdate);
            this.grpInventoryDetails.Controls.Add(this.btnInventoryAdd);
            this.grpInventoryDetails.Controls.Add(this.numInventoryReorder);
            this.grpInventoryDetails.Controls.Add(this.lblInventoryReorder);
            this.grpInventoryDetails.Controls.Add(this.numInventoryQuantity);
            this.grpInventoryDetails.Controls.Add(this.lblInventoryQuantity);
            this.grpInventoryDetails.Controls.Add(this.txtInventoryLocation);
            this.grpInventoryDetails.Controls.Add(this.lblInventoryLocation);
            this.grpInventoryDetails.Controls.Add(this.cmbInventoryCategory);
            this.grpInventoryDetails.Controls.Add(this.lblInventoryCategory);
            this.grpInventoryDetails.Controls.Add(this.txtInventoryItem);
            this.grpInventoryDetails.Controls.Add(this.lblInventoryItem);
            this.grpInventoryDetails.Location = new System.Drawing.Point(24, 24);
            this.grpInventoryDetails.Name = "grpInventoryDetails";
            this.grpInventoryDetails.Size = new System.Drawing.Size(328, 592);
            this.grpInventoryDetails.TabIndex = 0;
            this.grpInventoryDetails.TabStop = false;
            this.grpInventoryDetails.Text = "Medication and Supply Details";
            //
            // btnInventoryRefresh
            //
            this.btnInventoryRefresh.Location = new System.Drawing.Point(176, 408);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(128, 28);
            this.btnInventoryRefresh.TabIndex = 13;
            this.btnInventoryRefresh.Text = "Refresh";
            this.btnInventoryRefresh.UseVisualStyleBackColor = true;
            //
            // btnInventoryRemove
            //
            this.btnInventoryRemove.Location = new System.Drawing.Point(32, 408);
            this.btnInventoryRemove.Name = "btnInventoryRemove";
            this.btnInventoryRemove.Size = new System.Drawing.Size(128, 28);
            this.btnInventoryRemove.TabIndex = 12;
            this.btnInventoryRemove.Text = "Remove Item";
            this.btnInventoryRemove.UseVisualStyleBackColor = true;
            //
            // btnInventoryUpdate
            //
            this.btnInventoryUpdate.Location = new System.Drawing.Point(176, 372);
            this.btnInventoryUpdate.Name = "btnInventoryUpdate";
            this.btnInventoryUpdate.Size = new System.Drawing.Size(128, 28);
            this.btnInventoryUpdate.TabIndex = 11;
            this.btnInventoryUpdate.Text = "Update Stock";
            this.btnInventoryUpdate.UseVisualStyleBackColor = true;
            //
            // btnInventoryAdd
            //
            this.btnInventoryAdd.Location = new System.Drawing.Point(32, 372);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(128, 28);
            this.btnInventoryAdd.TabIndex = 10;
            this.btnInventoryAdd.Text = "Add Item";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            //
            // numInventoryReorder
            //
            this.numInventoryReorder.Location = new System.Drawing.Point(32, 304);
            this.numInventoryReorder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInventoryReorder.Name = "numInventoryReorder";
            this.numInventoryReorder.Size = new System.Drawing.Size(272, 20);
            this.numInventoryReorder.TabIndex = 9;
            //
            // lblInventoryReorder
            //
            this.lblInventoryReorder.AutoSize = true;
            this.lblInventoryReorder.Location = new System.Drawing.Point(32, 288);
            this.lblInventoryReorder.Name = "lblInventoryReorder";
            this.lblInventoryReorder.Size = new System.Drawing.Size(75, 13);
            this.lblInventoryReorder.TabIndex = 8;
            this.lblInventoryReorder.Text = "Reorder Level";
            //
            // numInventoryQuantity
            //
            this.numInventoryQuantity.Location = new System.Drawing.Point(32, 248);
            this.numInventoryQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInventoryQuantity.Name = "numInventoryQuantity";
            this.numInventoryQuantity.Size = new System.Drawing.Size(272, 20);
            this.numInventoryQuantity.TabIndex = 7;
            //
            // lblInventoryQuantity
            //
            this.lblInventoryQuantity.AutoSize = true;
            this.lblInventoryQuantity.Location = new System.Drawing.Point(32, 232);
            this.lblInventoryQuantity.Name = "lblInventoryQuantity";
            this.lblInventoryQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblInventoryQuantity.TabIndex = 6;
            this.lblInventoryQuantity.Text = "Quantity";
            //
            // txtInventoryLocation
            //
            this.txtInventoryLocation.Location = new System.Drawing.Point(32, 192);
            this.txtInventoryLocation.Name = "txtInventoryLocation";
            this.txtInventoryLocation.Size = new System.Drawing.Size(272, 20);
            this.txtInventoryLocation.TabIndex = 5;
            //
            // lblInventoryLocation
            //
            this.lblInventoryLocation.AutoSize = true;
            this.lblInventoryLocation.Location = new System.Drawing.Point(32, 176);
            this.lblInventoryLocation.Name = "lblInventoryLocation";
            this.lblInventoryLocation.Size = new System.Drawing.Size(89, 13);
            this.lblInventoryLocation.TabIndex = 4;
            this.lblInventoryLocation.Text = "Storage Location";
            //
            // cmbInventoryCategory
            //
            this.cmbInventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventoryCategory.FormattingEnabled = true;
            this.cmbInventoryCategory.Items.AddRange(new object[] {
            "Medication",
            "Surgical Supply",
            "Lab Supply",
            "General Supply",
            "Equipment"});
            this.cmbInventoryCategory.Location = new System.Drawing.Point(32, 136);
            this.cmbInventoryCategory.Name = "cmbInventoryCategory";
            this.cmbInventoryCategory.Size = new System.Drawing.Size(272, 21);
            this.cmbInventoryCategory.TabIndex = 3;
            //
            // lblInventoryCategory
            //
            this.lblInventoryCategory.AutoSize = true;
            this.lblInventoryCategory.Location = new System.Drawing.Point(32, 120);
            this.lblInventoryCategory.Name = "lblInventoryCategory";
            this.lblInventoryCategory.Size = new System.Drawing.Size(49, 13);
            this.lblInventoryCategory.TabIndex = 2;
            this.lblInventoryCategory.Text = "Category";
            //
            // txtInventoryItem
            //
            this.txtInventoryItem.Location = new System.Drawing.Point(32, 80);
            this.txtInventoryItem.Name = "txtInventoryItem";
            this.txtInventoryItem.Size = new System.Drawing.Size(272, 20);
            this.txtInventoryItem.TabIndex = 1;
            //
            // lblInventoryItem
            //
            this.lblInventoryItem.AutoSize = true;
            this.lblInventoryItem.Location = new System.Drawing.Point(32, 64);
            this.lblInventoryItem.Name = "lblInventoryItem";
            this.lblInventoryItem.Size = new System.Drawing.Size(58, 13);
            this.lblInventoryItem.TabIndex = 0;
            this.lblInventoryItem.Text = "Item Name";
            //
            // analyticsTab
            //
            this.analyticsTab.Controls.Add(this.reportGrid);
            this.analyticsTab.Controls.Add(this.grpReportOutput);
            this.analyticsTab.Controls.Add(this.grpAnalyticsSummary);
            this.analyticsTab.Controls.Add(this.grpAnalyticsFilters);
            this.analyticsTab.Location = new System.Drawing.Point(4, 22);
            this.analyticsTab.Name = "analyticsTab";
            this.analyticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.analyticsTab.Size = new System.Drawing.Size(1176, 641);
            this.analyticsTab.TabIndex = 4;
            this.analyticsTab.Text = "Analytics";
            this.analyticsTab.UseVisualStyleBackColor = true;
            //
            // reportGrid
            //
            this.reportGrid.AllowUserToAddRows = false;
            this.reportGrid.AllowUserToDeleteRows = false;
            this.reportGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportMetricColumn,
            this.reportCurrentColumn,
            this.reportPreviousColumn,
            this.reportChangeColumn});
            this.reportGrid.Location = new System.Drawing.Point(384, 112);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.Size = new System.Drawing.Size(768, 336);
            this.reportGrid.TabIndex = 2;
            //
            // reportMetricColumn
            //
            this.reportMetricColumn.HeaderText = "Metric";
            this.reportMetricColumn.Name = "reportMetricColumn";
            this.reportMetricColumn.ReadOnly = true;
            this.reportMetricColumn.Width = 220;
            //
            // reportCurrentColumn
            //
            this.reportCurrentColumn.HeaderText = "Current Period";
            this.reportCurrentColumn.Name = "reportCurrentColumn";
            this.reportCurrentColumn.ReadOnly = true;
            this.reportCurrentColumn.Width = 150;
            //
            // reportPreviousColumn
            //
            this.reportPreviousColumn.HeaderText = "Previous Period";
            this.reportPreviousColumn.Name = "reportPreviousColumn";
            this.reportPreviousColumn.ReadOnly = true;
            this.reportPreviousColumn.Width = 150;
            //
            // reportChangeColumn
            //
            this.reportChangeColumn.HeaderText = "Change";
            this.reportChangeColumn.Name = "reportChangeColumn";
            this.reportChangeColumn.ReadOnly = true;
            this.reportChangeColumn.Width = 120;
            //
            // grpReportOutput
            //
            this.grpReportOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReportOutput.Controls.Add(this.lstReportOutput);
            this.grpReportOutput.Location = new System.Drawing.Point(24, 464);
            this.grpReportOutput.Name = "grpReportOutput";
            this.grpReportOutput.Size = new System.Drawing.Size(1128, 152);
            this.grpReportOutput.TabIndex = 3;
            this.grpReportOutput.TabStop = false;
            this.grpReportOutput.Text = "Report Notes";
            //
            // lstReportOutput
            //
            this.lstReportOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReportOutput.FormattingEnabled = true;
            this.lstReportOutput.Items.AddRange(new object[] {
            "Generated report highlights will appear here.",
            "Trends for patient visits, common ailments, and medication usage will appear here."});
            this.lstReportOutput.Location = new System.Drawing.Point(16, 24);
            this.lstReportOutput.Name = "lstReportOutput";
            this.lstReportOutput.Size = new System.Drawing.Size(1096, 108);
            this.lstReportOutput.TabIndex = 0;
            //
            // grpAnalyticsSummary
            //
            this.grpAnalyticsSummary.Controls.Add(this.txtAnalyticsMedicationUsage);
            this.grpAnalyticsSummary.Controls.Add(this.lblAnalyticsMedicationUsage);
            this.grpAnalyticsSummary.Controls.Add(this.txtAnalyticsCommonAilment);
            this.grpAnalyticsSummary.Controls.Add(this.lblAnalyticsCommonAilment);
            this.grpAnalyticsSummary.Controls.Add(this.txtAnalyticsVisits);
            this.grpAnalyticsSummary.Controls.Add(this.lblAnalyticsVisits);
            this.grpAnalyticsSummary.Location = new System.Drawing.Point(24, 112);
            this.grpAnalyticsSummary.Name = "grpAnalyticsSummary";
            this.grpAnalyticsSummary.Size = new System.Drawing.Size(336, 336);
            this.grpAnalyticsSummary.TabIndex = 1;
            this.grpAnalyticsSummary.TabStop = false;
            this.grpAnalyticsSummary.Text = "Summary";
            //
            // txtAnalyticsMedicationUsage
            //
            this.txtAnalyticsMedicationUsage.Location = new System.Drawing.Point(32, 232);
            this.txtAnalyticsMedicationUsage.Name = "txtAnalyticsMedicationUsage";
            this.txtAnalyticsMedicationUsage.ReadOnly = true;
            this.txtAnalyticsMedicationUsage.Size = new System.Drawing.Size(272, 20);
            this.txtAnalyticsMedicationUsage.TabIndex = 5;
            this.txtAnalyticsMedicationUsage.Text = "Antibiotics";
            //
            // lblAnalyticsMedicationUsage
            //
            this.lblAnalyticsMedicationUsage.AutoSize = true;
            this.lblAnalyticsMedicationUsage.Location = new System.Drawing.Point(32, 216);
            this.lblAnalyticsMedicationUsage.Name = "lblAnalyticsMedicationUsage";
            this.lblAnalyticsMedicationUsage.Size = new System.Drawing.Size(122, 13);
            this.lblAnalyticsMedicationUsage.TabIndex = 4;
            this.lblAnalyticsMedicationUsage.Text = "Top Medication Usage";
            //
            // txtAnalyticsCommonAilment
            //
            this.txtAnalyticsCommonAilment.Location = new System.Drawing.Point(32, 152);
            this.txtAnalyticsCommonAilment.Name = "txtAnalyticsCommonAilment";
            this.txtAnalyticsCommonAilment.ReadOnly = true;
            this.txtAnalyticsCommonAilment.Size = new System.Drawing.Size(272, 20);
            this.txtAnalyticsCommonAilment.TabIndex = 3;
            this.txtAnalyticsCommonAilment.Text = "Respiratory Infection";
            //
            // lblAnalyticsCommonAilment
            //
            this.lblAnalyticsCommonAilment.AutoSize = true;
            this.lblAnalyticsCommonAilment.Location = new System.Drawing.Point(32, 136);
            this.lblAnalyticsCommonAilment.Name = "lblAnalyticsCommonAilment";
            this.lblAnalyticsCommonAilment.Size = new System.Drawing.Size(92, 13);
            this.lblAnalyticsCommonAilment.TabIndex = 2;
            this.lblAnalyticsCommonAilment.Text = "Common Ailment";
            //
            // txtAnalyticsVisits
            //
            this.txtAnalyticsVisits.Location = new System.Drawing.Point(32, 72);
            this.txtAnalyticsVisits.Name = "txtAnalyticsVisits";
            this.txtAnalyticsVisits.ReadOnly = true;
            this.txtAnalyticsVisits.Size = new System.Drawing.Size(272, 20);
            this.txtAnalyticsVisits.TabIndex = 1;
            this.txtAnalyticsVisits.Text = "284 visits";
            //
            // lblAnalyticsVisits
            //
            this.lblAnalyticsVisits.AutoSize = true;
            this.lblAnalyticsVisits.Location = new System.Drawing.Point(32, 56);
            this.lblAnalyticsVisits.Name = "lblAnalyticsVisits";
            this.lblAnalyticsVisits.Size = new System.Drawing.Size(68, 13);
            this.lblAnalyticsVisits.TabIndex = 0;
            this.lblAnalyticsVisits.Text = "Patient Visits";
            //
            // grpAnalyticsFilters
            //
            this.grpAnalyticsFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAnalyticsFilters.Controls.Add(this.btnGenerateReport);
            this.grpAnalyticsFilters.Controls.Add(this.cmbReportType);
            this.grpAnalyticsFilters.Controls.Add(this.lblReportType);
            this.grpAnalyticsFilters.Controls.Add(this.dtpReportEnd);
            this.grpAnalyticsFilters.Controls.Add(this.lblReportEnd);
            this.grpAnalyticsFilters.Controls.Add(this.dtpReportStart);
            this.grpAnalyticsFilters.Controls.Add(this.lblReportStart);
            this.grpAnalyticsFilters.Location = new System.Drawing.Point(24, 24);
            this.grpAnalyticsFilters.Name = "grpAnalyticsFilters";
            this.grpAnalyticsFilters.Size = new System.Drawing.Size(1128, 72);
            this.grpAnalyticsFilters.TabIndex = 0;
            this.grpAnalyticsFilters.TabStop = false;
            this.grpAnalyticsFilters.Text = "Report Filters";
            //
            // btnGenerateReport
            //
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Location = new System.Drawing.Point(976, 28);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(128, 28);
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            //
            // cmbReportType
            //
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Patient Visits",
            "Common Ailments",
            "Medication Usage",
            "Department Load"});
            this.cmbReportType.Location = new System.Drawing.Point(656, 32);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 21);
            this.cmbReportType.TabIndex = 5;
            //
            // lblReportType
            //
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(584, 36);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(66, 13);
            this.lblReportType.TabIndex = 4;
            this.lblReportType.Text = "Report Type";
            //
            // dtpReportEnd
            //
            this.dtpReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportEnd.Location = new System.Drawing.Point(360, 32);
            this.dtpReportEnd.Name = "dtpReportEnd";
            this.dtpReportEnd.Size = new System.Drawing.Size(160, 20);
            this.dtpReportEnd.TabIndex = 3;
            //
            // lblReportEnd
            //
            this.lblReportEnd.AutoSize = true;
            this.lblReportEnd.Location = new System.Drawing.Point(288, 36);
            this.lblReportEnd.Name = "lblReportEnd";
            this.lblReportEnd.Size = new System.Drawing.Size(52, 13);
            this.lblReportEnd.TabIndex = 2;
            this.lblReportEnd.Text = "End Date";
            //
            // dtpReportStart
            //
            this.dtpReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportStart.Location = new System.Drawing.Point(96, 32);
            this.dtpReportStart.Name = "dtpReportStart";
            this.dtpReportStart.Size = new System.Drawing.Size(160, 20);
            this.dtpReportStart.TabIndex = 1;
            //
            // lblReportStart
            //
            this.lblReportStart.AutoSize = true;
            this.lblReportStart.Location = new System.Drawing.Point(16, 36);
            this.lblReportStart.Name = "lblReportStart";
            this.lblReportStart.Size = new System.Drawing.Size(55, 13);
            this.lblReportStart.TabIndex = 0;
            this.lblReportStart.Text = "Start Date";
            //
            // communicationTab
            //
            this.communicationTab.Controls.Add(this.grpNotifications);
            this.communicationTab.Controls.Add(this.grpMessageHistory);
            this.communicationTab.Controls.Add(this.grpConversations);
            this.communicationTab.Location = new System.Drawing.Point(4, 22);
            this.communicationTab.Name = "communicationTab";
            this.communicationTab.Padding = new System.Windows.Forms.Padding(3);
            this.communicationTab.Size = new System.Drawing.Size(1176, 641);
            this.communicationTab.TabIndex = 5;
            this.communicationTab.Text = "Communication";
            this.communicationTab.UseVisualStyleBackColor = true;
            //
            // grpNotifications
            //
            this.grpNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNotifications.Controls.Add(this.lstNotifications);
            this.grpNotifications.Location = new System.Drawing.Point(864, 24);
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.Size = new System.Drawing.Size(288, 592);
            this.grpNotifications.TabIndex = 2;
            this.grpNotifications.TabStop = false;
            this.grpNotifications.Text = "Notifications";
            //
            // lstNotifications
            //
            this.lstNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Items.AddRange(new object[] {
            "Appointment rescheduled",
            "Emergency broadcast",
            "Medication stock update",
            "Patient vitals changed"});
            this.lstNotifications.Location = new System.Drawing.Point(16, 24);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(256, 550);
            this.lstNotifications.TabIndex = 0;
            //
            // grpMessageHistory
            //
            this.grpMessageHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMessageHistory.Controls.Add(this.txtMessageInput);
            this.grpMessageHistory.Controls.Add(this.btnSendMessage);
            this.grpMessageHistory.Controls.Add(this.lstMessageHistory);
            this.grpMessageHistory.Location = new System.Drawing.Point(320, 24);
            this.grpMessageHistory.Name = "grpMessageHistory";
            this.grpMessageHistory.Size = new System.Drawing.Size(520, 592);
            this.grpMessageHistory.TabIndex = 1;
            this.grpMessageHistory.TabStop = false;
            this.grpMessageHistory.Text = "Message History";
            //
            // txtMessageInput
            //
            this.txtMessageInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageInput.Location = new System.Drawing.Point(16, 532);
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Size = new System.Drawing.Size(376, 20);
            this.txtMessageInput.TabIndex = 1;
            //
            // btnSendMessage
            //
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(408, 528);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(88, 28);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            //
            // lstMessageHistory
            //
            this.lstMessageHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessageHistory.FormattingEnabled = true;
            this.lstMessageHistory.Items.AddRange(new object[] {
            "Selected conversation messages will appear here."});
            this.lstMessageHistory.Location = new System.Drawing.Point(16, 24);
            this.lstMessageHistory.Name = "lstMessageHistory";
            this.lstMessageHistory.Size = new System.Drawing.Size(480, 485);
            this.lstMessageHistory.TabIndex = 0;
            //
            // grpConversations
            //
            this.grpConversations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpConversations.Controls.Add(this.btnNewConversation);
            this.grpConversations.Controls.Add(this.lstConversations);
            this.grpConversations.Location = new System.Drawing.Point(24, 24);
            this.grpConversations.Name = "grpConversations";
            this.grpConversations.Size = new System.Drawing.Size(272, 592);
            this.grpConversations.TabIndex = 0;
            this.grpConversations.TabStop = false;
            this.grpConversations.Text = "Conversations";
            //
            // btnNewConversation
            //
            this.btnNewConversation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewConversation.Location = new System.Drawing.Point(16, 528);
            this.btnNewConversation.Name = "btnNewConversation";
            this.btnNewConversation.Size = new System.Drawing.Size(240, 28);
            this.btnNewConversation.TabIndex = 1;
            this.btnNewConversation.Text = "New Conversation";
            this.btnNewConversation.UseVisualStyleBackColor = true;
            //
            // lstConversations
            //
            this.lstConversations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConversations.FormattingEnabled = true;
            this.lstConversations.Items.AddRange(new object[] {
            "Nurse Station",
            "Dr. Adams",
            "Patient Support",
            "Emergency Team"});
            this.lstConversations.Location = new System.Drawing.Point(16, 24);
            this.lstConversations.Name = "lstConversations";
            this.lstConversations.Size = new System.Drawing.Size(240, 485);
            this.lstConversations.TabIndex = 0;
            //
            // monitoringTab
            //
            this.monitoringTab.Controls.Add(this.grpMonitoringAlerts);
            this.monitoringTab.Controls.Add(this.grpVitalsEntry);
            this.monitoringTab.Controls.Add(this.vitalsGrid);
            this.monitoringTab.Location = new System.Drawing.Point(4, 22);
            this.monitoringTab.Name = "monitoringTab";
            this.monitoringTab.Padding = new System.Windows.Forms.Padding(3);
            this.monitoringTab.Size = new System.Drawing.Size(1176, 641);
            this.monitoringTab.TabIndex = 6;
            this.monitoringTab.Text = "Monitoring";
            this.monitoringTab.UseVisualStyleBackColor = true;
            //
            // grpMonitoringAlerts
            //
            this.grpMonitoringAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonitoringAlerts.Controls.Add(this.lstMonitoringAlerts);
            this.grpMonitoringAlerts.Location = new System.Drawing.Point(24, 464);
            this.grpMonitoringAlerts.Name = "grpMonitoringAlerts";
            this.grpMonitoringAlerts.Size = new System.Drawing.Size(800, 152);
            this.grpMonitoringAlerts.TabIndex = 1;
            this.grpMonitoringAlerts.TabStop = false;
            this.grpMonitoringAlerts.Text = "Critical Care Alerts";
            //
            // lstMonitoringAlerts
            //
            this.lstMonitoringAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMonitoringAlerts.FormattingEnabled = true;
            this.lstMonitoringAlerts.Items.AddRange(new object[] {
            "Vitals outside normal range will appear here.",
            "Critical care patient updates will appear here."});
            this.lstMonitoringAlerts.Location = new System.Drawing.Point(16, 24);
            this.lstMonitoringAlerts.Name = "lstMonitoringAlerts";
            this.lstMonitoringAlerts.Size = new System.Drawing.Size(768, 108);
            this.lstMonitoringAlerts.TabIndex = 0;
            //
            // grpVitalsEntry
            //
            this.grpVitalsEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVitalsEntry.Controls.Add(this.btnMonitoringRefresh);
            this.grpVitalsEntry.Controls.Add(this.btnUpdateVitals);
            this.grpVitalsEntry.Controls.Add(this.txtMonitoringNotes);
            this.grpVitalsEntry.Controls.Add(this.lblMonitoringNotes);
            this.grpVitalsEntry.Controls.Add(this.numOxygenLevel);
            this.grpVitalsEntry.Controls.Add(this.lblOxygenLevel);
            this.grpVitalsEntry.Controls.Add(this.numTemperature);
            this.grpVitalsEntry.Controls.Add(this.lblTemperature);
            this.grpVitalsEntry.Controls.Add(this.txtBloodPressure);
            this.grpVitalsEntry.Controls.Add(this.lblBloodPressure);
            this.grpVitalsEntry.Controls.Add(this.numHeartRate);
            this.grpVitalsEntry.Controls.Add(this.lblHeartRate);
            this.grpVitalsEntry.Controls.Add(this.txtMonitoringPatient);
            this.grpVitalsEntry.Controls.Add(this.lblMonitoringPatient);
            this.grpVitalsEntry.Location = new System.Drawing.Point(848, 24);
            this.grpVitalsEntry.Name = "grpVitalsEntry";
            this.grpVitalsEntry.Size = new System.Drawing.Size(304, 592);
            this.grpVitalsEntry.TabIndex = 2;
            this.grpVitalsEntry.TabStop = false;
            this.grpVitalsEntry.Text = "Patient Vitals";
            //
            // btnMonitoringRefresh
            //
            this.btnMonitoringRefresh.Location = new System.Drawing.Point(160, 472);
            this.btnMonitoringRefresh.Name = "btnMonitoringRefresh";
            this.btnMonitoringRefresh.Size = new System.Drawing.Size(120, 28);
            this.btnMonitoringRefresh.TabIndex = 13;
            this.btnMonitoringRefresh.Text = "Refresh";
            this.btnMonitoringRefresh.UseVisualStyleBackColor = true;
            //
            // btnUpdateVitals
            //
            this.btnUpdateVitals.Location = new System.Drawing.Point(24, 472);
            this.btnUpdateVitals.Name = "btnUpdateVitals";
            this.btnUpdateVitals.Size = new System.Drawing.Size(120, 28);
            this.btnUpdateVitals.TabIndex = 12;
            this.btnUpdateVitals.Text = "Update Vitals";
            this.btnUpdateVitals.UseVisualStyleBackColor = true;
            //
            // txtMonitoringNotes
            //
            this.txtMonitoringNotes.Location = new System.Drawing.Point(24, 352);
            this.txtMonitoringNotes.Multiline = true;
            this.txtMonitoringNotes.Name = "txtMonitoringNotes";
            this.txtMonitoringNotes.Size = new System.Drawing.Size(256, 88);
            this.txtMonitoringNotes.TabIndex = 11;
            //
            // lblMonitoringNotes
            //
            this.lblMonitoringNotes.AutoSize = true;
            this.lblMonitoringNotes.Location = new System.Drawing.Point(24, 336);
            this.lblMonitoringNotes.Name = "lblMonitoringNotes";
            this.lblMonitoringNotes.Size = new System.Drawing.Size(95, 13);
            this.lblMonitoringNotes.TabIndex = 10;
            this.lblMonitoringNotes.Text = "Monitoring Notes";
            //
            // numOxygenLevel
            //
            this.numOxygenLevel.Location = new System.Drawing.Point(24, 296);
            this.numOxygenLevel.Name = "numOxygenLevel";
            this.numOxygenLevel.Size = new System.Drawing.Size(256, 20);
            this.numOxygenLevel.TabIndex = 9;
            //
            // lblOxygenLevel
            //
            this.lblOxygenLevel.AutoSize = true;
            this.lblOxygenLevel.Location = new System.Drawing.Point(24, 280);
            this.lblOxygenLevel.Name = "lblOxygenLevel";
            this.lblOxygenLevel.Size = new System.Drawing.Size(78, 13);
            this.lblOxygenLevel.TabIndex = 8;
            this.lblOxygenLevel.Text = "Oxygen Level";
            //
            // numTemperature
            //
            this.numTemperature.DecimalPlaces = 1;
            this.numTemperature.Location = new System.Drawing.Point(24, 240);
            this.numTemperature.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTemperature.Name = "numTemperature";
            this.numTemperature.Size = new System.Drawing.Size(256, 20);
            this.numTemperature.TabIndex = 7;
            //
            // lblTemperature
            //
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(24, 224);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature";
            //
            // txtBloodPressure
            //
            this.txtBloodPressure.Location = new System.Drawing.Point(24, 184);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(256, 20);
            this.txtBloodPressure.TabIndex = 5;
            //
            // lblBloodPressure
            //
            this.lblBloodPressure.AutoSize = true;
            this.lblBloodPressure.Location = new System.Drawing.Point(24, 168);
            this.lblBloodPressure.Name = "lblBloodPressure";
            this.lblBloodPressure.Size = new System.Drawing.Size(82, 13);
            this.lblBloodPressure.TabIndex = 4;
            this.lblBloodPressure.Text = "Blood Pressure";
            //
            // numHeartRate
            //
            this.numHeartRate.Location = new System.Drawing.Point(24, 128);
            this.numHeartRate.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numHeartRate.Name = "numHeartRate";
            this.numHeartRate.Size = new System.Drawing.Size(256, 20);
            this.numHeartRate.TabIndex = 3;
            //
            // lblHeartRate
            //
            this.lblHeartRate.AutoSize = true;
            this.lblHeartRate.Location = new System.Drawing.Point(24, 112);
            this.lblHeartRate.Name = "lblHeartRate";
            this.lblHeartRate.Size = new System.Drawing.Size(59, 13);
            this.lblHeartRate.TabIndex = 2;
            this.lblHeartRate.Text = "Heart Rate";
            //
            // txtMonitoringPatient
            //
            this.txtMonitoringPatient.Location = new System.Drawing.Point(24, 72);
            this.txtMonitoringPatient.Name = "txtMonitoringPatient";
            this.txtMonitoringPatient.Size = new System.Drawing.Size(256, 20);
            this.txtMonitoringPatient.TabIndex = 1;
            //
            // lblMonitoringPatient
            //
            this.lblMonitoringPatient.AutoSize = true;
            this.lblMonitoringPatient.Location = new System.Drawing.Point(24, 56);
            this.lblMonitoringPatient.Name = "lblMonitoringPatient";
            this.lblMonitoringPatient.Size = new System.Drawing.Size(43, 13);
            this.lblMonitoringPatient.TabIndex = 0;
            this.lblMonitoringPatient.Text = "Patient";
            //
            // vitalsGrid
            //
            this.vitalsGrid.AllowUserToAddRows = false;
            this.vitalsGrid.AllowUserToDeleteRows = false;
            this.vitalsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vitalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vitalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vitalsPatientColumn,
            this.vitalsRoomColumn,
            this.vitalsHeartRateColumn,
            this.vitalsBloodPressureColumn,
            this.vitalsOxygenColumn,
            this.vitalsStatusColumn});
            this.vitalsGrid.Location = new System.Drawing.Point(24, 24);
            this.vitalsGrid.Name = "vitalsGrid";
            this.vitalsGrid.ReadOnly = true;
            this.vitalsGrid.Size = new System.Drawing.Size(800, 424);
            this.vitalsGrid.TabIndex = 0;
            //
            // vitalsPatientColumn
            //
            this.vitalsPatientColumn.HeaderText = "Patient";
            this.vitalsPatientColumn.Name = "vitalsPatientColumn";
            this.vitalsPatientColumn.ReadOnly = true;
            this.vitalsPatientColumn.Width = 160;
            //
            // vitalsRoomColumn
            //
            this.vitalsRoomColumn.HeaderText = "Room";
            this.vitalsRoomColumn.Name = "vitalsRoomColumn";
            this.vitalsRoomColumn.ReadOnly = true;
            //
            // vitalsHeartRateColumn
            //
            this.vitalsHeartRateColumn.HeaderText = "Heart Rate";
            this.vitalsHeartRateColumn.Name = "vitalsHeartRateColumn";
            this.vitalsHeartRateColumn.ReadOnly = true;
            //
            // vitalsBloodPressureColumn
            //
            this.vitalsBloodPressureColumn.HeaderText = "Blood Pressure";
            this.vitalsBloodPressureColumn.Name = "vitalsBloodPressureColumn";
            this.vitalsBloodPressureColumn.ReadOnly = true;
            this.vitalsBloodPressureColumn.Width = 120;
            //
            // vitalsOxygenColumn
            //
            this.vitalsOxygenColumn.HeaderText = "Oxygen";
            this.vitalsOxygenColumn.Name = "vitalsOxygenColumn";
            this.vitalsOxygenColumn.ReadOnly = true;
            //
            // vitalsStatusColumn
            //
            this.vitalsStatusColumn.HeaderText = "Status";
            this.vitalsStatusColumn.Name = "vitalsStatusColumn";
            this.vitalsStatusColumn.ReadOnly = true;
            this.vitalsStatusColumn.Width = 160;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.grpCriticalStatus.ResumeLayout(false);
            this.grpBedStatus.ResumeLayout(false);
            this.grpRealTimeUpdates.ResumeLayout(false);
            this.grpQuickCounts.ResumeLayout(false);
            this.grpQuickCounts.PerformLayout();
            this.patientsTab.ResumeLayout(false);
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).EndInit();
            this.grpPatientSearch.ResumeLayout(false);
            this.grpPatientSearch.PerformLayout();
            this.appointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).EndInit();
            this.grpAppointmentDetails.ResumeLayout(false);
            this.grpAppointmentDetails.PerformLayout();
            this.inventoryTab.ResumeLayout(false);
            this.grpLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.grpInventoryDetails.ResumeLayout(false);
            this.grpInventoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInventoryReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventoryQuantity)).EndInit();
            this.analyticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.grpReportOutput.ResumeLayout(false);
            this.grpAnalyticsSummary.ResumeLayout(false);
            this.grpAnalyticsSummary.PerformLayout();
            this.grpAnalyticsFilters.ResumeLayout(false);
            this.grpAnalyticsFilters.PerformLayout();
            this.communicationTab.ResumeLayout(false);
            this.grpNotifications.ResumeLayout(false);
            this.grpMessageHistory.ResumeLayout(false);
            this.grpMessageHistory.PerformLayout();
            this.grpConversations.ResumeLayout(false);
            this.monitoringTab.ResumeLayout(false);
            this.grpMonitoringAlerts.ResumeLayout(false);
            this.grpVitalsEntry.ResumeLayout(false);
            this.grpVitalsEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOxygenLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
