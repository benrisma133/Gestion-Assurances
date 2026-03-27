using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    public static class clsComercialData
    {

        public static bool GetComercialByID(int comercialID,ref string firstName,ref string lastName,ref string phone,ref string email,ref string username)
        {

            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_GetComercialByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_ComercialID", comercialID);

                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                phone = reader["Phone"] == DBNull.Value ? null : reader["Phone"].ToString();
                                email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString();
                                username = reader["Username"].ToString();

                                isFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or show error if you want
                Console.WriteLine("Error in GetComercialByID: " + ex.Message);
            }

            return isFound;

        }

        public static bool GetComercialByUsername(
                string username,
                ref int comercialID,
                ref string firstName,
                ref string lastName,
                ref string phone,
                ref string email)
        {
            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_GetComercialByUsername", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_Username", username);

                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                comercialID = Convert.ToInt32(reader["ComercialID"]);
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                phone = reader["Phone"] == DBNull.Value ? null : reader["Phone"].ToString();
                                email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString();

                                isFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetComercialByUsername: " + ex.Message);
            }

            return isFound;
        }


        // Add New Comercial (returns new ID)


        public static int AddNewComercial(string firstName, string lastName, string phone, string email, string username)
        {

            int newID = -1;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_AddNewComercial", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_FirstName", firstName);
                        cmd.Parameters.AddWithValue("@p_LastName", lastName);

                        // use DBNull for null values in one line
                        cmd.Parameters.AddWithValue("@p_Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : (object)phone);
                        cmd.Parameters.AddWithValue("@p_Email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);

                        cmd.Parameters.AddWithValue("@p_Username", username);

                        // OUT parameter for new ID
                        MySqlParameter outputId = new MySqlParameter("@p_NewID", MySqlDbType.Int32);
                        outputId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        newID = Convert.ToInt32(outputId.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewComercial: " + ex.Message);
            }

            return newID;

        }

        // Update Comercial
        public static bool UpdateComercial(int comercialID, string firstName, string lastName, string phone, string email, string username)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_UpdateComercial", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_ComercialID", comercialID);
                        cmd.Parameters.AddWithValue("@p_FirstName", firstName);
                        cmd.Parameters.AddWithValue("@p_LastName", lastName);

                        // use DBNull for null values in one line
                        cmd.Parameters.AddWithValue("@p_Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : (object)phone);
                        cmd.Parameters.AddWithValue("@p_Email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);

                        cmd.Parameters.AddWithValue("@p_Username", username);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        isUpdated = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateComercial: " + ex.Message);
            }
            return isUpdated;
        }

        // Delete Comercial
        public static bool DeleteComercial(int comercialID)
        {
            bool isDeleted = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_DeleteComercial", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_ComercialID", comercialID);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        isDeleted = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteComercial: " + ex.Message);
            }
            return isDeleted;
        }

        // Get All Comercials
        // Returns DataTable with all commercials
        // I did not use stored procedure for simplicity
        public static DataTable GetAllComercials()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    string query = "SELECT * FROM Comercials";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllComercials: " + ex.Message);
            }
            return dt;
        }

        public static DataTable GetComercialStatisticsWithMonth()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    string query = "SELECT * FROM vw_comercialstatisticbymonth;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or show it for debugging
                Console.WriteLine("Error loading comercial statistics (with month): " + ex.Message);
            }

            return dt;
        }


        public static DataTable GetComercialStatisticsWithoutMonth()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    string query = "SELECT * FROM vw_comercialstatisticbyyear;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or show it for debugging
                Console.WriteLine("Error loading comercial statistics (without month): " + ex.Message);
            }

            return dt;
        }



    }
}
