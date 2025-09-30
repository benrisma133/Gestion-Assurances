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

namespace GestionAssurances
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clsAssurance assurance = clsAssurance.FindByID(1 ,true);

            //if (assurance != null)
            //{
            //    // Modify fields before updating
            //    assurance.Assurance.FirstName = "UpdatedFirstName";
            //    assurance.Assurance.LastName = "UpdatedLastName";
            //    assurance.Assurance.Phone = "0612345678";

            //    bool isUpdated = assurance._Update();

            //    if (isUpdated)
            //        MessageBox.Show("Assurance mise à jour avec succès ✅");
            //    else
            //        MessageBox.Show("Échec de la mise à jour ❌");
            //}
            //else
            //{
            //    MessageBox.Show("Assurance introuvable ❌");
            //}
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrlLabelField1.FieldIconAccept = Properties.Resources.cancel;
            ctrlLabelField2.FieldIconAccept = Properties.Resources.cancel;
            ctrlLabelField3.FieldIconAccept = Properties.Resources.cancel;
            ctrlLabelField4.FieldIconAccept = Properties.Resources.cancel;
        }

        private void gunaShadowPanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowShift = 4; // Increase shadow when hovering
        }

        private void gunaShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowShift = 3; // Reset shadow when leaving
        }
    }
}
