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
        private void SetupPatientMessagesTab()
        {
            patientMessageDisplayEmptyText = "Your patient messages will appear here.";
            SetMessageDisplayEmpty(patientMessageHistoryFlowPanel, patientMessageDisplayItems, patientMessageDisplayEmptyText);

            if (IsPatientUser())
            {
                LoadPatientChatMessages();
            }
        }

        private int GetCurrentPatientConversationId()
        {
            if (!IsPatientUser() || currentPatientId == 0)
            {
                return 0;
            }

            return EnsurePatientConversation(currentPatientId, currentPatientName);
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
    }
}
