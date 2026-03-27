using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsStatus
    {

        // Properties : StatusID ,StatusName ,StatusDescription

        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }

        private clsStatus(int StatusID, string StatusName, string StatusDescription)
        {
            this.StatusID = StatusID;
            this.StatusName = StatusName;
            this.StatusDescription = StatusDescription;
        }

        static public clsStatus FindByID(int StatusID)
        {
            string StatusName = string.Empty;
            string StatusDescription = string.Empty;
            // Dummy data for demonstration purposes
            if(clsStatusData.GetStatusByID(StatusID, ref StatusName, ref StatusDescription))
            {
                return new clsStatus(StatusID, StatusName, StatusDescription);
            }
            else
            {
                return null;
            }
        }

    }
}
