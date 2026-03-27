using GA_DAL;
using System;

namespace GA_BLL
{
    public class clsResponse
    {
        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int ResponseID { get; private set; }
        public int NotificationID { get; set; }
        public int CommercialID { get; set; }
        public bool HasContactedClient { get; set; }
        public bool RenewalAccepted { get; set; }
        public string Notes { get; set; }
        public DateTime ActionDate { get; private set; }

        // Constructor → AddNew
        public clsResponse()
        {
            ResponseID = -1;
            NotificationID = -1;
            CommercialID = -1;
            HasContactedClient = false;
            RenewalAccepted = false;
            Notes = string.Empty;
            ActionDate = DateTime.Now;

            _Mode = enMode.AddNew;
        }

        // Private constructor → Update
        private clsResponse(
            int responseID,
            int notificationID,
            int commercialID,
            bool contacted,
            bool accepted,
            string notes,
            DateTime actionDate)
        {
            ResponseID = responseID;
            NotificationID = notificationID;
            CommercialID = commercialID;
            HasContactedClient = contacted;
            RenewalAccepted = accepted;
            Notes = notes;
            ActionDate = actionDate;

            _Mode = enMode.Update;
        }

        // ===== FINDER =====
        public static clsResponse FindByNotificationID(int notificationID)
        {
            int responseID = -1;
            int commercialID = -1;
            bool contacted = false;
            bool accepted = false;
            string notes = "";
            DateTime actionDate = default;

            bool isFound = clsResponseData.GetResponseByNotificationID(
                notificationID,
                ref responseID,
                ref commercialID,
                ref contacted,
                ref accepted,
                ref notes,
                ref actionDate
            );

            if (!isFound)
                return null;

            return new clsResponse(
                responseID,
                notificationID,
                commercialID,
                contacted,
                accepted,
                notes,
                actionDate
            );
        }

        // ===== ADD =====
        private bool _AddNew()
        {
            int newID = clsResponseData.AddNewResponse(
                NotificationID,
                CommercialID,
                HasContactedClient,
                RenewalAccepted,
                Notes
            );

            if (newID == -1)
                return false;

            ResponseID = newID;
            return true; // مبدلناش المود هنا نفس ستايل Brand
        }

        // ===== UPDATE =====
        private bool _Update()
        {
            return clsResponseData.UpdateResponseByID(
                ResponseID,
                HasContactedClient,
                RenewalAccepted,
                Notes
            );
        }

        // ===== SAVE =====
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;   // التحويل هنا فقط نفس clsBrand
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }
    }
}
