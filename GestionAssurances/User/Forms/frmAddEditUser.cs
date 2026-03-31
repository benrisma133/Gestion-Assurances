using GA_BLL;
using GestionAssurances.Controls;
using GestionAssurances.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.User.Forms
{
    public partial class frmAddEditUser : Form
    {

        enum enMode { AddNew ,Update}
        enMode Mode;

        int _UserID = -1;
        clsUser _User;

        public frmAddEditUser()
        {
            InitializeComponent();

            Mode = enMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            Mode = enMode.Update;

            _UserID = UserID;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefault();
            if(Mode == enMode.Update)
                _LoadData();
        }

        void _ResetDefault()
        {
            if(Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = lblTitle.Text;
                _User = new clsUser();
            }

            else
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
            }


            txtFirstName.FieldValue = string.Empty;
            txtLastName.FieldValue = string.Empty;
            txtEmail.FieldValue = string.Empty;
            txtPassword.FieldValue = string.Empty;
            txtUsername.FieldValue = string.Empty;
            txtConfirmPassword.FieldValue = string.Empty;
            txtPhone.FieldValue = string.Empty;
            txtAddress.FieldValue = string.Empty;
        }

        void _LoadData()
        {
            _User = clsUser.GetUserByID(_UserID);

            if(_User == null)
            {
                MessageBox.Show($"User with ID [{_UserID}] not found." ,"Not found" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFirstName.FieldValue = _User.FirstName;
            txtLastName.FieldValue = _User.LastName;
            txtEmail.FieldValue = _User.Email;
            //txtPassword.FieldValue = _User.Password;
            txtUsername.FieldValue = _User.Username;
            txtAddress.FieldValue = _User.Address;
            txtPhone.FieldValue = _User.Phone;

            txtPassword.Visible = false;
            txtConfirmPassword.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateFields())
            {
                
                MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.FirstName = txtFirstName.FieldValue;
            _User.LastName = txtLastName.FieldValue;
            _User.Email = txtEmail.FieldValue;
            _User.Phone = txtPhone.FieldValue;
            _User.Address = txtAddress.FieldValue;
            _User.Password = clsUtil.HashPassword(txtPassword.FieldValue);
            _User.Username = txtUsername.FieldValue;

            if (_User.Save())
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        {
                            MessageBox.Show($"User added successfully." ,"Success" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblTitle.Text = "Update User";
                            this.Text = lblTitle.Text;
                            Mode = enMode.Update;
                            txtPassword.Visible = false;
                            txtConfirmPassword.Visible = false;
                            break;
                        }
                        case enMode.Update:
                        {
                            MessageBox.Show($"User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show($"User not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateFields()
        {
            bool allValid = true;

            // check empty fields
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { txtFirstName, txtLastName, txtUsername, txtPassword, txtConfirmPassword })
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

            // Password length (only if not empty)
            if (!string.IsNullOrWhiteSpace(txtPassword.FieldValue))
            {
                if (txtPassword.FieldValue.Length < 8)
                {
                    errorProvider1.SetError(txtPassword, "Password must be at least 8 characters.");
                    allValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "");
                }
            }

            // Confirm password (only if password is valid)
            if (!string.IsNullOrWhiteSpace(txtPassword.FieldValue) &&
                txtPassword.FieldValue.Length >= 8)
            {
                if (txtPassword.FieldValue != txtConfirmPassword.FieldValue)
                {
                    errorProvider1.SetError(txtConfirmPassword, "Les mots de passe ne correspondent pas.");
                    allValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtConfirmPassword, "");
                }
            }

            return allValid;
        }

        private void txtFirstName_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
        {
            ctrlTextBox Temp = sender as ctrlTextBox;

            if (string.IsNullOrEmpty(e.Text))
            {
                errorProvider1.SetError(Temp, "Ce champ ne peut pas être vide.");
                Temp.IsVisibleIconAccept = false; // Hide the success icon
                return;
            }
            else
            {
                errorProvider1.SetError(Temp, null); // Clear the error if validation passes
                Temp.IsVisibleIconAccept = true; // Show the success icon
            }
        }

        private void txtConfirmPassword_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
        {
            ctrlTextBox Temp = sender as ctrlTextBox;

            if (string.IsNullOrWhiteSpace(e.Text))
            {
                errorProvider1.SetError(Temp, "Ce champ ne peut pas être vide.");
                Temp.IsVisibleIconAccept = false;
                return;
            }

            if (txtPassword.FieldValue != txtConfirmPassword.FieldValue)
            {
                errorProvider1.SetError(Temp, "Les mots de passe ne correspondent pas.");
                Temp.IsVisibleIconAccept = false;
            }
            else
            {
                errorProvider1.SetError(Temp, null);
                Temp.IsVisibleIconAccept = true;
            }
        }

        private void txtPassword_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
        {
            ctrlTextBox Temp = sender as ctrlTextBox;

            if (string.IsNullOrWhiteSpace(e.Text))
            {
                errorProvider1.SetError(Temp, "Ce champ ne peut pas être vide.");
                Temp.IsVisibleIconAccept = false;
                return;
            }

            if (e.Text.Length < 8)
            {
                errorProvider1.SetError(Temp, "Password must be at least 8 characters.");
                Temp.IsVisibleIconAccept = false;
            }
            else
            {
                errorProvider1.SetError(Temp, null);
                Temp.IsVisibleIconAccept = true;
            }
        }
    }
}
