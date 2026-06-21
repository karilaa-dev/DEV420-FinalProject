using System;
using System.Collections.Generic;

namespace HospitalManagement.Client
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string PatientUserId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public bool IsAdmitted { get; set; }
        public string Notes { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<PatientVitals> PatientVitals { get; set; } = new List<PatientVitals>();
        public ChatConversation ChatConversation { get; set; }
    }

    internal class DoctorProfile
    {
        public int DoctorProfileId { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }

    internal class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorProfileId { get; set; }
        public string VisitReason { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AppointmentStatus { get; set; }
        public bool CompletionMessageSent { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }

        public Patient Patient { get; set; }
        public DoctorProfile DoctorProfile { get; set; }
    }

    internal class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public string StorageLocation { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    }

    internal class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        public int? InventoryItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int QuantityChange { get; set; }
        public string TransactionReason { get; set; }
        public DateTime CreatedAt { get; set; }

        public InventoryItem InventoryItem { get; set; }
    }

    internal class ChatConversation
    {
        public int ChatConversationId { get; set; }
        public string ConversationName { get; set; }
        public int PatientId { get; set; }
        public string ConversationType { get; set; }
        public DateTime CreatedAt { get; set; }

        public Patient Patient { get; set; }
        public ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();
    }

    internal class ChatMessage
    {
        public int ChatMessageId { get; set; }
        public int ChatConversationId { get; set; }
        public string SenderName { get; set; }
        public string SenderRole { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedAt { get; set; }

        public ChatConversation ChatConversation { get; set; }
    }

    internal class PatientVitals
    {
        public int PatientVitalsId { get; set; }
        public int PatientId { get; set; }
        public int HeartRate { get; set; }
        public string BloodPressure { get; set; }
        public int OxygenLevel { get; set; }
        public decimal Temperature { get; set; }
        public string VitalsStatus { get; set; }
        public string Notes { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Patient Patient { get; set; }
    }

    internal class SystemNotification
    {
        public int SystemNotificationId { get; set; }
        public string NotificationType { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
