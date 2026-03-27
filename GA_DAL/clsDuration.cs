using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace GA_DAL
{
    static public class clsDurationData
    {

        private static string connectionString = clsDataAccessSetting.connectionString;

        // Get Duration Info By DurationID
        static public bool GetDurationByID(int DurationID ,ref int Duration ,ref DateTime StartDate ,ref DateTime EndDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Durations WHERE DurationID = @DurationID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DurationID", DurationID);
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            Duration = reader["Duration"] != DBNull.Value ? (int)reader["Duration"] : 0;
                            StartDate = reader["StartDate"] != DBNull.Value ? (DateTime)reader["StartDate"] : DateTime.MinValue;
                            EndDate = reader["EndDate"] != DBNull.Value ? (DateTime)reader["EndDate"] : DateTime.MinValue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetDurationByID: " + ex);
                }
            }
            return isFound;
        }



    }
}
