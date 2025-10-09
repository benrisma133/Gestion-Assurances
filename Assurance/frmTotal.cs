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

            // Single series
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            // Bold fonts
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chart1.Legends[0].Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Payment data
            var data = new Dictionary<string, decimal>
            {
                { "Espèce", _PaymentDetails.Espece },
                { "Chèque", _PaymentDetails.Cheque },
                { "Virement", _PaymentDetails.VirBank },
                { "WafaSalaf", _PaymentDetails.WafaSalaf },
                { "Total", _PaymentDetails.Total }
            };

            // Add points with colors and custom legend text
            foreach (var kv in data)
            {
                int pointIndex = series.Points.AddXY(kv.Key, (double)kv.Value);
                series.Points[pointIndex].LegendText = kv.Key; // This makes legend show the payment type

                switch (kv.Key)
                {
                    case "Espèce":
                        series.Points[pointIndex].Color = Color.FromArgb(66, 133, 244); // Blue
                        break;
                    case "Chèque":
                        series.Points[pointIndex].Color = Color.FromArgb(40, 205, 140); // Green
                        break;
                    case "Virement":
                        series.Points[pointIndex].Color = Color.FromArgb(11, 197, 218); // Cyan
                        break;
                    case "WafaSalaf":
                        series.Points[pointIndex].Color = Color.FromArgb(222, 226, 3); // Yellow-Green
                        break;
                    case "Total":
                        series.Points[pointIndex].Color = Color.Gold; // Highlight Total
                        break;
                }
            }

            // Add series to chart
            chart1.Series.Add(series);

            // Axis scaling
            double maxValue = (double)data.Max(kv => kv.Value);
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Ceiling(maxValue / 10000) * 10000;

        }


        private void frmTotal_Load(object sender, EventArgs e)
        {
            ctrlMoneyCard1.LoadPaymentDetails(_PaymentDetails);
            if(_FilterData != null)
                ctrlCarDetails1._LoadData(_FilterData);

            LoadChart();
        }
    }
}
