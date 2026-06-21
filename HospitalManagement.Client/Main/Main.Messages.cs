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
    public partial class Main
    {
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

        private string GetPatientName(HospitalDbContext db, int patientId)
        {
            return db.Patients
                .Where(patient => patient.PatientId == patientId)
                .Select(patient => patient.Name)
                .FirstOrDefault() ?? "";
        }

        private string NormalizePatientConversationName(string patientName)
        {
            return "Patient: " + patientName.Trim();
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
                await SendNotificationAsync("Chat", "Conversation available: " + conversationName + ".", conversationName);
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
    }
}
