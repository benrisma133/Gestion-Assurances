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
        public static class clsLoading
        {
            public static void Show(Guna.UI.WinForms.GunaWinCircleProgressIndicator indicator)
            {
                indicator.Visible = true;
            }

            public static void Hide(Guna.UI.WinForms.GunaWinCircleProgressIndicator indicator)
            {
                indicator.Visible = false;
            }
        }

        private async Task RunWithLoading(Func<Task> action)
        {
            clsLoading.Show(gunaWinCircleProgressIndicator1);

            await Task.Delay(150);

            await action();

            clsLoading.Hide(gunaWinCircleProgressIndicator1);
        }

        public enum enAssuranceViewMode
        {
            Active,
            Historique,
            Archive
        }

        private readonly enAssuranceViewMode _ViewMode;

        DataTable _dtAllAssurances;
        private DataTable _dtAllAssurancesMaster; // نسخة أصلية محفوظة

        public frmListOfAssurances(enAssuranceViewMode viewMode = enAssuranceViewMode.Active)
        {
            InitializeComponent();
            _ViewMode = viewMode;
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

                dgvAllAssurances.Columns["AssuranceID"].Width = 60;
                dgvAllAssurances.Columns["AssuranceID"].HeaderText = "Nr Or";


                dgvAllAssurances.Columns["ClientFullName"].Width = 150;
                dgvAllAssurances.Columns["ClientFullName"].HeaderText = "Client";

                dgvAllAssurances.Columns["ClientPhone"].Width = 100;
                dgvAllAssurances.Columns["ClientPhone"].HeaderText = "Téléphone";

                dgvAllAssurances.Columns["ClientEmail"].Width = 100;
                dgvAllAssurances.Columns["ClientEmail"].HeaderText = "Police";

                dgvAllAssurances.Columns["Marque"].Width = 100;
                dgvAllAssurances.Columns["Marque"].HeaderText = "Marque";

                dgvAllAssurances.Columns["Model"].Width = 100;
                dgvAllAssurances.Columns["Model"].HeaderText = "Modèle";

                dgvAllAssurances.Columns["Matricule"].Width = 100;
                dgvAllAssurances.Columns["Matricule"].HeaderText = "Matricule";

                dgvAllAssurances.Columns["Dure"].Width = 60;
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
                dgvAllAssurances.Columns["Status"].Visible = false;

                dgvAllAssurances.Columns["Version"].Width = 60;
                dgvAllAssurances.Columns["Version"].HeaderText = "Version";
                dgvAllAssurances.Columns["Version"].Visible = false;

                dgvAllAssurances.Columns["IsCurrent"].Width = 60;
                dgvAllAssurances.Columns["IsCurrent"].HeaderText = "Actuel";
                dgvAllAssurances.Columns["IsCurrent"].Visible = false;

            }

            _LoadRecordsCount();
        }

        private async Task _LoadDataToDataTableAsync()
        {
            await RunWithLoading(async () =>
            {
                switch (_ViewMode)
                {
                    case enAssuranceViewMode.Historique:
                        _dtAllAssurances = await Task.Run(() => clsAssurance.GetAssuranceHistories()); // تحميل بيانات بشكل async
                        this.Text = "Liste des Historiques d’Assurances";
                        break;

                    case enAssuranceViewMode.Archive:
                        _dtAllAssurances = await Task.Run(() => clsAssurance.GetArchivedAssurances());
                        this.Text = "Assurances Archivées";
                        break;

                    default:
                        _dtAllAssurances = await Task.Run(() => clsAssurance.GetAllAssurances());
                        this.Text = "Liste des Assurances";
                        break;
                }

                _dtAllAssurancesMaster = _dtAllAssurances.Copy();
                dgvAllAssurances.DataSource = _dtAllAssurances;
                _LoadData();
            });
        }

        private void SetupArchiveMode()
        {
            this.Text = "Assurances Archivées";
            lblTitle.Text = "Assurances Archivées";
            lblTitle.BackColor = Color.FromArgb(5, 51, 156);

            dgvAllAssurances.EnableHeadersVisualStyles = false;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 51, 156);
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAllAssurances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            gunaAdvenceButton1.Visible = false;
            gunaAdvenceButton2.Visible = false;

            lblRecord.BackColor = Color.FromArgb(0, 120, 215);
            lblRecordTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblMessage.ForeColor = Color.FromArgb(0, 120, 215);
        }

        private void SetupHistoriqueMode()
        {
            this.Text = "Liste des Historiques d’Assurances";
            lblTitle.Text = "Liste des Historiques d’Assurances";
            lblTitle.BackColor = Color.FromArgb(145, 18, 188);

            dgvAllAssurances.EnableHeadersVisualStyles = false;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(145, 18, 188);
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAllAssurances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            gunaAdvenceButton1.Visible = false;
            gunaAdvenceButton2.Visible = false;

            lblRecord.BackColor = Color.FromArgb(145, 18, 188);
            lblRecordTitle.ForeColor = Color.FromArgb(145, 18, 188);
            lblMessage.ForeColor = Color.FromArgb(145, 18, 188);
        }

        private void SetupActiveMode()
        {
            this.Text = "Liste des Assurances Actives";
            lblTitle.Text = "Liste des Assurances Actives";

            dgvAllAssurances.EnableHeadersVisualStyles = false;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAllAssurances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            gunaAdvenceButton1.Visible = true;
            gunaAdvenceButton2.Visible = true;
        }

        private void SetupDataGridViewStyles()
        {
            dgvAllAssurances.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvAllAssurances.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // rgb(1 107 97)
            dgvAllAssurances.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1 ,107 ,97);
            dgvAllAssurances.DefaultCellStyle.SelectionForeColor = Color.White; // selected row text
            dgvAllAssurances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAllAssurances.ColumnHeadersHeight = 40;
            dgvAllAssurances.ScrollBars = ScrollBars.Both;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 🔹 Set UI according to mode
            switch (_ViewMode)
            {
                case enAssuranceViewMode.Archive:
                    SetupArchiveMode();
                    break;
                case enAssuranceViewMode.Historique:
                    SetupHistoriqueMode();
                    break;
                default:
                    SetupActiveMode();
                    break;
            }

            // 🔹 General DataGridView styling
            SetupDataGridViewStyles();

            // 🔹 Filters default selection
            cbFilterBy.SelectedIndex = 0;

            // 🔹 Load data
            await _LoadDataToDataTableAsync();

            // 🔹 Apply header color after data binding
            dgvAllAssurances.EnableHeadersVisualStyles = false;
            dgvAllAssurances.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // 🔹 Fill year/month filters
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

        private async Task ApplyFiltersAsync()
        {
            if (_dtAllAssurancesMaster == null || _dtAllAssurancesMaster.Rows.Count == 0)
            {
                dgvAllAssurances.DataSource = null;
                _LoadRecordsCount();
                return;
            }

            await RunWithLoading(async () =>
            {
                IEnumerable<DataRow> rows = _dtAllAssurancesMaster.AsEnumerable();

                bool isYearSelected = _IsYearSelected();
                bool isMonthSelected = _IsMonthSelected();

                // tolerate "Periode" or "Période"
                bool isPeriode = string.Equals(cbMois.Text?.Trim(), "Periode", StringComparison.OrdinalIgnoreCase)
                                 || string.Equals(cbMois.Text?.Trim(), "Période", StringComparison.OrdinalIgnoreCase);

                int startMonth = 0, endMonth = 0;

                // ----- PERIOD VALIDATION -----
                if (isPeriode)
                {
                    if (string.IsNullOrWhiteSpace(txtDu.Text) || string.IsNullOrWhiteSpace(txtAu.Text))
                    {
                        MessageBox.Show("Veuillez remplir les mois de début et de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtDu.Text.Trim(), out startMonth) ||
                        !int.TryParse(txtAu.Text.Trim(), out endMonth) ||
                        startMonth < 1 || startMonth > 12 ||
                        endMonth < 1 || endMonth > 12 ||
                        startMonth > endMonth)
                    {
                        MessageBox.Show("Veuillez entrer une plage de mois valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // helper: try to get a DateTime from common column names and types
                DateTime? GetRowDate(DataRow r)
                {
                    // try several candidate columns (adjust or add names used in your table)
                    string[] candidates = new[] { "Debut", "DateDebut", "StartDate", "Date" };
                    foreach (var col in candidates)
                    {
                        if (!_dtAllAssurancesMaster.Columns.Contains(col)) continue;

                        var val = r[col];
                        if (val == null || val == DBNull.Value) continue;

                        if (val is DateTime dt) return dt;
                        if (val is DateTime?) return (DateTime?)val;

                        // try parse if stored as string
                        if (val is string s)
                        {
                            if (DateTime.TryParse(s.Trim(), out var parsed)) return parsed;
                        }

                        // try convert for other types
                        try
                        {
                            var converted = Convert.ToDateTime(val);
                            return converted;
                        }
                        catch { /* ignore */ }
                    }

                    // fallback: if there is a column named "Debut" but it had DBNull, return null
                    return null;
                }

                // ----- FILTERS -----

                // Year
                if (isYearSelected)
                {
                    if (!int.TryParse(cbAnnee.Text?.Trim(), out int yearSelected))
                    {
                        // invalid year text — treat as not selected
                    }
                    else
                    {
                        rows = rows.Where(r =>
                        {
                            var d = GetRowDate(r);
                            return d.HasValue && d.Value.Year == yearSelected;
                        });
                    }
                }

                // Single Month
                if (isMonthSelected && !isPeriode && int.TryParse(cbMois.Text?.Trim(), out int targetMonth))
                {
                    rows = rows.Where(r =>
                    {
                        var d = GetRowDate(r);
                        return d.HasValue && d.Value.Month == targetMonth;
                    });
                }

                // Période (month range)
                if (isPeriode)
                {
                    rows = rows.Where(r =>
                    {
                        var d = GetRowDate(r);
                        return d.HasValue && d.Value.Month >= startMonth && d.Value.Month <= endMonth;
                    });
                }

                // Text filter
                string filterColumn = GetFilterColumn();
                string search = txtFilterByValue.Text.Trim();

                if (!string.IsNullOrEmpty(search) && !string.Equals(filterColumn, "Aucun", StringComparison.OrdinalIgnoreCase))
                {
                    // ensure the column exists
                    if (_dtAllAssurancesMaster.Columns.Contains(filterColumn))
                    {
                        rows = rows.Where(r =>
                        {
                            var val = r[filterColumn];
                            return val != null && val != DBNull.Value &&
                                   val.ToString().StartsWith(search, StringComparison.CurrentCultureIgnoreCase);
                        });
                    }
                    else
                    {
                        // unknown filter column => zero results
                        rows = Enumerable.Empty<DataRow>();
                    }
                }

                // ----- MATERIALIZE RESULTS & CORRECT COUNT -----
                List<DataRow> filteredList = rows.ToList();
                int filteredCount = filteredList.Count;

                // ----- SET FILTER NAME & VALUE FOR frmTotal -----
                //_filterName = cbFilterBy.Text;
                _filterValue = filteredCount.ToString();

                // ----- BUILD FILTERDATA -----
                if (isPeriode)
                {
                    int year = isYearSelected ? int.Parse(cbAnnee.Text.Trim()) : 0;
                    _FilterData = new clsFilterData(_filterName, _filterValue, year, startMonth, endMonth);
                }
                else if (isYearSelected && !isMonthSelected)
                {
                    int year = int.Parse(cbAnnee.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, year, clsFilterData.enDateSelection.ParAnnee);
                }
                else if (isMonthSelected && !isYearSelected)
                {
                    int month = int.Parse(cbMois.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, month, clsFilterData.enDateSelection.ParMois);
                }
                else if (isMonthSelected && isYearSelected)
                {
                    int year = int.Parse(cbAnnee.Text.Trim());
                    int month = int.Parse(cbMois.Text.Trim());
                    _FilterData = new clsFilterData(_filterName, _filterValue, year, month);
                }
                else
                {
                    _FilterData = new clsFilterData(_filterName, _filterValue);
                }

                // ----- BIND TO DATAGRID -----
                dgvAllAssurances.DataSource =
                    filteredCount > 0 ? filteredList.CopyToDataTable() : null;

                _LoadData();
                _LoadRecordsCount();
                dgvAllAssurances.Focus();

                // ----- DEBUG HELP (remove or comment out in production) -----
                if (filteredCount == 0)
                {
                    // gather some quick diagnostics to help you understand why it's empty
                    int masterCount = _dtAllAssurancesMaster.Rows.Count;
                    string sampleInfo = "(no sample)";
                    var first = _dtAllAssurancesMaster.AsEnumerable().FirstOrDefault();
                    if (first != null)
                    {
                        if (_dtAllAssurancesMaster.Columns.Contains("Debut"))
                        {
                            var v = first["Debut"];
                            sampleInfo = v == DBNull.Value ? "Debut = DBNull" : v?.ToString() ?? "(null)";
                        }
                        else
                        {
                            // show first column value
                            var col0 = _dtAllAssurancesMaster.Columns[0].ColumnName;
                            sampleInfo = first[col0]?.ToString() ?? "(null)";
                        }
                    }

                    // reason on français

                    string reasons = "Raisons possibles :\n" +
                                     "- La colonne 'Début' est manquante, vide ou n'est pas une DateTime.\n" +
                                     "- Le texte de cbMois/Période ne correspond pas à la valeur attendue.\n" +
                                     "- La colonne de filtre de texte n'existe pas ou la chaîne de filtre filtre tout.\n\n" +
                                     $"Lignes maîtresses : {masterCount}\nPremier Début d'échantillon : {sampleInfo}";



                    //string reasons = "Possible reasons:\n" +
                    //                 "- 'Debut' column missing, empty or not a DateTime.\n" +
                    //                 "- cbMois/Periode text doesn't match expected value.\n" +
                    //                 "- Your text filter column doesn't exist or filter string filters everything out.\n\n" +
                    //                 $"Master rows: {masterCount}\nSample first Debut: {sampleInfo}";

                    MessageBox.Show("No results after filtering.\n\n" + reasons, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }

        private async void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            
            await ApplyFiltersAsync();

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
            comboBox.Items.Add("Periode");

            for (int month = 1; month <= 12; month++)
            {
                comboBox.Items.Add(month);
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = DateTime.Now.Month; // optional: select first month
        }

        bool _IsYearSelected()
        {
            return int.TryParse(cbAnnee.Text, out _);
        }

        bool _IsMonthSelected()
        {
            return int.TryParse(cbMois.Text, out _);
        }

        private async void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // is year not selected we check if month is selected
            // if month is selected we filter by month only
            // if month is not selected we show all records

            // is Month not selected we check if year is selected
            // if year is selected we filter by year only
            // if year is not selected we show all records

            await ApplyFiltersAsync();
        }

        private async void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show "Periode" controls only if Periode is selected
            bool isPeriode = cbMois.Text == "Periode";
            lblDu.Visible = txtDu.Visible = lblAu.Visible = txtAu.Visible = btnFind.Visible = isPeriode;

            // If not Periode, apply normal filters
            if (!isPeriode)
                await ApplyFiltersAsync();
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

        private async void btnFind_Click(object sender, EventArgs e) 
        {
            if (_dtAllAssurancesMaster == null || _dtAllAssurancesMaster.Rows.Count == 0)
                return;

            await RunWithLoading(async () =>
            {
                if (!int.TryParse(txtDu.Text.Trim(), out int startMonth) || !int.TryParse(txtAu.Text.Trim(), out int endMonth))
                {
                    MessageBox.Show("Veuillez entrer des mois valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (startMonth < 1 || startMonth > 12 || endMonth < 1 || endMonth > 12 || startMonth > endMonth)
                {
                    MessageBox.Show("La plage de mois est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IEnumerable<DataRow> rows = _dtAllAssurancesMaster.AsEnumerable();

                if (_IsYearSelected())
                {
                    int year = Convert.ToInt32(cbAnnee.Text.Trim());
                    rows = rows.Where(r => r.Field<DateTime>("Debut").Year == year);
                }

                // Period filter
                rows = rows.Where(r =>
                    r.Field<DateTime>("Debut").Month >= startMonth &&
                    r.Field<DateTime>("Debut").Month <= endMonth);

                // Optional text filter
                string filterColumn = GetFilterColumn();
                string search = txtFilterByValue.Text.Trim();
                if (!string.IsNullOrEmpty(search) && filterColumn != "Aucun")
                {
                    rows = rows.Where(r =>
                        r[filterColumn] != DBNull.Value &&
                        r[filterColumn].ToString().StartsWith(search, StringComparison.CurrentCultureIgnoreCase));
                }

                // ----- HERE IS YOUR FIX -----
                List<DataRow> filteredList = rows.ToList();
                int filteredCount = filteredList.Count;

                //_filterName = "Periode";
                _filterValue = filteredCount.ToString();

                dgvAllAssurances.DataSource = filteredList.Any()
                    ? filteredList.CopyToDataTable()
                    : null;

                _LoadData();
                _LoadRecordsCount();

                int yearFilter = _IsYearSelected() ? Convert.ToInt32(cbAnnee.Text.Trim()) : 0;
                _FilterData = new clsFilterData(_filterName, _filterValue, yearFilter, startMonth, endMonth);
            });
        }

        private void ConfigureContextMenu()
        {
            if (_ViewMode == enAssuranceViewMode.Archive)
            {
                // Archive view
                ajouterToolStripMenuItem.Visible = false;
                renevoulerToolStripMenuItem.Visible = false;
                archivéToolStripMenuItem.Visible = false;
                restauréToolStripMenuItem.Visible = true;
            }
            else if (_ViewMode == enAssuranceViewMode.Historique)
            {
                // Histories view
                ajouterToolStripMenuItem.Visible = false;
                renevoulerToolStripMenuItem.Visible = false;
                archivéToolStripMenuItem.Visible = true;
                restauréToolStripMenuItem.Visible = false;
            }
            else if (_ViewMode == enAssuranceViewMode.Active)
            {
                // Active assurances
                ajouterToolStripMenuItem.Visible = true;
                renevoulerToolStripMenuItem.Visible = true;
                archivéToolStripMenuItem.Visible = true;
                restauréToolStripMenuItem.Visible = false;
            }
        }

        private void dgvAllAssurances_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAllAssurances.ClearSelection();
                dgvAllAssurances.Rows[e.RowIndex].Selected = true;

                ConfigureContextMenu(); // update items visibility

                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void archivéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllAssurances.SelectedRows.Count == 0)
                return;

            // Get selected AssuranceID from the first selected row
            int assuranceID = Convert.ToInt32(dgvAllAssurances.SelectedRows[0].Cells["AssuranceID"].Value);

            // Ask confirmation in French
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir archiver cette assurance ?",
                "Confirmation d'archivage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = clsAssurance.SoftDeleteAssuranceByID(assuranceID);
                if (success)
                    MessageBox.Show("L'assurance a été archivée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Échec de l'archivage de l'assurance.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally refresh DataGridView
                Form1_Load(null, null);
            }
        }

        private void restauréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllAssurances.SelectedRows.Count == 0)
                return;

            // Get selected AssuranceID from the first selected row
            int assuranceID = Convert.ToInt32(dgvAllAssurances.SelectedRows[0].Cells["AssuranceID"].Value);

            // Ask confirmation in French
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir restaurer cette assurance ?",
                "Confirmation de restauration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = clsAssurance.RestoreAssuranceByID(assuranceID);
                if (success)
                    MessageBox.Show("L'assurance a été restaurée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Échec de la restauration de l'assurance.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally refresh DataGridView
                Form1_Load(null, null);
            }
        }

    }
}
