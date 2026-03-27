using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsDuration
    {

        public int DurationID { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private clsDuration(int DurationID, int Duration, DateTime StartDate, DateTime EndDate)
        {
            this.DurationID = DurationID;
            this.Duration = Duration;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        static public clsDuration FindByID(int DurationID)
        {
            int Duration = 0;
            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MinValue;
            if (clsDurationData.GetDurationByID(DurationID, ref Duration, ref StartDate, ref EndDate))
            {
                return new clsDuration(DurationID, Duration, StartDate, EndDate);
            }
            else
            {
                return null;
            }
        }

    }
}
