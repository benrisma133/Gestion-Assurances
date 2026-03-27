using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsPayment
    {

        // Properties : PaymentID ,Espece ,Cheque ,VirBank ,WafaAssurance ,Total

        public int PaymentID { get; set; }
        public decimal Espece { get; set; }
        public decimal Cheque { get; set; }
        public decimal VirBank { get; set; }
        public decimal WafaSalaf { get; set; }
        public decimal Total
        {
            get
            {
                return Espece + Cheque + VirBank + WafaSalaf;
            }
        }

        private clsPayment(int PaymentID, decimal Espece, decimal Cheque, decimal VirBank, decimal WafaSalaf)
        {
            this.PaymentID = PaymentID;
            this.Espece = Espece;
            this.Cheque = Cheque;
            this.VirBank = VirBank;
            this.WafaSalaf = WafaSalaf;
        }

        static public clsPayment FindByID(int PaymentID)
        {
            decimal Espece = 0;
            decimal Cheque = 0;
            decimal VirBank = 0;
            decimal WafaSalaf = 0;
            if (clsPaymentData.GetPaymentByID(PaymentID, ref Espece, ref Cheque, ref VirBank, ref WafaSalaf))
            {
                return new clsPayment(PaymentID, Espece, Cheque, VirBank, WafaSalaf);
            }
            else
            {
                return null;
            }
        }


    }
}
