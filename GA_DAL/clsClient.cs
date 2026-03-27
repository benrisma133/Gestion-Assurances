using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GA_DAL
{
    public static class clsClientData
    {
        
        private static string connectionString = clsDataAccessSetting.connectionString;

        static public bool GetClientInfoByClientID(int ClientID, ref string Nom, ref string Prenom, ref string Telephone, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClientID", ClientID);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            Nom = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : "";
                            Prenom = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : "";
                            Telephone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : "";
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetClientInfoByClientID: " + ex);
                }
            }

            return isFound;
        }

        static public bool GetClientInfoByTelephone(string Telephone, ref int ClientID, ref string Nom, ref string Prenom, ref string Email)
        {
            bool isFound = false;
            string query = "SELECT * FROM Clients WHERE Telephone = @Telephone";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Telephone", Telephone);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            Nom = reader["Nom"] != DBNull.Value ? reader["Nom"].ToString() : "";
                            Prenom = reader["Prenom"] != DBNull.Value ? reader["Prenom"].ToString() : "";
                            ClientID = reader["ClientID"] != DBNull.Value ? Convert.ToInt32(reader["ClientID"]) : -1;
                            Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetClientInfoByTelephone: " + ex.Message);
                }
            }

            return isFound;
        }

        static public int AddNewClient(string Nom, string Prenom, string Telephone, string Email)
        {
            int ClientID = -1;

            string query = @"INSERT INTO Clients (Nom, Prenom, Telephone, Email)
                         VALUES (@Nom, @Prenom, @Telephone, @Email);
                         SELECT LAST_INSERT_ID();";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", Nom);
                command.Parameters.AddWithValue("@Prenom", Prenom);
                command.Parameters.AddWithValue("@Telephone", Telephone);
                command.Parameters.AddWithValue("@Email", Email);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ClientID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in AddNewClient: " + ex.Message);
                }
            }

            return ClientID;
        }

        static public bool UpdateClientByID(int ClientID, string Nom, string Prenom, string Telephone, string Email)
        {
            int rowUpdated = 0;

            string query = @"UPDATE Clients
                         SET Nom = @Nom,
                             Prenom = @Prenom, 
                             Telephone = @Telephone, 
                             Email = @Email
                         WHERE ClientID = @ClientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", Nom);
                command.Parameters.AddWithValue("@Prenom", Prenom);
                command.Parameters.AddWithValue("@Telephone", Telephone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@ClientID", ClientID);

                try
                {
                    connection.Open();
                    rowUpdated = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in UpdateClientByID: " + ex.Message);
                }
            }

            return rowUpdated > 0;
        }

        static public bool DeleteClientInfo(int ClientID)
        {
            int rowDeleted = 0;

            string query = "DELETE FROM Clients WHERE ClientID = @ClientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClientID", ClientID);

                try
                {
                    connection.Open();
                    rowDeleted = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in DeleteClientInfo: " + ex.Message);
                }
            }

            return rowDeleted > 0;
        }

        static public bool IsClientExistByID(int ClientID)
        {
            bool isExist = false;

            string query = "SELECT 1 FROM Clients WHERE ClientID = @ClientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClientID", ClientID);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        isExist = reader.HasRows;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in IsClientExistByID: " + ex.Message);
                }
            }

            return isExist;
        }

        static public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Clients"; // Update with your MySQL view/table name

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }


    }
}
