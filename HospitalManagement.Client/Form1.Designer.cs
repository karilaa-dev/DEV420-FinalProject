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
            btnNotifications = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            lblRole = new System.Windows.Forms.Label();
            lblLoggedInUser = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusText = new System.Windows.Forms.ToolStripStatusLabel();
            connectionStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            mainTabs = new System.Windows.Forms.TabControl();
            dashboardTab = new System.Windows.Forms.TabPage();
            grpCriticalStatus = new System.Windows.Forms.GroupBox();
            currentAlertsGrid = new System.Windows.Forms.DataGridView();
            alertTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alertSubjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alertDetailsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alertUpdatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpBedStatus = new System.Windows.Forms.GroupBox();
            bedStatusGrid = new System.Windows.Forms.DataGridView();
            bedDepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bedOpenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bedTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bedUpdatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            doctorVisitsTab = new System.Windows.Forms.TabPage();
            grpDoctorTodayVisits = new System.Windows.Forms.GroupBox();
            doctorVisitsGrid = new System.Windows.Forms.DataGridView();
            doctorVisitTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorVisitPatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorVisitStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorVisitReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpDoctorTodayVisit = new System.Windows.Forms.GroupBox();
            btnTextNextVisitPatient = new System.Windows.Forms.Button();
            lblDoctorTodayVisitPlaceholder = new System.Windows.Forms.Label();
            lblDoctorTodayVisitNotesValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitNotesCaption = new System.Windows.Forms.Label();
            lblDoctorTodayVisitReasonValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitReasonCaption = new System.Windows.Forms.Label();
            lblDoctorTodayVisitStatusValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitStatusCaption = new System.Windows.Forms.Label();
            lblDoctorTodayVisitPatientValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitPatientCaption = new System.Windows.Forms.Label();
            lblDoctorTodayVisitTimeValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitTimeCaption = new System.Windows.Forms.Label();
            lblDoctorTodayVisitDateValue = new System.Windows.Forms.Label();
            lblDoctorTodayVisitDateCaption = new System.Windows.Forms.Label();
            pnlDoctorTodayVisitStatus = new System.Windows.Forms.Panel();
            grpDoctorLastVisit = new System.Windows.Forms.GroupBox();
            btnTextLastVisitPatient = new System.Windows.Forms.Button();
            lblDoctorLastVisitPlaceholder = new System.Windows.Forms.Label();
            lblDoctorLastVisitNotesValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitNotesCaption = new System.Windows.Forms.Label();
            lblDoctorLastVisitReasonValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitReasonCaption = new System.Windows.Forms.Label();
            lblDoctorLastVisitStatusValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitStatusCaption = new System.Windows.Forms.Label();
            lblDoctorLastVisitPatientValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitPatientCaption = new System.Windows.Forms.Label();
            lblDoctorLastVisitTimeValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitTimeCaption = new System.Windows.Forms.Label();
            lblDoctorLastVisitDateValue = new System.Windows.Forms.Label();
            lblDoctorLastVisitDateCaption = new System.Windows.Forms.Label();
            pnlDoctorLastVisitStatus = new System.Windows.Forms.Panel();
            patientCareTab = new System.Windows.Forms.TabPage();
            grpPatientLatestVitals = new System.Windows.Forms.GroupBox();
            lblPatientVitalsPlaceholder = new System.Windows.Forms.Label();
            lblVitalNotes = new System.Windows.Forms.Label();
            pnlVitalUpdated = new System.Windows.Forms.Panel();
            lblVitalUpdated = new System.Windows.Forms.Label();
            lblVitalUpdatedCaption = new System.Windows.Forms.Label();
            pnlVitalStatus = new System.Windows.Forms.Panel();
            lblVitalStatus = new System.Windows.Forms.Label();
            lblVitalStatusCaption = new System.Windows.Forms.Label();
            pnlVitalTemperature = new System.Windows.Forms.Panel();
            lblVitalTemperature = new System.Windows.Forms.Label();
            lblVitalTemperatureCaption = new System.Windows.Forms.Label();
            pnlVitalOxygen = new System.Windows.Forms.Panel();
            lblVitalOxygen = new System.Windows.Forms.Label();
            lblVitalOxygenCaption = new System.Windows.Forms.Label();
            pnlVitalBloodPressure = new System.Windows.Forms.Panel();
            lblVitalBloodPressure = new System.Windows.Forms.Label();
            lblVitalBloodPressureCaption = new System.Windows.Forms.Label();
            pnlVitalHeartRate = new System.Windows.Forms.Panel();
            lblVitalHeartRate = new System.Windows.Forms.Label();
            lblVitalHeartRateCaption = new System.Windows.Forms.Label();
            grpPatientNextAppointment = new System.Windows.Forms.GroupBox();
            lblPatientAppointmentPlaceholder = new System.Windows.Forms.Label();
            lblPatientAppointmentNotesValue = new System.Windows.Forms.Label();
            lblPatientAppointmentNotesCaption = new System.Windows.Forms.Label();
            lblPatientAppointmentReasonValue = new System.Windows.Forms.Label();
            lblPatientAppointmentReasonCaption = new System.Windows.Forms.Label();
            lblPatientAppointmentStatusValue = new System.Windows.Forms.Label();
            lblPatientAppointmentStatusCaption = new System.Windows.Forms.Label();
            lblPatientAppointmentDoctorValue = new System.Windows.Forms.Label();
            lblPatientAppointmentDoctorCaption = new System.Windows.Forms.Label();
            lblPatientAppointmentTimeValue = new System.Windows.Forms.Label();
            lblPatientAppointmentTimeCaption = new System.Windows.Forms.Label();
            lblPatientAppointmentDateValue = new System.Windows.Forms.Label();
            lblPatientAppointmentDateCaption = new System.Windows.Forms.Label();
            pnlPatientAppointmentStatus = new System.Windows.Forms.Panel();
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
            btnClearAppointment = new System.Windows.Forms.Button();
            btnAppointmentRefresh = new System.Windows.Forms.Button();
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
            cmbAppointmentPatientPicker = new System.Windows.Forms.ComboBox();
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
            grpMessageHistory = new System.Windows.Forms.GroupBox();
            txtMessageInput = new System.Windows.Forms.TextBox();
            btnSendMessage = new System.Windows.Forms.Button();
            messageHistoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            grpConversations = new System.Windows.Forms.GroupBox();
            btnNewConversation = new System.Windows.Forms.Button();
            lstConversations = new System.Windows.Forms.ListBox();
            patientMessagesTab = new System.Windows.Forms.TabPage();
            grpPatientMessageHistory = new System.Windows.Forms.GroupBox();
            txtPatientMessageInput = new System.Windows.Forms.TextBox();
            btnSendPatientMessage = new System.Windows.Forms.Button();
            patientMessageHistoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            cmbMonitoringPatientPicker = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)currentAlertsGrid).BeginInit();
            grpBedStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bedStatusGrid).BeginInit();
            grpQuickCounts.SuspendLayout();
            doctorVisitsTab.SuspendLayout();
            grpDoctorTodayVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorVisitsGrid).BeginInit();
            grpDoctorTodayVisit.SuspendLayout();
            grpDoctorLastVisit.SuspendLayout();
            patientCareTab.SuspendLayout();
            grpPatientLatestVitals.SuspendLayout();
            pnlVitalUpdated.SuspendLayout();
            pnlVitalStatus.SuspendLayout();
            pnlVitalTemperature.SuspendLayout();
            pnlVitalOxygen.SuspendLayout();
            pnlVitalBloodPressure.SuspendLayout();
            pnlVitalHeartRate.SuspendLayout();
            grpPatientNextAppointment.SuspendLayout();
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
            grpMessageHistory.SuspendLayout();
            grpConversations.SuspendLayout();
            patientMessagesTab.SuspendLayout();
            grpPatientMessageHistory.SuspendLayout();
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
            headerPanel.Controls.Add(btnNotifications);
            headerPanel.Controls.Add(btnLogout);
            headerPanel.Controls.Add(lblRole);
            headerPanel.Controls.Add(lblLoggedInUser);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(0, 0);
            headerPanel.Margin = new System.Windows.Forms.Padding(4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(1382, 72);
            headerPanel.TabIndex = 0;
            // 
            // btnNotifications
            // 
            btnNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNotifications.Location = new System.Drawing.Point(1084, 12);
            btnNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new System.Drawing.Size(127, 43);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLogout.Location = new System.Drawing.Point(1217, 12);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(153, 43);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRole.Location = new System.Drawing.Point(13, 34);
            lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(184, 21);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role: Administrative Staff";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLoggedInUser.Location = new System.Drawing.Point(13, 9);
            lblLoggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new System.Drawing.Size(138, 21);
            lblLoggedInUser.TabIndex = 1;
            lblLoggedInUser.Text = "User: Current User";
            lblLoggedInUser.Click += lblLoggedInUser_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusText, connectionStatusText });
            statusStrip.Location = new System.Drawing.Point(0, 856);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            statusStrip.Size = new System.Drawing.Size(1382, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // statusText
            // 
            statusText.Name = "statusText";
            statusText.Size = new System.Drawing.Size(1248, 17);
            statusText.Spring = true;
            statusText.Text = "Ready";
            statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectionStatusText
            // 
            connectionStatusText.Name = "connectionStatusText";
            connectionStatusText.Size = new System.Drawing.Size(116, 17);
            connectionStatusText.Text = "Connection: Waiting";
            // 
            // mainTabs
            // 
            mainTabs.Controls.Add(dashboardTab);
            mainTabs.Controls.Add(doctorVisitsTab);
            mainTabs.Controls.Add(patientCareTab);
            mainTabs.Controls.Add(patientsTab);
            mainTabs.Controls.Add(appointmentsTab);
            mainTabs.Controls.Add(inventoryTab);
            mainTabs.Controls.Add(analyticsTab);
            mainTabs.Controls.Add(communicationTab);
            mainTabs.Controls.Add(patientMessagesTab);
            mainTabs.Controls.Add(monitoringTab);
            mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            mainTabs.Location = new System.Drawing.Point(0, 72);
            mainTabs.Margin = new System.Windows.Forms.Padding(4);
            mainTabs.Name = "mainTabs";
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new System.Drawing.Size(1382, 784);
            mainTabs.TabIndex = 1;
            // 
            // dashboardTab
            // 
            dashboardTab.Controls.Add(grpCriticalStatus);
            dashboardTab.Controls.Add(grpBedStatus);
            dashboardTab.Controls.Add(grpQuickCounts);
            dashboardTab.Location = new System.Drawing.Point(4, 24);
            dashboardTab.Margin = new System.Windows.Forms.Padding(4);
            dashboardTab.Name = "dashboardTab";
            dashboardTab.Padding = new System.Windows.Forms.Padding(4);
            dashboardTab.Size = new System.Drawing.Size(1374, 756);
            dashboardTab.TabIndex = 0;
            dashboardTab.Text = "Dashboard";
            dashboardTab.UseVisualStyleBackColor = true;
            // 
            // grpCriticalStatus
            // 
            grpCriticalStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpCriticalStatus.Controls.Add(currentAlertsGrid);
            grpCriticalStatus.Location = new System.Drawing.Point(686, 216);
            grpCriticalStatus.Margin = new System.Windows.Forms.Padding(4);
            grpCriticalStatus.Name = "grpCriticalStatus";
            grpCriticalStatus.Padding = new System.Windows.Forms.Padding(4);
            grpCriticalStatus.Size = new System.Drawing.Size(658, 495);
            grpCriticalStatus.TabIndex = 3;
            grpCriticalStatus.TabStop = false;
            grpCriticalStatus.Text = "Current Alerts";
            // 
            // currentAlertsGrid
            // 
            currentAlertsGrid.AllowUserToAddRows = false;
            currentAlertsGrid.AllowUserToDeleteRows = false;
            currentAlertsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            currentAlertsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentAlertsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { alertTypeColumn, alertSubjectColumn, alertDetailsColumn, alertUpdatedColumn });
            currentAlertsGrid.Location = new System.Drawing.Point(18, 28);
            currentAlertsGrid.Margin = new System.Windows.Forms.Padding(4);
            currentAlertsGrid.Name = "currentAlertsGrid";
            currentAlertsGrid.ReadOnly = true;
            currentAlertsGrid.RowHeadersWidth = 51;
            currentAlertsGrid.Size = new System.Drawing.Size(620, 443);
            currentAlertsGrid.TabIndex = 0;
            // 
            // alertTypeColumn
            // 
            alertTypeColumn.HeaderText = "Type / Severity";
            alertTypeColumn.MinimumWidth = 6;
            alertTypeColumn.Name = "alertTypeColumn";
            alertTypeColumn.ReadOnly = true;
            alertTypeColumn.Width = 140;
            // 
            // alertSubjectColumn
            // 
            alertSubjectColumn.HeaderText = "Patient or Item";
            alertSubjectColumn.MinimumWidth = 6;
            alertSubjectColumn.Name = "alertSubjectColumn";
            alertSubjectColumn.ReadOnly = true;
            alertSubjectColumn.Width = 160;
            // 
            // alertDetailsColumn
            // 
            alertDetailsColumn.HeaderText = "Details";
            alertDetailsColumn.MinimumWidth = 6;
            alertDetailsColumn.Name = "alertDetailsColumn";
            alertDetailsColumn.ReadOnly = true;
            alertDetailsColumn.Width = 220;
            // 
            // alertUpdatedColumn
            // 
            alertUpdatedColumn.HeaderText = "Updated";
            alertUpdatedColumn.MinimumWidth = 6;
            alertUpdatedColumn.Name = "alertUpdatedColumn";
            alertUpdatedColumn.ReadOnly = true;
            alertUpdatedColumn.Width = 120;
            // 
            // grpBedStatus
            // 
            grpBedStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            grpBedStatus.Controls.Add(bedStatusGrid);
            grpBedStatus.Location = new System.Drawing.Point(28, 216);
            grpBedStatus.Margin = new System.Windows.Forms.Padding(4);
            grpBedStatus.Name = "grpBedStatus";
            grpBedStatus.Padding = new System.Windows.Forms.Padding(4);
            grpBedStatus.Size = new System.Drawing.Size(632, 495);
            grpBedStatus.TabIndex = 1;
            grpBedStatus.TabStop = false;
            grpBedStatus.Text = "Bed Availability";
            // 
            // bedStatusGrid
            // 
            bedStatusGrid.AllowUserToAddRows = false;
            bedStatusGrid.AllowUserToDeleteRows = false;
            bedStatusGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bedStatusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bedStatusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bedDepartmentColumn, bedOpenColumn, bedTotalColumn, bedUpdatedColumn });
            bedStatusGrid.Location = new System.Drawing.Point(18, 28);
            bedStatusGrid.Margin = new System.Windows.Forms.Padding(4);
            bedStatusGrid.Name = "bedStatusGrid";
            bedStatusGrid.ReadOnly = true;
            bedStatusGrid.RowHeadersWidth = 51;
            bedStatusGrid.Size = new System.Drawing.Size(594, 443);
            bedStatusGrid.TabIndex = 0;
            // 
            // bedDepartmentColumn
            // 
            bedDepartmentColumn.HeaderText = "Department";
            bedDepartmentColumn.MinimumWidth = 6;
            bedDepartmentColumn.Name = "bedDepartmentColumn";
            bedDepartmentColumn.ReadOnly = true;
            bedDepartmentColumn.Width = 180;
            // 
            // bedOpenColumn
            // 
            bedOpenColumn.HeaderText = "Open Beds";
            bedOpenColumn.MinimumWidth = 6;
            bedOpenColumn.Name = "bedOpenColumn";
            bedOpenColumn.ReadOnly = true;
            bedOpenColumn.Width = 110;
            // 
            // bedTotalColumn
            // 
            bedTotalColumn.HeaderText = "Total Beds";
            bedTotalColumn.MinimumWidth = 6;
            bedTotalColumn.Name = "bedTotalColumn";
            bedTotalColumn.ReadOnly = true;
            bedTotalColumn.Width = 110;
            // 
            // bedUpdatedColumn
            // 
            bedUpdatedColumn.HeaderText = "Last Updated";
            bedUpdatedColumn.MinimumWidth = 6;
            bedUpdatedColumn.Name = "bedUpdatedColumn";
            bedUpdatedColumn.ReadOnly = true;
            bedUpdatedColumn.Width = 140;
            // 
            // grpQuickCounts
            // 
            grpQuickCounts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            grpQuickCounts.Location = new System.Drawing.Point(28, 28);
            grpQuickCounts.Margin = new System.Windows.Forms.Padding(4);
            grpQuickCounts.Name = "grpQuickCounts";
            grpQuickCounts.Padding = new System.Windows.Forms.Padding(4);
            grpQuickCounts.Size = new System.Drawing.Size(1316, 160);
            grpQuickCounts.TabIndex = 0;
            grpQuickCounts.TabStop = false;
            grpQuickCounts.Text = "Today Overview";
            // 
            // txtDashboardEmergencies
            // 
            txtDashboardEmergencies.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            txtDashboardEmergencies.Location = new System.Drawing.Point(1066, 72);
            txtDashboardEmergencies.Margin = new System.Windows.Forms.Padding(4);
            txtDashboardEmergencies.Name = "txtDashboardEmergencies";
            txtDashboardEmergencies.ReadOnly = true;
            txtDashboardEmergencies.Size = new System.Drawing.Size(214, 39);
            txtDashboardEmergencies.TabIndex = 9;
            txtDashboardEmergencies.Text = "1";
            txtDashboardEmergencies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDashboardEmergencies
            // 
            lblDashboardEmergencies.AutoSize = true;
            lblDashboardEmergencies.Location = new System.Drawing.Point(1066, 47);
            lblDashboardEmergencies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardEmergencies.Name = "lblDashboardEmergencies";
            lblDashboardEmergencies.Size = new System.Drawing.Size(99, 15);
            lblDashboardEmergencies.TabIndex = 8;
            lblDashboardEmergencies.Text = "Emergency Alerts";
            // 
            // txtDashboardLowStock
            // 
            txtDashboardLowStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            txtDashboardLowStock.Location = new System.Drawing.Point(810, 72);
            txtDashboardLowStock.Margin = new System.Windows.Forms.Padding(4);
            txtDashboardLowStock.Name = "txtDashboardLowStock";
            txtDashboardLowStock.ReadOnly = true;
            txtDashboardLowStock.Size = new System.Drawing.Size(214, 39);
            txtDashboardLowStock.TabIndex = 7;
            txtDashboardLowStock.Text = "7";
            txtDashboardLowStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDashboardLowStock
            // 
            lblDashboardLowStock.AutoSize = true;
            lblDashboardLowStock.Location = new System.Drawing.Point(810, 47);
            lblDashboardLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardLowStock.Name = "lblDashboardLowStock";
            lblDashboardLowStock.Size = new System.Drawing.Size(93, 15);
            lblDashboardLowStock.TabIndex = 6;
            lblDashboardLowStock.Text = "Low Stock Items";
            // 
            // txtDashboardOpenBeds
            // 
            txtDashboardOpenBeds.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            txtDashboardOpenBeds.Location = new System.Drawing.Point(554, 72);
            txtDashboardOpenBeds.Margin = new System.Windows.Forms.Padding(4);
            txtDashboardOpenBeds.Name = "txtDashboardOpenBeds";
            txtDashboardOpenBeds.ReadOnly = true;
            txtDashboardOpenBeds.Size = new System.Drawing.Size(214, 39);
            txtDashboardOpenBeds.TabIndex = 5;
            txtDashboardOpenBeds.Text = "39";
            txtDashboardOpenBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDashboardOpenBeds
            // 
            lblDashboardOpenBeds.AutoSize = true;
            lblDashboardOpenBeds.Location = new System.Drawing.Point(554, 47);
            lblDashboardOpenBeds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardOpenBeds.Name = "lblDashboardOpenBeds";
            lblDashboardOpenBeds.Size = new System.Drawing.Size(64, 15);
            lblDashboardOpenBeds.TabIndex = 4;
            lblDashboardOpenBeds.Text = "Open Beds";
            // 
            // txtDashboardAppointments
            // 
            txtDashboardAppointments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            txtDashboardAppointments.Location = new System.Drawing.Point(298, 72);
            txtDashboardAppointments.Margin = new System.Windows.Forms.Padding(4);
            txtDashboardAppointments.Name = "txtDashboardAppointments";
            txtDashboardAppointments.ReadOnly = true;
            txtDashboardAppointments.Size = new System.Drawing.Size(214, 39);
            txtDashboardAppointments.TabIndex = 3;
            txtDashboardAppointments.Text = "24";
            txtDashboardAppointments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDashboardAppointments
            // 
            lblDashboardAppointments.AutoSize = true;
            lblDashboardAppointments.Location = new System.Drawing.Point(298, 47);
            lblDashboardAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardAppointments.Name = "lblDashboardAppointments";
            lblDashboardAppointments.Size = new System.Drawing.Size(118, 15);
            lblDashboardAppointments.TabIndex = 2;
            lblDashboardAppointments.Text = "Appointments Today";
            // 
            // txtDashboardPatients
            // 
            txtDashboardPatients.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            txtDashboardPatients.Location = new System.Drawing.Point(42, 72);
            txtDashboardPatients.Margin = new System.Windows.Forms.Padding(4);
            txtDashboardPatients.Name = "txtDashboardPatients";
            txtDashboardPatients.ReadOnly = true;
            txtDashboardPatients.Size = new System.Drawing.Size(214, 39);
            txtDashboardPatients.TabIndex = 1;
            txtDashboardPatients.Text = "126";
            txtDashboardPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDashboardPatients
            // 
            lblDashboardPatients.AutoSize = true;
            lblDashboardPatients.Location = new System.Drawing.Point(42, 47);
            lblDashboardPatients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboardPatients.Name = "lblDashboardPatients";
            lblDashboardPatients.Size = new System.Drawing.Size(85, 15);
            lblDashboardPatients.TabIndex = 0;
            lblDashboardPatients.Text = "Active Patients";
            // 
            // doctorVisitsTab
            // 
            doctorVisitsTab.Controls.Add(grpDoctorTodayVisits);
            doctorVisitsTab.Controls.Add(grpDoctorTodayVisit);
            doctorVisitsTab.Controls.Add(grpDoctorLastVisit);
            doctorVisitsTab.Location = new System.Drawing.Point(4, 24);
            doctorVisitsTab.Margin = new System.Windows.Forms.Padding(4);
            doctorVisitsTab.Name = "doctorVisitsTab";
            doctorVisitsTab.Padding = new System.Windows.Forms.Padding(4);
            doctorVisitsTab.Size = new System.Drawing.Size(1374, 756);
            doctorVisitsTab.TabIndex = 10;
            doctorVisitsTab.Text = "My Visits";
            doctorVisitsTab.UseVisualStyleBackColor = true;
            // 
            // grpDoctorTodayVisits
            // 
            grpDoctorTodayVisits.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpDoctorTodayVisits.Controls.Add(doctorVisitsGrid);
            grpDoctorTodayVisits.Location = new System.Drawing.Point(687, 20);
            grpDoctorTodayVisits.Margin = new System.Windows.Forms.Padding(4);
            grpDoctorTodayVisits.Name = "grpDoctorTodayVisits";
            grpDoctorTodayVisits.Padding = new System.Windows.Forms.Padding(4);
            grpDoctorTodayVisits.Size = new System.Drawing.Size(663, 717);
            grpDoctorTodayVisits.TabIndex = 2;
            grpDoctorTodayVisits.TabStop = false;
            grpDoctorTodayVisits.Text = "Today's Visits";
            // 
            // doctorVisitsGrid
            // 
            doctorVisitsGrid.AllowUserToAddRows = false;
            doctorVisitsGrid.AllowUserToDeleteRows = false;
            doctorVisitsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            doctorVisitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorVisitsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { doctorVisitTimeColumn, doctorVisitPatientColumn, doctorVisitStatusColumn, doctorVisitReasonColumn });
            doctorVisitsGrid.Location = new System.Drawing.Point(19, 24);
            doctorVisitsGrid.Margin = new System.Windows.Forms.Padding(4);
            doctorVisitsGrid.Name = "doctorVisitsGrid";
            doctorVisitsGrid.ReadOnly = true;
            doctorVisitsGrid.RowHeadersWidth = 51;
            doctorVisitsGrid.Size = new System.Drawing.Size(636, 675);
            doctorVisitsGrid.TabIndex = 0;
            doctorVisitsGrid.CellContentClick += doctorVisitsGrid_CellContentClick;
            doctorVisitsGrid.SelectionChanged += doctorVisitsGrid_SelectionChanged;
            // 
            // doctorVisitTimeColumn
            // 
            doctorVisitTimeColumn.HeaderText = "Time";
            doctorVisitTimeColumn.MinimumWidth = 6;
            doctorVisitTimeColumn.Name = "doctorVisitTimeColumn";
            doctorVisitTimeColumn.ReadOnly = true;
            // 
            // doctorVisitPatientColumn
            // 
            doctorVisitPatientColumn.HeaderText = "Patient";
            doctorVisitPatientColumn.MinimumWidth = 6;
            doctorVisitPatientColumn.Name = "doctorVisitPatientColumn";
            doctorVisitPatientColumn.ReadOnly = true;
            doctorVisitPatientColumn.Width = 190;
            // 
            // doctorVisitStatusColumn
            // 
            doctorVisitStatusColumn.HeaderText = "Status";
            doctorVisitStatusColumn.MinimumWidth = 6;
            doctorVisitStatusColumn.Name = "doctorVisitStatusColumn";
            doctorVisitStatusColumn.ReadOnly = true;
            doctorVisitStatusColumn.Width = 140;
            // 
            // doctorVisitReasonColumn
            // 
            doctorVisitReasonColumn.HeaderText = "Reason";
            doctorVisitReasonColumn.MinimumWidth = 6;
            doctorVisitReasonColumn.Name = "doctorVisitReasonColumn";
            doctorVisitReasonColumn.ReadOnly = true;
            doctorVisitReasonColumn.Width = 260;
            // 
            // grpDoctorTodayVisit
            // 
            grpDoctorTodayVisit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpDoctorTodayVisit.Controls.Add(btnTextNextVisitPatient);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitPlaceholder);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitNotesValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitNotesCaption);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitReasonValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitReasonCaption);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitStatusValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitStatusCaption);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitPatientValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitPatientCaption);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitTimeValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitTimeCaption);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitDateValue);
            grpDoctorTodayVisit.Controls.Add(lblDoctorTodayVisitDateCaption);
            grpDoctorTodayVisit.Controls.Add(pnlDoctorTodayVisitStatus);
            grpDoctorTodayVisit.Location = new System.Drawing.Point(20, 20);
            grpDoctorTodayVisit.Margin = new System.Windows.Forms.Padding(4);
            grpDoctorTodayVisit.Name = "grpDoctorTodayVisit";
            grpDoctorTodayVisit.Padding = new System.Windows.Forms.Padding(4);
            grpDoctorTodayVisit.Size = new System.Drawing.Size(646, 210);
            grpDoctorTodayVisit.TabIndex = 1;
            grpDoctorTodayVisit.TabStop = false;
            grpDoctorTodayVisit.Text = "Today Visit View";
            // 
            // btnTextNextVisitPatient
            // 
            btnTextNextVisitPatient.Enabled = false;
            btnTextNextVisitPatient.Location = new System.Drawing.Point(34, 162);
            btnTextNextVisitPatient.Margin = new System.Windows.Forms.Padding(4);
            btnTextNextVisitPatient.Name = "btnTextNextVisitPatient";
            btnTextNextVisitPatient.Size = new System.Drawing.Size(130, 28);
            btnTextNextVisitPatient.TabIndex = 14;
            btnTextNextVisitPatient.Text = "Text Patient";
            btnTextNextVisitPatient.UseVisualStyleBackColor = true;
            btnTextNextVisitPatient.Click += btnTextVisitPatient_Click;
            // 
            // lblDoctorTodayVisitPlaceholder
            // 
            lblDoctorTodayVisitPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorTodayVisitPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblDoctorTodayVisitPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitPlaceholder.Location = new System.Drawing.Point(110, 26);
            lblDoctorTodayVisitPlaceholder.Name = "lblDoctorTodayVisitPlaceholder";
            lblDoctorTodayVisitPlaceholder.Size = new System.Drawing.Size(529, 32);
            lblDoctorTodayVisitPlaceholder.TabIndex = 13;
            lblDoctorTodayVisitPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblDoctorTodayVisitPlaceholder.Visible = false;
            lblDoctorTodayVisitPlaceholder.Click += lblDoctorTodayVisitPlaceholder_Click;
            // 
            // lblDoctorTodayVisitNotesValue
            // 
            lblDoctorTodayVisitNotesValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorTodayVisitNotesValue.Location = new System.Drawing.Point(111, 137);
            lblDoctorTodayVisitNotesValue.Name = "lblDoctorTodayVisitNotesValue";
            lblDoctorTodayVisitNotesValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitNotesValue.TabIndex = 12;
            // 
            // lblDoctorTodayVisitNotesCaption
            // 
            lblDoctorTodayVisitNotesCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitNotesCaption.Location = new System.Drawing.Point(34, 136);
            lblDoctorTodayVisitNotesCaption.Name = "lblDoctorTodayVisitNotesCaption";
            lblDoctorTodayVisitNotesCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitNotesCaption.TabIndex = 11;
            lblDoctorTodayVisitNotesCaption.Text = "Notes";
            // 
            // lblDoctorTodayVisitReasonValue
            // 
            lblDoctorTodayVisitReasonValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorTodayVisitReasonValue.Location = new System.Drawing.Point(111, 115);
            lblDoctorTodayVisitReasonValue.Name = "lblDoctorTodayVisitReasonValue";
            lblDoctorTodayVisitReasonValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitReasonValue.TabIndex = 10;
            // 
            // lblDoctorTodayVisitReasonCaption
            // 
            lblDoctorTodayVisitReasonCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitReasonCaption.Location = new System.Drawing.Point(34, 114);
            lblDoctorTodayVisitReasonCaption.Name = "lblDoctorTodayVisitReasonCaption";
            lblDoctorTodayVisitReasonCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitReasonCaption.TabIndex = 9;
            lblDoctorTodayVisitReasonCaption.Text = "Reason";
            // 
            // lblDoctorTodayVisitStatusValue
            // 
            lblDoctorTodayVisitStatusValue.Location = new System.Drawing.Point(110, 92);
            lblDoctorTodayVisitStatusValue.Name = "lblDoctorTodayVisitStatusValue";
            lblDoctorTodayVisitStatusValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitStatusValue.TabIndex = 8;
            // 
            // lblDoctorTodayVisitStatusCaption
            // 
            lblDoctorTodayVisitStatusCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitStatusCaption.Location = new System.Drawing.Point(34, 92);
            lblDoctorTodayVisitStatusCaption.Name = "lblDoctorTodayVisitStatusCaption";
            lblDoctorTodayVisitStatusCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitStatusCaption.TabIndex = 7;
            lblDoctorTodayVisitStatusCaption.Text = "Status";
            // 
            // lblDoctorTodayVisitPatientValue
            // 
            lblDoctorTodayVisitPatientValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorTodayVisitPatientValue.Location = new System.Drawing.Point(111, 71);
            lblDoctorTodayVisitPatientValue.Name = "lblDoctorTodayVisitPatientValue";
            lblDoctorTodayVisitPatientValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitPatientValue.TabIndex = 6;
            // 
            // lblDoctorTodayVisitPatientCaption
            // 
            lblDoctorTodayVisitPatientCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitPatientCaption.Location = new System.Drawing.Point(34, 70);
            lblDoctorTodayVisitPatientCaption.Name = "lblDoctorTodayVisitPatientCaption";
            lblDoctorTodayVisitPatientCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitPatientCaption.TabIndex = 5;
            lblDoctorTodayVisitPatientCaption.Text = "Patient";
            // 
            // lblDoctorTodayVisitTimeValue
            // 
            lblDoctorTodayVisitTimeValue.Location = new System.Drawing.Point(110, 48);
            lblDoctorTodayVisitTimeValue.Name = "lblDoctorTodayVisitTimeValue";
            lblDoctorTodayVisitTimeValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitTimeValue.TabIndex = 4;
            // 
            // lblDoctorTodayVisitTimeCaption
            // 
            lblDoctorTodayVisitTimeCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitTimeCaption.Location = new System.Drawing.Point(34, 48);
            lblDoctorTodayVisitTimeCaption.Name = "lblDoctorTodayVisitTimeCaption";
            lblDoctorTodayVisitTimeCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitTimeCaption.TabIndex = 3;
            lblDoctorTodayVisitTimeCaption.Text = "Time";
            // 
            // lblDoctorTodayVisitDateValue
            // 
            lblDoctorTodayVisitDateValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorTodayVisitDateValue.Location = new System.Drawing.Point(111, 27);
            lblDoctorTodayVisitDateValue.Name = "lblDoctorTodayVisitDateValue";
            lblDoctorTodayVisitDateValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorTodayVisitDateValue.TabIndex = 2;
            // 
            // lblDoctorTodayVisitDateCaption
            // 
            lblDoctorTodayVisitDateCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorTodayVisitDateCaption.Location = new System.Drawing.Point(34, 26);
            lblDoctorTodayVisitDateCaption.Name = "lblDoctorTodayVisitDateCaption";
            lblDoctorTodayVisitDateCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorTodayVisitDateCaption.TabIndex = 1;
            lblDoctorTodayVisitDateCaption.Text = "Date";
            // 
            // pnlDoctorTodayVisitStatus
            // 
            pnlDoctorTodayVisitStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlDoctorTodayVisitStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            pnlDoctorTodayVisitStatus.Location = new System.Drawing.Point(19, 25);
            pnlDoctorTodayVisitStatus.Name = "pnlDoctorTodayVisitStatus";
            pnlDoctorTodayVisitStatus.Size = new System.Drawing.Size(6, 128);
            pnlDoctorTodayVisitStatus.TabIndex = 0;
            // 
            // grpDoctorLastVisit
            // 
            grpDoctorLastVisit.Controls.Add(btnTextLastVisitPatient);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitPlaceholder);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitNotesValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitNotesCaption);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitReasonValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitReasonCaption);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitStatusValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitStatusCaption);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitPatientValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitPatientCaption);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitTimeValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitTimeCaption);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitDateValue);
            grpDoctorLastVisit.Controls.Add(lblDoctorLastVisitDateCaption);
            grpDoctorLastVisit.Controls.Add(pnlDoctorLastVisitStatus);
            grpDoctorLastVisit.Location = new System.Drawing.Point(20, 242);
            grpDoctorLastVisit.Margin = new System.Windows.Forms.Padding(4);
            grpDoctorLastVisit.Name = "grpDoctorLastVisit";
            grpDoctorLastVisit.Padding = new System.Windows.Forms.Padding(4);
            grpDoctorLastVisit.Size = new System.Drawing.Size(646, 210);
            grpDoctorLastVisit.TabIndex = 0;
            grpDoctorLastVisit.TabStop = false;
            grpDoctorLastVisit.Text = "Last Completed Visit";
            // 
            // btnTextLastVisitPatient
            // 
            btnTextLastVisitPatient.Enabled = false;
            btnTextLastVisitPatient.Location = new System.Drawing.Point(34, 162);
            btnTextLastVisitPatient.Margin = new System.Windows.Forms.Padding(4);
            btnTextLastVisitPatient.Name = "btnTextLastVisitPatient";
            btnTextLastVisitPatient.Size = new System.Drawing.Size(130, 28);
            btnTextLastVisitPatient.TabIndex = 14;
            btnTextLastVisitPatient.Text = "Text Patient";
            btnTextLastVisitPatient.UseVisualStyleBackColor = true;
            btnTextLastVisitPatient.Click += btnTextVisitPatient_Click;
            // 
            // lblDoctorLastVisitPlaceholder
            // 
            lblDoctorLastVisitPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorLastVisitPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblDoctorLastVisitPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitPlaceholder.Location = new System.Drawing.Point(110, 25);
            lblDoctorLastVisitPlaceholder.Name = "lblDoctorLastVisitPlaceholder";
            lblDoctorLastVisitPlaceholder.Size = new System.Drawing.Size(529, 34);
            lblDoctorLastVisitPlaceholder.TabIndex = 13;
            lblDoctorLastVisitPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblDoctorLastVisitPlaceholder.Visible = false;
            // 
            // lblDoctorLastVisitNotesValue
            // 
            lblDoctorLastVisitNotesValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorLastVisitNotesValue.Location = new System.Drawing.Point(111, 137);
            lblDoctorLastVisitNotesValue.Name = "lblDoctorLastVisitNotesValue";
            lblDoctorLastVisitNotesValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitNotesValue.TabIndex = 12;
            // 
            // lblDoctorLastVisitNotesCaption
            // 
            lblDoctorLastVisitNotesCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitNotesCaption.Location = new System.Drawing.Point(34, 136);
            lblDoctorLastVisitNotesCaption.Name = "lblDoctorLastVisitNotesCaption";
            lblDoctorLastVisitNotesCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitNotesCaption.TabIndex = 11;
            lblDoctorLastVisitNotesCaption.Text = "Notes";
            // 
            // lblDoctorLastVisitReasonValue
            // 
            lblDoctorLastVisitReasonValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorLastVisitReasonValue.Location = new System.Drawing.Point(111, 115);
            lblDoctorLastVisitReasonValue.Name = "lblDoctorLastVisitReasonValue";
            lblDoctorLastVisitReasonValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitReasonValue.TabIndex = 10;
            // 
            // lblDoctorLastVisitReasonCaption
            // 
            lblDoctorLastVisitReasonCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitReasonCaption.Location = new System.Drawing.Point(34, 114);
            lblDoctorLastVisitReasonCaption.Name = "lblDoctorLastVisitReasonCaption";
            lblDoctorLastVisitReasonCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitReasonCaption.TabIndex = 9;
            lblDoctorLastVisitReasonCaption.Text = "Reason";
            // 
            // lblDoctorLastVisitStatusValue
            // 
            lblDoctorLastVisitStatusValue.Location = new System.Drawing.Point(110, 92);
            lblDoctorLastVisitStatusValue.Name = "lblDoctorLastVisitStatusValue";
            lblDoctorLastVisitStatusValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitStatusValue.TabIndex = 8;
            // 
            // lblDoctorLastVisitStatusCaption
            // 
            lblDoctorLastVisitStatusCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitStatusCaption.Location = new System.Drawing.Point(34, 92);
            lblDoctorLastVisitStatusCaption.Name = "lblDoctorLastVisitStatusCaption";
            lblDoctorLastVisitStatusCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitStatusCaption.TabIndex = 7;
            lblDoctorLastVisitStatusCaption.Text = "Status";
            // 
            // lblDoctorLastVisitPatientValue
            // 
            lblDoctorLastVisitPatientValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorLastVisitPatientValue.Location = new System.Drawing.Point(111, 71);
            lblDoctorLastVisitPatientValue.Name = "lblDoctorLastVisitPatientValue";
            lblDoctorLastVisitPatientValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitPatientValue.TabIndex = 6;
            // 
            // lblDoctorLastVisitPatientCaption
            // 
            lblDoctorLastVisitPatientCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitPatientCaption.Location = new System.Drawing.Point(34, 70);
            lblDoctorLastVisitPatientCaption.Name = "lblDoctorLastVisitPatientCaption";
            lblDoctorLastVisitPatientCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitPatientCaption.TabIndex = 5;
            lblDoctorLastVisitPatientCaption.Text = "Patient";
            // 
            // lblDoctorLastVisitTimeValue
            // 
            lblDoctorLastVisitTimeValue.Location = new System.Drawing.Point(110, 48);
            lblDoctorLastVisitTimeValue.Name = "lblDoctorLastVisitTimeValue";
            lblDoctorLastVisitTimeValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitTimeValue.TabIndex = 4;
            // 
            // lblDoctorLastVisitTimeCaption
            // 
            lblDoctorLastVisitTimeCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitTimeCaption.Location = new System.Drawing.Point(34, 48);
            lblDoctorLastVisitTimeCaption.Name = "lblDoctorLastVisitTimeCaption";
            lblDoctorLastVisitTimeCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitTimeCaption.TabIndex = 3;
            lblDoctorLastVisitTimeCaption.Text = "Time";
            // 
            // lblDoctorLastVisitDateValue
            // 
            lblDoctorLastVisitDateValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDoctorLastVisitDateValue.Location = new System.Drawing.Point(111, 27);
            lblDoctorLastVisitDateValue.Name = "lblDoctorLastVisitDateValue";
            lblDoctorLastVisitDateValue.Size = new System.Drawing.Size(521, 20);
            lblDoctorLastVisitDateValue.TabIndex = 2;
            // 
            // lblDoctorLastVisitDateCaption
            // 
            lblDoctorLastVisitDateCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblDoctorLastVisitDateCaption.Location = new System.Drawing.Point(34, 26);
            lblDoctorLastVisitDateCaption.Name = "lblDoctorLastVisitDateCaption";
            lblDoctorLastVisitDateCaption.Size = new System.Drawing.Size(70, 20);
            lblDoctorLastVisitDateCaption.TabIndex = 1;
            lblDoctorLastVisitDateCaption.Text = "Date";
            // 
            // pnlDoctorLastVisitStatus
            // 
            pnlDoctorLastVisitStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlDoctorLastVisitStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            pnlDoctorLastVisitStatus.Location = new System.Drawing.Point(19, 25);
            pnlDoctorLastVisitStatus.Name = "pnlDoctorLastVisitStatus";
            pnlDoctorLastVisitStatus.Size = new System.Drawing.Size(6, 128);
            pnlDoctorLastVisitStatus.TabIndex = 0;
            // 
            // patientCareTab
            // 
            patientCareTab.Controls.Add(grpPatientLatestVitals);
            patientCareTab.Controls.Add(grpPatientNextAppointment);
            patientCareTab.Location = new System.Drawing.Point(4, 24);
            patientCareTab.Margin = new System.Windows.Forms.Padding(4);
            patientCareTab.Name = "patientCareTab";
            patientCareTab.Padding = new System.Windows.Forms.Padding(4);
            patientCareTab.Size = new System.Drawing.Size(1374, 756);
            patientCareTab.TabIndex = 9;
            patientCareTab.Text = "My Care";
            patientCareTab.UseVisualStyleBackColor = true;
            // 
            // grpPatientLatestVitals
            // 
            grpPatientLatestVitals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpPatientLatestVitals.Controls.Add(lblPatientVitalsPlaceholder);
            grpPatientLatestVitals.Controls.Add(lblVitalNotes);
            grpPatientLatestVitals.Controls.Add(pnlVitalUpdated);
            grpPatientLatestVitals.Controls.Add(pnlVitalStatus);
            grpPatientLatestVitals.Controls.Add(pnlVitalTemperature);
            grpPatientLatestVitals.Controls.Add(pnlVitalOxygen);
            grpPatientLatestVitals.Controls.Add(pnlVitalBloodPressure);
            grpPatientLatestVitals.Controls.Add(pnlVitalHeartRate);
            grpPatientLatestVitals.Location = new System.Drawing.Point(24, 230);
            grpPatientLatestVitals.Margin = new System.Windows.Forms.Padding(4);
            grpPatientLatestVitals.Name = "grpPatientLatestVitals";
            grpPatientLatestVitals.Padding = new System.Windows.Forms.Padding(4);
            grpPatientLatestVitals.Size = new System.Drawing.Size(2500, 1136);
            grpPatientLatestVitals.TabIndex = 1;
            grpPatientLatestVitals.TabStop = false;
            grpPatientLatestVitals.Text = "Latest Vitals";
            grpPatientLatestVitals.Enter += grpPatientLatestVitals_Enter;
            // 
            // lblPatientVitalsPlaceholder
            // 
            lblPatientVitalsPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientVitalsPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblPatientVitalsPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientVitalsPlaceholder.Location = new System.Drawing.Point(14, 20);
            lblPatientVitalsPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientVitalsPlaceholder.Name = "lblPatientVitalsPlaceholder";
            lblPatientVitalsPlaceholder.Size = new System.Drawing.Size(430, 28);
            lblPatientVitalsPlaceholder.TabIndex = 0;
            lblPatientVitalsPlaceholder.Text = "No vitals recorded yet.";
            lblPatientVitalsPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblPatientVitalsPlaceholder.Visible = false;
            lblPatientVitalsPlaceholder.Click += lblPatientVitalsPlaceholder_Click;
            // 
            // lblVitalNotes
            // 
            lblVitalNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblVitalNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblVitalNotes.Location = new System.Drawing.Point(472, 52);
            lblVitalNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalNotes.Name = "lblVitalNotes";
            lblVitalNotes.Padding = new System.Windows.Forms.Padding(8);
            lblVitalNotes.Size = new System.Drawing.Size(854, 400);
            lblVitalNotes.TabIndex = 7;
            lblVitalNotes.Text = "Notes: --";
            lblVitalNotes.Click += lblVitalNotes_Click;
            // 
            // pnlVitalUpdated
            // 
            pnlVitalUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlVitalUpdated.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalUpdated.Controls.Add(lblVitalUpdated);
            pnlVitalUpdated.Controls.Add(lblVitalUpdatedCaption);
            pnlVitalUpdated.Location = new System.Drawing.Point(14, 392);
            pnlVitalUpdated.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalUpdated.Name = "pnlVitalUpdated";
            pnlVitalUpdated.Size = new System.Drawing.Size(430, 60);
            pnlVitalUpdated.TabIndex = 6;
            // 
            // lblVitalUpdated
            // 
            lblVitalUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalUpdated.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalUpdated.Location = new System.Drawing.Point(10, 32);
            lblVitalUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalUpdated.Name = "lblVitalUpdated";
            lblVitalUpdated.Size = new System.Drawing.Size(637, 28);
            lblVitalUpdated.TabIndex = 1;
            lblVitalUpdated.Text = "--";
            // 
            // lblVitalUpdatedCaption
            // 
            lblVitalUpdatedCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalUpdatedCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalUpdatedCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalUpdatedCaption.Name = "lblVitalUpdatedCaption";
            lblVitalUpdatedCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalUpdatedCaption.TabIndex = 0;
            lblVitalUpdatedCaption.Text = "Updated";
            // 
            // pnlVitalStatus
            // 
            pnlVitalStatus.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalStatus.Controls.Add(lblVitalStatus);
            pnlVitalStatus.Controls.Add(lblVitalStatusCaption);
            pnlVitalStatus.Location = new System.Drawing.Point(14, 324);
            pnlVitalStatus.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalStatus.Name = "pnlVitalStatus";
            pnlVitalStatus.Size = new System.Drawing.Size(430, 60);
            pnlVitalStatus.TabIndex = 5;
            // 
            // lblVitalStatus
            // 
            lblVitalStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalStatus.Location = new System.Drawing.Point(10, 32);
            lblVitalStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalStatus.Name = "lblVitalStatus";
            lblVitalStatus.Size = new System.Drawing.Size(413, 28);
            lblVitalStatus.TabIndex = 1;
            lblVitalStatus.Text = "--";
            // 
            // lblVitalStatusCaption
            // 
            lblVitalStatusCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalStatusCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalStatusCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalStatusCaption.Name = "lblVitalStatusCaption";
            lblVitalStatusCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalStatusCaption.TabIndex = 0;
            lblVitalStatusCaption.Text = "Status";
            // 
            // pnlVitalTemperature
            // 
            pnlVitalTemperature.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalTemperature.Controls.Add(lblVitalTemperature);
            pnlVitalTemperature.Controls.Add(lblVitalTemperatureCaption);
            pnlVitalTemperature.Location = new System.Drawing.Point(14, 120);
            pnlVitalTemperature.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalTemperature.Name = "pnlVitalTemperature";
            pnlVitalTemperature.Size = new System.Drawing.Size(430, 60);
            pnlVitalTemperature.TabIndex = 4;
            // 
            // lblVitalTemperature
            // 
            lblVitalTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalTemperature.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalTemperature.Location = new System.Drawing.Point(10, 32);
            lblVitalTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalTemperature.Name = "lblVitalTemperature";
            lblVitalTemperature.Size = new System.Drawing.Size(414, 28);
            lblVitalTemperature.TabIndex = 1;
            lblVitalTemperature.Text = "--";
            // 
            // lblVitalTemperatureCaption
            // 
            lblVitalTemperatureCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalTemperatureCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalTemperatureCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalTemperatureCaption.Name = "lblVitalTemperatureCaption";
            lblVitalTemperatureCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalTemperatureCaption.TabIndex = 0;
            lblVitalTemperatureCaption.Text = "Temperature";
            // 
            // pnlVitalOxygen
            // 
            pnlVitalOxygen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlVitalOxygen.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalOxygen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalOxygen.Controls.Add(lblVitalOxygen);
            pnlVitalOxygen.Controls.Add(lblVitalOxygenCaption);
            pnlVitalOxygen.Location = new System.Drawing.Point(14, 256);
            pnlVitalOxygen.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalOxygen.Name = "pnlVitalOxygen";
            pnlVitalOxygen.Size = new System.Drawing.Size(430, 60);
            pnlVitalOxygen.TabIndex = 3;
            // 
            // lblVitalOxygen
            // 
            lblVitalOxygen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalOxygen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalOxygen.Location = new System.Drawing.Point(10, 32);
            lblVitalOxygen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalOxygen.Name = "lblVitalOxygen";
            lblVitalOxygen.Size = new System.Drawing.Size(413, 28);
            lblVitalOxygen.TabIndex = 1;
            lblVitalOxygen.Text = "--";
            // 
            // lblVitalOxygenCaption
            // 
            lblVitalOxygenCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalOxygenCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalOxygenCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalOxygenCaption.Name = "lblVitalOxygenCaption";
            lblVitalOxygenCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalOxygenCaption.TabIndex = 0;
            lblVitalOxygenCaption.Text = "Oxygen";
            // 
            // pnlVitalBloodPressure
            // 
            pnlVitalBloodPressure.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalBloodPressure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalBloodPressure.Controls.Add(lblVitalBloodPressure);
            pnlVitalBloodPressure.Controls.Add(lblVitalBloodPressureCaption);
            pnlVitalBloodPressure.Location = new System.Drawing.Point(14, 188);
            pnlVitalBloodPressure.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalBloodPressure.Name = "pnlVitalBloodPressure";
            pnlVitalBloodPressure.Size = new System.Drawing.Size(430, 60);
            pnlVitalBloodPressure.TabIndex = 2;
            // 
            // lblVitalBloodPressure
            // 
            lblVitalBloodPressure.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalBloodPressure.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalBloodPressure.Location = new System.Drawing.Point(10, 32);
            lblVitalBloodPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalBloodPressure.Name = "lblVitalBloodPressure";
            lblVitalBloodPressure.Size = new System.Drawing.Size(413, 28);
            lblVitalBloodPressure.TabIndex = 1;
            lblVitalBloodPressure.Text = "--";
            // 
            // lblVitalBloodPressureCaption
            // 
            lblVitalBloodPressureCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalBloodPressureCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalBloodPressureCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalBloodPressureCaption.Name = "lblVitalBloodPressureCaption";
            lblVitalBloodPressureCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalBloodPressureCaption.TabIndex = 0;
            lblVitalBloodPressureCaption.Text = "Blood Pressure";
            lblVitalBloodPressureCaption.Click += lblVitalBloodPressureCaption_Click;
            // 
            // pnlVitalHeartRate
            // 
            pnlVitalHeartRate.BackColor = System.Drawing.SystemColors.Window;
            pnlVitalHeartRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlVitalHeartRate.Controls.Add(lblVitalHeartRate);
            pnlVitalHeartRate.Controls.Add(lblVitalHeartRateCaption);
            pnlVitalHeartRate.Location = new System.Drawing.Point(14, 52);
            pnlVitalHeartRate.Margin = new System.Windows.Forms.Padding(4);
            pnlVitalHeartRate.Name = "pnlVitalHeartRate";
            pnlVitalHeartRate.Size = new System.Drawing.Size(430, 60);
            pnlVitalHeartRate.TabIndex = 1;
            // 
            // lblVitalHeartRate
            // 
            lblVitalHeartRate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVitalHeartRate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVitalHeartRate.Location = new System.Drawing.Point(10, 32);
            lblVitalHeartRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalHeartRate.Name = "lblVitalHeartRate";
            lblVitalHeartRate.Size = new System.Drawing.Size(414, 28);
            lblVitalHeartRate.TabIndex = 1;
            lblVitalHeartRate.Text = "--";
            // 
            // lblVitalHeartRateCaption
            // 
            lblVitalHeartRateCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblVitalHeartRateCaption.Location = new System.Drawing.Point(10, 10);
            lblVitalHeartRateCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVitalHeartRateCaption.Name = "lblVitalHeartRateCaption";
            lblVitalHeartRateCaption.Size = new System.Drawing.Size(220, 20);
            lblVitalHeartRateCaption.TabIndex = 0;
            lblVitalHeartRateCaption.Text = "Heart Rate";
            // 
            // grpPatientNextAppointment
            // 
            grpPatientNextAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentPlaceholder);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentNotesValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentNotesCaption);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentReasonValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentReasonCaption);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentStatusValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentStatusCaption);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentDoctorValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentDoctorCaption);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentTimeValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentTimeCaption);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentDateValue);
            grpPatientNextAppointment.Controls.Add(lblPatientAppointmentDateCaption);
            grpPatientNextAppointment.Controls.Add(pnlPatientAppointmentStatus);
            grpPatientNextAppointment.Location = new System.Drawing.Point(20, 20);
            grpPatientNextAppointment.Margin = new System.Windows.Forms.Padding(4);
            grpPatientNextAppointment.Name = "grpPatientNextAppointment";
            grpPatientNextAppointment.Padding = new System.Windows.Forms.Padding(4);
            grpPatientNextAppointment.Size = new System.Drawing.Size(646, 210);
            grpPatientNextAppointment.TabIndex = 0;
            grpPatientNextAppointment.TabStop = false;
            grpPatientNextAppointment.Text = "Next Appointment";
            // 
            // lblPatientAppointmentPlaceholder
            // 
            lblPatientAppointmentPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientAppointmentPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblPatientAppointmentPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentPlaceholder.Location = new System.Drawing.Point(8, 174);
            lblPatientAppointmentPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientAppointmentPlaceholder.Name = "lblPatientAppointmentPlaceholder";
            lblPatientAppointmentPlaceholder.Size = new System.Drawing.Size(527, 32);
            lblPatientAppointmentPlaceholder.TabIndex = 13;
            lblPatientAppointmentPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblPatientAppointmentPlaceholder.Visible = false;
            // 
            // lblPatientAppointmentNotesValue
            // 
            lblPatientAppointmentNotesValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientAppointmentNotesValue.Location = new System.Drawing.Point(121, 137);
            lblPatientAppointmentNotesValue.Name = "lblPatientAppointmentNotesValue";
            lblPatientAppointmentNotesValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentNotesValue.TabIndex = 12;
            // 
            // lblPatientAppointmentNotesCaption
            // 
            lblPatientAppointmentNotesCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentNotesCaption.Location = new System.Drawing.Point(34, 136);
            lblPatientAppointmentNotesCaption.Name = "lblPatientAppointmentNotesCaption";
            lblPatientAppointmentNotesCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentNotesCaption.TabIndex = 11;
            lblPatientAppointmentNotesCaption.Text = "Notes";
            // 
            // lblPatientAppointmentReasonValue
            // 
            lblPatientAppointmentReasonValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientAppointmentReasonValue.Location = new System.Drawing.Point(121, 115);
            lblPatientAppointmentReasonValue.Name = "lblPatientAppointmentReasonValue";
            lblPatientAppointmentReasonValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentReasonValue.TabIndex = 10;
            // 
            // lblPatientAppointmentReasonCaption
            // 
            lblPatientAppointmentReasonCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentReasonCaption.Location = new System.Drawing.Point(34, 114);
            lblPatientAppointmentReasonCaption.Name = "lblPatientAppointmentReasonCaption";
            lblPatientAppointmentReasonCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentReasonCaption.TabIndex = 9;
            lblPatientAppointmentReasonCaption.Text = "Reason";
            // 
            // lblPatientAppointmentStatusValue
            // 
            lblPatientAppointmentStatusValue.Location = new System.Drawing.Point(120, 92);
            lblPatientAppointmentStatusValue.Name = "lblPatientAppointmentStatusValue";
            lblPatientAppointmentStatusValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentStatusValue.TabIndex = 8;
            // 
            // lblPatientAppointmentStatusCaption
            // 
            lblPatientAppointmentStatusCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentStatusCaption.Location = new System.Drawing.Point(34, 92);
            lblPatientAppointmentStatusCaption.Name = "lblPatientAppointmentStatusCaption";
            lblPatientAppointmentStatusCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentStatusCaption.TabIndex = 7;
            lblPatientAppointmentStatusCaption.Text = "Status";
            // 
            // lblPatientAppointmentDoctorValue
            // 
            lblPatientAppointmentDoctorValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientAppointmentDoctorValue.Location = new System.Drawing.Point(121, 71);
            lblPatientAppointmentDoctorValue.Name = "lblPatientAppointmentDoctorValue";
            lblPatientAppointmentDoctorValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentDoctorValue.TabIndex = 6;
            // 
            // lblPatientAppointmentDoctorCaption
            // 
            lblPatientAppointmentDoctorCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentDoctorCaption.Location = new System.Drawing.Point(34, 70);
            lblPatientAppointmentDoctorCaption.Name = "lblPatientAppointmentDoctorCaption";
            lblPatientAppointmentDoctorCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentDoctorCaption.TabIndex = 5;
            lblPatientAppointmentDoctorCaption.Text = "Doctor";
            // 
            // lblPatientAppointmentTimeValue
            // 
            lblPatientAppointmentTimeValue.Location = new System.Drawing.Point(120, 48);
            lblPatientAppointmentTimeValue.Name = "lblPatientAppointmentTimeValue";
            lblPatientAppointmentTimeValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentTimeValue.TabIndex = 4;
            // 
            // lblPatientAppointmentTimeCaption
            // 
            lblPatientAppointmentTimeCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentTimeCaption.Location = new System.Drawing.Point(34, 48);
            lblPatientAppointmentTimeCaption.Name = "lblPatientAppointmentTimeCaption";
            lblPatientAppointmentTimeCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentTimeCaption.TabIndex = 3;
            lblPatientAppointmentTimeCaption.Text = "Time";
            // 
            // lblPatientAppointmentDateValue
            // 
            lblPatientAppointmentDateValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPatientAppointmentDateValue.Location = new System.Drawing.Point(121, 27);
            lblPatientAppointmentDateValue.Name = "lblPatientAppointmentDateValue";
            lblPatientAppointmentDateValue.Size = new System.Drawing.Size(521, 20);
            lblPatientAppointmentDateValue.TabIndex = 2;
            // 
            // lblPatientAppointmentDateCaption
            // 
            lblPatientAppointmentDateCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            lblPatientAppointmentDateCaption.Location = new System.Drawing.Point(34, 26);
            lblPatientAppointmentDateCaption.Name = "lblPatientAppointmentDateCaption";
            lblPatientAppointmentDateCaption.Size = new System.Drawing.Size(70, 20);
            lblPatientAppointmentDateCaption.TabIndex = 1;
            lblPatientAppointmentDateCaption.Text = "Date";
            // 
            // pnlPatientAppointmentStatus
            // 
            pnlPatientAppointmentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlPatientAppointmentStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            pnlPatientAppointmentStatus.Location = new System.Drawing.Point(19, 25);
            pnlPatientAppointmentStatus.Name = "pnlPatientAppointmentStatus";
            pnlPatientAppointmentStatus.Size = new System.Drawing.Size(6, 128);
            pnlPatientAppointmentStatus.TabIndex = 0;
            // 
            // patientsTab
            // 
            patientsTab.Controls.Add(grpPatientDetails);
            patientsTab.Controls.Add(patientGrid);
            patientsTab.Controls.Add(grpPatientSearch);
            patientsTab.Location = new System.Drawing.Point(4, 24);
            patientsTab.Margin = new System.Windows.Forms.Padding(4);
            patientsTab.Name = "patientsTab";
            patientsTab.Padding = new System.Windows.Forms.Padding(4);
            patientsTab.Size = new System.Drawing.Size(1374, 756);
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
            grpPatientDetails.Location = new System.Drawing.Point(970, 111);
            grpPatientDetails.Margin = new System.Windows.Forms.Padding(4);
            grpPatientDetails.Name = "grpPatientDetails";
            grpPatientDetails.Padding = new System.Windows.Forms.Padding(4);
            grpPatientDetails.Size = new System.Drawing.Size(374, 603);
            grpPatientDetails.TabIndex = 2;
            grpPatientDetails.TabStop = false;
            grpPatientDetails.Text = "Add / Edit Patient";
            // 
            // btnClearPatient
            // 
            btnClearPatient.Location = new System.Drawing.Point(196, 540);
            btnClearPatient.Margin = new System.Windows.Forms.Padding(4);
            btnClearPatient.Name = "btnClearPatient";
            btnClearPatient.Size = new System.Drawing.Size(150, 32);
            btnClearPatient.TabIndex = 18;
            btnClearPatient.Text = "Clear Form";
            btnClearPatient.UseVisualStyleBackColor = true;
            btnClearPatient.Click += btnClearPatient_Click;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new System.Drawing.Point(28, 540);
            btnDeletePatient.Margin = new System.Windows.Forms.Padding(4);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new System.Drawing.Size(150, 32);
            btnDeletePatient.TabIndex = 17;
            btnDeletePatient.Text = "Delete Patient";
            btnDeletePatient.UseVisualStyleBackColor = true;
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // btnUpdatePatient
            // 
            btnUpdatePatient.Location = new System.Drawing.Point(196, 499);
            btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4);
            btnUpdatePatient.Name = "btnUpdatePatient";
            btnUpdatePatient.Size = new System.Drawing.Size(150, 32);
            btnUpdatePatient.TabIndex = 16;
            btnUpdatePatient.Text = "Save Changes";
            btnUpdatePatient.UseVisualStyleBackColor = true;
            btnUpdatePatient.Click += btnUpdatePatient_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new System.Drawing.Point(28, 499);
            btnAddPatient.Margin = new System.Windows.Forms.Padding(4);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new System.Drawing.Size(150, 32);
            btnAddPatient.TabIndex = 15;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // chkPatientAdmitted
            // 
            chkPatientAdmitted.AutoSize = true;
            chkPatientAdmitted.Location = new System.Drawing.Point(28, 401);
            chkPatientAdmitted.Margin = new System.Windows.Forms.Padding(4);
            chkPatientAdmitted.Name = "chkPatientAdmitted";
            chkPatientAdmitted.Size = new System.Drawing.Size(128, 19);
            chkPatientAdmitted.TabIndex = 14;
            chkPatientAdmitted.Text = "Currently Admitted";
            chkPatientAdmitted.UseVisualStyleBackColor = true;
            // 
            // cmbPatientDepartment
            // 
            cmbPatientDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatientDepartment.FormattingEnabled = true;
            cmbPatientDepartment.Items.AddRange(new object[] { "Emergency", "General Medicine", "ICU", "Pediatrics", "Surgery", "Radiology" });
            cmbPatientDepartment.Location = new System.Drawing.Point(28, 360);
            cmbPatientDepartment.Margin = new System.Windows.Forms.Padding(4);
            cmbPatientDepartment.Name = "cmbPatientDepartment";
            cmbPatientDepartment.Size = new System.Drawing.Size(316, 23);
            cmbPatientDepartment.TabIndex = 13;
            // 
            // lblPatientDepartment
            // 
            lblPatientDepartment.AutoSize = true;
            lblPatientDepartment.Location = new System.Drawing.Point(28, 341);
            lblPatientDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientDepartment.Name = "lblPatientDepartment";
            lblPatientDepartment.Size = new System.Drawing.Size(70, 15);
            lblPatientDepartment.TabIndex = 12;
            lblPatientDepartment.Text = "Department";
            // 
            // txtPatientNotes
            // 
            txtPatientNotes.Location = new System.Drawing.Point(28, 443);
            txtPatientNotes.Margin = new System.Windows.Forms.Padding(4);
            txtPatientNotes.Multiline = true;
            txtPatientNotes.Name = "txtPatientNotes";
            txtPatientNotes.Size = new System.Drawing.Size(316, 36);
            txtPatientNotes.TabIndex = 11;
            // 
            // lblPatientNotes
            // 
            lblPatientNotes.AutoSize = true;
            lblPatientNotes.Location = new System.Drawing.Point(28, 424);
            lblPatientNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientNotes.Name = "lblPatientNotes";
            lblPatientNotes.Size = new System.Drawing.Size(83, 15);
            lblPatientNotes.TabIndex = 10;
            lblPatientNotes.Text = "Medical Notes";
            // 
            // txtPatientPhone
            // 
            txtPatientPhone.Location = new System.Drawing.Point(28, 304);
            txtPatientPhone.Margin = new System.Windows.Forms.Padding(4);
            txtPatientPhone.Name = "txtPatientPhone";
            txtPatientPhone.Size = new System.Drawing.Size(316, 23);
            txtPatientPhone.TabIndex = 9;
            // 
            // lblPatientPhone
            // 
            lblPatientPhone.AutoSize = true;
            lblPatientPhone.Location = new System.Drawing.Point(28, 286);
            lblPatientPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientPhone.Name = "lblPatientPhone";
            lblPatientPhone.Size = new System.Drawing.Size(88, 15);
            lblPatientPhone.TabIndex = 8;
            lblPatientPhone.Text = "Phone Number";
            // 
            // dtpPatientDob
            // 
            dtpPatientDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPatientDob.Location = new System.Drawing.Point(28, 249);
            dtpPatientDob.Margin = new System.Windows.Forms.Padding(4);
            dtpPatientDob.Name = "dtpPatientDob";
            dtpPatientDob.Size = new System.Drawing.Size(316, 23);
            dtpPatientDob.TabIndex = 7;
            // 
            // lblPatientDob
            // 
            lblPatientDob.AutoSize = true;
            lblPatientDob.Location = new System.Drawing.Point(28, 231);
            lblPatientDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientDob.Name = "lblPatientDob";
            lblPatientDob.Size = new System.Drawing.Size(73, 15);
            lblPatientDob.TabIndex = 6;
            lblPatientDob.Text = "Date of Birth";
            // 
            // cmbPatientGender
            // 
            cmbPatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatientGender.FormattingEnabled = true;
            cmbPatientGender.Items.AddRange(new object[] { "Female", "Male", "Other", "Prefer not to say" });
            cmbPatientGender.Location = new System.Drawing.Point(28, 194);
            cmbPatientGender.Margin = new System.Windows.Forms.Padding(4);
            cmbPatientGender.Name = "cmbPatientGender";
            cmbPatientGender.Size = new System.Drawing.Size(316, 23);
            cmbPatientGender.TabIndex = 5;
            // 
            // lblPatientGender
            // 
            lblPatientGender.AutoSize = true;
            lblPatientGender.Location = new System.Drawing.Point(28, 176);
            lblPatientGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientGender.Name = "lblPatientGender";
            lblPatientGender.Size = new System.Drawing.Size(45, 15);
            lblPatientGender.TabIndex = 4;
            lblPatientGender.Text = "Gender";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new System.Drawing.Point(28, 139);
            txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new System.Drawing.Size(316, 23);
            txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new System.Drawing.Point(28, 120);
            lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new System.Drawing.Size(79, 15);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Patient Name";
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new System.Drawing.Point(28, 83);
            txtPatientId.Margin = new System.Windows.Forms.Padding(4);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.ReadOnly = true;
            txtPatientId.Size = new System.Drawing.Size(316, 23);
            txtPatientId.TabIndex = 1;
            txtPatientId.TabStop = false;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new System.Drawing.Point(28, 64);
            lblPatientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new System.Drawing.Size(95, 15);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Patient ID (Auto)";
            // 
            // patientGrid
            // 
            patientGrid.AllowUserToAddRows = false;
            patientGrid.AllowUserToDeleteRows = false;
            patientGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            patientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { patientIdColumn, patientNameColumn, patientDepartmentColumn, patientStatusColumn, patientDoctorColumn });
            patientGrid.Location = new System.Drawing.Point(28, 111);
            patientGrid.Margin = new System.Windows.Forms.Padding(4);
            patientGrid.Name = "patientGrid";
            patientGrid.ReadOnly = true;
            patientGrid.RowHeadersWidth = 51;
            patientGrid.Size = new System.Drawing.Size(914, 603);
            patientGrid.TabIndex = 1;
            patientGrid.CellContentClick += patientGrid_CellContentClick;
            patientGrid.CellDoubleClick += patientGrid_CellDoubleClick;
            // 
            // patientIdColumn
            // 
            patientIdColumn.HeaderText = "Patient ID";
            patientIdColumn.MinimumWidth = 6;
            patientIdColumn.Name = "patientIdColumn";
            patientIdColumn.ReadOnly = true;
            patientIdColumn.Width = 85;
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
            grpPatientSearch.Location = new System.Drawing.Point(28, 23);
            grpPatientSearch.Margin = new System.Windows.Forms.Padding(4);
            grpPatientSearch.Name = "grpPatientSearch";
            grpPatientSearch.Padding = new System.Windows.Forms.Padding(4);
            grpPatientSearch.Size = new System.Drawing.Size(1316, 69);
            grpPatientSearch.TabIndex = 0;
            grpPatientSearch.TabStop = false;
            grpPatientSearch.Text = "Patient Search";
            // 
            // btnPatientRefresh
            // 
            btnPatientRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPatientRefresh.Location = new System.Drawing.Point(1186, 23);
            btnPatientRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnPatientRefresh.Name = "btnPatientRefresh";
            btnPatientRefresh.Size = new System.Drawing.Size(102, 28);
            btnPatientRefresh.TabIndex = 5;
            btnPatientRefresh.Text = "Refresh List";
            btnPatientRefresh.UseVisualStyleBackColor = true;
            btnPatientRefresh.Click += btnPatientRefresh_Click;
            // 
            // btnPatientSearch
            // 
            btnPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPatientSearch.Location = new System.Drawing.Point(1074, 23);
            btnPatientSearch.Margin = new System.Windows.Forms.Padding(4);
            btnPatientSearch.Name = "btnPatientSearch";
            btnPatientSearch.Size = new System.Drawing.Size(102, 28);
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
            cmbPatientFilter.Location = new System.Drawing.Point(443, 27);
            cmbPatientFilter.Margin = new System.Windows.Forms.Padding(4);
            cmbPatientFilter.Name = "cmbPatientFilter";
            cmbPatientFilter.Size = new System.Drawing.Size(214, 23);
            cmbPatientFilter.TabIndex = 3;
            // 
            // lblPatientFilter
            // 
            lblPatientFilter.AutoSize = true;
            lblPatientFilter.Location = new System.Drawing.Point(402, 30);
            lblPatientFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientFilter.Name = "lblPatientFilter";
            lblPatientFilter.Size = new System.Drawing.Size(33, 15);
            lblPatientFilter.TabIndex = 2;
            lblPatientFilter.Text = "Filter";
            // 
            // txtPatientSearch
            // 
            txtPatientSearch.Location = new System.Drawing.Point(68, 27);
            txtPatientSearch.Margin = new System.Windows.Forms.Padding(4);
            txtPatientSearch.Name = "txtPatientSearch";
            txtPatientSearch.Size = new System.Drawing.Size(326, 23);
            txtPatientSearch.TabIndex = 1;
            // 
            // lblPatientSearch
            // 
            lblPatientSearch.AutoSize = true;
            lblPatientSearch.Location = new System.Drawing.Point(18, 30);
            lblPatientSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientSearch.Name = "lblPatientSearch";
            lblPatientSearch.Size = new System.Drawing.Size(42, 15);
            lblPatientSearch.TabIndex = 0;
            lblPatientSearch.Text = "Search";
            // 
            // appointmentsTab
            // 
            appointmentsTab.Controls.Add(appointmentGrid);
            appointmentsTab.Controls.Add(grpAppointmentDetails);
            appointmentsTab.Location = new System.Drawing.Point(4, 24);
            appointmentsTab.Margin = new System.Windows.Forms.Padding(4);
            appointmentsTab.Name = "appointmentsTab";
            appointmentsTab.Padding = new System.Windows.Forms.Padding(4);
            appointmentsTab.Size = new System.Drawing.Size(1374, 756);
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
            appointmentGrid.Location = new System.Drawing.Point(438, 28);
            appointmentGrid.Margin = new System.Windows.Forms.Padding(4);
            appointmentGrid.Name = "appointmentGrid";
            appointmentGrid.ReadOnly = true;
            appointmentGrid.RowHeadersWidth = 51;
            appointmentGrid.Size = new System.Drawing.Size(906, 650);
            appointmentGrid.TabIndex = 1;
            appointmentGrid.CellDoubleClick += appointmentGrid_CellDoubleClick;
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
            grpAppointmentDetails.Controls.Add(btnClearAppointment);
            grpAppointmentDetails.Controls.Add(btnAppointmentRefresh);
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
            grpAppointmentDetails.Controls.Add(cmbAppointmentPatientPicker);
            grpAppointmentDetails.Controls.Add(lblAppointmentPatient);
            grpAppointmentDetails.Location = new System.Drawing.Point(28, 28);
            grpAppointmentDetails.Margin = new System.Windows.Forms.Padding(4);
            grpAppointmentDetails.Name = "grpAppointmentDetails";
            grpAppointmentDetails.Padding = new System.Windows.Forms.Padding(4);
            grpAppointmentDetails.Size = new System.Drawing.Size(382, 650);
            grpAppointmentDetails.TabIndex = 0;
            grpAppointmentDetails.TabStop = false;
            grpAppointmentDetails.Text = "Add / Edit Appointment";
            // 
            // btnClearAppointment
            // 
            btnClearAppointment.Location = new System.Drawing.Point(38, 539);
            btnClearAppointment.Margin = new System.Windows.Forms.Padding(4);
            btnClearAppointment.Name = "btnClearAppointment";
            btnClearAppointment.Size = new System.Drawing.Size(150, 30);
            btnClearAppointment.TabIndex = 18;
            btnClearAppointment.Text = "Clear Form";
            btnClearAppointment.UseVisualStyleBackColor = true;
            btnClearAppointment.Click += btnClearAppointment_Click;
            // 
            // btnAppointmentRefresh
            // 
            btnAppointmentRefresh.Location = new System.Drawing.Point(204, 539);
            btnAppointmentRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnAppointmentRefresh.Name = "btnAppointmentRefresh";
            btnAppointmentRefresh.Size = new System.Drawing.Size(150, 30);
            btnAppointmentRefresh.TabIndex = 17;
            btnAppointmentRefresh.Text = "Refresh List";
            btnAppointmentRefresh.UseVisualStyleBackColor = true;
            btnAppointmentRefresh.Click += btnAppointmentRefresh_Click;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Location = new System.Drawing.Point(204, 577);
            btnUpdateAppointment.Margin = new System.Windows.Forms.Padding(4);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new System.Drawing.Size(150, 30);
            btnUpdateAppointment.TabIndex = 15;
            btnUpdateAppointment.Text = "Save Changes";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new System.Drawing.Point(38, 577);
            btnAddAppointment.Margin = new System.Windows.Forms.Padding(4);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new System.Drawing.Size(150, 30);
            btnAddAppointment.TabIndex = 14;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // txtAppointmentNotes
            // 
            txtAppointmentNotes.Location = new System.Drawing.Point(38, 434);
            txtAppointmentNotes.Margin = new System.Windows.Forms.Padding(4);
            txtAppointmentNotes.Multiline = true;
            txtAppointmentNotes.Name = "txtAppointmentNotes";
            txtAppointmentNotes.Size = new System.Drawing.Size(316, 82);
            txtAppointmentNotes.TabIndex = 13;
            // 
            // lblAppointmentNotes
            // 
            lblAppointmentNotes.AutoSize = true;
            lblAppointmentNotes.Location = new System.Drawing.Point(38, 416);
            lblAppointmentNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentNotes.Name = "lblAppointmentNotes";
            lblAppointmentNotes.Size = new System.Drawing.Size(38, 15);
            lblAppointmentNotes.TabIndex = 12;
            lblAppointmentNotes.Text = "Notes";
            // 
            // cmbAppointmentStatus
            // 
            cmbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAppointmentStatus.FormattingEnabled = true;
            cmbAppointmentStatus.Items.AddRange(new object[] { "Scheduled", "Checked In", "Completed", "Cancelled", "Rescheduled" });
            cmbAppointmentStatus.Location = new System.Drawing.Point(38, 369);
            cmbAppointmentStatus.Margin = new System.Windows.Forms.Padding(4);
            cmbAppointmentStatus.Name = "cmbAppointmentStatus";
            cmbAppointmentStatus.Size = new System.Drawing.Size(316, 23);
            cmbAppointmentStatus.TabIndex = 11;
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Location = new System.Drawing.Point(38, 351);
            lblAppointmentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new System.Drawing.Size(39, 15);
            lblAppointmentStatus.TabIndex = 10;
            lblAppointmentStatus.Text = "Status";
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new System.Drawing.Point(38, 304);
            dtpAppointmentTime.Margin = new System.Windows.Forms.Padding(4);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.ShowUpDown = true;
            dtpAppointmentTime.Size = new System.Drawing.Size(316, 23);
            dtpAppointmentTime.TabIndex = 9;
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new System.Drawing.Point(38, 286);
            lblAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new System.Drawing.Size(34, 15);
            lblAppointmentTime.TabIndex = 8;
            lblAppointmentTime.Text = "Time";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new System.Drawing.Point(38, 240);
            dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(316, 23);
            dtpAppointmentDate.TabIndex = 7;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new System.Drawing.Point(38, 221);
            lblAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new System.Drawing.Size(31, 15);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "Date";
            // 
            // txtAppointmentReason
            // 
            txtAppointmentReason.Location = new System.Drawing.Point(38, 176);
            txtAppointmentReason.Margin = new System.Windows.Forms.Padding(4);
            txtAppointmentReason.Name = "txtAppointmentReason";
            txtAppointmentReason.Size = new System.Drawing.Size(316, 23);
            txtAppointmentReason.TabIndex = 5;
            // 
            // lblAppointmentReason
            // 
            lblAppointmentReason.AutoSize = true;
            lblAppointmentReason.Location = new System.Drawing.Point(38, 157);
            lblAppointmentReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentReason.Name = "lblAppointmentReason";
            lblAppointmentReason.Size = new System.Drawing.Size(70, 15);
            lblAppointmentReason.TabIndex = 4;
            lblAppointmentReason.Text = "Visit Reason";
            // 
            // cmbAppointmentDoctor
            // 
            cmbAppointmentDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAppointmentDoctor.FormattingEnabled = true;
            cmbAppointmentDoctor.Items.AddRange(new object[] { "Dr. Adams", "Dr. Chen", "Dr. Patel", "Dr. Rivera", "Nurse Station" });
            cmbAppointmentDoctor.Location = new System.Drawing.Point(38, 111);
            cmbAppointmentDoctor.Margin = new System.Windows.Forms.Padding(4);
            cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            cmbAppointmentDoctor.Size = new System.Drawing.Size(316, 23);
            cmbAppointmentDoctor.TabIndex = 3;
            // 
            // lblAppointmentDoctor
            // 
            lblAppointmentDoctor.AutoSize = true;
            lblAppointmentDoctor.Location = new System.Drawing.Point(38, 92);
            lblAppointmentDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentDoctor.Name = "lblAppointmentDoctor";
            lblAppointmentDoctor.Size = new System.Drawing.Size(43, 15);
            lblAppointmentDoctor.TabIndex = 2;
            lblAppointmentDoctor.Text = "Doctor";
            // 
            // cmbAppointmentPatientPicker
            // 
            cmbAppointmentPatientPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAppointmentPatientPicker.FormattingEnabled = true;
            cmbAppointmentPatientPicker.Location = new System.Drawing.Point(38, 46);
            cmbAppointmentPatientPicker.Margin = new System.Windows.Forms.Padding(4);
            cmbAppointmentPatientPicker.Name = "cmbAppointmentPatientPicker";
            cmbAppointmentPatientPicker.Size = new System.Drawing.Size(316, 23);
            cmbAppointmentPatientPicker.TabIndex = 1;
            // 
            // lblAppointmentPatient
            // 
            lblAppointmentPatient.AutoSize = true;
            lblAppointmentPatient.Location = new System.Drawing.Point(38, 28);
            lblAppointmentPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppointmentPatient.Name = "lblAppointmentPatient";
            lblAppointmentPatient.Size = new System.Drawing.Size(79, 15);
            lblAppointmentPatient.TabIndex = 0;
            lblAppointmentPatient.Text = "Patient Name";
            // 
            // inventoryTab
            // 
            inventoryTab.Controls.Add(grpLowStock);
            inventoryTab.Controls.Add(inventoryGrid);
            inventoryTab.Controls.Add(grpInventoryDetails);
            inventoryTab.Location = new System.Drawing.Point(4, 24);
            inventoryTab.Margin = new System.Windows.Forms.Padding(4);
            inventoryTab.Name = "inventoryTab";
            inventoryTab.Padding = new System.Windows.Forms.Padding(4);
            inventoryTab.Size = new System.Drawing.Size(1374, 756);
            inventoryTab.TabIndex = 3;
            inventoryTab.Text = "Inventory";
            inventoryTab.UseVisualStyleBackColor = true;
            // 
            // grpLowStock
            // 
            grpLowStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpLowStock.Controls.Add(lstLowStock);
            grpLowStock.Location = new System.Drawing.Point(438, 529);
            grpLowStock.Margin = new System.Windows.Forms.Padding(4);
            grpLowStock.Name = "grpLowStock";
            grpLowStock.Padding = new System.Windows.Forms.Padding(4);
            grpLowStock.Size = new System.Drawing.Size(906, 184);
            grpLowStock.TabIndex = 2;
            grpLowStock.TabStop = false;
            grpLowStock.Text = "Low Stock Alerts";
            // 
            // lstLowStock
            // 
            lstLowStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstLowStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstLowStock.FormattingEnabled = true;
            lstLowStock.ItemHeight = 21;
            lstLowStock.Items.AddRange(new object[] { "Insulin pens below reorder level", "IV saline bags below reorder level", "Sterile gloves below reorder level" });
            lstLowStock.Location = new System.Drawing.Point(18, 28);
            lstLowStock.Margin = new System.Windows.Forms.Padding(4);
            lstLowStock.Name = "lstLowStock";
            lstLowStock.Size = new System.Drawing.Size(868, 130);
            lstLowStock.TabIndex = 0;
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToDeleteRows = false;
            inventoryGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { inventoryItemColumn, inventoryCategoryColumn, inventoryQuantityColumn, inventoryReorderColumn, inventoryLocationColumn });
            inventoryGrid.Location = new System.Drawing.Point(438, 28);
            inventoryGrid.Margin = new System.Windows.Forms.Padding(4);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.ReadOnly = true;
            inventoryGrid.RowHeadersWidth = 51;
            inventoryGrid.Size = new System.Drawing.Size(906, 483);
            inventoryGrid.TabIndex = 1;
            inventoryGrid.CellDoubleClick += inventoryGrid_CellDoubleClick;
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
            grpInventoryDetails.Location = new System.Drawing.Point(28, 28);
            grpInventoryDetails.Margin = new System.Windows.Forms.Padding(4);
            grpInventoryDetails.Name = "grpInventoryDetails";
            grpInventoryDetails.Padding = new System.Windows.Forms.Padding(4);
            grpInventoryDetails.Size = new System.Drawing.Size(382, 686);
            grpInventoryDetails.TabIndex = 0;
            grpInventoryDetails.TabStop = false;
            grpInventoryDetails.Text = "Add / Edit Inventory Item";
            // 
            // btnInventoryRefresh
            // 
            btnInventoryRefresh.Location = new System.Drawing.Point(206, 471);
            btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnInventoryRefresh.Name = "btnInventoryRefresh";
            btnInventoryRefresh.Size = new System.Drawing.Size(150, 32);
            btnInventoryRefresh.TabIndex = 13;
            btnInventoryRefresh.Text = "Refresh List";
            btnInventoryRefresh.UseVisualStyleBackColor = true;
            btnInventoryRefresh.Click += btnInventoryRefresh_Click;
            // 
            // btnInventoryRemove
            // 
            btnInventoryRemove.Location = new System.Drawing.Point(38, 471);
            btnInventoryRemove.Margin = new System.Windows.Forms.Padding(4);
            btnInventoryRemove.Name = "btnInventoryRemove";
            btnInventoryRemove.Size = new System.Drawing.Size(150, 32);
            btnInventoryRemove.TabIndex = 12;
            btnInventoryRemove.Text = "Remove Item";
            btnInventoryRemove.UseVisualStyleBackColor = true;
            btnInventoryRemove.Click += btnInventoryRemove_Click;
            // 
            // btnInventoryUpdate
            // 
            btnInventoryUpdate.Location = new System.Drawing.Point(206, 429);
            btnInventoryUpdate.Margin = new System.Windows.Forms.Padding(4);
            btnInventoryUpdate.Name = "btnInventoryUpdate";
            btnInventoryUpdate.Size = new System.Drawing.Size(150, 32);
            btnInventoryUpdate.TabIndex = 11;
            btnInventoryUpdate.Text = "Save Stock Changes";
            btnInventoryUpdate.UseVisualStyleBackColor = true;
            btnInventoryUpdate.Click += btnInventoryUpdate_Click;
            // 
            // btnInventoryAdd
            // 
            btnInventoryAdd.Location = new System.Drawing.Point(38, 429);
            btnInventoryAdd.Margin = new System.Windows.Forms.Padding(4);
            btnInventoryAdd.Name = "btnInventoryAdd";
            btnInventoryAdd.Size = new System.Drawing.Size(150, 32);
            btnInventoryAdd.TabIndex = 10;
            btnInventoryAdd.Text = "Add Item";
            btnInventoryAdd.UseVisualStyleBackColor = true;
            btnInventoryAdd.Click += btnInventoryAdd_Click;
            // 
            // numInventoryReorder
            // 
            numInventoryReorder.Location = new System.Drawing.Point(38, 351);
            numInventoryReorder.Margin = new System.Windows.Forms.Padding(4);
            numInventoryReorder.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInventoryReorder.Name = "numInventoryReorder";
            numInventoryReorder.Size = new System.Drawing.Size(318, 23);
            numInventoryReorder.TabIndex = 9;
            // 
            // lblInventoryReorder
            // 
            lblInventoryReorder.AutoSize = true;
            lblInventoryReorder.Location = new System.Drawing.Point(38, 332);
            lblInventoryReorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryReorder.Name = "lblInventoryReorder";
            lblInventoryReorder.Size = new System.Drawing.Size(78, 15);
            lblInventoryReorder.TabIndex = 8;
            lblInventoryReorder.Text = "Reorder Level";
            // 
            // numInventoryQuantity
            // 
            numInventoryQuantity.Location = new System.Drawing.Point(38, 286);
            numInventoryQuantity.Margin = new System.Windows.Forms.Padding(4);
            numInventoryQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInventoryQuantity.Name = "numInventoryQuantity";
            numInventoryQuantity.Size = new System.Drawing.Size(318, 23);
            numInventoryQuantity.TabIndex = 7;
            // 
            // lblInventoryQuantity
            // 
            lblInventoryQuantity.AutoSize = true;
            lblInventoryQuantity.Location = new System.Drawing.Point(38, 268);
            lblInventoryQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryQuantity.Name = "lblInventoryQuantity";
            lblInventoryQuantity.Size = new System.Drawing.Size(53, 15);
            lblInventoryQuantity.TabIndex = 6;
            lblInventoryQuantity.Text = "Quantity";
            // 
            // txtInventoryLocation
            // 
            txtInventoryLocation.Location = new System.Drawing.Point(38, 221);
            txtInventoryLocation.Margin = new System.Windows.Forms.Padding(4);
            txtInventoryLocation.Name = "txtInventoryLocation";
            txtInventoryLocation.Size = new System.Drawing.Size(316, 23);
            txtInventoryLocation.TabIndex = 5;
            // 
            // lblInventoryLocation
            // 
            lblInventoryLocation.AutoSize = true;
            lblInventoryLocation.Location = new System.Drawing.Point(38, 203);
            lblInventoryLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryLocation.Name = "lblInventoryLocation";
            lblInventoryLocation.Size = new System.Drawing.Size(96, 15);
            lblInventoryLocation.TabIndex = 4;
            lblInventoryLocation.Text = "Storage Location";
            // 
            // cmbInventoryCategory
            // 
            cmbInventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbInventoryCategory.FormattingEnabled = true;
            cmbInventoryCategory.Items.AddRange(new object[] { "Medication", "Surgical Supply", "Lab Supply", "General Supply", "Equipment" });
            cmbInventoryCategory.Location = new System.Drawing.Point(38, 157);
            cmbInventoryCategory.Margin = new System.Windows.Forms.Padding(4);
            cmbInventoryCategory.Name = "cmbInventoryCategory";
            cmbInventoryCategory.Size = new System.Drawing.Size(316, 23);
            cmbInventoryCategory.TabIndex = 3;
            // 
            // lblInventoryCategory
            // 
            lblInventoryCategory.AutoSize = true;
            lblInventoryCategory.Location = new System.Drawing.Point(38, 139);
            lblInventoryCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryCategory.Name = "lblInventoryCategory";
            lblInventoryCategory.Size = new System.Drawing.Size(55, 15);
            lblInventoryCategory.TabIndex = 2;
            lblInventoryCategory.Text = "Category";
            // 
            // txtInventoryItem
            // 
            txtInventoryItem.Location = new System.Drawing.Point(38, 92);
            txtInventoryItem.Margin = new System.Windows.Forms.Padding(4);
            txtInventoryItem.Name = "txtInventoryItem";
            txtInventoryItem.Size = new System.Drawing.Size(316, 23);
            txtInventoryItem.TabIndex = 1;
            // 
            // lblInventoryItem
            // 
            lblInventoryItem.AutoSize = true;
            lblInventoryItem.Location = new System.Drawing.Point(38, 74);
            lblInventoryItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryItem.Name = "lblInventoryItem";
            lblInventoryItem.Size = new System.Drawing.Size(66, 15);
            lblInventoryItem.TabIndex = 0;
            lblInventoryItem.Text = "Item Name";
            // 
            // analyticsTab
            // 
            analyticsTab.Controls.Add(reportGrid);
            analyticsTab.Controls.Add(grpReportOutput);
            analyticsTab.Controls.Add(grpAnalyticsSummary);
            analyticsTab.Controls.Add(grpAnalyticsFilters);
            analyticsTab.Location = new System.Drawing.Point(4, 24);
            analyticsTab.Margin = new System.Windows.Forms.Padding(4);
            analyticsTab.Name = "analyticsTab";
            analyticsTab.Padding = new System.Windows.Forms.Padding(4);
            analyticsTab.Size = new System.Drawing.Size(1374, 756);
            analyticsTab.TabIndex = 4;
            analyticsTab.Text = "Reports";
            analyticsTab.UseVisualStyleBackColor = true;
            // 
            // reportGrid
            // 
            reportGrid.AllowUserToAddRows = false;
            reportGrid.AllowUserToDeleteRows = false;
            reportGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { reportMetricColumn, reportCurrentColumn, reportPreviousColumn, reportChangeColumn });
            reportGrid.Location = new System.Drawing.Point(448, 129);
            reportGrid.Margin = new System.Windows.Forms.Padding(4);
            reportGrid.Name = "reportGrid";
            reportGrid.ReadOnly = true;
            reportGrid.RowHeadersWidth = 51;
            reportGrid.Size = new System.Drawing.Size(896, 391);
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
            grpReportOutput.Location = new System.Drawing.Point(28, 539);
            grpReportOutput.Margin = new System.Windows.Forms.Padding(4);
            grpReportOutput.Name = "grpReportOutput";
            grpReportOutput.Padding = new System.Windows.Forms.Padding(4);
            grpReportOutput.Size = new System.Drawing.Size(1316, 176);
            grpReportOutput.TabIndex = 3;
            grpReportOutput.TabStop = false;
            grpReportOutput.Text = "Report Notes";
            // 
            // lstReportOutput
            // 
            lstReportOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstReportOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstReportOutput.FormattingEnabled = true;
            lstReportOutput.ItemHeight = 21;
            lstReportOutput.Items.AddRange(new object[] { "Generated report highlights will appear here.", "Trends for patient visits, common ailments, and medication usage will appear here." });
            lstReportOutput.Location = new System.Drawing.Point(18, 28);
            lstReportOutput.Margin = new System.Windows.Forms.Padding(4);
            lstReportOutput.Name = "lstReportOutput";
            lstReportOutput.Size = new System.Drawing.Size(1278, 109);
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
            grpAnalyticsSummary.Location = new System.Drawing.Point(28, 129);
            grpAnalyticsSummary.Margin = new System.Windows.Forms.Padding(4);
            grpAnalyticsSummary.Name = "grpAnalyticsSummary";
            grpAnalyticsSummary.Padding = new System.Windows.Forms.Padding(4);
            grpAnalyticsSummary.Size = new System.Drawing.Size(392, 388);
            grpAnalyticsSummary.TabIndex = 1;
            grpAnalyticsSummary.TabStop = false;
            grpAnalyticsSummary.Text = "Report Summary";
            // 
            // txtAnalyticsMedicationUsage
            // 
            txtAnalyticsMedicationUsage.Location = new System.Drawing.Point(38, 268);
            txtAnalyticsMedicationUsage.Margin = new System.Windows.Forms.Padding(4);
            txtAnalyticsMedicationUsage.Name = "txtAnalyticsMedicationUsage";
            txtAnalyticsMedicationUsage.ReadOnly = true;
            txtAnalyticsMedicationUsage.Size = new System.Drawing.Size(316, 23);
            txtAnalyticsMedicationUsage.TabIndex = 5;
            txtAnalyticsMedicationUsage.Text = "Antibiotics";
            // 
            // lblAnalyticsMedicationUsage
            // 
            lblAnalyticsMedicationUsage.AutoSize = true;
            lblAnalyticsMedicationUsage.Location = new System.Drawing.Point(38, 249);
            lblAnalyticsMedicationUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsMedicationUsage.Name = "lblAnalyticsMedicationUsage";
            lblAnalyticsMedicationUsage.Size = new System.Drawing.Size(125, 15);
            lblAnalyticsMedicationUsage.TabIndex = 4;
            lblAnalyticsMedicationUsage.Text = "Top Medication Usage";
            // 
            // txtAnalyticsCommonAilment
            // 
            txtAnalyticsCommonAilment.Location = new System.Drawing.Point(38, 176);
            txtAnalyticsCommonAilment.Margin = new System.Windows.Forms.Padding(4);
            txtAnalyticsCommonAilment.Name = "txtAnalyticsCommonAilment";
            txtAnalyticsCommonAilment.ReadOnly = true;
            txtAnalyticsCommonAilment.Size = new System.Drawing.Size(316, 23);
            txtAnalyticsCommonAilment.TabIndex = 3;
            txtAnalyticsCommonAilment.Text = "Respiratory Infection";
            // 
            // lblAnalyticsCommonAilment
            // 
            lblAnalyticsCommonAilment.AutoSize = true;
            lblAnalyticsCommonAilment.Location = new System.Drawing.Point(38, 157);
            lblAnalyticsCommonAilment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsCommonAilment.Name = "lblAnalyticsCommonAilment";
            lblAnalyticsCommonAilment.Size = new System.Drawing.Size(103, 15);
            lblAnalyticsCommonAilment.TabIndex = 2;
            lblAnalyticsCommonAilment.Text = "Common Ailment";
            // 
            // txtAnalyticsVisits
            // 
            txtAnalyticsVisits.Location = new System.Drawing.Point(38, 83);
            txtAnalyticsVisits.Margin = new System.Windows.Forms.Padding(4);
            txtAnalyticsVisits.Name = "txtAnalyticsVisits";
            txtAnalyticsVisits.ReadOnly = true;
            txtAnalyticsVisits.Size = new System.Drawing.Size(316, 23);
            txtAnalyticsVisits.TabIndex = 1;
            txtAnalyticsVisits.Text = "284 visits";
            // 
            // lblAnalyticsVisits
            // 
            lblAnalyticsVisits.AutoSize = true;
            lblAnalyticsVisits.Location = new System.Drawing.Point(38, 64);
            lblAnalyticsVisits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalyticsVisits.Name = "lblAnalyticsVisits";
            lblAnalyticsVisits.Size = new System.Drawing.Size(74, 15);
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
            grpAnalyticsFilters.Location = new System.Drawing.Point(28, 28);
            grpAnalyticsFilters.Margin = new System.Windows.Forms.Padding(4);
            grpAnalyticsFilters.Name = "grpAnalyticsFilters";
            grpAnalyticsFilters.Padding = new System.Windows.Forms.Padding(4);
            grpAnalyticsFilters.Size = new System.Drawing.Size(1316, 83);
            grpAnalyticsFilters.TabIndex = 0;
            grpAnalyticsFilters.TabStop = false;
            grpAnalyticsFilters.Text = "Report Filters";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGenerateReport.Location = new System.Drawing.Point(1138, 32);
            btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new System.Drawing.Size(150, 32);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Run Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Patient Visits", "Common Ailments", "Medication Usage", "Department Load" });
            cmbReportType.Location = new System.Drawing.Point(766, 37);
            cmbReportType.Margin = new System.Windows.Forms.Padding(4);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new System.Drawing.Size(232, 23);
            cmbReportType.TabIndex = 5;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Location = new System.Drawing.Point(682, 41);
            lblReportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new System.Drawing.Size(70, 15);
            lblReportType.TabIndex = 4;
            lblReportType.Text = "Report Type";
            // 
            // dtpReportEnd
            // 
            dtpReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReportEnd.Location = new System.Drawing.Point(420, 37);
            dtpReportEnd.Margin = new System.Windows.Forms.Padding(4);
            dtpReportEnd.Name = "dtpReportEnd";
            dtpReportEnd.Size = new System.Drawing.Size(186, 23);
            dtpReportEnd.TabIndex = 3;
            // 
            // lblReportEnd
            // 
            lblReportEnd.AutoSize = true;
            lblReportEnd.Location = new System.Drawing.Point(336, 41);
            lblReportEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportEnd.Name = "lblReportEnd";
            lblReportEnd.Size = new System.Drawing.Size(54, 15);
            lblReportEnd.TabIndex = 2;
            lblReportEnd.Text = "End Date";
            // 
            // dtpReportStart
            // 
            dtpReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReportStart.Location = new System.Drawing.Point(112, 37);
            dtpReportStart.Margin = new System.Windows.Forms.Padding(4);
            dtpReportStart.Name = "dtpReportStart";
            dtpReportStart.Size = new System.Drawing.Size(186, 23);
            dtpReportStart.TabIndex = 1;
            // 
            // lblReportStart
            // 
            lblReportStart.AutoSize = true;
            lblReportStart.Location = new System.Drawing.Point(18, 41);
            lblReportStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReportStart.Name = "lblReportStart";
            lblReportStart.Size = new System.Drawing.Size(58, 15);
            lblReportStart.TabIndex = 0;
            lblReportStart.Text = "Start Date";
            // 
            // communicationTab
            // 
            communicationTab.Controls.Add(grpMessageHistory);
            communicationTab.Controls.Add(grpConversations);
            communicationTab.Location = new System.Drawing.Point(4, 24);
            communicationTab.Margin = new System.Windows.Forms.Padding(4);
            communicationTab.Name = "communicationTab";
            communicationTab.Padding = new System.Windows.Forms.Padding(4);
            communicationTab.Size = new System.Drawing.Size(1374, 756);
            communicationTab.TabIndex = 5;
            communicationTab.Text = "Messages";
            communicationTab.UseVisualStyleBackColor = true;
            // 
            // grpMessageHistory
            // 
            grpMessageHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMessageHistory.Controls.Add(txtMessageInput);
            grpMessageHistory.Controls.Add(btnSendMessage);
            grpMessageHistory.Controls.Add(messageHistoryFlowPanel);
            grpMessageHistory.Location = new System.Drawing.Point(374, 28);
            grpMessageHistory.Margin = new System.Windows.Forms.Padding(4);
            grpMessageHistory.Name = "grpMessageHistory";
            grpMessageHistory.Padding = new System.Windows.Forms.Padding(4);
            grpMessageHistory.Size = new System.Drawing.Size(970, 686);
            grpMessageHistory.TabIndex = 1;
            grpMessageHistory.TabStop = false;
            grpMessageHistory.Text = "Selected Conversation";
            // 
            // txtMessageInput
            // 
            txtMessageInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMessageInput.Location = new System.Drawing.Point(18, 617);
            txtMessageInput.Margin = new System.Windows.Forms.Padding(4);
            txtMessageInput.Name = "txtMessageInput";
            txtMessageInput.Size = new System.Drawing.Size(802, 23);
            txtMessageInput.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSendMessage.Location = new System.Drawing.Point(840, 612);
            btnSendMessage.Margin = new System.Windows.Forms.Padding(4);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new System.Drawing.Size(102, 32);
            btnSendMessage.TabIndex = 2;
            btnSendMessage.Text = "Send Message";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // messageHistoryFlowPanel
            // 
            messageHistoryFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageHistoryFlowPanel.AutoScroll = true;
            messageHistoryFlowPanel.BackColor = System.Drawing.SystemColors.Window;
            messageHistoryFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            messageHistoryFlowPanel.Location = new System.Drawing.Point(18, 28);
            messageHistoryFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            messageHistoryFlowPanel.Name = "messageHistoryFlowPanel";
            messageHistoryFlowPanel.Padding = new System.Windows.Forms.Padding(8);
            messageHistoryFlowPanel.Size = new System.Drawing.Size(924, 544);
            messageHistoryFlowPanel.TabIndex = 0;
            messageHistoryFlowPanel.WrapContents = false;
            // 
            // grpConversations
            // 
            grpConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            grpConversations.Controls.Add(btnNewConversation);
            grpConversations.Controls.Add(lstConversations);
            grpConversations.Location = new System.Drawing.Point(28, 28);
            grpConversations.Margin = new System.Windows.Forms.Padding(4);
            grpConversations.Name = "grpConversations";
            grpConversations.Padding = new System.Windows.Forms.Padding(4);
            grpConversations.Size = new System.Drawing.Size(318, 686);
            grpConversations.TabIndex = 0;
            grpConversations.TabStop = false;
            grpConversations.Text = "Patient Conversations";
            // 
            // btnNewConversation
            // 
            btnNewConversation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNewConversation.Location = new System.Drawing.Point(18, 612);
            btnNewConversation.Margin = new System.Windows.Forms.Padding(4);
            btnNewConversation.Name = "btnNewConversation";
            btnNewConversation.Size = new System.Drawing.Size(280, 32);
            btnNewConversation.TabIndex = 1;
            btnNewConversation.Text = "Start Patient Chat";
            btnNewConversation.UseVisualStyleBackColor = true;
            btnNewConversation.Click += btnNewConversation_Click;
            // 
            // lstConversations
            // 
            lstConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstConversations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstConversations.FormattingEnabled = true;
            lstConversations.ItemHeight = 17;
            lstConversations.Items.AddRange(new object[] { "Patient chats will appear here." });
            lstConversations.Location = new System.Drawing.Point(18, 28);
            lstConversations.Margin = new System.Windows.Forms.Padding(4);
            lstConversations.Name = "lstConversations";
            lstConversations.Size = new System.Drawing.Size(280, 531);
            lstConversations.TabIndex = 0;
            lstConversations.SelectedIndexChanged += lstConversations_SelectedIndexChanged;
            // 
            // patientMessagesTab
            // 
            patientMessagesTab.Controls.Add(grpPatientMessageHistory);
            patientMessagesTab.Location = new System.Drawing.Point(4, 24);
            patientMessagesTab.Margin = new System.Windows.Forms.Padding(4);
            patientMessagesTab.Name = "patientMessagesTab";
            patientMessagesTab.Padding = new System.Windows.Forms.Padding(4);
            patientMessagesTab.Size = new System.Drawing.Size(1374, 756);
            patientMessagesTab.TabIndex = 6;
            patientMessagesTab.Text = "My Messages";
            patientMessagesTab.UseVisualStyleBackColor = true;
            // 
            // grpPatientMessageHistory
            // 
            grpPatientMessageHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpPatientMessageHistory.Controls.Add(txtPatientMessageInput);
            grpPatientMessageHistory.Controls.Add(btnSendPatientMessage);
            grpPatientMessageHistory.Controls.Add(patientMessageHistoryFlowPanel);
            grpPatientMessageHistory.Location = new System.Drawing.Point(28, 28);
            grpPatientMessageHistory.Margin = new System.Windows.Forms.Padding(4);
            grpPatientMessageHistory.Name = "grpPatientMessageHistory";
            grpPatientMessageHistory.Padding = new System.Windows.Forms.Padding(4);
            grpPatientMessageHistory.Size = new System.Drawing.Size(1316, 686);
            grpPatientMessageHistory.TabIndex = 0;
            grpPatientMessageHistory.TabStop = false;
            grpPatientMessageHistory.Text = "My Patient Chat";
            // 
            // txtPatientMessageInput
            // 
            txtPatientMessageInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPatientMessageInput.Location = new System.Drawing.Point(18, 617);
            txtPatientMessageInput.Margin = new System.Windows.Forms.Padding(4);
            txtPatientMessageInput.Name = "txtPatientMessageInput";
            txtPatientMessageInput.Size = new System.Drawing.Size(1158, 23);
            txtPatientMessageInput.TabIndex = 1;
            // 
            // btnSendPatientMessage
            // 
            btnSendPatientMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSendPatientMessage.Location = new System.Drawing.Point(1196, 612);
            btnSendPatientMessage.Margin = new System.Windows.Forms.Padding(4);
            btnSendPatientMessage.Name = "btnSendPatientMessage";
            btnSendPatientMessage.Size = new System.Drawing.Size(102, 32);
            btnSendPatientMessage.TabIndex = 2;
            btnSendPatientMessage.Text = "Send Message";
            btnSendPatientMessage.UseVisualStyleBackColor = true;
            btnSendPatientMessage.Click += btnSendPatientMessage_Click;
            // 
            // patientMessageHistoryFlowPanel
            // 
            patientMessageHistoryFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            patientMessageHistoryFlowPanel.AutoScroll = true;
            patientMessageHistoryFlowPanel.BackColor = System.Drawing.SystemColors.Window;
            patientMessageHistoryFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            patientMessageHistoryFlowPanel.Location = new System.Drawing.Point(18, 28);
            patientMessageHistoryFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            patientMessageHistoryFlowPanel.Name = "patientMessageHistoryFlowPanel";
            patientMessageHistoryFlowPanel.Padding = new System.Windows.Forms.Padding(8);
            patientMessageHistoryFlowPanel.Size = new System.Drawing.Size(1278, 544);
            patientMessageHistoryFlowPanel.TabIndex = 0;
            patientMessageHistoryFlowPanel.WrapContents = false;
            // 
            // monitoringTab
            // 
            monitoringTab.Controls.Add(grpMonitoringAlerts);
            monitoringTab.Controls.Add(grpVitalsEntry);
            monitoringTab.Controls.Add(vitalsGrid);
            monitoringTab.Location = new System.Drawing.Point(4, 24);
            monitoringTab.Margin = new System.Windows.Forms.Padding(4);
            monitoringTab.Name = "monitoringTab";
            monitoringTab.Padding = new System.Windows.Forms.Padding(4);
            monitoringTab.Size = new System.Drawing.Size(1374, 756);
            monitoringTab.TabIndex = 8;
            monitoringTab.Text = "Vitals";
            monitoringTab.UseVisualStyleBackColor = true;
            // 
            // grpMonitoringAlerts
            // 
            grpMonitoringAlerts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMonitoringAlerts.Controls.Add(lstMonitoringAlerts);
            grpMonitoringAlerts.Location = new System.Drawing.Point(28, 542);
            grpMonitoringAlerts.Margin = new System.Windows.Forms.Padding(4);
            grpMonitoringAlerts.Name = "grpMonitoringAlerts";
            grpMonitoringAlerts.Padding = new System.Windows.Forms.Padding(4);
            grpMonitoringAlerts.Size = new System.Drawing.Size(934, 176);
            grpMonitoringAlerts.TabIndex = 1;
            grpMonitoringAlerts.TabStop = false;
            grpMonitoringAlerts.Text = "Critical Care Alerts";
            // 
            // lstMonitoringAlerts
            // 
            lstMonitoringAlerts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstMonitoringAlerts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstMonitoringAlerts.FormattingEnabled = true;
            lstMonitoringAlerts.ItemHeight = 21;
            lstMonitoringAlerts.Items.AddRange(new object[] { "Vitals outside normal range will appear here.", "Critical care patient updates will appear here." });
            lstMonitoringAlerts.Location = new System.Drawing.Point(18, 28);
            lstMonitoringAlerts.Margin = new System.Windows.Forms.Padding(4);
            lstMonitoringAlerts.Name = "lstMonitoringAlerts";
            lstMonitoringAlerts.Size = new System.Drawing.Size(896, 109);
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
            grpVitalsEntry.Controls.Add(cmbMonitoringPatientPicker);
            grpVitalsEntry.Controls.Add(lblMonitoringPatient);
            grpVitalsEntry.Location = new System.Drawing.Point(990, 28);
            grpVitalsEntry.Margin = new System.Windows.Forms.Padding(4);
            grpVitalsEntry.Name = "grpVitalsEntry";
            grpVitalsEntry.Padding = new System.Windows.Forms.Padding(4);
            grpVitalsEntry.Size = new System.Drawing.Size(354, 689);
            grpVitalsEntry.TabIndex = 2;
            grpVitalsEntry.TabStop = false;
            grpVitalsEntry.Text = "Update Patient Vitals";
            // 
            // btnMonitoringRefresh
            // 
            btnMonitoringRefresh.Location = new System.Drawing.Point(186, 544);
            btnMonitoringRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnMonitoringRefresh.Name = "btnMonitoringRefresh";
            btnMonitoringRefresh.Size = new System.Drawing.Size(140, 32);
            btnMonitoringRefresh.TabIndex = 13;
            btnMonitoringRefresh.Text = "Refresh List";
            btnMonitoringRefresh.UseVisualStyleBackColor = true;
            btnMonitoringRefresh.Click += btnMonitoringRefresh_Click;
            // 
            // btnUpdateVitals
            // 
            btnUpdateVitals.Location = new System.Drawing.Point(28, 544);
            btnUpdateVitals.Margin = new System.Windows.Forms.Padding(4);
            btnUpdateVitals.Name = "btnUpdateVitals";
            btnUpdateVitals.Size = new System.Drawing.Size(140, 32);
            btnUpdateVitals.TabIndex = 12;
            btnUpdateVitals.Text = "Save Vitals";
            btnUpdateVitals.UseVisualStyleBackColor = true;
            btnUpdateVitals.Click += btnUpdateVitals_Click;
            // 
            // txtMonitoringNotes
            // 
            txtMonitoringNotes.Location = new System.Drawing.Point(28, 406);
            txtMonitoringNotes.Margin = new System.Windows.Forms.Padding(4);
            txtMonitoringNotes.Multiline = true;
            txtMonitoringNotes.Name = "txtMonitoringNotes";
            txtMonitoringNotes.Size = new System.Drawing.Size(298, 101);
            txtMonitoringNotes.TabIndex = 11;
            // 
            // lblMonitoringNotes
            // 
            lblMonitoringNotes.AutoSize = true;
            lblMonitoringNotes.Location = new System.Drawing.Point(28, 388);
            lblMonitoringNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMonitoringNotes.Name = "lblMonitoringNotes";
            lblMonitoringNotes.Size = new System.Drawing.Size(101, 15);
            lblMonitoringNotes.TabIndex = 10;
            lblMonitoringNotes.Text = "Monitoring Notes";
            // 
            // numOxygenLevel
            // 
            numOxygenLevel.Location = new System.Drawing.Point(28, 341);
            numOxygenLevel.Margin = new System.Windows.Forms.Padding(4);
            numOxygenLevel.Name = "numOxygenLevel";
            numOxygenLevel.Size = new System.Drawing.Size(298, 23);
            numOxygenLevel.TabIndex = 9;
            // 
            // lblOxygenLevel
            // 
            lblOxygenLevel.AutoSize = true;
            lblOxygenLevel.Location = new System.Drawing.Point(28, 323);
            lblOxygenLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOxygenLevel.Name = "lblOxygenLevel";
            lblOxygenLevel.Size = new System.Drawing.Size(98, 15);
            lblOxygenLevel.TabIndex = 8;
            lblOxygenLevel.Text = "Oxygen Level (%)";
            // 
            // numTemperature
            // 
            numTemperature.DecimalPlaces = 1;
            numTemperature.Location = new System.Drawing.Point(28, 277);
            numTemperature.Margin = new System.Windows.Forms.Padding(4);
            numTemperature.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numTemperature.Name = "numTemperature";
            numTemperature.Size = new System.Drawing.Size(298, 23);
            numTemperature.TabIndex = 7;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new System.Drawing.Point(28, 259);
            lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new System.Drawing.Size(91, 15);
            lblTemperature.TabIndex = 6;
            lblTemperature.Text = "Temperature (F)";
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.Location = new System.Drawing.Point(28, 212);
            txtBloodPressure.Margin = new System.Windows.Forms.Padding(4);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new System.Drawing.Size(298, 23);
            txtBloodPressure.TabIndex = 5;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Location = new System.Drawing.Point(28, 194);
            lblBloodPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new System.Drawing.Size(85, 15);
            lblBloodPressure.TabIndex = 4;
            lblBloodPressure.Text = "Blood Pressure";
            // 
            // numHeartRate
            // 
            numHeartRate.Location = new System.Drawing.Point(28, 148);
            numHeartRate.Margin = new System.Windows.Forms.Padding(4);
            numHeartRate.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeartRate.Name = "numHeartRate";
            numHeartRate.Size = new System.Drawing.Size(298, 23);
            numHeartRate.TabIndex = 3;
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Location = new System.Drawing.Point(28, 129);
            lblHeartRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new System.Drawing.Size(98, 15);
            lblHeartRate.TabIndex = 2;
            lblHeartRate.Text = "Heart Rate (bpm)";
            // 
            // cmbMonitoringPatientPicker
            // 
            cmbMonitoringPatientPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMonitoringPatientPicker.FormattingEnabled = true;
            cmbMonitoringPatientPicker.Location = new System.Drawing.Point(28, 83);
            cmbMonitoringPatientPicker.Margin = new System.Windows.Forms.Padding(4);
            cmbMonitoringPatientPicker.Name = "cmbMonitoringPatientPicker";
            cmbMonitoringPatientPicker.Size = new System.Drawing.Size(298, 23);
            cmbMonitoringPatientPicker.TabIndex = 1;
            // 
            // lblMonitoringPatient
            // 
            lblMonitoringPatient.AutoSize = true;
            lblMonitoringPatient.Location = new System.Drawing.Point(28, 64);
            lblMonitoringPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMonitoringPatient.Name = "lblMonitoringPatient";
            lblMonitoringPatient.Size = new System.Drawing.Size(79, 15);
            lblMonitoringPatient.TabIndex = 0;
            lblMonitoringPatient.Text = "Patient Name";
            // 
            // vitalsGrid
            // 
            vitalsGrid.AllowUserToAddRows = false;
            vitalsGrid.AllowUserToDeleteRows = false;
            vitalsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            vitalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vitalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { vitalsPatientColumn, vitalsRoomColumn, vitalsHeartRateColumn, vitalsBloodPressureColumn, vitalsOxygenColumn, vitalsStatusColumn });
            vitalsGrid.Location = new System.Drawing.Point(28, 28);
            vitalsGrid.Margin = new System.Windows.Forms.Padding(4);
            vitalsGrid.Name = "vitalsGrid";
            vitalsGrid.ReadOnly = true;
            vitalsGrid.RowHeadersWidth = 51;
            vitalsGrid.Size = new System.Drawing.Size(934, 495);
            vitalsGrid.TabIndex = 0;
            vitalsGrid.CellDoubleClick += vitalsGrid_CellDoubleClick;
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1382, 878);
            Controls.Add(mainTabs);
            Controls.Add(statusStrip);
            Controls.Add(headerPanel);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(1163, 741);
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
            ((System.ComponentModel.ISupportInitialize)currentAlertsGrid).EndInit();
            grpBedStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bedStatusGrid).EndInit();
            grpQuickCounts.ResumeLayout(false);
            grpQuickCounts.PerformLayout();
            doctorVisitsTab.ResumeLayout(false);
            grpDoctorTodayVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doctorVisitsGrid).EndInit();
            grpDoctorTodayVisit.ResumeLayout(false);
            grpDoctorLastVisit.ResumeLayout(false);
            patientCareTab.ResumeLayout(false);
            grpPatientLatestVitals.ResumeLayout(false);
            pnlVitalUpdated.ResumeLayout(false);
            pnlVitalStatus.ResumeLayout(false);
            pnlVitalTemperature.ResumeLayout(false);
            pnlVitalOxygen.ResumeLayout(false);
            pnlVitalBloodPressure.ResumeLayout(false);
            pnlVitalHeartRate.ResumeLayout(false);
            grpPatientNextAppointment.ResumeLayout(false);
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
            grpMessageHistory.ResumeLayout(false);
            grpMessageHistory.PerformLayout();
            grpConversations.ResumeLayout(false);
            patientMessagesTab.ResumeLayout(false);
            grpPatientMessageHistory.ResumeLayout(false);
            grpPatientMessageHistory.PerformLayout();
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
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusText;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.GroupBox grpCriticalStatus;
        private System.Windows.Forms.DataGridView currentAlertsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertSubjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertDetailsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertUpdatedColumn;
        private System.Windows.Forms.GroupBox grpBedStatus;
        private System.Windows.Forms.DataGridView bedStatusGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedOpenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedUpdatedColumn;
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
        private System.Windows.Forms.TabPage patientCareTab;
        private System.Windows.Forms.GroupBox grpPatientLatestVitals;
        private System.Windows.Forms.Label lblPatientVitalsPlaceholder;
        private System.Windows.Forms.Label lblVitalNotes;
        private System.Windows.Forms.Panel pnlVitalUpdated;
        private System.Windows.Forms.Label lblVitalUpdated;
        private System.Windows.Forms.Label lblVitalUpdatedCaption;
        private System.Windows.Forms.Panel pnlVitalStatus;
        private System.Windows.Forms.Label lblVitalStatus;
        private System.Windows.Forms.Label lblVitalStatusCaption;
        private System.Windows.Forms.Panel pnlVitalTemperature;
        private System.Windows.Forms.Label lblVitalTemperature;
        private System.Windows.Forms.Label lblVitalTemperatureCaption;
        private System.Windows.Forms.Panel pnlVitalOxygen;
        private System.Windows.Forms.Label lblVitalOxygen;
        private System.Windows.Forms.Label lblVitalOxygenCaption;
        private System.Windows.Forms.Panel pnlVitalBloodPressure;
        private System.Windows.Forms.Label lblVitalBloodPressure;
        private System.Windows.Forms.Label lblVitalBloodPressureCaption;
        private System.Windows.Forms.Panel pnlVitalHeartRate;
        private System.Windows.Forms.Label lblVitalHeartRate;
        private System.Windows.Forms.Label lblVitalHeartRateCaption;
        private System.Windows.Forms.GroupBox grpPatientNextAppointment;
        private System.Windows.Forms.Label lblPatientAppointmentPlaceholder;
        private System.Windows.Forms.Label lblPatientAppointmentNotesValue;
        private System.Windows.Forms.Label lblPatientAppointmentNotesCaption;
        private System.Windows.Forms.Label lblPatientAppointmentReasonValue;
        private System.Windows.Forms.Label lblPatientAppointmentReasonCaption;
        private System.Windows.Forms.Label lblPatientAppointmentStatusValue;
        private System.Windows.Forms.Label lblPatientAppointmentStatusCaption;
        private System.Windows.Forms.Label lblPatientAppointmentDoctorValue;
        private System.Windows.Forms.Label lblPatientAppointmentDoctorCaption;
        private System.Windows.Forms.Label lblPatientAppointmentTimeValue;
        private System.Windows.Forms.Label lblPatientAppointmentTimeCaption;
        private System.Windows.Forms.Label lblPatientAppointmentDateValue;
        private System.Windows.Forms.Label lblPatientAppointmentDateCaption;
        private System.Windows.Forms.Panel pnlPatientAppointmentStatus;
        private System.Windows.Forms.TabPage doctorVisitsTab;
        private System.Windows.Forms.GroupBox grpDoctorTodayVisits;
        private System.Windows.Forms.DataGridView doctorVisitsGrid;
        private System.Windows.Forms.GroupBox grpDoctorTodayVisit;
        private System.Windows.Forms.Button btnTextNextVisitPatient;
        private System.Windows.Forms.Label lblDoctorTodayVisitPlaceholder;
        private System.Windows.Forms.Label lblDoctorTodayVisitNotesValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitNotesCaption;
        private System.Windows.Forms.Label lblDoctorTodayVisitReasonValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitReasonCaption;
        private System.Windows.Forms.Label lblDoctorTodayVisitStatusValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitStatusCaption;
        private System.Windows.Forms.Label lblDoctorTodayVisitPatientValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitPatientCaption;
        private System.Windows.Forms.Label lblDoctorTodayVisitTimeValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitTimeCaption;
        private System.Windows.Forms.Label lblDoctorTodayVisitDateValue;
        private System.Windows.Forms.Label lblDoctorTodayVisitDateCaption;
        private System.Windows.Forms.Panel pnlDoctorTodayVisitStatus;
        private System.Windows.Forms.GroupBox grpDoctorLastVisit;
        private System.Windows.Forms.Button btnTextLastVisitPatient;
        private System.Windows.Forms.Label lblDoctorLastVisitPlaceholder;
        private System.Windows.Forms.Label lblDoctorLastVisitNotesValue;
        private System.Windows.Forms.Label lblDoctorLastVisitNotesCaption;
        private System.Windows.Forms.Label lblDoctorLastVisitReasonValue;
        private System.Windows.Forms.Label lblDoctorLastVisitReasonCaption;
        private System.Windows.Forms.Label lblDoctorLastVisitStatusValue;
        private System.Windows.Forms.Label lblDoctorLastVisitStatusCaption;
        private System.Windows.Forms.Label lblDoctorLastVisitPatientValue;
        private System.Windows.Forms.Label lblDoctorLastVisitPatientCaption;
        private System.Windows.Forms.Label lblDoctorLastVisitTimeValue;
        private System.Windows.Forms.Label lblDoctorLastVisitTimeCaption;
        private System.Windows.Forms.Label lblDoctorLastVisitDateValue;
        private System.Windows.Forms.Label lblDoctorLastVisitDateCaption;
        private System.Windows.Forms.Panel pnlDoctorLastVisitStatus;
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
        private System.Windows.Forms.Button btnClearAppointment;
        private System.Windows.Forms.Button btnAppointmentRefresh;
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
        private System.Windows.Forms.ComboBox cmbAppointmentPatientPicker;
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
        private System.Windows.Forms.GroupBox grpMessageHistory;
        private System.Windows.Forms.TextBox txtMessageInput;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.FlowLayoutPanel messageHistoryFlowPanel;
        private System.Windows.Forms.GroupBox grpConversations;
        private System.Windows.Forms.Button btnNewConversation;
        private System.Windows.Forms.ListBox lstConversations;
        private System.Windows.Forms.TabPage patientMessagesTab;
        private System.Windows.Forms.GroupBox grpPatientMessageHistory;
        private System.Windows.Forms.TextBox txtPatientMessageInput;
        private System.Windows.Forms.Button btnSendPatientMessage;
        private System.Windows.Forms.FlowLayoutPanel patientMessageHistoryFlowPanel;
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
        private System.Windows.Forms.ComboBox cmbMonitoringPatientPicker;
        private System.Windows.Forms.Label lblMonitoringPatient;
        private System.Windows.Forms.DataGridView vitalsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsPatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsRoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsHeartRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsBloodPressureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsOxygenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitalsStatusColumn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDoctorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorVisitTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorVisitPatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorVisitStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorVisitReasonColumn;
    }
}
