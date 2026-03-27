using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GA_DAL
{
    public static class clsResponseData
    {
        // Get Response by NotificationID
        public static bool GetResponseByNotificationID(
            int notificationID,
            ref int responseID,
            ref int commercialID,
            ref bool hasContactedClient,
            ref bool renewalAccepted,
            ref string notes,
            ref DateTime actionDate)
        {
            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_GetResponseByNotificationID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NotificationID", notificationID);

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            responseID = Convert.ToInt32(reader["ResponseID"]);
                            commercialID = Convert.ToInt32(reader["ActionByCommercialID"]);
                            hasContactedClient = Convert.ToBoolean(reader["HasContactedClient"]);
                            renewalAccepted = Convert.ToBoolean(reader["RenewalAccepted"]);
                            notes = reader["Notes"].ToString();
                            actionDate = Convert.ToDateTime(reader["ActionDate"]);

                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetResponseByNotificationID: " + ex.Message);
            }

            return isFound;
        }

        // Add new response - returns new ResponseID
        public static int AddNewResponse(int notificationID, int commercialID, bool contacted, bool accepted, string notes)
        {
            int newID = -1;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_AddNotificationResponse", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_NotificationID", notificationID);
                    cmd.Parameters.AddWithValue("@p_CommercialID", commercialID);
                    cmd.Parameters.AddWithValue("@p_HasContactedClient", contacted);
                    cmd.Parameters.AddWithValue("@p_RenewalAccepted", accepted);
                    cmd.Parameters.AddWithValue("@p_Notes", notes);

                    // OUT parameter
                    MySqlParameter outParam = new MySqlParameter("@p_NewResponseID", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    newID = Convert.ToInt32(outParam.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewResponse: " + ex.Message);
            }

            return newID;
        }

        // Update response
        public static bool UpdateResponseByID(int responseID, bool contacted, bool accepted, string notes)
        {
            bool isUpdated = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_UpdateNotificationResponse", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ResponseID", responseID);
                    cmd.Parameters.AddWithValue("@p_HasContactedClient", contacted);
                    cmd.Parameters.AddWithValue("@p_RenewalAccepted", accepted);
                    cmd.Parameters.AddWithValue("@p_Notes", notes);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    isUpdated = rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateResponseByID: " + ex.Message);
            }

            return isUpdated;
        }
    }
}
