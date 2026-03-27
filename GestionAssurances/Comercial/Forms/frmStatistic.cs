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
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionAssurances.Comercial.Forms
{
    public partial class frmStatistic : Form
    {
        DataTable _dtStatistic;

        public frmStatistic()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            // Load initial data (without month)
            _dtStatistic = clsComercial.GetComercialStatisticsWithoutMonth();
            dgvComercialStatistics.DataSource = _dtStatistic;

            // تعديل العناوين للأعمدة
            dgvComercialStatistics.Columns["ComercialFullName"].HeaderText = "Comercial";
            dgvComercialStatistics.Columns["BrandName"].HeaderText = "Marque";
            dgvComercialStatistics.Columns["TotalVoitures"].HeaderText = "Total";

            // إخفاء الأعمدة ديال الفلترة
            if (dgvComercialStatistics.Columns.Contains("Year"))
                dgvComercialStatistics.Columns["Year"].Visible = false;

            if (dgvComercialStatistics.Columns.Contains("Month"))
                dgvComercialStatistics.Columns["Month"].Visible = false;

            // ضبط الأعمدة
            dgvComercialStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvComercialStatistics.Columns["ComercialFullName"].Width = 160;
            dgvComercialStatistics.Columns["BrandName"].Width = 120;
            dgvComercialStatistics.Columns["TotalVoitures"].Width = 61;

            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            foreach (DataGridViewColumn col in dgvComercialStatistics.Columns)
                col.Resizable = DataGridViewTriState.False;

            // تعبئة الكومبوبوكس
            FillMonthComboBox();
            FillYearComboBox();
            FillComercialComboBox();

            LoadChartFromDGV();
        }


        private void frmStatistic_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Get the working area of the screen (excludes taskbar)
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            // Resize if too big
            if (this.Width > screen.Width) this.Width = screen.Width;
            if (this.Height > screen.Height) this.Height = screen.Height;

            // Center the form
            this.Left = (screen.Width - this.Width) / 2;
            this.Top = (screen.Height - this.Height) / 2;
        }

        private void LoadChartFromDGV()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Comercial Statistics - Total Voitures");

            var series = new Series("TotalVoitures")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(255 ,63 ,127)
                //rgb(255 63 127)
            };

            Dictionary<string, int> comercialTotals = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dgvComercialStatistics.Rows)
            {
                if (row.IsNewRow) continue;

                string comercialName = row.Cells["ComercialFullName"].Value.ToString();
                int total = Convert.ToInt32(row.Cells["TotalVoitures"].Value);

                if (comercialTotals.ContainsKey(comercialName))
                    comercialTotals[comercialName] += total;
                else
                    comercialTotals[comercialName] = total;
            }

            foreach (var kvp in comercialTotals)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chart1.Series.Add(series);

            // X-Axis settings
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Y-Axis settings
            chart1.ChartAreas[0].AxisY.Minimum = 0;   // Start at 1
            chart1.ChartAreas[0].AxisY.Maximum = 130;  // End at 30
            chart1.ChartAreas[0].AxisY.Interval = 20;  // Step: 5 (1, 5, 10, 15, 20, 25, 30)
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void FillMonthComboBox()
        {
            cbMois.Items.Clear();

            // إضافة "Aucun" فالأول
            cbMois.Items.Add("Aucun");

            // الشهور من 1 إلى 12
            for (int i = 1; i <= 12; i++)
            {
                cbMois.Items.Add(i);
            }

            // تحديد القيمة الإفتراضية
            cbMois.SelectedIndex = 0; // "Aucun"
        }

        private void FillYearComboBox()
        {
            cbAnnee.Items.Clear();

            int startYear = 2022;
            int currentYear = DateTime.Now.Year;

            for (int year = startYear; year <= currentYear; year++)
            {
                cbAnnee.Items.Add(year);
            }

            // تحديد القيمة الإفتراضية
            cbAnnee.SelectedItem = currentYear;
        }

        private void FillComercialComboBox()
        {
            cbComercial.Items.Clear();
            cbComercial.Items.Add("Tous"); // "All" option

            // Get all unique names from your statistics DataTable
            var distinctComercials = _dtStatistic.AsEnumerable()
                .Select(r => r.Field<string>("ComercialFullName"))
                .Distinct()
                .OrderBy(name => name);

            foreach (var name in distinctComercials)
            {
                cbComercial.Items.Add(name);
            }

            cbComercial.SelectedIndex = 0; // Default "Tous"
        }


        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndUpdateChart();
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndUpdateChart();
        }

        // الميثود المشتركة للفلترة
        private void FilterAndUpdateChart()
        {
            if (cbAnnee.SelectedItem == null) return;

            int year = Convert.ToInt32(cbAnnee.SelectedItem);
            string selectedMonth = cbMois.SelectedItem?.ToString();
            string selectedComercial = cbComercial.SelectedItem?.ToString();

            // Choose view based on month selection
            if (selectedMonth != null && selectedMonth != "Aucun")
                _dtStatistic = clsComercial.GetComercialStatisticsWithMonth();
            else
                _dtStatistic = clsComercial.GetComercialStatisticsWithoutMonth();

            DataView dv = new DataView(_dtStatistic);

            // Base filter
            string filter = $"Year = {year}";

            // Month filter
            if (selectedMonth != null && selectedMonth != "Aucun")
            {
                int month = Convert.ToInt32(selectedMonth);
                filter += $" AND Month = {month}";
            }

            // Comercial filter
            if (!string.IsNullOrEmpty(selectedComercial) && selectedComercial != "Tous")
            {
                // Escape single quotes in names if any
                selectedComercial = selectedComercial.Replace("'", "''");
                filter += $" AND ComercialFullName = '{selectedComercial}'";
            }

            dv.RowFilter = filter;

            dgvComercialStatistics.DataSource = dv;

            // Hide columns
            if (dgvComercialStatistics.Columns.Contains("Year"))
                dgvComercialStatistics.Columns["Year"].Visible = false;
            if (dgvComercialStatistics.Columns.Contains("Month"))
                dgvComercialStatistics.Columns["Month"].Visible = false;

            // Update headers and formatting
            dgvComercialStatistics.Columns["ComercialFullName"].HeaderText = "Comercial";
            dgvComercialStatistics.Columns["BrandName"].HeaderText = "Marque";
            dgvComercialStatistics.Columns["TotalVoitures"].HeaderText = "Total";

            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            foreach (DataGridViewColumn col in dgvComercialStatistics.Columns)
                col.Resizable = DataGridViewTriState.False;

            // Recalculate total
            int totalSum = dv.ToTable()
                             .AsEnumerable()
                             .Sum(r => Convert.ToInt32(r["TotalVoitures"]));

            ctrlTotal.FieldValue = totalSum.ToString();

            // Update chart
            LoadChartFromDGV();
        }


        private void cbComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndUpdateChart();
        }
    }
}
