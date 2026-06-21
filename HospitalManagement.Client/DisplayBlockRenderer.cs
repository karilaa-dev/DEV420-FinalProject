using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagement.Client
{
    internal static class DisplayBlockRenderer
    {
        internal static void ConfigureFlowPanel(FlowLayoutPanel flowPanel)
        {
            if (flowPanel == null)
            {
                return;
            }

            flowPanel.AutoScroll = true;
            flowPanel.BackColor = SystemColors.Window;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Padding = new Padding(8);
            flowPanel.WrapContents = false;
        }

        internal static void ClearBlocks(FlowLayoutPanel flowPanel)
        {
            if (flowPanel == null)
            {
                return;
            }

            while (flowPanel.Controls.Count > 0)
            {
                Control control = flowPanel.Controls[0];
                flowPanel.Controls.RemoveAt(0);
                control.Dispose();
            }
        }

        internal static Control CreateEmptyBlock(string text, int blockWidth)
        {
            Label emptyLabel = new Label();
            emptyLabel.AutoSize = false;
            emptyLabel.Text = text;
            emptyLabel.TextAlign = ContentAlignment.MiddleLeft;
            emptyLabel.Margin = new Padding(0, 0, 0, 6);
            emptyLabel.Size = new Size(blockWidth, 32);
            return emptyLabel;
        }

        internal static Control CreateTextBlock(string title, string timeText, string message, Font baseFont, int blockWidth, bool highlight = false)
        {
            int contentWidth = blockWidth - 18;
            int messageHeight = GetMessageHeight(message, baseFont, contentWidth);
            Color backColor = highlight ? Color.AliceBlue : SystemColors.Window;

            Panel blockPanel = new Panel();
            blockPanel.BackColor = backColor;
            blockPanel.BorderStyle = BorderStyle.FixedSingle;
            blockPanel.Margin = new Padding(0, 0, 0, 6);
            blockPanel.Padding = new Padding(8);
            blockPanel.Size = new Size(blockWidth, 57 + messageHeight);

            Label titleLabel = new Label();
            titleLabel.AutoSize = false;
            titleLabel.BackColor = backColor;
            titleLabel.Font = new Font(baseFont, FontStyle.Bold);
            titleLabel.Location = new Point(8, 7);
            titleLabel.Size = new Size(contentWidth, 20);
            titleLabel.Text = title;

            Label timeLabel = new Label();
            timeLabel.AutoSize = false;
            timeLabel.BackColor = backColor;
            timeLabel.ForeColor = SystemColors.GrayText;
            timeLabel.Location = new Point(8, 27);
            timeLabel.Size = new Size(contentWidth, 18);
            timeLabel.Text = timeText;

            Label messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.BackColor = backColor;
            messageLabel.Location = new Point(8, 49);
            messageLabel.Size = new Size(contentWidth, messageHeight);
            messageLabel.Text = message;

            blockPanel.Controls.Add(titleLabel);
            blockPanel.Controls.Add(timeLabel);
            blockPanel.Controls.Add(messageLabel);

            return blockPanel;
        }

        internal static int GetBlockWidth(FlowLayoutPanel flowPanel)
        {
            if (flowPanel == null)
            {
                return 320;
            }

            return Math.Max(320, flowPanel.ClientSize.Width - flowPanel.Padding.Horizontal - 20);
        }

        internal static string FormatRecentTime(DateTime createdAt)
        {
            TimeSpan age = DateTime.Now - createdAt;

            if (age < TimeSpan.Zero)
            {
                age = TimeSpan.Zero;
            }

            if (age < TimeSpan.FromDays(1))
            {
                return FormatRelativeTime(age) + " (" + createdAt.ToString("g") + ")";
            }

            return createdAt.ToString("g");
        }

        private static int GetMessageHeight(string message, Font font, int width)
        {
            Size proposedSize = new Size(Math.Max(80, width), Int32.MaxValue);
            Size measuredSize = TextRenderer.MeasureText(
                String.IsNullOrWhiteSpace(message) ? " " : message,
                font,
                proposedSize,
                TextFormatFlags.WordBreak);

            return Math.Max(22, measuredSize.Height + 2);
        }

        private static string FormatRelativeTime(TimeSpan age)
        {
            if (age.TotalMinutes < 1)
            {
                return "Just now";
            }

            if (age.TotalMinutes < 60)
            {
                int minutes = Math.Max(1, (int)Math.Floor(age.TotalMinutes));
                return minutes == 1 ? "1 minute ago" : minutes.ToString() + " minutes ago";
            }

            int hours = Math.Max(1, (int)Math.Floor(age.TotalHours));
            return hours == 1 ? "1 hour ago" : hours.ToString() + " hours ago";
        }
    }
}
