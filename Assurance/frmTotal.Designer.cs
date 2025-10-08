namespace GestionAssurances.Assurance
{
    partial class frmTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctrlMoneyCard1 = new GestionAssurances.Controls.ctrlMoneyCard();
            this.ctrlCarDetails1 = new GestionAssurances.Cards.ctrlCarDetails();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(-2, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1543, 87);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Aperçu des totaux de paiements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(736, 106);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(791, 706);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // ctrlMoneyCard1
            // 
            this.ctrlMoneyCard1.BackColor = System.Drawing.Color.White;
            this.ctrlMoneyCard1.Location = new System.Drawing.Point(15, 377);
            this.ctrlMoneyCard1.Name = "ctrlMoneyCard1";
            this.ctrlMoneyCard1.Size = new System.Drawing.Size(715, 435);
            this.ctrlMoneyCard1.TabIndex = 3;
            // 
            // ctrlCarDetails1
            // 
            this.ctrlCarDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlCarDetails1.Location = new System.Drawing.Point(15, 106);
            this.ctrlCarDetails1.Name = "ctrlCarDetails1";
            this.ctrlCarDetails1.Size = new System.Drawing.Size(715, 265);
            this.ctrlCarDetails1.TabIndex = 5;
            // 
            // frmTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1539, 828);
            this.Controls.Add(this.ctrlCarDetails1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ctrlMoneyCard1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTotal";
            this.Load += new System.EventHandler(this.frmTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Controls.ctrlMoneyCard ctrlMoneyCard1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Cards.ctrlCarDetails ctrlCarDetails1;
    }
}