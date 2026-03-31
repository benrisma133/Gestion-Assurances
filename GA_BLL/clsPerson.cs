using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsPerson
    {

        public int PersonID { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }
        public string Address { get;  set; }
        public DateTime CreatedAt { get;  set; }

        public string FullName => $"{FirstName} {LastName}";

        public clsPerson()
        {
            PersonID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            CreatedAt = DateTime.MinValue;
        }

        public clsPerson(int personID, string firstName, string lastName, string email, string phone, string address, DateTime createdAt)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            CreatedAt = createdAt;
        }

        static public clsPerson GetPersonByID(int personID)
        {
            string firstName = null, lastName = null, email = null, phone = null, address = null;
            DateTime createdAt = DateTime.MinValue;
            bool isFound = clsPersonData.GetPersonByID(personID,
                ref firstName,
                ref lastName,
                ref email,
                ref phone,
                ref address,
                ref createdAt);
            if (isFound)
            {
                return new clsPerson(personID, firstName, lastName, email, phone, address, createdAt);
            }
            else
            {
                return null; // or throw an exception if you prefer
            }

        }
    }
}
