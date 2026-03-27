using GA_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Comercial.Controls
{
    public partial class ctrlComercialInfo : UserControl
    {

        clsComercial _Comercial;
        int _ComercialID;

        public clsComercial Comercial
        {
            get
            {
                return _Comercial;
            }
        }

        public int ComercialID
        {
            get
            {
                return _ComercialID;
            }
        }

        public ctrlComercialInfo()
        {
            InitializeComponent();
        }

        public void ResetDefaultInfo()
        {
            lblPrenom.Text = "???????????";
            lblNom.Text = "???????????";
            lblTelephone.Text = "???????????";
            lblEmail.Text = "???????????";
            lblUsername.Text = "???????????";
        }

        void _LoadInfo()
        {
            lblPrenom.Text = _Comercial.FirstName;
            lblNom.Text = _Comercial.LastName;
            lblUsername.Text = _Comercial.Username;

            if (string.IsNullOrEmpty(_Comercial.Email))
                lblEmail.Text = "-----------------";
            else
                lblEmail.Text = _Comercial.Email;

            if (!string.IsNullOrEmpty(_Comercial.Phone))
            {

                string formattedTele = _Comercial.Phone;

                int lengthOfDelimiters = " - ".Length; // Number of characters between spaces

                string spacedPhone = Regex.Replace(formattedTele, ".{2}", "$0 - ");
                spacedPhone = spacedPhone.Substring(0, spacedPhone.Length - lengthOfDelimiters); // Remove the last delimiter
                spacedPhone = spacedPhone.Trim();

                // Set the formatted telephone number to the control
                lblTelephone.Text = spacedPhone;
            }
            else
            {
                lblTelephone.Text = "-- -- -- -- --";
            }

        }

        public void LoadComercialInfo(int ComercialID)
        {
            _Comercial = clsComercial.FindByID(ComercialID);
            
            if(_Comercial == null)
            {
                // Message box an francais 
                MessageBox.Show("Comercial introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultInfo();
                _ComercialID = -1;
                return;
            }

            _ComercialID = ComercialID;
            _LoadInfo();

        }

    }
}
