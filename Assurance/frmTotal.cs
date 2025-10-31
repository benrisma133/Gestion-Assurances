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
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionAssurances.Assurance
{
    public partial class frmTotal : Form
    {
        clsPaymentDetails _PaymentDetails;
        clsFilterData _FilterData;

        public frmTotal(clsPaymentDetails PaymentDetails)
        {
            InitializeComponent();

            _PaymentDetails = PaymentDetails;
        }

        public frmTotal(clsPaymentDetails PaymentDetails ,clsFilterData FilterData)
        {
            InitializeComponent();

            _FilterData = FilterData;
            
            _PaymentDetails = PaymentDetails;

        }

        private void LoadChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Title = "Montant (DH)";
            chart1.ChartAreas[0].AxisX.Title = "Type de paiement";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            // ✅ Make only bottom labels (X-axis) bold and bigger
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            chart1.Legends[0].Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Protect against nulls
            decimal GetSafeValue(decimal? val) => val ?? 0m;

            var data = new Dictionary<string, decimal>
            {
                { "Espèce", GetSafeValue(_PaymentDetails?.Espece) },
                { "Chèque", GetSafeValue(_PaymentDetails?.Cheque) },
                { "Virement", GetSafeValue(_PaymentDetails?.VirBank) },
                { "WafaSalaf", GetSafeValue(_PaymentDetails?.WafaSalaf) },
                { "Total", GetSafeValue(_PaymentDetails?.Total) }
            };

            foreach (var kv in data)
            {
                int pointIndex = series.Points.AddXY(kv.Key, (double)kv.Value);

                // optional: show values above columns
                // series.Points[pointIndex].Label = $"{kv.Value} DH";

                series.Points[pointIndex].LegendText = kv.Key;

                switch (kv.Key)
                {
                    case "Espèce":
                        series.Points[pointIndex].Color = Color.FromArgb(0, 70, 255);
                        break;
                    case "Chèque":
                        series.Points[pointIndex].Color = Color.FromArgb(6, 146, 62);
                        break;
                    case "Virement":
                        series.Points[pointIndex].Color = Color.FromArgb(140, 0, 255);
                        break;
                    case "WafaSalaf":
                        series.Points[pointIndex].Color = Color.FromArgb(244, 247, 84);
                        break;
                    case "Total":
                        //rgb(244 247 84)
                        series.Points[pointIndex].Color = Color.FromArgb(255 ,63 ,127);
                        break;
                }
            }

            chart1.Series.Add(series);

            double maxValue = data.Max(kv => (double)kv.Value);
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Max(1000, Math.Ceiling(maxValue / 10000) * 10000);
        }

        private void frmTotal_Load(object sender, EventArgs e)
        {
            ctrlMoneyCard1.LoadPaymentDetails(_PaymentDetails);
            
            ctrlCarDetails1._LoadData(_FilterData);

            LoadChart();
        }


    }
}
