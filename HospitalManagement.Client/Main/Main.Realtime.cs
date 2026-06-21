using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    public partial class Main
    {
        private void SetNotificationDisplayItems(IEnumerable<NotificationDisplayItem> items)
        {
            notificationDisplayItems.Clear();

            foreach (NotificationDisplayItem item in items.Where(item => item != null).Take(WrappingDisplayItemLimit))
            {
                notificationDisplayItems.Add(item);
            }

            RefreshNotificationsWindowDisplay();
        }

        private void AddNotificationDisplayItem(NotificationDisplayItem item)
        {
            if (item == null)
            {
                return;
            }

            notificationDisplayItems.Insert(0, item);

            while (notificationDisplayItems.Count > WrappingDisplayItemLimit)
            {
                notificationDisplayItems.RemoveAt(notificationDisplayItems.Count - 1);
            }

            RefreshNotificationsWindowDisplay();
        }

        private void RefreshNotificationsWindowDisplay()
        {
            if (notificationsWindow == null || notificationsWindow.IsDisposed)
            {
                return;
            }

            notificationsWindow.SetNotifications(notificationDisplayItems);
        }

        private void SetConnectionStatus(string text)
        {
            if (connectionStatusText != null)
            {
                connectionStatusText.Text = text;
            }
        }

        private string GetSignalRHubUrl()
        {
            return AppConnections.GetSignalRHubUrl();
        }

        private string GetSignalRHubUrlForCurrentUser()
        {
            string hubUrl = GetSignalRHubUrl();
            string userId = GetCurrentUserId();

            if (String.IsNullOrWhiteSpace(userId))
            {
                return hubUrl;
            }

            string separator = hubUrl.Contains("?") ? "&" : "?";
            return hubUrl + separator + "userId=" + Uri.EscapeDataString(userId);
        }

        private void ShowNotificationsWindow()
        {
            if (notificationsWindow != null && !notificationsWindow.IsDisposed)
            {
                if (notificationsWindow.WindowState == FormWindowState.Minimized)
                {
                    notificationsWindow.WindowState = FormWindowState.Normal;
                }

                notificationsWindow.BringToFront();
                notificationsWindow.Activate();
                return;
            }

            notificationsWindow = new Notifications();
            notificationsWindow.FormClosed += (sender, args) =>
            {
                notificationsWindow = null;
            };

            RefreshNotificationsWindowDisplay();
            notificationsWindow.Show(this);
        }

        internal void BringMainWindowToFront()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Show();
            BringToFront();
            Activate();
        }

        internal void ShowNotificationCenter()
        {
            ShowNotificationsWindow();
        }

        private void InitializeDesktopNotifications()
        {
            if (notificationTrayIcon != null)
            {
                return;
            }

            notificationTrayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Text = "Hospital Management",
                Visible = true
            };

            notificationTrayIcon.BalloonTipClicked += (sender, args) =>
            {
                BringMainWindowToFront();
                ShowNotificationCenter();
            };

            notificationTrayIcon.DoubleClick += (sender, args) =>
            {
                BringMainWindowToFront();
                ShowNotificationCenter();
            };
        }

        private void DisposeDesktopNotifications()
        {
            if (notificationTrayIcon == null)
            {
                return;
            }

            notificationTrayIcon.Visible = false;
            notificationTrayIcon.Dispose();
            notificationTrayIcon = null;
        }

        private void ShowDesktopNotification(string notificationType, string title, string message, string conversationName)
        {
            if (notificationTrayIcon == null)
            {
                return;
            }

            string cleanType = CleanDesktopNotificationText(notificationType, "Notification", 60);
            string cleanTitle = CleanDesktopNotificationText(title, cleanType, 80);
            string cleanMessage = CleanDesktopNotificationText(message, cleanTitle, 180);

            try
            {
                SystemSounds.Exclamation.Play();
            }
            catch
            {
                // Sound playback can fail on machines with notification audio disabled.
            }

            try
            {
                notificationTrayIcon.BalloonTipTitle = cleanTitle;
                notificationTrayIcon.BalloonTipText = cleanMessage;
                notificationTrayIcon.BalloonTipIcon = GetDesktopNotificationIcon(cleanType);
                notificationTrayIcon.ShowBalloonTip(5000);
            }
            catch
            {
                // NotifyIcon can be unavailable when Windows shell notifications are disabled.
            }
        }

        private static ToolTipIcon GetDesktopNotificationIcon(string notificationType)
        {
            if (notificationType.IndexOf("critical", StringComparison.OrdinalIgnoreCase) >= 0 ||
                notificationType.IndexOf("warning", StringComparison.OrdinalIgnoreCase) >= 0 ||
                notificationType.IndexOf("emergency", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return ToolTipIcon.Warning;
            }

            return ToolTipIcon.Info;
        }

        private static string CleanDesktopNotificationText(string value, string fallback, int maxLength)
        {
            string cleanValue = String.IsNullOrWhiteSpace(value) ? fallback : value.Trim();
            cleanValue = cleanValue.Replace("\r", " ").Replace("\n", " ").Trim();

            while (cleanValue.Contains("  "))
            {
                cleanValue = cleanValue.Replace("  ", " ");
            }

            if (cleanValue.Length <= maxLength)
            {
                return cleanValue;
            }

            return cleanValue.Substring(0, Math.Max(0, maxLength - 3)) + "...";
        }

        private async Task StartSignalRConnectionAsync()
        {
            if (hospitalHubConnection != null)
            {
                return;
            }

            hospitalHubConnection = new HubConnectionBuilder()
                .WithUrl(GetSignalRHubUrlForCurrentUser())
                .WithAutomaticReconnect()
                .Build();

            hospitalHubConnection.Reconnecting += error =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Reconnecting");
                    statusText.Text = "SignalR connection lost. Reconnecting...";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.Reconnected += connectionId =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Connected");
                    statusText.Text = "SignalR connection restored.";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.Closed += error =>
            {
                RunOnUiThread(() =>
                {
                    SetConnectionStatus("Connection: Disconnected");
                    statusText.Text = "SignalR connection closed.";
                });

                return Task.CompletedTask;
            };

            hospitalHubConnection.On<string, string, string, string>(
                "ServerNotificationReceived",
                (notificationType, title, message, conversationName) =>
                {
                    RunOnUiThread(() =>
                    {
                        if (!CanCurrentUserSeeDesktopNotification(notificationType, message, conversationName))
                        {
                            return;
                        }

                        ShowDesktopNotification(notificationType, title, message, conversationName);
                    });
                });

            hospitalHubConnection.On<string>("AppointmentChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadAppointments();
                    RefreshDashboardCounts();
                    statusText.Text = "Appointment update received.";
                });
            });

            hospitalHubConnection.On<string>("InventoryChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!IsAdminUser())
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadInventoryItems();
                    RefreshDashboardCounts();
                    statusText.Text = "Inventory update received.";
                });
            });

            hospitalHubConnection.On<string>("PatientChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadPatients();
                    RefreshDashboardCounts();
                    statusText.Text = "Patient update received.";
                });
            });

            hospitalHubConnection.On<string, string, string>("ChatMessageReceived", (conversationName, senderName, message) =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserAccessConversationName(conversationName))
                    {
                        return;
                    }

                    AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");

                    if (IsPatientUser())
                    {
                        if (IsCurrentPatientConversationName(conversationName))
                        {
                            LoadPatientChatMessages();
                        }
                    }
                    else
                    {
                        LoadConversations();

                        if (GetSelectedConversationName() == conversationName)
                        {
                            LoadChatMessages();
                        }
                    }

                    RefreshDashboardCounts();
                    statusText.Text = "Chat message received.";
                });
            });

            hospitalHubConnection.On<string>("VitalsChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    LoadVitals();
                    RefreshDashboardCounts();
                    statusText.Text = "Vitals update received.";
                });
            });

            hospitalHubConnection.On<string>("DashboardChanged", message =>
            {
                RunOnUiThread(() =>
                {
                    if (IsPatientUser())
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    RefreshDashboardCounts();
                    statusText.Text = "Dashboard update received.";
                });
            });

            hospitalHubConnection.On<string>("NotificationReceived", message =>
            {
                RunOnUiThread(() =>
                {
                    if (!CanCurrentUserSeeNotificationMessage(message))
                    {
                        return;
                    }

                    AddRealTimeUpdate(message);
                    RefreshDashboardCounts();
                    statusText.Text = "Notification received.";
                });
            });

            try
            {
                await hospitalHubConnection.StartAsync();
                SetConnectionStatus("Connection: Connected");
                statusText.Text = "SignalR connection started.";
            }
            catch (Exception ex)
            {
                SetConnectionStatus("Connection: Unavailable");
                statusText.Text = "Could not connect to SignalR server: " + ex.Message;
            }
        }

        private bool CanCurrentUserSeeDesktopNotification(string notificationType, string message, string conversationName)
        {
            string cleanType = String.IsNullOrWhiteSpace(notificationType) ? "" : notificationType.Trim();

            if (String.Equals(cleanType, "Inventory", StringComparison.OrdinalIgnoreCase))
            {
                return IsAdminUser();
            }

            if (String.Equals(cleanType, "Chat", StringComparison.OrdinalIgnoreCase))
            {
                return CanCurrentUserAccessConversationName(conversationName);
            }

            if (String.Equals(cleanType, "Dashboard", StringComparison.OrdinalIgnoreCase))
            {
                return !IsPatientUser();
            }

            if (String.Equals(cleanType, "System", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return CanCurrentUserSeeNotificationMessage(message);
        }

        private async Task SendPatientChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendPatientChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Patient saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendChatMessageAsync(string conversationName, string senderName, string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendChatMessage", conversationName, senderName, message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");
                    statusText.Text = "Message saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(senderName + " sent a chat message in " + conversationName + ".");
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendVitalsChangeAsync(string notificationType, string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendVitalsChanged", notificationType, message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Vitals saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendNotificationAsync(string notificationType, string message, string conversationName)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendNotification", notificationType, message, conversationName);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Notification saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private void RunOnUiThread(Action action)
        {
            if (IsDisposed)
            {
                return;
            }

            if (InvokeRequired)
            {
                try
                {
                    BeginInvoke(new MethodInvoker(() => action()));
                }
                catch (InvalidOperationException)
                {
                    // Form is closing while a background SignalR callback is finishing.
                }

                return;
            }

            action();
        }

        private void AddRealTimeUpdate(string message)
        {
            DateTime updateTime = DateTime.Now;
            AddNotificationDisplayItem(new NotificationDisplayItem("Live Update", message, updateTime));
        }

        private async Task SendAppointmentChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendAppointmentChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Appointment saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private async Task SendInventoryChangeAsync(string message)
        {
            if (hospitalHubConnection != null && hospitalHubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await hospitalHubConnection.InvokeAsync("SendInventoryChanged", message);
                }
                catch (Exception ex)
                {
                    AddRealTimeUpdate(message);
                    statusText.Text = "Inventory saved, but SignalR notification failed: " + ex.Message;
                }
            }
            else
            {
                AddRealTimeUpdate(message);
                SetConnectionStatus("Connection: Unavailable");
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ShowNotificationsWindow();
        }

        private void SaveNotification(string notificationType, string messageText)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    db.SystemNotifications.Add(new SystemNotification
                    {
                        NotificationType = notificationType,
                        MessageText = messageText,
                        CreatedAt = DateTime.Now
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                statusText.Text = "Notification could not be saved: " + ex.Message;
            }
        }
    }
}
