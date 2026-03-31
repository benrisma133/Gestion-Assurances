using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GA_DAL
{
    public static class clsUserData
    {
        // Get User by ID
        public static bool GetUserByID(int userID,
                ref int personID,
                ref string username,
                ref string passwordHash,
                ref bool isActive,
                ref DateTime createdAt)
        {
            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_GetUserByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_UserID", userID);

                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                personID = Convert.ToInt32(reader["PersonID"]);
                                username = reader["Username"].ToString();
                                passwordHash = reader["PasswordHash"].ToString();
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                createdAt = Convert.ToDateTime(reader["CreatedAt"]);

                                isFound = true;
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUserByID: " + ex.Message);
            }

            return isFound;
        }

        // Add New User (returns UserID)
        public static int AddNewUser(string firstName, string lastName, string email, string phone, string address, string username, string passwordHash)
        {
            int newUserID = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_RegisterNewUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_FirstName", firstName);
                        cmd.Parameters.AddWithValue("@p_LastName", lastName);
                        cmd.Parameters.AddWithValue("@p_Email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                        cmd.Parameters.AddWithValue("@p_Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : (object)phone);
                        cmd.Parameters.AddWithValue("@p_Address", string.IsNullOrEmpty(address) ? DBNull.Value : (object)address);
                        cmd.Parameters.AddWithValue("@p_Username", username);
                        cmd.Parameters.AddWithValue("@p_Password", passwordHash);

                        MySqlParameter outputId = new MySqlParameter("@p_NewUserID", MySqlDbType.Int32);
                        outputId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        newUserID = Convert.ToInt32(outputId.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewUser: " + ex.Message);
            }
            return newUserID;
        }

        // Update User
        public static bool UpdateUser(int userID, string firstName, string lastName, string email, string phone, string address, string username, string passwordHash)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_UpdateUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_UserID", userID);
                        cmd.Parameters.AddWithValue("@p_FirstName", firstName);
                        cmd.Parameters.AddWithValue("@p_LastName", lastName);
                        cmd.Parameters.AddWithValue("@p_Email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                        cmd.Parameters.AddWithValue("@p_Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : (object)phone);
                        cmd.Parameters.AddWithValue("@p_Address", string.IsNullOrEmpty(address) ? DBNull.Value : (object)address);
                        cmd.Parameters.AddWithValue("@p_Username", username);
                        cmd.Parameters.AddWithValue("@p_Password", passwordHash);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        isUpdated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateUser: " + ex.Message);
            }
            return isUpdated;
        }

        // Delete User
        public static bool DeleteUser(int userID)
        {
            bool isDeleted = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_DeleteUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_UserID", userID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        isDeleted = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteUser: " + ex.Message);
            }
            return isDeleted;
        }

        // Get all users (from view)
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM vw_UserWithPerson", conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllUsers: " + ex.Message);
            }
            return dt;
        }

        // Get User by Username and Password
        public static bool GetUserByUsernameAndPassword(
            string username,
            string password,
            ref int userID,
            ref int personID,
            ref bool isActive,
            ref DateTime createdAt)
        {
            bool isFound = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_GetUserByUsernameAndPassword", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.AddWithValue("@p_Username", username);
                        cmd.Parameters.AddWithValue("@p_Password", password);

                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = Convert.ToInt32(reader["UserID"]);
                                personID = Convert.ToInt32(reader["PersonID"]);
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                createdAt = Convert.ToDateTime(reader["CreatedAt"]);

                                isFound = true;
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUserByUsernameAndPassword: " + ex.Message);
            }
            return isFound;
        }

        // Toggle User Active Status
        public static bool UpdateUserStatus(int userID, bool newStatus)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_UpdateUserStatus", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_UserID", userID);
                        cmd.Parameters.AddWithValue("@p_IsActive", newStatus);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        isUpdated = rowsAffected > 0; // true if row updated
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateUserStatus: " + ex.Message);
            }
            return isUpdated;
        }
    }
}