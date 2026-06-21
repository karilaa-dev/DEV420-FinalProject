using System;

namespace HospitalManagement.Client
{
    internal class NotificationDisplayItem
    {
        public NotificationDisplayItem(string title, string message, DateTime createdAt)
        {
            Title = String.IsNullOrWhiteSpace(title) ? "Notification" : title.Trim();
            Message = String.IsNullOrWhiteSpace(message) ? "" : message.Trim();
            CreatedAt = createdAt;
        }

        public string Title { get; }
        public string Message { get; }
        public DateTime CreatedAt { get; }
    }
}
