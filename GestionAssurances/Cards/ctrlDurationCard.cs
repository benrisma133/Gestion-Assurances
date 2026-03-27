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
    public partial class ctrlDurationCard : UserControl
    {
        public ctrlDurationCard()
        {
            InitializeComponent();
        }

        public void _ResetDefaults()
        {
            lblDure.Text = "????????????";
            lblDebut.Text = "????????????";
            lblFin.Text = "????????????";
        }

        public void LoadDurationDataByID(int DurationID)
        {
            clsDuration duration = clsDuration.FindByID(DurationID);

            // Message box an Français

            if(duration == null)
            {
                MessageBox.Show("Durée non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaults();
                return;
            }

            lblDure.Text = duration.Duration.ToString();
            lblDebut.Text = duration.StartDate.ToString("dd/MM/yyyy");
            lblFin.Text = duration.EndDate.ToString("dd/MM/yyyy");

        }

    }
}
