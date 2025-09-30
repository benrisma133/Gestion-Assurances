using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAssurances.Modals
{
    public class clsPaymentDetails
    {

        public decimal Espece { get; set; }
        public decimal Cheque { get; set; }
        public decimal VirBank { get; set; }
        public decimal WafaSalaf { get; set; }
        public decimal Total { get; set; }

        public clsPaymentDetails(decimal Espece ,decimal Cheque ,decimal VirBank ,decimal WafaSalaf ,decimal Total)
        {
            this.Espece = Espece;
            this.Cheque = Cheque;
            this.VirBank = VirBank;
            this.WafaSalaf = WafaSalaf;
            this.Total = Total;
        }

    }
}
