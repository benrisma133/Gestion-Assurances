namespace GestionAssurances
{
    partial class frmListOfAssurances
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfAssurances));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtFilterByValue = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbFilterBy = new Guna.UI.WinForms.GunaComboBox();
            this.dgvAllAssurances = new Guna.UI.WinForms.GunaDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renevoulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trouverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblRecord = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssurances)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(1, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1885, 86);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Gestion des Assurances";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterByValue
            // 
            this.txtFilterByValue.Animated = true;
            this.txtFilterByValue.BackColor = System.Drawing.Color.White;
            this.txtFilterByValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByValue.FocusedLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterByValue.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFilterByValue.LineSize = 2;
            this.txtFilterByValue.Location = new System.Drawing.Point(359, 157);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PasswordChar = '\0';
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(400, 37);
            this.txtFilterByValue.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(4, 153);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 41);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Filtrer par";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BaseColor = System.Drawing.Color.White;
            this.cbFilterBy.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbFilterBy.BorderSize = 1;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Aucun",
            "Client",
            "Telephone",
            "Marque",
            "Model",
            "Dure",
            "Comercial"});
            this.cbFilterBy.Location = new System.Drawing.Point(143, 159);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.OnHoverItemBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.cbFilterBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Size = new System.Drawing.Size(198, 35);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // dgvAllAssurances
            // 
            this.dgvAllAssurances.AllowUserToAddRows = false;
            this.dgvAllAssurances.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvAllAssurances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllAssurances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllAssurances.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllAssurances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllAssurances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAssurances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllAssurances.ColumnHeadersHeight = 17;
            this.dgvAllAssurances.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAssurances.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllAssurances.EnableHeadersVisualStyles = false;
            this.dgvAllAssurances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllAssurances.Location = new System.Drawing.Point(9, 213);
            this.dgvAllAssurances.Name = "dgvAllAssurances";
            this.dgvAllAssurances.ReadOnly = true;
            this.dgvAllAssurances.RowHeadersVisible = false;
            this.dgvAllAssurances.RowHeadersWidth = 62;
            this.dgvAllAssurances.RowTemplate.Height = 28;
            this.dgvAllAssurances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAssurances.Size = new System.Drawing.Size(1864, 628);
            this.dgvAllAssurances.TabIndex = 6;
            this.dgvAllAssurances.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllAssurances.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAssurances.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllAssurances.ThemeStyle.HeaderStyle.Height = 17;
            this.dgvAllAssurances.ThemeStyle.ReadOnly = true;
            this.dgvAllAssurances.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAssurances.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvAllAssurances.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAllAssurances.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllAssurances.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAllAssurances.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllAssurances.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.renevoulerToolStripMenuItem,
            this.trouverToolStripMenuItem,
            this.suprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 184);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.main_add_24_green;
            this.ajouterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editerToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.edit_green_24;
            this.editerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.editerToolStripMenuItem.Text = "Editer";
            this.editerToolStripMenuItem.Click += new System.EventHandler(this.editerToolStripMenuItem_Click);
            // 
            // renevoulerToolStripMenuItem
            // 
            this.renevoulerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renevoulerToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.renew_green_24;
            this.renevoulerToolStripMenuItem.Name = "renevoulerToolStripMenuItem";
            this.renevoulerToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.renevoulerToolStripMenuItem.Text = "Renevouler";
            this.renevoulerToolStripMenuItem.Click += new System.EventHandler(this.renevoulerToolStripMenuItem_Click);
            // 
            // trouverToolStripMenuItem
            // 
            this.trouverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trouverToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.find_green_24;
            this.trouverToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trouverToolStripMenuItem.Name = "trouverToolStripMenuItem";
            this.trouverToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.trouverToolStripMenuItem.Text = "Trouver";
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suprimerToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.delete_red_24;
            this.suprimerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.suprimerToolStripMenuItem_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 855);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(431, 64);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Nombre d\'enregistrements : ";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(450, 854);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(310, 64);
            this.lblRecord.TabIndex = 8;
            this.lblRecord.Text = "# 0";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(816, 901);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(133, 41);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 1.7F;
            this.gunaAdvenceButton1.AnimationSpeed = 1.7F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::GestionAssurances.Properties.Resources.main_add_64_green;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1794, 120);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(79, 74);
            this.gunaAdvenceButton1.TabIndex = 5;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // frmListOfAssurances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1885, 928);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.dgvAllAssurances);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "frmListOfAssurances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssurances)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtFilterByValue;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaDataGridView dgvAllAssurances;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblRecord;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trouverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renevoulerToolStripMenuItem;
    }
}

