using GA_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GA_BLL
{
    public class clsNotification
    {
        public int NotificationID { get; private set; }
        public int AssuranceID { get; private set; }   // Composition
        public bool IsRead { get; private set; }
        public int ReminderCount { get; private set; }
        public DateTime SentDate { get; private set; }
        public DateTime NextReminderDate { get; private set; }
        public int DaysRemainin { get; private set; }
        public string Message { get; private set; }

        // --- Response (User Action) ---
        public bool? HasContactedClient { get; set; }
        public bool? RenewalAccepted { get; set; }
        public string Notes { get; set; }
        public DateTime? ActionDate { get; set; }

        // Relation
        public clsAssurance Assurance { get; private set; }
        public clsResponse Response { get; private set; }

        private clsNotification() { }

        // -----------------------
        // LOAD
        // -----------------------
        public static clsNotification Find(int notificationID)
        {
            var data = clsNotificationData.GetNotificationMinimalDetails(notificationID);

            if (data == null)
                return null;

            return new clsNotification
            {
                NotificationID = data.NotificationID,
                AssuranceID = data.AssuranceID,
                IsRead = data.IsRead,
                ReminderCount = data.ReminderCount,
                SentDate = data.SentDate,
                NextReminderDate = data.NextReminderDate,
                HasContactedClient = data.HasContactedClient,
                RenewalAccepted = data.RenewalAccepted,
                Notes = data.Notes,
                ActionDate = data.ActionDate,
                DaysRemainin = data.DaysRemaining,
                Message = data.Message,

                // Load Assurance object (Composition)
                Assurance = clsAssurance.FindByID(data.AssuranceID),
                Response = clsResponse.FindByNotificationID(notificationID)
            };
        }

        public static List<clsNotificationListItem> GetNotificationsList()
        {
            return clsNotificationData.GetNotificationsList();
        }

        public static List<clsNotificationListItemV2> GetNotificationsListV2()
        {
            return clsNotificationData.GetNotificationsListV2();
        }

        // -----------------------
        // MARK AS READ
        // -----------------------
        public static bool MarkAsRead(int NotificationID)
        {
            if (NotificationID <= 0) return false;

            if (!clsNotificationData.MarkAsRead(NotificationID))
                return false;

            return true;
        }

        // -----------------------
        // MARK AS UNREAD
        // -----------------------
        public bool MarkAsUnread()
        {
            if (NotificationID <= 0) return false;

            if (!clsNotificationData.MarkAsUnRead(NotificationID))
                return false;

            IsRead = false;
            return true;
        }

        // 8) Count unread notifications
        public static int CountUnreadNotifications()
        {
            return clsNotificationData.CountUnreadNotifications();
        }

    }
}
