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
    public partial class ctrlCarCard : UserControl
    {
        public ctrlCarCard()
        {
            InitializeComponent();
        }

        public void _ResetDefaults()
        {
            lblMarque.Text = "?????????????";
            lblMatricule.Text = "?????????????";
            lblModel.Text = "?????????????";
        }

        public void LoadCarDataByID(int CarID)
        {
            clsCar car = clsCar.FindByID(CarID);

            // Message box an francais : Voiture introuvable !
            if (car == null)
            {
                MessageBox.Show("Voiture introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaults();
                return;
            }

            
            lblMarque.Text = clsBrand.FindByID(car.BrandID).Name;
            lblModel.Text = car.Model;
            lblMatricule.Text = car.Matricule;
            

        }

    }
}
