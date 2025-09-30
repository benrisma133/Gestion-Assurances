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

namespace GestionAssurances.Assurance
{
    public partial class frmTotal : Form
    {

        clsPaymentDetails _PaymentDetails;

        public frmTotal(clsPaymentDetails PaymentDetails)
        {
            InitializeComponent();

            _PaymentDetails = PaymentDetails;
        }

        private void frmTotal_Load(object sender, EventArgs e)
        {
            ctrlMoneyCard1.LoadPaymentDetails(_PaymentDetails);
        }
    }
}
