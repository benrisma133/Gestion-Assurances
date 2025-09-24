namespace GestionAssurances.Comercial.Forms
{
    partial class frmListOfComercials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfComercials));
            this.lblRecord = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAllComerciaux = new Guna.UI.WinForms.GunaDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trouverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFindBy = new Guna.UI.WinForms.GunaComboBox();
            this.txtFindBy = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddComercial = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComerciaux)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(440, 814);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(185, 64);
            this.lblRecord.TabIndex = 17;
            this.lblRecord.Text = "# 0";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel3.Location = new System.Drawing.Point(10, 814);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(424, 64);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Nombre d\'enregistrements : ";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAllComerciaux
            // 
            this.dgvAllComerciaux.AllowUserToAddRows = false;
            this.dgvAllComerciaux.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllComerciaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllComerciaux.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllComerciaux.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllComerciaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllComerciaux.ColumnHeadersHeight = 17;
            this.dgvAllComerciaux.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllComerciaux.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllComerciaux.EnableHeadersVisualStyles = false;
            this.dgvAllComerciaux.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllComerciaux.Location = new System.Drawing.Point(12, 274);
            this.dgvAllComerciaux.Name = "dgvAllComerciaux";
            this.dgvAllComerciaux.ReadOnly = true;
            this.dgvAllComerciaux.RowHeadersVisible = false;
            this.dgvAllComerciaux.RowHeadersWidth = 62;
            this.dgvAllComerciaux.RowTemplate.Height = 28;
            this.dgvAllComerciaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllComerciaux.Size = new System.Drawing.Size(1492, 523);
            this.dgvAllComerciaux.TabIndex = 15;
            this.dgvAllComerciaux.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllComerciaux.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllComerciaux.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllComerciaux.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllComerciaux.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllComerciaux.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllComerciaux.ThemeStyle.HeaderStyle.Height = 17;
            this.dgvAllComerciaux.ThemeStyle.ReadOnly = true;
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.dgvAllComerciaux.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.trouverToolStripMenuItem,
            this.suprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 148);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.main_add_24_green;
            this.ajouterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editerToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.edit_green_24;
            this.editerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.editerToolStripMenuItem.Text = "Editer";
            this.editerToolStripMenuItem.Click += new System.EventHandler(this.editerToolStripMenuItem_Click);
            // 
            // trouverToolStripMenuItem
            // 
            this.trouverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trouverToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.find_green_24;
            this.trouverToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trouverToolStripMenuItem.Name = "trouverToolStripMenuItem";
            this.trouverToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.trouverToolStripMenuItem.Text = "Trouver";
            this.trouverToolStripMenuItem.Click += new System.EventHandler(this.trouverToolStripMenuItem_Click);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suprimerToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.delete_red_24;
            this.suprimerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.suprimerToolStripMenuItem_Click);
            // 
            // cbFindBy
            // 
            this.cbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFindBy.BaseColor = System.Drawing.Color.White;
            this.cbFindBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.cbFindBy.BorderSize = 1;
            this.cbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFindBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFindBy.ForeColor = System.Drawing.Color.Black;
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "Aucun",
            "Prenom",
            "Nom",
            "Telephone",
            "Nom d\'utilisateur"});
            this.cbFindBy.Location = new System.Drawing.Point(162, 220);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFindBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFindBy.Size = new System.Drawing.Size(198, 35);
            this.cbFindBy.TabIndex = 13;
            this.cbFindBy.SelectedIndexChanged += new System.EventHandler(this.cbFindBy_SelectedIndexChanged);
            // 
            // txtFindBy
            // 
            this.txtFindBy.BackColor = System.Drawing.Color.White;
            this.txtFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.txtFindBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindBy.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFindBy.LineSize = 2;
            this.txtFindBy.Location = new System.Drawing.Point(384, 220);
            this.txtFindBy.Name = "txtFindBy";
            this.txtFindBy.PasswordChar = '\0';
            this.txtFindBy.SelectedText = "";
            this.txtFindBy.Size = new System.Drawing.Size(314, 37);
            this.txtFindBy.TabIndex = 11;
            this.txtFindBy.TextChanged += new System.EventHandler(this.txtFindBy_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1518, 86);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Gestion des Comerciaux";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(17, 216);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 41);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Filtrer par   :";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(868, 859);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(133, 41);
            this.gunaLabel4.TabIndex = 20;
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddComercial
            // 
            this.btnAddComercial.Animated = true;
            this.btnAddComercial.AnimationHoverSpeed = 1.7F;
            this.btnAddComercial.AnimationSpeed = 1.7F;
            this.btnAddComercial.BackColor = System.Drawing.Color.Transparent;
            this.btnAddComercial.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddComercial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnAddComercial.BorderSize = 1;
            this.btnAddComercial.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddComercial.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddComercial.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddComercial.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddComercial.CheckedImage")));
            this.btnAddComercial.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddComercial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddComercial.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddComercial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddComercial.ForeColor = System.Drawing.Color.White;
            this.btnAddComercial.Image = global::GestionAssurances.Properties.Resources.main_add_64_green;
            this.btnAddComercial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddComercial.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddComercial.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddComercial.Location = new System.Drawing.Point(1423, 184);
            this.btnAddComercial.Name = "btnAddComercial";
            this.btnAddComercial.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnAddComercial.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnAddComercial.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddComercial.OnHoverImage = null;
            this.btnAddComercial.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddComercial.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddComercial.Radius = 8;
            this.btnAddComercial.Size = new System.Drawing.Size(79, 74);
            this.btnAddComercial.TabIndex = 14;
            this.btnAddComercial.Click += new System.EventHandler(this.btnAddComercial_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel5.Location = new System.Drawing.Point(631, 814);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(248, 64);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "Enregistrements.";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmListOfComercials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1517, 887);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.dgvAllComerciaux);
            this.Controls.Add(this.btnAddComercial);
            this.Controls.Add(this.cbFindBy);
            this.Controls.Add(this.txtFindBy);
            this.Controls.Add(this.gunaLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfComercials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListOfComercials";
            this.Load += new System.EventHandler(this.frmListOfComercials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComerciaux)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblRecord;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDataGridView dgvAllComerciaux;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddComercial;
        private Guna.UI.WinForms.GunaComboBox cbFindBy;
        private Guna.UI.WinForms.GunaLineTextBox txtFindBy;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trouverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}