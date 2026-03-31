using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    public static class clsDashboardStatsData
    {
        private static string connectionString = clsDataAccessSetting.connectionString;

        public static DataSet GetDashboardStats()
        {
            DataSet ds = new DataSet();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("GetDashboardStats", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle database errors
                Console.WriteLine("Database error: " + ex.Message);
                // Optional: log the error somewhere
            }
            catch (Exception ex)
            {
                // Handle general errors
                Console.WriteLine("General error: " + ex.Message);
            }

            return ds;
        }

        public static DataTable GetAssurancesByStatus()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT s.StatusName, COUNT(*) AS Total
                FROM assurances a
                JOIN statuses s ON a.StatusID = s.StatusID
                GROUP BY s.StatusID;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
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
                Console.WriteLine("Error: " + ex.Message);
            }

            return dt;
        }

        public static DataTable GetAssurancesByMonth()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT MONTH(d.StartDate) AS Month, COUNT(*) AS Total
                FROM assurances a
                JOIN durations d ON a.DurationID = d.DurationID
                GROUP BY MONTH(d.StartDate)
                ORDER BY Month;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
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
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

    }
}
