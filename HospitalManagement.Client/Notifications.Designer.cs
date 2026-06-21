namespace HospitalManagement.Client
{
    partial class Notifications
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
            notificationsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // notificationsFlowPanel
            // 
            notificationsFlowPanel.AutoScroll = true;
            notificationsFlowPanel.BackColor = System.Drawing.SystemColors.Window;
            notificationsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            notificationsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            notificationsFlowPanel.Location = new System.Drawing.Point(0, 0);
            notificationsFlowPanel.Name = "notificationsFlowPanel";
            notificationsFlowPanel.Padding = new System.Windows.Forms.Padding(8);
            notificationsFlowPanel.Size = new System.Drawing.Size(800, 450);
            notificationsFlowPanel.TabIndex = 0;
            notificationsFlowPanel.WrapContents = false;
            // 
            // Notifications
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(notificationsFlowPanel);
            MinimumSize = new System.Drawing.Size(480, 320);
            Name = "Notifications";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Notifications";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notificationsFlowPanel;
    }
}
