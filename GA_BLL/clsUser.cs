using GA_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsUser : clsPerson
    {

        enum enMode { AddNew, Update }
        enMode _Mode;

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        new public DateTime CreatedAt { get; set; }

        public clsUser() : base()
        {
            UserID = 0;
            Username = string.Empty;
            Password = string.Empty;
            IsActive = false;
            this.CreatedAt = DateTime.MinValue;

            _Mode = enMode.AddNew;

        }

        private clsUser(int userID, string username, string password, bool isActive, DateTime userCreatedAt,
                        int personID, string firstName, string lastName, string email,
                        string phone, string address, DateTime personCreatedAt) :
            base(personID, firstName, lastName, email, phone, address, personCreatedAt)
        {
            UserID = userID;
            Username = username;
            Password = password;
            IsActive = isActive;
            this.CreatedAt = userCreatedAt;
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            base.CreatedAt = personCreatedAt;

            _Mode = enMode.Update;
        }

        static public clsUser GetUserByID(int userID)
        {
            string username = null, password = null;
            bool isActive = false;
            DateTime userCreatedAt = DateTime.MinValue;
            int personID = 0;
            DateTime personCreatedAt = DateTime.MinValue;



            bool isFound = clsUserData.GetUserByID(userID, ref personID,
                    ref username,
                    ref password,
                    ref isActive,
                    ref userCreatedAt);



            if (isFound)
            {
                clsPerson personFound = clsPerson.GetPersonByID(personID);
                return new clsUser(userID, username, password, isActive, userCreatedAt, personID, personFound.FirstName, personFound.LastName,
                    personFound.Email, personFound.Phone, personFound.Address, personFound.CreatedAt);
            }
            else
            {
                return null; // or throw an exception if you prefer
            }
        }

        public static clsUser Login(string username, string password)
        {
            int userID = 0, personID = 0;
            bool isActive = false;
            DateTime userCreatedAt = DateTime.MinValue, personCreatedAt = DateTime.MinValue;
            bool isFound = clsUserData.GetUserByUsernameAndPassword(username, password, ref userID, ref personID, ref isActive, ref userCreatedAt);
            if (isFound)
            {
                clsPerson personFound = clsPerson.GetPersonByID(personID);
                return new clsUser(userID, username, password, isActive, userCreatedAt, personID, personFound.FirstName, personFound.LastName,
                    personFound.Email, personFound.Phone, personFound.Address, personFound.CreatedAt);
            }
            else
            {
                return null; // or throw an exception if you prefer
            }
        }

        bool _AddNew()
        {
            this.UserID = clsUserData.AddNewUser(FirstName, LastName, Email, Phone, Address, Username, Password);

            return this.UserID != -1;
        }

        bool _Update()
        {
            return clsUserData.UpdateUser(UserID, FirstName, LastName, Email, Phone, Address, Username, Password);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
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
                default:
                    {
                        return false;
                    }
            }
        }

        static public bool DeleteUser(int userID)
        {
            return clsUserData.DeleteUser(userID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        static public bool UpdateUserStatus(int userID, bool isActive)
        {
            return clsUserData.UpdateUserStatus(userID, isActive);

        }
    }
}
