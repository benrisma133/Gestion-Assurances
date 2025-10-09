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

                // Show value with "MAD" on top
                //series.Points[pointIndex].Label = $"{kv.Value} MAD";
                //series.Points[pointIndex].LabelAngle = 90; // Vertical label

                series.Points[pointIndex].LegendText = kv.Key;

                switch (kv.Key)
                {
                    case "Espèce":
                        series.Points[pointIndex].Color = Color.FromArgb(66, 133, 244);
                        break;
                    case "Chèque":
                        series.Points[pointIndex].Color = Color.FromArgb(40, 205, 140);
                        break;
                    case "Virement":
                        series.Points[pointIndex].Color = Color.FromArgb(11, 197, 218);
                        break;
                    case "WafaSalaf":
                        series.Points[pointIndex].Color = Color.FromArgb(222, 226, 3);
                        break;
                    case "Total":
                        series.Points[pointIndex].Color = Color.Gold;
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
