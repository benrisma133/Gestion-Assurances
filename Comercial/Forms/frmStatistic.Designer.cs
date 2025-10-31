namespace GestionAssurances.Comercial.Forms
{
    partial class frmStatistic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvComercialStatistics = new Guna.UI.WinForms.GunaDataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.cbMois = new Guna.UI.WinForms.GunaComboBox();
            this.cbAnnee = new Guna.UI.WinForms.GunaComboBox();
            this.ctrlTotal = new GestionAssurances.Cards.ctrlLbaelField2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComercialStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(1, 1);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1879, 86);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Statistiques";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvComercialStatistics
            // 
            this.dgvComercialStatistics.AllowUserToAddRows = false;
            this.dgvComercialStatistics.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComercialStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComercialStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComercialStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComercialStatistics.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComercialStatistics.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComercialStatistics.EnableHeadersVisualStyles = false;
            this.dgvComercialStatistics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvComercialStatistics.Location = new System.Drawing.Point(12, 244);
            this.dgvComercialStatistics.Name = "dgvComercialStatistics";
            this.dgvComercialStatistics.ReadOnly = true;
            this.dgvComercialStatistics.RowHeadersVisible = false;
            this.dgvComercialStatistics.RowHeadersWidth = 62;
            this.dgvComercialStatistics.RowTemplate.Height = 28;
            this.dgvComercialStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComercialStatistics.Size = new System.Drawing.Size(539, 617);
            this.dgvComercialStatistics.TabIndex = 7;
            this.dgvComercialStatistics.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvComercialStatistics.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvComercialStatistics.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvComercialStatistics.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvComercialStatistics.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvComercialStatistics.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvComercialStatistics.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvComercialStatistics.ThemeStyle.ReadOnly = true;
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.Height = 28;
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvComercialStatistics.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(572, 244);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1287, 617);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 879);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mois :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(12, 176);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(94, 29);
            this.lblDebut.TabIndex = 44;
            this.lblDebut.Text = "Annee :";
            // 
            // cbMois
            // 
            this.cbMois.BackColor = System.Drawing.Color.Transparent;
            this.cbMois.BaseColor = System.Drawing.Color.White;
            this.cbMois.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbMois.BorderSize = 1;
            this.cbMois.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMois.FocusedColor = System.Drawing.Color.Empty;
            this.cbMois.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMois.ForeColor = System.Drawing.Color.Black;
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Location = new System.Drawing.Point(122, 124);
            this.cbMois.Name = "cbMois";
            this.cbMois.OnHoverItemBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.cbMois.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMois.Size = new System.Drawing.Size(198, 35);
            this.cbMois.TabIndex = 43;
            this.cbMois.SelectedIndexChanged += new System.EventHandler(this.cbMois_SelectedIndexChanged);
            // 
            // cbAnnee
            // 
            this.cbAnnee.BackColor = System.Drawing.Color.Transparent;
            this.cbAnnee.BaseColor = System.Drawing.Color.White;
            this.cbAnnee.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbAnnee.BorderSize = 1;
            this.cbAnnee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnee.FocusedColor = System.Drawing.Color.Empty;
            this.cbAnnee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAnnee.ForeColor = System.Drawing.Color.Black;
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(122, 174);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.OnHoverItemBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.cbAnnee.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbAnnee.Size = new System.Drawing.Size(198, 35);
            this.cbAnnee.TabIndex = 42;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
            // 
            // ctrlTotal
            // 
            this.ctrlTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.ctrlTotal.FieldName = "Total";
            this.ctrlTotal.FieldValue = "0";
            this.ctrlTotal.Location = new System.Drawing.Point(962, 165);
            this.ctrlTotal.Name = "ctrlTotal";
            this.ctrlTotal.Size = new System.Drawing.Size(355, 63);
            this.ctrlTotal.TabIndex = 46;
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1881, 884);
            this.Controls.Add(this.ctrlTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.cbMois);
            this.Controls.Add(this.cbAnnee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvComercialStatistics);
            this.Controls.Add(this.gunaLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComercialStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvComercialStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDebut;
        private Guna.UI.WinForms.GunaComboBox cbMois;
        private Guna.UI.WinForms.GunaComboBox cbAnnee;
        private Cards.ctrlLbaelField2 ctrlTotal;
    }
}