using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GA_DAL
{
    public static class clsPaymentData
    {
        private static string connectionString = clsDataAccessSetting.connectionString;

        // Get Payment Info By PaymentID
        static public bool GetPaymentByID(int PaymentID ,ref decimal Espece ,ref decimal Cheque ,ref decimal VirBank ,ref decimal WafaSalaf)
        {
            bool isFound = false;
            string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";

            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            Espece = reader["Espece"] != DBNull.Value ? (decimal)reader["Espece"] : 0;
                            Cheque = reader["Cheque"] != DBNull.Value ? (decimal)reader["Cheque"] : 0;
                            VirBank = reader["VirBank"] != DBNull.Value ? (decimal)reader["VirBank"] : 0;
                            WafaSalaf = reader["WafaSalaf"] != DBNull.Value ? (decimal)reader["WafaSalaf"] : 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetPaymentByID: " + ex);

            }

            return isFound;

        }

    }
}
