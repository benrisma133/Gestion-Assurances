using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsClient
    {

        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        private clsClient(int ClientID ,string FirstName ,string LastName ,string Email ,string Phone)
        {
            this.ClientID = ClientID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        static public clsClient FindByID(int ClientID)
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;

            if(clsClientData.GetClientInfoByClientID(ClientID, ref FirstName, ref LastName, ref Phone, ref Email))
            {
                return new clsClient(ClientID, FirstName, LastName, Email, Phone);
            }
            else
            {
                return null;
            }

        }

    }
}
