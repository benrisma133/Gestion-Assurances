using GA_BLL;
using GestionAssurances.Controls;
using GestionAssurances.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAssurances.Comercial.Forms
{
    public partial class frmAddEditComercial : Form
    {

        int _ComercialID;
        clsComercial _Comercial;

        enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        enMode _Mode = enMode.AddNew;

        public frmAddEditComercial()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditComercial(int ComercialID)
        {
            InitializeComponent();

            _Mode = enMode.Update;

            _ComercialID = ComercialID;
        }

        void _ResetDefaultInfo()
        {
            fieldPrenom.FieldValue = string.Empty;
            fieldNom.FieldValue = string.Empty;
            fieldTele.FieldValue = string.Empty;
            fieldEmail.FieldValue = string.Empty;
            fieldUsername.FieldValue = string.Empty;

            if (_Mode == enMode.Update)
            {
                lblTitle.Text = "Editer Comercial";
                this.Text = "Editer Comercial";
            }

            else
            {
                _Comercial = new clsComercial();
                lblTitle.Text = "Ajouter Comercial";
                this.Text = "Ajouter Comercial";
            }
        }

        void _LoadComercialInfo()
        {
            _Comercial = clsComercial.FindByID(_ComercialID);
            if (_Comercial != null)
            {
                fieldPrenom.FieldValue = _Comercial.FirstName;
                fieldNom.FieldValue = _Comercial.LastName;
                fieldTele.FieldValue = _Comercial.Phone;
                fieldEmail.FieldValue = _Comercial.Email;
                fieldUsername.FieldValue = _Comercial.Username;
            }
            else
            {
                MessageBox.Show("Erreur: Comercial introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            _ResetDefaultInfo();

            if (_Mode == enMode.Update)
            {
                _LoadComercialInfo();
            }
        }

        private void fieldPrenom_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
        {
            ctrlTextBox Temp = sender as ctrlTextBox;

            if (string.IsNullOrEmpty(e.Text))
            {
                errorProvider1.SetError(Temp, "Ce champ ne peut pas être vide.");
                Temp.IsVisibleIconAccept = false; // Hide the success icon
            }
            else
            {
                errorProvider1.SetError(Temp, null); // Clear the error if validation passes
                Temp.IsVisibleIconAccept = true; // Show the success icon
            }
        }

        private bool ValidateComercialFields()
        {
            bool allValid = true;

            // قائمة كل cfTextBox
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { fieldPrenom, fieldNom })
            {
                if (string.IsNullOrWhiteSpace(ctl.FieldValue))
                {
                    errorProvider1.SetError(ctl, "Ce champ ne peut pas être vide.");
                    allValid = false;
                }
                else
                {
                    errorProvider1.SetError(ctl, "");
                }
            }

            return allValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateComercialFields())
            {
                // Check if there are any validation errors
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Comercial.FirstName = fieldPrenom.FieldValue;
            _Comercial.LastName = fieldNom.FieldValue;
            _Comercial.Phone = fieldTele.FieldValue;
            _Comercial.Email = fieldEmail.FieldValue;
            _Comercial.Username = fieldUsername.FieldValue;

            if (_Comercial.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    lblTitle.Text = "Editer Comercial";
                    this.Text = "Editer Comercial";
                    MessageBox.Show("Comercial ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Change mode to Update after adding a new comercial
                lblTitle.Text = "Editer Comercial";
                this.Text = "Editer Comercial";
                MessageBox.Show("Comercial édité avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Failed to save comercial. Please try again.{_Comercial.Username}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
