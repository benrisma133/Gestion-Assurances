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
            _dtStatistic = clsComercial.GetComercialStatistics();
            dgvComercialStatistics.DataSource = _dtStatistic;

            // تعديل العناوين للأعمدة
            dgvComercialStatistics.Columns["ComercialFullName"].HeaderText = "Comercial";
            dgvComercialStatistics.Columns["BrandName"].HeaderText = "Marque";
            dgvComercialStatistics.Columns["TotalVoitures"].HeaderText = "Total";

            // إخفاء الأعمدة ديال الفلترة
            dgvComercialStatistics.Columns["Year"].Visible = false;
            dgvComercialStatistics.Columns["Month"].Visible = false;

            // منع تغيير الحجم التلقائي
            dgvComercialStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // تحديد العرض الثابت لكل عمود
            dgvComercialStatistics.Columns["ComercialFullName"].Width = 160;
            dgvComercialStatistics.Columns["BrandName"].Width = 120;
            dgvComercialStatistics.Columns["TotalVoitures"].Width = 61;

            // محاذاة القيم في عمود Total للوسط
            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComercialStatistics.Columns["TotalVoitures"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // منع المستخدم من تعديل حجم الأعمدة
            foreach (DataGridViewColumn col in dgvComercialStatistics.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }

            // تعبئة ComboBoxes
            FillMonthComboBox();
            FillYearComboBox();

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
            chart1.ChartAreas[0].AxisY.Maximum = 30;  // End at 30
            chart1.ChartAreas[0].AxisY.Interval = 5;  // Step: 5 (1, 5, 10, 15, 20, 25, 30)
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
            if (_dtStatistic == null) return;

            string filter = "";

            // فلترة السنة
            if (cbAnnee.SelectedItem != null)
            {
                int year = Convert.ToInt32(cbAnnee.SelectedItem);
                filter += $"Year = {year}";
            }

            // فلترة الشهر
            if (cbMois.SelectedItem != null && cbMois.SelectedItem.ToString() != "Aucun")
            {
                int month = Convert.ToInt32(cbMois.SelectedItem);
                if (!string.IsNullOrEmpty(filter))
                    filter += " AND ";
                filter += $"Month = {month}";
            }

            // فلترة DataTable
            DataView dv = new DataView(_dtStatistic);
            dv.RowFilter = filter;

            dgvComercialStatistics.DataSource = dv;
            // Suppose dv is your DataView (e.g. from DataTable.DefaultView)
            int totalSum = dv.ToTable()
                             .AsEnumerable()
                             .Sum(r => Convert.ToInt32(r["TotalVoitures"]));

            ctrlTotal.FieldValue = totalSum.ToString();


            // تحديث Chart من نفس الـ DGV
            LoadChartFromDGV();
        }

    }
}
