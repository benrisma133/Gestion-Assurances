using GA_BLL;
using GestionAssurances.Assurance;
using GestionAssurances.Modals;
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
        private DataTable _dtAllAssurancesMaster; // نسخة أصلية محفوظة


        public frmListOfAssurances()
        {
            InitializeComponent();
        }

        decimal _EspeceTotal = 0;
        decimal _ChequeTotal = 0;
        decimal _VirBankTotal = 0;
        decimal _WafaSalafTotal = 0;
        decimal _AllTotal = 0;

        clsPaymentDetails _PaymentDetails;

        string _filterName = string.Empty;
        string _filterValue = string.Empty;
        int _Annee;
        int _Mois;

        enum enFilterMode
        {
            None = 0,
            YearOnly = 1,
            MonthOnly = 2,
            YearAndMonth = 3
        }

        enFilterMode GetFilterMode()
        {
            if (_IsYearSelected() && !_IsMonthSelected())
            {
                return enFilterMode.YearOnly;
            }
            else if (!_IsYearSelected() && _IsMonthSelected())
            {
                return enFilterMode.MonthOnly;
            }
            else if (_IsYearSelected() && _IsMonthSelected())
            {
                return enFilterMode.YearAndMonth;
            }
            else
            {
                return enFilterMode.None;
            }
        }

        clsFilterData _FilterData;

        public void LoadAllTotals()
        {
            if (dgvAllAssurances.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAllAssurances.Rows)
                {
                    _EspeceTotal += Convert.ToDecimal(row.Cells["Espece"].Value);
                    _ChequeTotal += Convert.ToDecimal(row.Cells["Cheque"].Value);
                    _VirBankTotal += Convert.ToDecimal(row.Cells["VirBank"].Value);
                    _WafaSalafTotal += Convert.ToDecimal(row.Cells["WafaSalaf"].Value);
                    _AllTotal += Convert.ToDecimal(row.Cells["Total"].Value);

                }
            }
            
            _PaymentDetails = new clsPaymentDetails(_EspeceTotal, _ChequeTotal, _VirBankTotal, _WafaSalafTotal, _AllTotal);

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
            _dtAllAssurancesMaster = _dtAllAssurances.Copy(); // حفظ نسخة أصلية
            dgvAllAssurances.DataSource = _dtAllAssurances;
            _LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            dgvAllAssurances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvAllAssurances.ColumnHeadersHeight = 40; // change 40 to whatever height you want


            dgvAllAssurances.ScrollBars = ScrollBars.Both; // or ScrollBars.Horizontal

            //dgvAllAssurances.DataSource = clsAssurance.GetAllAssurances();

            cbFilterBy.SelectedIndex = 0;

            _LoadDataToDataTable();

            FillYears(cbAnnee);
            FillMonths(cbMois);

            cbAnnee.SelectedIndex = 0;
            cbMois.SelectedIndex = 0;

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
            else
            {
                txtFilterByValue.Text = string.Empty;
            }
        }

        private string GetFilterColumn()
        {
            switch (cbFilterBy.Text)
            {
                case "Aucun": return "Aucun";
                case "Client": return "ClientFullName";
                case "Téléphone": return "ClientPhone";
                case "Email": return "ClientEmail";
                case "Marque": return "Marque";
                case "Modèle": return "Model";
                case "Matricule": return "Matricule";
                case "Durée": return "Dure";
                case "Comercial": return "ComercialUsername";
                case "Statut": return "Status";
                case "Version": return "Version";
                case "Actuel": return "IsCurrent";
                default: return "Aucun";
            }
        }

        private void ApplyFilters()
        {
            if (_dtAllAssurancesMaster == null || _dtAllAssurancesMaster.Rows.Count == 0)
            {
                dgvAllAssurances.DataSource = null;
                _LoadRecordsCount();
                return;
            }

            IEnumerable<DataRow> rows = _dtAllAssurancesMaster.AsEnumerable();

            // Year filter
            if (_IsYearSelected())
            {
                int targetYear = Convert.ToInt32(cbAnnee.Text.Trim());
                rows = rows.Where(r => r.Field<DateTime>("Debut").Year == targetYear);
            }

            // Month filter
            if (_IsMonthSelected() && int.TryParse(cbMois.Text.Trim(), out int targetMonth))
            {
                rows = rows.Where(r => r.Field<DateTime>("Debut").Month == targetMonth);
            }

            // Text filter
            string filterColumn = GetFilterColumn();
            string search = txtFilterByValue.Text.Trim();

            if (filterColumn == "Aucun")
            {
                _FilterData = null;
            }

            else
            {

                _filterName = cbFilterBy.Text;
                _filterValue = search;

                if(!_IsYearSelected() && !_IsMonthSelected())
                {
                    _FilterData = new clsFilterData(_filterName, _filterValue);
                }

                if (_IsYearSelected() && !_IsMonthSelected())
                {
                    _Annee = Convert.ToInt32(cbAnnee.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, _Annee ,clsFilterData.enDateSelection.ParAnnee);
                }

                if (_IsMonthSelected() && !_IsYearSelected())
                {
                    _Mois = Convert.ToInt32(cbMois.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, _Mois , clsFilterData.enDateSelection.ParMois);
                }

                if (_IsMonthSelected() && _IsYearSelected())
                {
                    _Annee = Convert.ToInt32(cbAnnee.Text.Trim());
                    _Mois = Convert.ToInt32(cbMois.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, _Annee, _Mois);
                }


                
            }

            if (!string.IsNullOrEmpty(search) && filterColumn != "Aucun")
            {
                rows = rows.Where(r =>
                {
                    var val = r[filterColumn];
                    if (val == null || val == DBNull.Value) return false;
                    return val.ToString().StartsWith(search, StringComparison.CurrentCultureIgnoreCase);
                });
            }

            dgvAllAssurances.DataSource = rows.Any() ? rows.CopyToDataTable() : null;
            _LoadData();
            _LoadRecordsCount();
        }


        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            
            ApplyFilters();

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

        //void _FilterData()
        //{
        //    if (!_IsYearSelected() && !_IsMonthSelected())
        //    {
        //        dgvAllAssurances.DataSource = _dtAllAssurances;
        //        _LoadData();
        //        return;
        //    }
        //    var filteredRows = _dtAllAssurances.AsEnumerable();
        //    if (_IsYearSelected())
        //    {
        //        int year = Convert.ToInt32(cbAnnee.Text.Trim());
        //        int targetYear = year;
        //        filteredRows = _dtAllAssurances.AsEnumerable()
        //            .Where(r => r.Field<DateTime>("Debut").Year == targetYear);
        //    }
        //    if (_IsMonthSelected())
        //    {
        //        if (int.TryParse(cbMois.Text.Trim(), out int month))
        //        {
        //            int targetMonth = month;
        //            filteredRows = filteredRows
        //                .Where(r => r.Field<DateTime>("Debut").Month == targetMonth);
        //            filteredRows = filteredRows
        //            .Where(r => r.Field<DateTime>("Debut").Month == targetMonth);
        //        }

        //    }
        //    dgvAllAssurances.DataSource = filteredRows.Any() ? filteredRows.CopyToDataTable() : null;
        //    _LoadData();
        //}

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // is year not selected we check if month is selected
            // if month is selected we filter by month only
            // if month is not selected we show all records

            // is Month not selected we check if year is selected
            // if year is selected we filter by year only
            // if year is not selected we show all records

            //_FilterData();
            ApplyFilters();
        }

        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            // is year not selected we check if month is selected
            // if month is selected we filter by month only
            // if month is not selected we show all records

            // is Month not selected we check if year is selected
            // if year is selected we filter by year only
            // if year is not selected we show all records

            //_FilterData();
            ApplyFilters();
        }

        private void trouverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AssuranceID = Convert.ToInt32(dgvAllAssurances.CurrentRow.Cells[0].Value);
            frmAssuranceInfo frmAssuranceInfo = new frmAssuranceInfo(AssuranceID);
            frmAssuranceInfo.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            LoadAllTotals();

            frmTotal frmTotal = null;

            if (_FilterData != null)
            {
                frmTotal = new frmTotal(_PaymentDetails, _FilterData);
            }
            else
            {
                frmTotal = new frmTotal(_PaymentDetails);
            }

            frmTotal.ShowDialog();

            _EspeceTotal = 0;
            _ChequeTotal = 0;
            _VirBankTotal = 0;
            _WafaSalafTotal = 0;
            _AllTotal = 0;

            

        }

        private void frmListOfAssurances_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
