using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GA_DAL
{
    public static  class clsPersonData
    {
        public static bool GetPersonByID(int personID,
            ref string firstName,
            ref string lastName,
            ref string email,
            ref string phone,
            ref string address,
            ref DateTime createdAt)
        {
            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_GetPersonByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_PersonID", personID);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString();
                                phone = reader["Phone"] == DBNull.Value ? null : reader["Phone"].ToString();
                                address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
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
                Console.WriteLine("Error in GetPersonByID: " + ex.Message);
            }

            return isFound;
        }
    }
}