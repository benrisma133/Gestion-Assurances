using GestionAssurances.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Controls
{
    public partial class ctrlMoneyCard : UserControl
    {
        clsPaymentDetails _PaymentDetails;
        public ctrlMoneyCard()
        {
            InitializeComponent();
        }

        public void LoadPaymentDetails(clsPaymentDetails PaymentDetails)
        {

            if (PaymentDetails == null)
            {
                MessageBox.Show("PaymentDetails is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PaymentDetails = PaymentDetails;
            ctrlLabelFieldEspece.FieldValue = PaymentDetails.Espece.ToString("N2");
            ctrlLabelFieldCheque.FieldValue = PaymentDetails.Cheque.ToString("N2");
            ctrlLabelFieldVirBank.FieldValue = PaymentDetails.VirBank.ToString("N2");
            ctrlLabelFieldWafaSalaf.FieldValue = PaymentDetails.WafaSalaf.ToString("N2");
            ctrlLabelFieldTotal.FieldValue = PaymentDetails.Total.ToString("N2");
        }

    }
}
