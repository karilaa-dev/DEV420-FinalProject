using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalManagement.Client
{
    public partial class Notifications : Form
    {
        private readonly List<NotificationDisplayItem> currentNotifications = new List<NotificationDisplayItem>();

        public Notifications()
        {
            InitializeComponent();
            Icon = SystemIcons.Information;
            DisplayBlockRenderer.ConfigureFlowPanel(notificationsFlowPanel);
            notificationsFlowPanel.Resize += notificationsFlowPanel_Resize;
            SetNotifications(Enumerable.Empty<NotificationDisplayItem>());
        }

        internal void SetNotifications(IEnumerable<NotificationDisplayItem> notifications)
        {
            currentNotifications.Clear();
            currentNotifications.AddRange(notifications.Where(notification => notification != null));
            RenderNotifications();
        }

        private void notificationsFlowPanel_Resize(object sender, EventArgs e)
        {
            RenderNotifications();
        }

        private void RenderNotifications()
        {
            notificationsFlowPanel.SuspendLayout();
            DisplayBlockRenderer.ClearBlocks(notificationsFlowPanel);

            if (currentNotifications.Count == 0)
            {
                notificationsFlowPanel.Controls.Add(
                    DisplayBlockRenderer.CreateEmptyBlock(
                        "No notifications recorded yet.",
                        DisplayBlockRenderer.GetBlockWidth(notificationsFlowPanel)));
            }
            else
            {
                foreach (NotificationDisplayItem notification in currentNotifications)
                {
                    notificationsFlowPanel.Controls.Add(
                        DisplayBlockRenderer.CreateTextBlock(
                            notification.Title,
                            DisplayBlockRenderer.FormatRecentTime(notification.CreatedAt),
                            notification.Message,
                            Font,
                            DisplayBlockRenderer.GetBlockWidth(notificationsFlowPanel)));
                }
            }

            notificationsFlowPanel.ResumeLayout();
        }
    }
}
