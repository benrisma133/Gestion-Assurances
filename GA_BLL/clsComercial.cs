using GA_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsComercial
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int ComercialID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }

        public clsComercial()
        {
            ComercialID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Username = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsComercial(int comercialID, string firstName, string lastName, string phone, string email, string username)
        {
            ComercialID = comercialID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Username = username;
            _Mode = enMode.Update;
        }

        public static clsComercial FindByID(int comercialID)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            string username = string.Empty;
            bool isFound = GA_DAL.clsComercialData.GetComercialByID(comercialID, ref firstName, ref lastName, ref phone, ref email, ref username);
            if (isFound)
            {
                return new clsComercial(comercialID, firstName, lastName, phone, email, username);
            }
            else
            {
                return null; // Not found
            }
        }

        public static clsComercial FindByUsername(string Username)
        {
            int comercialID = -1;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            string username = string.Empty;
            bool isFound = GA_DAL.clsComercialData.GetComercialByUsername(Username ,ref comercialID, ref firstName, ref lastName, ref phone, ref email);
            if (isFound)
            {
                return new clsComercial(comercialID, firstName, lastName, phone, email, username);
            }
            else
            {
                return null; // Not found
            }
        }

        bool _AddNew()
        {
            this.ComercialID = clsComercialData.AddNewComercial(FirstName, LastName, Phone, Email, Username);
            
            return this.ComercialID != -1;
        }

        bool _Update()
        {
            return clsComercialData.UpdateComercial(ComercialID, FirstName, LastName, Phone, Email, Username);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNew())
                        {
                            _Mode = enMode.Update; // Switch to update mode after adding
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case enMode.Update:
                {
                    return _Update();
                }
            }

            return false; // Should not reach here
        }

        public static bool DeleteByID(int comercialID)
        {
            return clsComercialData.DeleteComercial(comercialID);
        }

        public static DataTable AllComercials()
        {
            return clsComercialData.GetAllComercials();
        }

        public static DataTable GetComercialStatisticsWithMonth()
        {
            return clsComercialData.GetComercialStatisticsWithMonth();
        }

        public static DataTable GetComercialStatisticsWithoutMonth()
        {
            return clsComercialData.GetComercialStatisticsWithoutMonth();
        }


    }
}
