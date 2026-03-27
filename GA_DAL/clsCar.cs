using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    static public class clsCarData
    {

        private static string comnnectionString = clsDataAccessSetting.connectionString;

        static public bool GetCarByID(int CarID, ref int BrandID, ref string Model, ref string Matricule)
        {
            bool isFound = false;

            string sql = "SELECT * FROM Voitures WHERE VoitureID = @VoitureID";

            using (MySqlConnection connection = new MySqlConnection(comnnectionString))
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@VoitureID", CarID);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            BrandID = reader["BrandID"] != DBNull.Value ? (int)reader["BrandID"] : 0;
                            Model = reader["Model"] != DBNull.Value ? (string)reader["Model"] : "";
                            Matricule = reader["Matricule"] != DBNull.Value ? (string)reader["Matricule"] : "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetCarByID: " + ex);
                }
            }

            return isFound;
        }


    }
}
