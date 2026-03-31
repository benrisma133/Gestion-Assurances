using System;
using System.Data;
using GA_DAL; // assuming your DAL namespace
using System.Collections.Generic;

namespace GA_BLL
{
    // DTO for the dashboard
    public class DashboardDTO
    {
        public int TotalAssurances { get; set; }
        public int CurrentAssurances { get; set; }
        public int TotalClients { get; set; }
        public int ExpiredAssurances { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal RevenueToday { get; set; }
        public string TopComercialName { get; set; }
        public int TopComercialCount { get; set; }
        public string TopBrandName { get; set; }
        public int TopBrandCount { get; set; }
    }

    public class StatusDTO
    {
        public string StatusName { get; set; }
        public int Total { get; set; }
    }

    public class MonthlyDTO
    {
        public int Month { get; set; }
        public int Total { get; set; }
    }

    public static class clsDashboardStats
    {
        // Call DAL, convert to DTO
        public static DashboardDTO GetDashboard()
        {
            DashboardDTO dto = new DashboardDTO();

            try
            {
                // Call DAL to get DataSet
                DataSet ds = clsDashboardStatsData.GetDashboardStats();

                if (ds != null && ds.Tables.Count >= 8)
                {
                    dto.TotalAssurances = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    dto.CurrentAssurances = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
                    dto.TotalClients = Convert.ToInt32(ds.Tables[2].Rows[0][0]);
                    dto.ExpiredAssurances = Convert.ToInt32(ds.Tables[3].Rows[0][0]);
                    dto.TotalRevenue = ds.Tables[4].Rows[0][0] != DBNull.Value
                        ? Convert.ToDecimal(ds.Tables[4].Rows[0][0])
                        : 0;
                    dto.RevenueToday = ds.Tables[5].Rows[0][0] != DBNull.Value
                        ? Convert.ToDecimal(ds.Tables[5].Rows[0][0])
                        : 0;
                    dto.TopComercialName = ds.Tables[6].Rows.Count > 0
                        ? ds.Tables[6].Rows[0]["Username"].ToString()
                        : "N/A";

                    dto.TopComercialCount = ds.Tables[6].Rows.Count > 0
                        ? Convert.ToInt32(ds.Tables[6].Rows[0]["TotalSales"])
                        : 0;

                    dto.TopBrandName = ds.Tables[7].Rows.Count > 0
                        ? ds.Tables[7].Rows[0]["Name"].ToString()
                        : "N/A";

                    dto.TopBrandCount = ds.Tables[7].Rows.Count > 0
                        ? Convert.ToInt32(ds.Tables[7].Rows[0]["Total"])
                        : 0;
                }
            }
            catch (Exception ex)
            {
                // Handle errors (log or rethrow if needed)
                Console.WriteLine("Error in BLL: " + ex.Message);
            }

            return dto;
        }

        public static List<StatusDTO> GetAssurancesByStatus()
        {
            List<StatusDTO> list = new List<StatusDTO>();

            try
            {
                DataTable dt = clsDashboardStatsData.GetAssurancesByStatus();

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new StatusDTO
                    {
                        StatusName = row["StatusName"].ToString(),
                        Total = Convert.ToInt32(row["Total"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("BLL Error: " + ex.Message);
            }

            return list;
        }

        public static List<MonthlyDTO> GetAssurancesByMonth()
        {
            var list = new List<MonthlyDTO>();

            try
            {
                var dt = clsDashboardStatsData.GetAssurancesByMonth();

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new MonthlyDTO
                    {
                        Month = Convert.ToInt32(row["Month"]),
                        Total = Convert.ToInt32(row["Total"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}