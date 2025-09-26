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
    public partial class ctrlClientCard : UserControl
    {
        public ctrlClientCard()
        {
            InitializeComponent();
        }

        public void _ResetDefaults()
        {
            lblClient.Text = "?????????????";
            lblTele.Text = "?????????????";
            lblEmail.Text = "?????????????";
            lblComercial.Text = "?????????????";
        }

        public void LoadClientDataByID(int ClientID ,string ComercialUsername)
        {
            GA_BLL.clsClient client = GA_BLL.clsClient.FindByID(ClientID);

            if(client == null)
            {
                // Message box an francais : Client introuvable !
                MessageBox.Show("Client introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaults();
                return;
            }

            
            lblClient.Text = client.FullName;
            lblTele.Text = client.Phone;
            lblEmail.Text = client.Email;
            lblComercial.Text = ComercialUsername;
            
        }


    }
}
