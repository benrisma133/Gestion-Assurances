using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Cards
{
    public partial class ctrlPaymentCard : UserControl
    {
        public ctrlPaymentCard()
        {
            InitializeComponent();
        }

        public void _RestDefaults()
        {
            lblEspece.Text = "????????????";
            lblCheque.Text = "????????????";
            lblVirBank.Text = "????????????";
            lblWafaSalaf.Text = "????????????";
            lblTotal.Text = "????????????";
        }

        public void _LoadPaymentDataByID(int PaymentID)
        {
            GA_BLL.clsPayment payment = GA_BLL.clsPayment.FindByID(PaymentID);
            if(payment == null)
            {
                MessageBox.Show("Paiement non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _RestDefaults();
                return;
            }
            lblEspece.Text = payment.Espece.ToString("N2") + " MAD";
            lblCheque.Text = payment.Cheque.ToString("N2") + " MAD";
            lblVirBank.Text = payment.VirBank.ToString("N2") + " MAD";
            lblWafaSalaf.Text = payment.WafaSalaf.ToString("N2") + " MAD";
            lblTotal.Text = payment.Total.ToString("N2") + " MAD";
        }

    }
}
