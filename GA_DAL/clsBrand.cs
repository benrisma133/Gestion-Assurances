using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    public static class clsBrandData
    {
        // Get Brand by ID
        public static bool GetBrandByID(int brandID, ref string name)
        {
            bool isFound = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_GetBrandByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_BrandID", brandID);

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetBrandByID: " + ex.Message);
            }

            return isFound;
        }

        public static bool GetBrandByName(string name, ref int brandID)
        {
            bool isFound = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_GetBrandByName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Name", name);

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assign the BrandID from the reader to the ref parameter
                            brandID = Convert.ToInt32(reader["BrandID"]);
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetBrandByName: " + ex.Message);
            }

            return isFound;
        }


        // Add New Brand (returns new ID)
        public static int AddNewBrand(string name)
        {
            int newID = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_AddNewBrand", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Name", name);

                    // OUT parameter for new BrandID
                    MySqlParameter outputId = new MySqlParameter("@p_NewID", MySqlDbType.Int32);
                    outputId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    newID = Convert.ToInt32(outputId.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewBrand: " + ex.Message);
            }
            return newID;
        }

        // Update Brand
        public static bool UpdateBrandByID(int brandID, string name)
        {
            bool isUpdated = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_UpdateBrandByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_BrandID", brandID);
                    cmd.Parameters.AddWithValue("@p_Name", name);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateBrandByID: " + ex.Message);
            }
            return isUpdated;
        }

        // Delete Brand
        public static bool DeleteBrandByID(int brandID)
        {
            bool isDeleted = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_DeleteBrandByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_BrandID", brandID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    isDeleted = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteBrandByID: " + ex.Message);
            }
            return isDeleted;
        }

        // Get All Brands
        public static DataTable GetAllBrands()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(clsDataAccessSetting.connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SP_GetAllBrands", conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllBrands: " + ex.Message);
            }
            return dt;
        }
    }

}
