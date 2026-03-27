using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GA_DAL
{
    public static class clsAssuranceData
    {

        private static string connectionString = clsDataAccessSetting.connectionString;

        public static bool GetAssuranceByID(
            int assuranceID,
            ref int clientID,
            ref int voitureID,
            ref int durationID,
            ref int PaymentID,
            ref int statusID,
            ref int version,
            ref bool isCurrent,
            ref int ComercialID)
        {
            bool isFound = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_GetAssuranceByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            clientID = reader["ClientID"] != DBNull.Value ? Convert.ToInt32(reader["ClientID"]) : 0;
                            voitureID = reader["VoitureID"] != DBNull.Value ? Convert.ToInt32(reader["VoitureID"]) : 0;
                            durationID = reader["DurationID"] != DBNull.Value ? Convert.ToInt32(reader["DurationID"]) : 0;
                            ComercialID = reader["ComercialID"] != DBNull.Value ? Convert.ToInt32(reader["ComercialID"]) : 0;
                            statusID = reader["StatusID"] != DBNull.Value ? Convert.ToInt32(reader["StatusID"]) : 0;
                            PaymentID = reader["PaymentID"] != DBNull.Value ? Convert.ToInt32(reader["PaymentID"]) : 0;
                            version = reader["Version"] != DBNull.Value ? Convert.ToInt32(reader["Version"]) : 0;
                            isCurrent = reader["IsCurrent"] != DBNull.Value ? Convert.ToBoolean(reader["IsCurrent"]) : false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAssuranceByID: " + ex.Message);
            }

            return isFound;
        }


        public static int AddFullAssurance(
            string firstNameClient, string lastNameClient, string phoneClient, string emailClient,
            int brandID, string model, string matricule,
            int duration, DateTime startDate, DateTime endDate,
            decimal espece, decimal cheque, decimal virBank, decimal wafaSalaf,
            int statusID, int comercialID)
        {
            int newAssuranceID = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand("SP_AddFullAssurance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Input parameters
                command.Parameters.AddWithValue("@p_FirstNameClient", firstNameClient);
                command.Parameters.AddWithValue("@p_LastNameClient", lastNameClient);
                command.Parameters.AddWithValue("@p_PhoneClient", phoneClient);
                command.Parameters.AddWithValue("@p_EmailClient", emailClient);
                command.Parameters.AddWithValue("@p_BrandID", brandID);
                command.Parameters.AddWithValue("@p_Model", model);
                command.Parameters.AddWithValue("@p_Matricule", matricule);
                command.Parameters.AddWithValue("@p_Duration", duration);
                command.Parameters.AddWithValue("@p_StartDate", startDate);
                command.Parameters.AddWithValue("@p_EndDate", endDate);
                command.Parameters.AddWithValue("@p_Espece", espece);
                command.Parameters.AddWithValue("@p_Cheque", cheque);
                command.Parameters.AddWithValue("@p_VirBank", virBank);
                command.Parameters.AddWithValue("@p_WafaSalaf", wafaSalaf);
                command.Parameters.AddWithValue("@p_StatusID", statusID);
                command.Parameters.AddWithValue("@p_ComercialID", comercialID);

                // OUT parameter
                var outParam = new MySqlParameter("@p_AssuranceID", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the output value
                    if (outParam.Value != DBNull.Value)
                        newAssuranceID = Convert.ToInt32(outParam.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in AddFullAssurance: " + ex.Message);
                }
            }

            return newAssuranceID;
        }



        public static bool UpdateAssurance(
            int assuranceID,
            string firstNameClient, string lastNameClient, string phoneClient, string emailClient,
            int brandID, string model, string matricule,
            int duration, DateTime startDate, DateTime endDate,
            decimal espece, decimal cheque, decimal virBank, decimal wafaSalaf,
            int statusID, int comercialID)
        {
            bool isUpdated = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_UpdateAssurance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    // Client
                    cmd.Parameters.AddWithValue("@p_FirstNameClient", firstNameClient);
                    cmd.Parameters.AddWithValue("@p_LastNameClient", lastNameClient);
                    cmd.Parameters.AddWithValue("@p_PhoneClient", string.IsNullOrEmpty(phoneClient) ? DBNull.Value : (object)phoneClient);
                    cmd.Parameters.AddWithValue("@p_EmailClient", string.IsNullOrEmpty(emailClient) ? DBNull.Value : (object)emailClient);

                    // Voiture
                    cmd.Parameters.AddWithValue("@p_BrandID", brandID);
                    cmd.Parameters.AddWithValue("@p_Model", model);
                    cmd.Parameters.AddWithValue("@p_Matricule", matricule);

                    // Duration
                    cmd.Parameters.AddWithValue("@p_Duration", duration);
                    cmd.Parameters.AddWithValue("@p_StartDate", startDate);
                    cmd.Parameters.AddWithValue("@p_EndDate", endDate);

                    // Payment
                    cmd.Parameters.AddWithValue("@p_Espece", espece);
                    cmd.Parameters.AddWithValue("@p_Cheque", cheque);
                    cmd.Parameters.AddWithValue("@p_VirBank", virBank);
                    cmd.Parameters.AddWithValue("@p_WafaSalaf", wafaSalaf);

                    // Assurance
                    cmd.Parameters.AddWithValue("@p_StatusID", statusID);
                    cmd.Parameters.AddWithValue("@p_ComercialID", comercialID);

                    conn.Open();

                    // Instead of ExecuteNonQuery, read the SELECT message
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string msg = reader["Message"].ToString();
                            if (msg.Contains("successfully"))
                                isUpdated = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateAssurance: " + ex.Message);
            }

            return isUpdated;
        }



        public static bool RenewAssurance(
            int assuranceID,
            int duration,
            DateTime startDate,
            DateTime endDate,
            decimal espece,
            decimal cheque,
            decimal virBank,
            decimal wafaSalaf)
        {
            bool isRenewed = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_RenewAssurance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Old Assurance ID
                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    // New Duration info
                    cmd.Parameters.AddWithValue("@p_Duration", duration);
                    cmd.Parameters.AddWithValue("@p_StartDate", startDate);
                    cmd.Parameters.AddWithValue("@p_EndDate", endDate);

                    // New Payment info
                    cmd.Parameters.AddWithValue("@p_Espece", espece);
                    cmd.Parameters.AddWithValue("@p_Cheque", cheque);
                    cmd.Parameters.AddWithValue("@p_VirBank", virBank);
                    cmd.Parameters.AddWithValue("@p_WafaSalaf", wafaSalaf);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string msg = reader["Message"].ToString();
                            if (msg.Contains("successfully"))
                                isRenewed = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in RenewAssurance: " + ex.Message);
            }

            return isRenewed;
        }



        public static bool DeleteAssuranceByID(int assuranceID)
        {
            bool isDeleted = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_DeleteAssuranceByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    conn.Open();

                    // Read the message returned by the SP
                    object result = cmd.ExecuteScalar(); // gets the first column of the first row
                    if (result != null)
                    {
                        string message = result.ToString();
                        Console.WriteLine(message);
                        isDeleted = message.StartsWith("Success");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteAssuranceByID: " + ex.Message);
            }

            return isDeleted;
        }

        public static bool SoftDeleteAssuranceByID(int assuranceID)
        {
            bool isArchived = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_SoftDeleteAssuranceByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string message = result.ToString();
                        Console.WriteLine(message);
                        isArchived = message.StartsWith("Success");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SoftDeleteAssuranceByID: " + ex.Message);
            }

            return isArchived;
        }

        public static bool RestoreAssuranceByID(int assuranceID)
        {
            bool isRestored = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_RestoreAssuranceByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_AssuranceID", assuranceID);

                    conn.Open();

                    // Read the message returned by the SP
                    object result = cmd.ExecuteScalar(); // gets the first column of the first row
                    if (result != null)
                    {
                        string message = result.ToString();
                        Console.WriteLine(message);
                        isRestored = message.StartsWith("Success");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in RestoreAssuranceByID: " + ex.Message);
            }

            return isRestored;
        }

        public static DataTable GetAllAssurances()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from v_assurance_main";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Optional: log error or throw
                    throw new Exception("Error loading assurances: " + ex.Message);
                }
            }

            return dt;
        }

        public static DataTable GetArchivedAssurances()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM v_assurance_archived";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading archived assurances: " + ex.Message);
                }
            }

            return dt;
        }

        public static DataTable GetAssuranceHistories()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
            {
                try
                {
                    conn.Open();

                    // Query the archived/old assurances view
                    string query = "SELECT * FROM v_assurance_old";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading assurance histories: " + ex.Message);
                }
            }

            return dt;
        }


    }
}
