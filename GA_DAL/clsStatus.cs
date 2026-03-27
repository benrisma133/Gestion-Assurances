using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    static public class clsStatusData
    {

        private static string connectionString = clsDataAccessSetting.connectionString;

        // Get Status By ID
        static public bool GetStatusByID(int StatusID, ref string StatusName ,ref string StatusDescription)
        {
            
            bool isFound = false;

            string query = "SELECT * FROM statuses WHERE StatusID = @StatusID";

            try
            {

                using(MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@StatusID", StatusID);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            StatusName = reader["StatusName"] != DBNull.Value ? (string)reader["StatusName"] : "";
                            StatusDescription = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Status by ID: " + ex.Message);
            }

            return isFound;

        }

        static public DataTable GetAllStatuses()
        {
            DataTable dtStatuses = new DataTable();
            string query = "SELECT * FROM statuses";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dtStatuses);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting all Statuses: " + ex.Message);
            }
            return dtStatuses;
        }

    }
}
