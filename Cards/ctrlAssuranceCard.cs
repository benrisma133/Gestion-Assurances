using GA_BLL;
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
    public partial class ctrlAssuranceCard : UserControl
    {
        public ctrlAssuranceCard()
        {
            InitializeComponent();
        }

        public void LoadAssuranceDataByID(int AssuranceID)
        {
            clsAssurance assurance = clsAssurance.FindByID(AssuranceID);


            if (assurance == null)
            {
                // Message box an Français
                MessageBox.Show("Assurance non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ComercialUsername = assurance.ComercialInfo.Username;

            ctrlCarCard1.LoadCarDataByID(assurance.CarID);
            ctrlClientCard1.LoadClientDataByID(assurance.ClientID ,ComercialUsername);
            ctrlDurationCard1.LoadDurationDataByID(assurance.DurationID);
            ctrlPaymentCard1._LoadPaymentDataByID(assurance.PaymentID);

            lblStatus.Text = clsStatus.FindByID(assurance.StatusID).StatusName;
            lblIsCurrent.Text = assurance.IsCurrent ? "Oui" : "Non";
            lblVersion.Text = assurance.Version.ToString();

        }


    }
}
