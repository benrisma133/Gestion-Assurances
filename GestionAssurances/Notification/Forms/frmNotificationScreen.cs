using GA_BLL;
using GA_DAL;
using GestionAssurances.Notification.Controls;
using GestionAssurances.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Notification.Forms
{
    public partial class frmNotificationScreen : Form
    {

        public event Action NotificationsUpdated;

        private void MarkNotificationAsRead(int notificationID)
        {
            if (clsNotification.MarkAsRead(notificationID))
            {
                // Do whatever UI updates you need here
                NotificationsUpdated?.Invoke(); // Notify main form
            }
        }

        public frmNotificationScreen()
        {
            InitializeComponent();

            // optional: avoid auto-scaling surprises while debugging
            this.AutoScaleMode = AutoScaleMode.None;

            // ensure dock settings are correct
            //flowNotifications.Dock = DockStyle.Left;
            //pnlDetails.Dock = DockStyle.Fill;

            // prefer using Shown so layout and DPI are finished
            this.Shown += Form1_Shown;

            // Attach Shown event
            this.Shown += FrmNotificationScreen_Shown;

        }

        private void FrmNotificationScreen_Shown(object sender, EventArgs e)
        {
            // Desired client area
            int leftWidth = 529;
            int rightWidth = 674;
            int desiredClientHeight = 600;
            int clientWidth = leftWidth + rightWidth;

            // Fix the exact size
            this.Size = this.SizeFromClientSize(new Size(clientWidth, desiredClientHeight));

            // Center the form manually
            Rectangle screen = Screen.FromControl(this).WorkingArea;
            this.Left = screen.Left + (screen.Width - this.Width) / 2;
            this.Top = screen.Top + (screen.Height - this.Height) / 2;
        }

        int _clientWidth = 0;
        int _clientHeight = 0;

        private void Form1_Shown(object sender, EventArgs e)
        {
            int leftWidth = 529;
            int rightWidth = 674;

            int desiredClientHeight = 600;
            _clientHeight = desiredClientHeight;

            int clientWidth = leftWidth + rightWidth;
            _clientWidth = clientWidth;

            // Fix Form size EXACTLY
            this.Size = this.SizeFromClientSize(new Size(clientWidth, desiredClientHeight));

        }

        private NotificationItem _selectedNotificationItem = null;

        public void LoadNotifications()
        {
            flowNotifications.Controls.Clear();

            List<clsNotificationListItemV2> list = clsNotification.GetNotificationsListV2();

            foreach (var n in list)
            {
                NotificationItem item = new NotificationItem
                {
                    IsRead = n.IsRead,
                    NotificationID = n.NotificationID.ToString(),
                    Title = n.ClientFullName,
                    Details = n.Message,
                    Date = n.IsRead
                            ? GetRelativeTime(n.SentDate)
                            : GetRelativeTime(n.LastSentDate),

                    Icon = n.IsRead ? Properties.Resources.no_notification : Properties.Resources.yes_notification
                };

                // Initial background/border
                item.BackColor = n.IsRead ? Color.Transparent : Color.FromArgb(220, 255, 240);
                item.BorderColor = n.IsRead ? Color.Transparent : Color.FromArgb(40, 205, 140);

                item.OnNotificationClick += (s, ev) =>
                {
                    NotificationItem clickedItem = s as NotificationItem;

                    // Deselect previously selected
                    if (_selectedNotificationItem != null && _selectedNotificationItem != clickedItem)
                    {
                        _selectedNotificationItem.isSelected = false;
                        _selectedNotificationItem.UpdateBackground();
                    }

                    // Select clicked
                    clickedItem.isSelected = true;
                    clickedItem.UpdateBackground();
                    _selectedNotificationItem = clickedItem;

                    // Mark as read
                    if (!n.IsRead && clsNotification.MarkAsRead(n.NotificationID))
                    {
                        clickedItem.IsRead = true;
                        clickedItem.Icon = Resources.no_notification;
                        clickedItem.UpdateBackground();
                        n.IsRead = true;

                        // <--- Raise the event to notify main form
                        NotificationsUpdated?.Invoke();
                    }

                    // Mark as read
                    if (!n.IsRead && clsNotification.MarkAsRead(n.NotificationID))
                    {
                        clickedItem.IsRead = true;
                        clickedItem.Icon = Resources.no_notification;
                        clickedItem.UpdateBackground();
                        n.IsRead = true;
                    }

                    notificationDetailControl1.Visible = true;
                    lblNoNotificationMessage.Visible = false;
                    notificationDetailControl1.LoadData(n.NotificationID);

                    if(flowNotifications.Controls.Count > 5)
                    {
                        this.Size = this.SizeFromClientSize(new Size(_clientWidth + 22, _clientHeight));
                    }
                };

                flowNotifications.Controls.Add(item);
            }

            // Adjust left panel width for scrollbar
            flowNotifications.Width += flowNotifications.Controls.Count > 5 ? 22 : 6;

            


        }

        public static string GetRelativeTime(DateTime date)
        {
            TimeSpan diff = DateTime.Now - date;

            if (diff.TotalSeconds < 60)
                return "Just now";

            if (diff.TotalMinutes < 60)
                return $"{(int)diff.TotalMinutes} minutes ago";

            if (diff.TotalHours < 24)
                return $"{(int)diff.TotalHours} hours ago";

            if (diff.TotalDays < 7)
                return $"{(int)diff.TotalDays} days ago";

            if (diff.TotalDays < 30)
            {
                int weeks = (int)(diff.TotalDays / 7);
                return weeks == 1 ? "1 week ago" : $"{weeks} weeks ago";
            }

            if (diff.TotalDays < 365)
            {
                int months = (int)(diff.TotalDays / 30);
                return months == 1 ? "1 month ago" : $"{months} months ago";
            }

            int years = (int)(diff.TotalDays / 365);
            return years == 1 ? "1 year ago" : $"{years} years ago";
        }

        private void frmNotificationScreen_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }
    }
}
