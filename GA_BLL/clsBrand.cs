using GA_DAL;
using System;
using System.Data;

namespace GA_BLL
{
    public class clsBrand
    {
        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int BrandID { get; set; }
        public string Name { get; set; }

        // Default constructor → AddNew mode
        public clsBrand()
        {
            BrandID = -1;
            Name = string.Empty;
            _Mode = enMode.AddNew;
        }

        // Private constructor → Update mode
        private clsBrand(int brandID, string name)
        {
            BrandID = brandID;
            Name = name;
            _Mode = enMode.Update;
        }

        // Find Brand by ID
        public static clsBrand FindByID(int brandID)
        {
            string name = string.Empty;
            bool isFound = clsBrandData.GetBrandByID(brandID, ref name);

            if (isFound)
            {
                return new clsBrand(brandID, name);
            }
            else
            {
                return null; // Not found
            }
        }

        // Find Brand By Name
        public static clsBrand FindByName(string brandName)
        {
            int brandID = -1;
            bool isFound = clsBrandData.GetBrandByName(brandName, ref brandID);

            if (isFound)
            {
                return new clsBrand(brandID, brandName);
            }
            else
            {
                return null; // Not found
            }
        }

        // Add new Brand
        bool _AddNew()
        {
            this.BrandID = clsBrandData.AddNewBrand(Name);
            return this.BrandID != -1;
        }

        // Update Brand
        bool _Update()
        {
            return clsBrandData.UpdateBrandByID(BrandID, Name);
        }

        // Save (Add or Update based on mode)
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update; // Switch to update mode after adding
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false; // Should never reach here
        }

        // Delete Brand by ID
        public static bool DeleteByID(int brandID)
        {
            return clsBrandData.DeleteBrandByID(brandID);
        }

        // Get all Brands
        public static DataTable AllBrands()
        {
            return clsBrandData.GetAllBrands();
        }
    }
}
