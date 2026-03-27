using GA_BLL;
using GestionAssurances.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Brand.Forms
{
    public partial class frmAddEditBrand : Form
    {

        int _BrandID;
        clsBrand _Brand;

        enum enMode { AddNew =0 ,Update = 1}
        enMode _Mode;

        public frmAddEditBrand()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditBrand(int BrandID)
        {
            InitializeComponent();

            _Mode = enMode.Update;

            _BrandID = BrandID;
        }

        void _ResetDefaultValues()
        {
            txtFieldMarque.FieldValue = "";

            if(_Mode == enMode.Update)
            {
                lblTitle.Text = "Editer Marque";
                this.Text = "Editer Marque";
            }
            else
            {
                _Brand = new clsBrand();
                lblTitle.Text = "Ajouter Marque";
                this.Text = "Ajouter Marque";
            }

        }

        void _LoadData()
        {
            _Brand = clsBrand.FindByID(_BrandID);


            if (_Brand == null)
            {
                MessageBox.Show("Marque introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFieldMarque.FieldValue = _Brand.Name;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateBrandField())
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de continuer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Brand.Name = txtFieldMarque.FieldValue.Trim();

            if (_Brand.Save()) 
            { 
                if(_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    _BrandID = _Brand.BrandID;
                    lblTitle.Text = "Editer Marque";
                    this.Text = "Editer Marque";
                    MessageBox.Show("Marque ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Change mode to Update after adding a new Brand
                lblTitle.Text = "Editer Marque";
                this.Text = "Editer Marque";
                MessageBox.Show("Marque éditée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show($"Échec de l'enregistrement de la marque. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateBrandField()
        {
            bool allValid = true;

            // قائمة كل cfTextBox
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { txtFieldMarque })
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

        private void txtFieldMarque_ValidatingTextChanged(object sender, Controls.ctrlTextBox.ValidationEventArgs e)
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

        private void frmAddEditBrand_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
            {
                _LoadData();
            }
        }
    }
}
