using GA_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsAssurance
    {
        enum enMode { AddNew = 0 ,Update = 1 ,Renew = 2}
        enMode _Mode;

        public int AssuranceID { get; set; }
        public int ClientID { get; set; }
        public clsClient ClientInfo;

        public int CarID { get; set; }
        public clsCar CarInfo;

        public int DurationID { get; set; }
        public clsDuration DurationInfo;

        public int PaymentID { get; set; }
        public clsPayment PaymentInfo;

        public int StatusID { get; set; }
        public clsStatus StatusInfo;

        public class AssuranceDTO
        {
            // Client info
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            // Car info
            public int BrandID { get; set; }
            public string Model { get; set; }
            public string Matricule { get; set; }

            // Duration
            public int Duration { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

            // Payment
            public decimal Espece { get; set; }
            public decimal Cheque { get; set; }
            public decimal VirBank { get; set; }
            public decimal WafaSalaf { get; set; }

            
        }

        public class RenewalDTO
        {
            public int Duration { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal Espece { get; set; }
            public decimal Cheque { get; set; }
            public decimal VirBank { get; set; }
            public decimal WafaSalaf { get; set; }
        }


        public AssuranceDTO Assurance { get; set; }

        
        public int ComercialID { get; set; }
        public clsComercial ComercialInfo;
        public int Version {  get; set; }
        public bool IsCurrent {  get; set; }

        public clsAssurance()
        {

            this.Assurance = new AssuranceDTO();

            this.AssuranceID = 0;
            Assurance.FirstName = string.Empty;
            Assurance.LastName = string.Empty;
            Assurance.Phone = string.Empty;
            Assurance.Email = string.Empty;

            Assurance.BrandID = -1;
            Assurance.Model = string.Empty;
            Assurance.Matricule = string.Empty;

            Assurance.Duration = 0;
            Assurance.StartDate = DateTime.MinValue;
            Assurance.EndDate = DateTime.MaxValue;

            Assurance.Espece = 0;
            Assurance.Cheque = 0;
            Assurance.VirBank = 0;
            Assurance.WafaSalaf = 0;

            _Mode = enMode.AddNew;

        }

        private clsAssurance(int AssuranceID ,int ClientID ,int CarID ,int DurationID ,int PaymentID ,int StatusID ,
            int ComercialID ,int Version ,bool IsCurrent ,enMode Mode = enMode.Update)
        {
            this.AssuranceID = AssuranceID;

            this.ClientID = ClientID;
            this.ClientInfo = clsClient.FindByID(ClientID);

            this.CarID = CarID;
            this.CarInfo = clsCar.FindByID(CarID);

            this.DurationID = DurationID;
            this.DurationInfo = clsDuration.FindByID(DurationID);

            this.PaymentID = PaymentID;
            this.PaymentInfo = clsPayment.FindByID(PaymentID);

            this.StatusID = StatusID;
            this.StatusInfo = clsStatus.FindByID(StatusID);

            this.ComercialID = ComercialID;
            this.ComercialInfo = clsComercial.FindByID(ComercialID);

            this.Version = Version;
            this.IsCurrent = IsCurrent;

            this.Assurance = new AssuranceDTO();


            Assurance.FirstName = ClientInfo.FirstName;
            Assurance.LastName = ClientInfo.LastName;
            Assurance.Email = ClientInfo.Email;
            Assurance.Phone = ClientInfo.Phone;

            Assurance.BrandID = CarInfo.BrandID;
            Assurance.Model = CarInfo.Model;
            Assurance.Matricule = CarInfo.Matricule;

            Assurance.Duration = DurationInfo.Duration;
            Assurance.StartDate = DurationInfo.StartDate;
            Assurance.EndDate = DurationInfo.EndDate;

            Assurance.Espece = PaymentInfo.Espece;
            Assurance.Cheque = PaymentInfo.Cheque;
            Assurance.VirBank = PaymentInfo.VirBank;
            Assurance.WafaSalaf = PaymentInfo.WafaSalaf;

            _Mode = Mode;
        }

        static public clsAssurance FindByID(int AssuranceID ,bool isRenew = false)
        {
            int ClientID = -1;
            int CarID = -1;
            int DurationID = -1;
            int PaymentID = -1;
            int StatusID = -1;
            int ComercialID = -1;
            int Version = -1;
            bool IsCurrent = false;

            if(clsAssuranceData.GetAssuranceByID(AssuranceID ,ref ClientID ,ref CarID ,ref DurationID ,ref PaymentID ,ref StatusID ,ref Version ,ref IsCurrent ,ref ComercialID))
            {
                if(!isRenew)
                    return new clsAssurance(AssuranceID, ClientID, CarID, DurationID, PaymentID, StatusID, ComercialID, Version, IsCurrent);
                else
                    return new clsAssurance(AssuranceID, ClientID, CarID, DurationID, PaymentID, StatusID, ComercialID, Version, IsCurrent ,enMode.Renew);

            }
            return null;
        }

        

        bool _AddNew()
        {
            this.AssuranceID = clsAssuranceData.AddFullAssurance(Assurance.FirstName, Assurance.LastName, Assurance.Phone, Assurance.Email,
                                                                 Assurance.BrandID, Assurance.Model, Assurance.Matricule,
                                                                 Assurance.Duration, Assurance.StartDate, Assurance.EndDate,
                                                                 Assurance.Espece, Assurance.Cheque, Assurance.VirBank, Assurance.WafaSalaf,
                                                                 StatusID, ComercialID);

            return this.AssuranceID != -1;

        }

        bool _Update()
        {
            return clsAssuranceData.UpdateAssurance(this.AssuranceID,Assurance.FirstName, Assurance.LastName, Assurance.Phone, Assurance.Email,
                                                                 Assurance.BrandID, Assurance.Model, Assurance.Matricule,
                                                                 Assurance.Duration, Assurance.StartDate, Assurance.EndDate,
                                                                 Assurance.Espece, Assurance.Cheque, Assurance.VirBank, Assurance.WafaSalaf,
                                                                 StatusID, ComercialID);
        }

        bool _Renew()
        {
            return clsAssuranceData.RenewAssurance(
                this.AssuranceID,
                this.Assurance.Duration,
                this.Assurance.StartDate,
                this.Assurance.EndDate,
                this.Assurance.Espece,
                this.Assurance.Cheque,
                this.Assurance.VirBank,
                this.Assurance.WafaSalaf
            );
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

                case enMode.Renew:
                    {
                        if (_Renew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else 
                            return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        static public bool Delete(int AssuranceID)
        {
            return clsAssuranceData.DeleteAssuranceByID(AssuranceID);
        }

        static public bool SoftDeleteAssuranceByID(int AssuranceID)
        {
            return clsAssuranceData.SoftDeleteAssuranceByID(AssuranceID);
        }

        static public bool RestoreAssuranceByID(int AssuranceID)
        {
            return clsAssuranceData.RestoreAssuranceByID(AssuranceID);
        }

        static public DataTable GetArchivedAssurances()
        {
            return clsAssuranceData.GetArchivedAssurances();
        }

        static public DataTable GetAssuranceHistories()
        {
            return clsAssuranceData.GetAssuranceHistories();
        }

        public static DataTable GetAllAssurances()
        {
            return clsAssuranceData.GetAllAssurances();
        }

    }
}
