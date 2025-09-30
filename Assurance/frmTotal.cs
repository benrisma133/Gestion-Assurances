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

        public frmTotal(clsPaymentDetails PaymentDetails)
        {
            InitializeComponent();

            _PaymentDetails = PaymentDetails;
        }

        private void LoadChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Title = "Amount (DH)";
            chart1.ChartAreas[0].AxisX.Title = "Payment Type";

            // Rotate bottom titles (X axis labels)
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            Series series = new Series("Payments");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            // Make legend text bold
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold); // labels on bars
            chart1.Legends[0].Font = new Font("Segoe UI", 10, FontStyle.Bold); // legend itself

            // Data
            var data = new Dictionary<string, decimal>
            {
                { "Espèce", _PaymentDetails.Espece },
                { "Chèque", _PaymentDetails.Cheque },
                { "Virement", _PaymentDetails.VirBank },
                { "WafaSalaf", _PaymentDetails.WafaSalaf },
                { "Total", _PaymentDetails.Total }
            };

            // Sort ascending
            var sortedData = data.OrderBy(kv => kv.Value).ToList();

            // Add points with custom colours
            foreach (var kv in sortedData)
            {
                int pointIndex = series.Points.AddXY(kv.Key, (double)kv.Value);

                // Assign colours
                if (kv.Key == "Total")
                {
                    series.Points[pointIndex].Color = Color.Gold;  // Highlight Total
                }
                else
                {
                    series.Points[pointIndex].Color = Color.FromArgb(40, 205, 140);  // Other bars
                }
            }

            chart1.Series.Add(series);

            // Axis scaling
            double maxValue = (double)sortedData.Max(kv => kv.Value);
            double axisMax = Math.Ceiling(maxValue / 10000) * 10000; // round up

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = axisMax;
        }




        private void frmTotal_Load(object sender, EventArgs e)
        {
            ctrlMoneyCard1.LoadPaymentDetails(_PaymentDetails);

            LoadChart();
        }
    }
}
