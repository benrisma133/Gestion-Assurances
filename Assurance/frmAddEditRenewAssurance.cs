using GA_BLL;
using GestionAssurances.Controls;
using GestionAssurances.Properties;
using Mysqlx.Crud;
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

namespace GestionAssurances.Assurance
{
    public partial class frmAddEditRenewAssurance : Form
    {

        int _Year = DateTime.Now.Year;
        int _Month = DateTime.Now.Month;
        int _Day = DateTime.Now.Day;

        int _AssuranceID;

        clsAssurance _Assurance;

        enum enMode { Add = 1, Update = 2, Renew = 3 }
        enMode _Mode;

        enum enResult { Success = 1, Failed = 2 }
        enResult _Result = enResult.Failed;

        public frmAddEditRenewAssurance()
        {
            InitializeComponent();

            _Mode = enMode.Add;
        }

        public frmAddEditRenewAssurance(int AssuranceID ,bool isRenew = false)
        {
            InitializeComponent();

            _AssuranceID = AssuranceID;

            if (isRenew)
                _Mode = enMode.Renew;
            else
                _Mode = enMode.Update;
        }

        void _FillComboBoxWithComercials()
        {
            DataTable dtComercials = clsComercial.AllComercials();

            foreach (DataRow row in dtComercials.Rows)
            {
                cbFieldComercial.MyComboBox.Items.Add(row["Username"]);
            }
        }

        void _FillComboBoxWithBrands()
        {
            DataTable dtBrands = clsBrand.AllBrands();

            foreach (DataRow row in dtBrands.Rows)
            {
                cbFieldMarque.MyComboBox.Items.Add(row["Name"]);
            }
        }

        void _FillComboBoxWithDure()
        {
            cbFieldDure.MyComboBox.Items.Clear(); // Clear existing items to avoid duplicates
            if (cbFieldDure.MyComboBox.Items.Count > 0)
                return; // If items are already filled, no need to fill again
            cbFieldDure.MyComboBox.Items.Add("12");
            cbFieldDure.MyComboBox.Items.Add("6");
            cbFieldDure.MyComboBox.Items.Add("3");
            cbFieldDure.MyComboBox.Items.Add("1");
        }

        void _FillCoboBoxWithMois()
        {
            if (cbFieldMois.MyComboBox.Items.Count > 0)
                return; // If items are already filled, no need to fill again
            cbFieldMois.MyComboBox.Items.Add("1");
            cbFieldMois.MyComboBox.Items.Add("2");
            cbFieldMois.MyComboBox.Items.Add("3");
            cbFieldMois.MyComboBox.Items.Add("4");
            cbFieldMois.MyComboBox.Items.Add("5");
            cbFieldMois.MyComboBox.Items.Add("6");
            cbFieldMois.MyComboBox.Items.Add("7");
            cbFieldMois.MyComboBox.Items.Add("8");
            cbFieldMois.MyComboBox.Items.Add("9");
            cbFieldMois.MyComboBox.Items.Add("10");
            cbFieldMois.MyComboBox.Items.Add("11");
            cbFieldMois.MyComboBox.Items.Add("12");
        }

        void _FillCoboBoxWithAnnee()
        {
            if (cbFieldAnnee.MyComboBox.Items.Count > 0)
                return; // If items are already filled, no need to fill again
            // Dynamicly fill the years from 2000 to the current year
            int currentYear = DateTime.Now.Year;
            for (int i = 2000; i <= currentYear; i++)
            {
                cbFieldAnnee.MyComboBox.Items.Add(i.ToString());
            }
        }

        void _FillComboBoxWithDays(int Year, int Month)
        {
            int currentYear = Year;

            int currentMonth = Month;
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            for (int i = 1; i <= daysInMonth; i++)
            {
                cbFieldJour.MyComboBox.Items.Add(i.ToString());
            }
        }

        void _LoadDateToComboBoxes()
        {

            cbFieldJour.MyComboBox.DropDownHeight = 290;
            cbFieldMois.MyComboBox.DropDownHeight = 200;
            cbFieldAnnee.MyComboBox.DropDownHeight = 290;


            _FillComboBoxWithDure();
            _FillCoboBoxWithAnnee();
            _FillCoboBoxWithMois();
            _FillComboBoxWithDays(_Year, _Month);

            cbFieldAnnee.MyComboBox.SelectedIndex = cbFieldAnnee.MyComboBox.FindString(_Year.ToString());
            cbFieldMois.MyComboBox.SelectedIndex = cbFieldMois.MyComboBox.FindString(_Month.ToString());
            cbFieldJour.MyComboBox.SelectedIndex = cbFieldJour.MyComboBox.FindString(_Day.ToString());
            cbFieldDure.MyComboBox.SelectedIndex = cbFieldDure.MyComboBox.FindString("3");
        }

        void _ResetDefaultClientValues()
        {
            // Client Fields
            txtFieldPrenom.FieldValue = string.Empty;
            txtFieldNom.FieldValue = string.Empty;
            txtFieldTelephone.FieldValue = string.Empty;
            txtFieldEmail.FieldValue = string.Empty;
            cbFieldComercial.MyComboBox.SelectedIndex = cbFieldComercial.MyComboBox.FindString("M.MOUDEN");
        }

        void _ResetDefaultVtBasicDetailsValues()
        {

            // Vehicle Details Fields
            txtFieldModel.FieldValue = string.Empty;
            txtFieldMatricule.FieldValue = string.Empty;
            cbFieldMarque.MyComboBox.SelectedIndex = cbFieldMarque.MyComboBox.FindString("DACIA");
        }

        void _ResetDefaultVtDureValues()
        {
            cbFieldDure.MyComboBox.SelectedIndex = cbFieldDure.MyComboBox.FindString("3");

        }

        void _ResetDefaultVtPaimentValues()
        {
            txtFieldEspece.FieldValue = "";
            txtFieldCheque.FieldValue = "";
            txtFieldVirBank.FieldValue = "";
            txtFieldWafaSalaf.FieldValue = "";
        }

        void _ResetToAddNewMode()
        {
            _Assurance = new clsAssurance();
            lblTitle.Text = "Créer un Nouveau Assurance";
            pbTitle.Image = Resources.add_person_40_green;
            // title en francai add new client and car
            this.Text = "Ajouter un nouveau";
            //this.Icon = Properties.Resources.client_add_black_42_icon; // Assuming you have an icon in your resources
        }

        void _ResetToUpdateMode()
        {
            lblTitle.Text = "Modifier l'Assurance";
            pbTitle.Image= Resources.edit_person_40_green;
            // title en francai update client and car
            this.Text = "Modifier l'Assurance";
            //this.Icon = Properties.Resources.update_person_42_black_icon; // Assuming you have an icon in your resources
        }

        void _ResetToRenewMode()
        {
            txtFieldNom.Enabled = false;
            txtFieldPrenom.Enabled = false;
            txtFieldTelephone.Enabled = false;
            txtFieldEmail.Enabled = false;

            txtFieldMatricule.Enabled = false;
            txtFieldModel.Enabled = false;
            cbFieldComercial.Enabled = false;
            cbFieldMarque.Enabled = false;

            tabControl1.SelectedTab = tbVehiculDure;

            lblTitle.Text = "Renouveler l'Assurance";
            pbTitle.Image = Resources.renew_32_green;
            // title en francai renew car insurance
            this.Text = "Renouveler l'Assurance";
            //this.Icon = Properties.Resources.renew_32_green; // Assuming you have an icon in your resources
        }

        void _ResetAllDefaultValues()
        {
            _LoadDateToComboBoxes();
            _FillComboBoxWithComercials();

            if (_Mode == enMode.Add)
            {
                _ResetToAddNewMode();
            }
            else if (_Mode == enMode.Update)
            {
                _ResetToUpdateMode();
            }
            else if (_Mode == enMode.Renew)
            {
                _ResetToRenewMode();
            }


            _ResetDefaultClientValues();
            _ResetDefaultVtBasicDetailsValues();
            _ResetDefaultVtDureValues();
            _ResetDefaultVtPaimentValues();
            _FillComboBoxWithBrands();
        }

        private bool ValidateClientFields()
        {
            bool allValid = true;

            // قائمة كل cfTextBox
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { txtFieldPrenom, txtFieldNom, txtFieldTelephone })
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

        private bool ValidateVDetailsFields()
        {
            bool allValid = true;

            // قائمة كل cfTextBox
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { txtFieldModel, txtFieldMatricule })
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

        private bool ValidateVPaymentFields()
        {
            bool allValid = true;

            // قائمة كل cfTextBox
            foreach (ctrlTextBox ctl in new ctrlTextBox[] { txtFieldEspece, txtFieldCheque, txtFieldVirBank, txtFieldWafaSalaf })
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

        void _LoadData()
        {
            // Load the Assurance object

            if (_Mode == enMode.Update)
                _Assurance = clsAssurance.FindByID(_AssuranceID);
            else if (_Mode == enMode.Renew)
                _Assurance = clsAssurance.FindByID(_AssuranceID, true);

            if (_Assurance == null)
            {
                MessageBox.Show("Assurance non trouvée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show("Email : " + _Assurance.ClientInfo.Email + " | " + "Phone : " + _Assurance.Assurance.Phone);

            // Client Fields
            txtFieldNom.FieldValue = _Assurance.Assurance.FirstName;
            txtFieldPrenom.FieldValue = _Assurance.Assurance.LastName;
            txtFieldTelephone.FieldValue = _Assurance.Assurance.Phone;
            txtFieldEmail.FieldValue = _Assurance.ClientInfo.Email;
            cbFieldComercial.MyComboBox.SelectedIndex = cbFieldComercial.MyComboBox.FindString(_Assurance.ComercialInfo.Username);

            // Vehicle Details Fields
            txtFieldModel.FieldValue = _Assurance.Assurance.Model;
            txtFieldMatricule.FieldValue = _Assurance.Assurance.Matricule;
            cbFieldMarque.MyComboBox.SelectedIndex = cbFieldMarque.MyComboBox.FindString(clsBrand.FindByID(_Assurance.CarInfo.BrandID).Name);

            // Vehicle Duration Fields
            cbFieldDure.MyComboBox.SelectedIndex = cbFieldDure.MyComboBox.FindString(_Assurance.Assurance.Duration.ToString());
            cbFieldAnnee.MyComboBox.SelectedIndex = cbFieldAnnee.MyComboBox.FindString(_Assurance.Assurance.StartDate.Year.ToString());
            cbFieldMois.MyComboBox.SelectedIndex = cbFieldMois.MyComboBox.FindString(_Assurance.Assurance.StartDate.Month.ToString());
            cbFieldJour.MyComboBox.SelectedIndex = cbFieldJour.MyComboBox.FindString(_Assurance.Assurance.StartDate.Day.ToString());

            // Vehicle Payment Fields
            txtFieldEspece.FieldValue = _Assurance.Assurance.Espece.ToString("F2");
            txtFieldCheque.FieldValue = _Assurance.Assurance.Cheque.ToString("F2");
            txtFieldVirBank.FieldValue = _Assurance.Assurance.VirBank.ToString("F2");
            txtFieldWafaSalaf.FieldValue = _Assurance.Assurance.WafaSalaf.ToString("F2");
        }


        private void btnNextAddClient_Click(object sender, EventArgs e)
        {
            if (!ValidateClientFields())
            {
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs du client correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl1.SelectedTab = tbVehiculDetails;
        }

        private void btnNextAddCar_Click(object sender, EventArgs e)
        {
            if (!ValidateVDetailsFields())
            {
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs du véhicule correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tabControl1.SelectedTab = tbVehiculDure;
        }

        private void btnBackAddCar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbClient;
        }

        private void btnNextAddDure_Click(object sender, EventArgs e)
        {
            if (!ValidateVDetailsFields() || !ValidateVDetailsFields())
            {
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs du véhicule correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tabControl1.SelectedTab = tbPaiment;
        }

        private void btnBackAddDure_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbVehiculDetails;
        }

        private void btnBackAddPayment_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbVehiculDure;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateClientFields())
            {
                tabControl1.SelectedTab = tbClient;
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateVDetailsFields())
            {
                tabControl1.SelectedTab = tbVehiculDetails;
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs du véhicule correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateVPaymentFields())
            {
                tabControl1.SelectedTab = tbPaiment;
                // Messages in francais
                MessageBox.Show("Veuillez remplir tous les champs de paiement correctement.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Assurance.Assurance.FirstName = txtFieldPrenom.FieldValue;
            _Assurance.Assurance.LastName = txtFieldNom.FieldValue;
            _Assurance.Assurance.Phone = txtFieldTelephone.FieldValue;
            _Assurance.Assurance.Email = txtFieldEmail.FieldValue;

            if(_Mode == enMode.Add)
                _Assurance.StatusID = 1;

            _Assurance.Assurance.Matricule = txtFieldMatricule.FieldValue;
            _Assurance.Assurance.Model = txtFieldModel.FieldValue;
            _Assurance.Assurance.BrandID = clsBrand.FindByName(cbFieldMarque.MyComboBox.SelectedItem.ToString()).BrandID;

            _Assurance.Assurance.Duration = int.Parse(cbFieldDure.MyComboBox.SelectedItem.ToString());
            _Assurance.Assurance.StartDate = new DateTime(int.Parse(cbFieldAnnee.MyComboBox.SelectedItem.ToString()),
                                           int.Parse(cbFieldMois.MyComboBox.SelectedItem.ToString()),
                                           int.Parse(cbFieldJour.MyComboBox.SelectedItem.ToString()));
            _Assurance.Assurance.EndDate = _Assurance.Assurance.StartDate.AddMonths(_Assurance.Assurance.Duration);

            _Assurance.Assurance.Espece = decimal.Parse(txtFieldEspece.FieldValue.ToString());
            _Assurance.Assurance.Cheque = decimal.Parse(txtFieldCheque.FieldValue.ToString());
            _Assurance.Assurance.VirBank = decimal.Parse(txtFieldVirBank.FieldValue.ToString());
            _Assurance.Assurance.WafaSalaf = decimal.Parse(txtFieldWafaSalaf.FieldValue.ToString());

            
            


            _Assurance.ComercialID = clsComercial.FindByUsername(cbFieldComercial.MyComboBox.SelectedItem.ToString()).ComercialID;


            if (_Assurance.Save())
            {
                switch (_Mode)
                {
                    case enMode.Add:
                        {
                            _Mode = enMode.Update;
                            this.Text = "Modifier l'Assurance";
                            lblTitle.Text = "Modifier l'Assurance";
                            pbTitle.Image = Resources.edit_person_40_green;
                            //frmAddEditRenewAssurance_Load(null, null);
                            MessageBox.Show("Assurance enregistrer avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case enMode.Update:
                        {
                            // message box en francais
                            MessageBox.Show("Assurance modifier avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case enMode.Renew:
                        {
                            MessageBox.Show("Assurance renouvelée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
                return;
            }
            MessageBox.Show("Erreur lors de l'enregistrement du Assurance !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void frmAddEditRenewAssurance_Load(object sender, EventArgs e)
        {
            //tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            //tabControl1.DrawItem += tabControl1_DrawItem;

            //pbFaildSuccess.Visible = false; // Hide the success/failure icon initially
            //txtFieldNom.IsVisibleIconAccept = true;
            _ResetAllDefaultValues();
            if (_Mode == enMode.Update || _Mode == enMode.Renew)
            {
                _LoadData();
            }
        }

        private void addTab_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
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

        private void VDetailsTab_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
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

        private void VPayments_ValidatingTextChanged(object sender, ctrlTextBox.ValidationEventArgs e)
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

        private void cbFieldAnnee_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _Year = int.Parse(cbFieldAnnee.MyComboBox.SelectedItem.ToString());
        }

        private void cbFieldMois_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _Month = int.Parse(cbFieldMois.MyComboBox.SelectedItem.ToString());
            cbFieldJour.MyComboBox.Items.Clear();
            _FillComboBoxWithDays(_Year, _Month);
        }
    }
}
