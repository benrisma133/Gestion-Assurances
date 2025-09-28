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

            // تحديد العرض الإجمالي 656px
            int totalWidth = 656;

            // تقسيم العرض على الأعمدة الظاهرة (مثلاً: Comercial 250, Marque 250, Total 156)
            dgvComercialStatistics.Columns["ComercialFullName"].Width = 250;
            dgvComercialStatistics.Columns["BrandName"].Width = 250;
            dgvComercialStatistics.Columns["TotalVoitures"].Width = 156;

            // تعبئة ComboBoxes
            FillMonthComboBox();
            FillYearComboBox();

            LoadChartFromDGV();

            // منع المستخدم من تعديل حجم الأعمدة
            dgvComercialStatistics.AllowUserToResizeColumns = false;
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
                Color = Color.FromArgb(40, 205, 140) // اللون الجديد
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
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
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
            cbAnnee.SelectedIndex = 0;
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

            // تحديث Chart من نفس الـ DGV
            LoadChartFromDGV();
        }

    }
}
