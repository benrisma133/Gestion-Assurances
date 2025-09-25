using GA_BLL;
using GestionAssurances.Assurance;
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
    public partial class frmListOfAssurances : Form
    {
        DataTable _dtAllAssurances;

        public frmListOfAssurances()
        {
            InitializeComponent();
        }

        private void _LoadRecordsCount()
        {
            lblRecord.Text = dgvAllAssurances.Rows.Count.ToString();
            lblMessage.Text = "assurances trouvées";
        }

        void _LoadData()
        {

            if (dgvAllAssurances.Rows.Count > 0)
            {

                // I have ClientFullName ,ClientPhone ,VoitureMarque ,DurationMonths ,DurationStart ,
                // DurationEnd ,PaymentEspece ,PaymentCheque ,PaymentVirBank ,PaymentWafaSalaf ,
                // TotalPayment ,ComercialUsername ,Version ,IsCurrent


                // I want to set width for each column and header text
                // For User i want to put titles an Francais



                dgvAllAssurances.Columns["ClientFullName"].Width = 150;
                dgvAllAssurances.Columns["ClientFullName"].HeaderText = "Client";

                dgvAllAssurances.Columns["ClientPhone"].Width = 120;
                dgvAllAssurances.Columns["ClientPhone"].HeaderText = "Téléphone";

                dgvAllAssurances.Columns["ClientEmail"].Width = 150;
                dgvAllAssurances.Columns["ClientEmail"].HeaderText = "Email";

                dgvAllAssurances.Columns["Marque"].Width = 120;
                dgvAllAssurances.Columns["Marque"].HeaderText = "Marque";

                dgvAllAssurances.Columns["Model"].Width = 120;
                dgvAllAssurances.Columns["Model"].HeaderText = "Modèle";

                dgvAllAssurances.Columns["Matricule"].Width = 100;
                dgvAllAssurances.Columns["Matricule"].HeaderText = "Matricule";

                dgvAllAssurances.Columns["Dure"].Width = 70;
                dgvAllAssurances.Columns["Dure"].HeaderText = "Durée";

                dgvAllAssurances.Columns["Debut"].Width = 90;
                dgvAllAssurances.Columns["Debut"].HeaderText = "Début";

                dgvAllAssurances.Columns["Fin"].Width = 90;
                dgvAllAssurances.Columns["Fin"].HeaderText = "Fin";

                dgvAllAssurances.Columns["Espece"].Width = 90;
                dgvAllAssurances.Columns["Espece"].HeaderText = "Espèce";

                dgvAllAssurances.Columns["Cheque"].Width = 90;
                dgvAllAssurances.Columns["Cheque"].HeaderText = "Chèque";

                dgvAllAssurances.Columns["VirBank"].Width = 100;
                dgvAllAssurances.Columns["VirBank"].HeaderText = "Vir. Bank";

                dgvAllAssurances.Columns["WafaSalaf"].Width = 100;
                dgvAllAssurances.Columns["WafaSalaf"].HeaderText = "WafaSalaf";

                dgvAllAssurances.Columns["Total"].Width = 100;
                dgvAllAssurances.Columns["Total"].HeaderText = "Total";

                dgvAllAssurances.Columns["ComercialUsername"].Width = 120;
                dgvAllAssurances.Columns["ComercialUsername"].HeaderText = "Commercial";

                dgvAllAssurances.Columns["Status"].Width = 100;
                dgvAllAssurances.Columns["Status"].HeaderText = "Statut";

                dgvAllAssurances.Columns["Version"].Width = 60;
                dgvAllAssurances.Columns["Version"].HeaderText = "Version";

                dgvAllAssurances.Columns["IsCurrent"].Width = 60;
                dgvAllAssurances.Columns["IsCurrent"].HeaderText = "Actuel";

            }

            _LoadRecordsCount();
        }

        void _LoadDataToDataTable()
        {
            _dtAllAssurances = clsAssurance.GetAllAssurances();
            dgvAllAssurances.DataSource = _dtAllAssurances;
            _LoadData();

            FillYears(cbAnnee);
            FillMonths(cbMois);

            cbAnnee.SelectedIndex = 0;
            cbMois.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAllAssurances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvAllAssurances.ColumnHeadersHeight = 40; // change 40 to whatever height you want


            dgvAllAssurances.ScrollBars = ScrollBars.Both; // or ScrollBars.Horizontal

            //dgvAllAssurances.DataSource = clsAssurance.GetAllAssurances();

            cbFilterBy.SelectedIndex = 0;

            _LoadDataToDataTable();

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance();
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance();
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AssuranceID = Convert.ToInt32(dgvAllAssurances.CurrentRow.Cells[0].Value);
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance(AssuranceID);
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }

        private void renevoulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AssuranceID = Convert.ToInt32(dgvAllAssurances.CurrentRow.Cells[0].Value);
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance(AssuranceID ,true);
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }

        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AssuranceID = Convert.ToInt32(dgvAllAssurances.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette assurance ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsAssurance.Delete(AssuranceID))
                {
                    MessageBox.Show("Assurance supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Échec de la suppression de l'assurance.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterByValue.Visible = (cbFilterBy.Text != "Aucun");

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Focus();
                txtFilterByValue.Text = string.Empty;
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Aucun":
                    FilterColumn = string.Empty;
                    break;

                case "Client":
                    FilterColumn = "ClientFullName";
                    break;

                case "Téléphone":
                    FilterColumn = "ClientPhone";
                    break;

                case "Email":
                    FilterColumn = "ClientEmail";
                    break;

                case "Marque":
                    FilterColumn = "VoitureMarque";
                    break;

                case "Modèle":
                    FilterColumn = "VoitureModel";
                    break;

                case "Matricule":
                    FilterColumn = "VoitureMatricule";
                    break;

                case "Durée":
                    FilterColumn = "DurationMonths";
                    break;

                case "Commercial":
                    FilterColumn = "ComercialUsername";
                    break;

                case "Statut":
                    FilterColumn = "Status";
                    break;

                case "Version":
                    FilterColumn = "Version";
                    break;

                case "Actuel":
                    FilterColumn = "IsCurrent";
                    break;

                default:
                    FilterColumn = "Aucun";
                    break;
            }

            if (txtFilterByValue.Text.Trim() == string.Empty || FilterColumn == "Aucun")
            {
                _LoadDataToDataTable();
                return;
            }

            _dtAllAssurances.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterByValue.Text.Trim());

            dgvAllAssurances.DataSource = _dtAllAssurances;

            _LoadRecordsCount();

            _dtAllAssurances = _dtAllAssurances.DefaultView.ToTable();

        }

        void FillYears(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // always clear before filling

            int startYear = 2023;
            int currentYear = DateTime.Now.Year;

            comboBox.Items.Add("Aucun"); // Add "Aucun" option at the top

            for (int year = startYear; year <= currentYear; year++)
            {
                comboBox.Items.Add(year);
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = comboBox.Items.Count - 1; // optional: select first year
        }

        void FillMonths(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // always clear before filling

            comboBox.Items.Add("Aucun"); // Add "Aucun" option at the top

            for (int month = 1; month <= 12; month++)
            {
                comboBox.Items.Add(month);
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = DateTime.Now.Month; // optional: select first month
        }

        bool _IsYearSelected()
        {
            if (cbAnnee.Text == "Aucun")
            {
                return false;
            }
            return true;
        }

        bool _IsMonthSelected()
        {
            if (cbMois.Text == "Aucun")
            {
                return false;
            }
            return true;
        }

        void _FilterData()
        {
            if (!_IsYearSelected() && !_IsMonthSelected())
            {
                dgvAllAssurances.DataSource = _dtAllAssurances;
                _LoadData();
                return;
            }
            var filteredRows = _dtAllAssurances.AsEnumerable();
            if (_IsYearSelected())
            {
                int year = Convert.ToInt32(cbAnnee.Text.Trim());
                int targetYear = year;
                filteredRows = _dtAllAssurances.AsEnumerable()
                    .Where(r => r.Field<DateTime>("Debut").Year == targetYear);
            }
            if (_IsMonthSelected())
            {
                if (int.TryParse(cbMois.Text.Trim(), out int month))
                {
                    int targetMonth = month;
                    filteredRows = filteredRows
                        .Where(r => r.Field<DateTime>("Debut").Month == targetMonth);
                    filteredRows = filteredRows
                    .Where(r => r.Field<DateTime>("Debut").Month == targetMonth);
                }

            }
            dgvAllAssurances.DataSource = filteredRows.Any() ? filteredRows.CopyToDataTable() : null;
            _LoadData();
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // is year not selected we check if month is selected
            // if month is selected we filter by month only
            // if month is not selected we show all records

            // is Month not selected we check if year is selected
            // if year is selected we filter by year only
            // if year is not selected we show all records

            _FilterData();
        }

        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            // is year not selected we check if month is selected
            // if month is selected we filter by month only
            // if month is not selected we show all records

            // is Month not selected we check if year is selected
            // if year is selected we filter by year only
            // if year is not selected we show all records

            _FilterData();
        }
    }
}
