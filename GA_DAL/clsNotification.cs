using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GA_DAL
{
    public class clsNotificationListItem
    {
        public int NotificationID { get; set; }
        public string ClientFullName { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }
    }

    public class clsNotificationFullDetails
    {
        public int NotificationID { get; set; }
        public int AssuranceID { get; set; }
        public string ClientName { get; set; }
        public string ComercialName { get; set; }
        public string BrandName { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public int ReminderCount { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime NextReminderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysRemaining { get; set; }

        // Response fields (may be null)
        public bool? HasContactedClient { get; set; }
        public bool? RenewalAccepted { get; set; }
        public string Notes { get; set; }
        public DateTime? ActionDate { get; set; }
    }

    public class clsNotificationMinimalDetails
    {
        public int NotificationID { get; set; }
        public int AssuranceID { get; set; }

        // Notification
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public int ReminderCount { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime NextReminderDate { get; set; }
        public int DaysRemaining { get; set; }

        // Response (nullable)
        public bool? HasContactedClient { get; set; }
        public bool? RenewalAccepted { get; set; }
        public string Notes { get; set; }
        public DateTime? ActionDate { get; set; }
    }

    public class clsNotificationListItemV2
    {
        public int NotificationID { get; set; }
        public string ClientFullName { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime LastSentDate { get; set; }
        public bool IsRead { get; set; }
    }

    public static class clsNotificationData
    {
        private static readonly string connectionString = clsDataAccessSetting.connectionString;

        // ---------------- Helper safe readers ----------------
        private static DateTime SafeDate(object value)
        {
            if (value == null || value == DBNull.Value) return DateTime.MinValue;
            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        private static DateTime? SafeNullableDate(object value)
        {
            if (value == null || value == DBNull.Value) return null;
            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return null;
            }
        }

        private static string SafeString(object value)
        {
            if (value == null || value == DBNull.Value) return string.Empty;
            try
            {
                return value.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private static int SafeInt(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }

        // Assumes DB stores isRead as tinyint (0/1) or boolean-like
        private static bool SafeBool(object value)
        {
            if (value == null || value == DBNull.Value) return false;
            try
            {
                // handle numeric and boolean types
                if (value is bool) return (bool)value;
                int n = Convert.ToInt32(value);
                return n == 1;
            }
            catch
            {
                return false;
            }
        }

        private static bool? SafeNullableBool(object value)
        {
            if (value == null || value == DBNull.Value) return null;
            try
            {
                if (value is bool) return (bool)value;
                int n = Convert.ToInt32(value);
                return n == 1;
            }
            catch
            {
                return null;
            }
        }

        // ---------------- DB Operations ----------------

        // 1) Mark ONE notification as READ
        public static bool MarkAsRead(int notificationID)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_MarkNotificationAsRead", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NotificationID", notificationID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MarkAsRead: " + ex.Message);
            }
            return isUpdated;
        }

        // 2) Mark ALL notifications as READ
        public static bool MarkAllAsRead()
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_MarkAllNotificationsAsRead", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MarkAllAsRead: " + ex.Message);
            }
            return isUpdated;
        }

        // 3) Mark ONE notification as UNREAD
        public static bool MarkAsUnRead(int notificationID)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_MarkNotificationAsUnRead", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NotificationID", notificationID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MarkAsUnRead: " + ex.Message);
            }
            return isUpdated;
        }

        // 4) Mark ALL notifications as UNREAD
        public static bool MarkAllAsUnRead()
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_MarkAllNotificationsAsUnRead", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MarkAllAsUnRead: " + ex.Message);
            }
            return isUpdated;
        }

        // 5) Get Notifications List
        public static List<clsNotificationListItem> GetNotificationsList()
        {
            List<clsNotificationListItem> list = new List<clsNotificationListItem>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM v_notifications_list ORDER BY SentDate DESC", conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsNotificationListItem item = new clsNotificationListItem();

                            item.NotificationID = SafeInt(reader["NotificationID"]);
                            item.ClientFullName = SafeString(reader["ClientFullName"]);
                            item.Message = SafeString(reader["Message"]);
                            item.SentDate = SafeDate(reader["SentDate"]);
                            item.IsRead = SafeBool(reader["IsRead"]);

                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetNotificationsList: " + ex.Message);
            }

            return list;
        }

        public static List<clsNotificationListItemV2> GetNotificationsListV2()
        {
            List<clsNotificationListItemV2> list = new List<clsNotificationListItemV2>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM v_notifications_listV2 ORDER BY SentDate DESC", conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsNotificationListItemV2 item = new clsNotificationListItemV2();

                            item.NotificationID = SafeInt(reader["NotificationID"]);
                            item.ClientFullName = SafeString(reader["ClientFullName"]);
                            item.Message = SafeString(reader["Message"]);
                            item.SentDate = SafeDate(reader["SentDate"]);
                            item.LastSentDate = SafeDate(reader["LastSentDate"]);
                            item.IsRead = SafeBool(reader["IsRead"]);

                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetNotificationsList: " + ex.Message);
            }

            return list;
        }

        // 6) Get Notifications Details (full)
        public static clsNotificationFullDetails GetNotificationDetails(int notificationID)
        {
            clsNotificationFullDetails details = null;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM v_comercialnotificationsfullwithold WHERE NotificationID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", notificationID);
                    conn.Open();

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            details = new clsNotificationFullDetails();

                            details.NotificationID = SafeInt(r["NotificationID"]);
                            details.AssuranceID = SafeInt(r["AssuranceID"]);
                            details.ClientName = SafeString(r["ClientName"]);
                            details.ComercialName = SafeString(r["ComercialName"]);
                            details.BrandName = SafeString(r["BrandName"]);
                            details.Message = SafeString(r["Message"]);
                            details.IsRead = SafeBool(r["IsRead"]);
                            details.ReminderCount = SafeInt(r["ReminderCount"]);
                            details.SentDate = SafeDate(r["SentDate"]);
                            details.NextReminderDate = SafeDate(r["NextReminderDate"]);
                            details.StartDate = SafeDate(r["StartDate"]);
                            details.EndDate = SafeDate(r["EndDate"]);
                            details.DaysRemaining = SafeInt(r["DaysRemaining"]);

                            details.HasContactedClient = SafeNullableBool(r["HasContactedClient"]);
                            details.RenewalAccepted = SafeNullableBool(r["RenewalAccepted"]);
                            details.Notes = SafeString(r["Notes"]);
                            details.ActionDate = SafeNullableDate(r["ActionDate"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetNotificationDetails: " + ex.Message);
            }

            return details;
        }

        // 7) Get Notifications Minimal Details
        public static clsNotificationMinimalDetails GetNotificationMinimalDetails(int notificationID)
        {
            clsNotificationMinimalDetails details = null;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM v_notifications_minimal WHERE NotificationID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", notificationID);
                    conn.Open();

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            details = new clsNotificationMinimalDetails();

                            details.NotificationID = SafeInt(r["NotificationID"]);
                            details.AssuranceID = SafeInt(r["AssuranceID"]);
                            details.Message = SafeString(r["Message"]);
                            details.IsRead = SafeBool(r["IsRead"]);
                            details.ReminderCount = SafeInt(r["ReminderCount"]);
                            details.SentDate = SafeDate(r["SentDate"]);
                            details.NextReminderDate = SafeDate(r["NextReminderDate"]);
                            details.DaysRemaining = SafeInt(r["DaysRemaining"]);

                            details.HasContactedClient = SafeNullableBool(r["HasContactedClient"]);
                            details.RenewalAccepted = SafeNullableBool(r["RenewalAccepted"]);
                            details.Notes = SafeString(r["Notes"]);
                            details.ActionDate = SafeNullableDate(r["ActionDate"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetNotificationMinimalDetails: " + ex.Message);
            }

            return details;
        }

        // 8) Count unread notifications
        public static int CountUnreadNotifications()
        {
            int count = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_CountUnreadNotifications", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CountUnreadNotifications: " + ex.Message);
            }

            return count;
        }

    }
}
