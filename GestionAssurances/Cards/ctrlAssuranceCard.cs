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

            //lblStatus.Text = clsStatus.FindByID(assurance.StatusID).StatusName;
            //lblIsCurrent.Text = assurance.IsCurrent ? "Oui" : "Non";
            //lblVersion.Text = assurance.Version.ToString();

            if (assurance.IsCurrent)
            {
                ctrlLabelFieldIsCurrent.FieldValue = "Oui";
                ctrlLabelFieldIsCurrent.FieldValueColor = Color.Green;
                ctrlLabelFieldIsCurrent.FieldIconAccept = Properties.Resources.Current;
            }
            else
            {
                ctrlLabelFieldIsCurrent.FieldValue = "Non";
                ctrlLabelFieldIsCurrent.FieldValueColor = Color.Red;
                ctrlLabelFieldIsCurrent.FieldIconAccept = Properties.Resources.not_current;
            }

            string StatusName = clsStatus.FindByID(assurance.StatusID).StatusName;

            ctrlLabelFieldStatus.FieldValue = StatusName;

            // Actif
            // Annulé
            // Expiré

            if (StatusName == "Actif")
            {
                ctrlLabelFieldStatus.FieldValueColor = Color.Green;
                ctrlLabelFieldStatus.FieldIconAccept = Properties.Resources.pending;
            }
            else if (StatusName == "Annulé")
            {
                ctrlLabelFieldStatus.FieldValueColor = Color.OrangeRed;
                ctrlLabelFieldStatus.FieldIconAccept = Properties.Resources.cancel;
                ctrlLabelFieldIsCurrent.FieldValue = "Non";
                ctrlLabelFieldIsCurrent.FieldValueColor = Color.Red;
                ctrlLabelFieldIsCurrent.FieldIconAccept = Properties.Resources.not_current;
            }
            else if (StatusName == "Expiré")
            {
                ctrlLabelFieldStatus.FieldValueColor = Color.Red;
                ctrlLabelFieldStatus.FieldIconAccept = Properties.Resources.expired;
                ctrlLabelFieldIsCurrent.FieldValue = "Non";
                ctrlLabelFieldIsCurrent.FieldValueColor = Color.Red;
                ctrlLabelFieldIsCurrent.FieldIconAccept = Properties.Resources.not_current;
            }

            ctrlLabelFieldVersion.FieldValue = assurance.Version.ToString();
            ctrlLabelFieldVersion.FieldValueColor = Color.Black;
            ctrlLabelFieldVersion.FieldIconAccept = Properties.Resources.version;



        }


    }
}
