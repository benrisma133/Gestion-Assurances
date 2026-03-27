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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfAssurances));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
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
            this.archivéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordTitle = new Guna.UI.WinForms.GunaLabel();
            this.lblRecord = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.cbAnnee = new Guna.UI.WinForms.GunaComboBox();
            this.cbMois = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.txtDu = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAu = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblDu = new System.Windows.Forms.Label();
            this.lblAu = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssurances)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1885, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestion des Assurances";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtFilterByValue.Location = new System.Drawing.Point(329, 157);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PasswordChar = '\0';
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(400, 37);
            this.txtFilterByValue.TabIndex = 1;
            this.txtFilterByValue.TextChanged += new System.EventHandler(this.txtFilterByValue_TextChanged);
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
            "Téléphone",
            "Email",
            "Marque",
            "Modèle",
            "Matricule",
            "Durée",
            "Comercial"});
            this.cbFilterBy.Location = new System.Drawing.Point(113, 159);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllAssurances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAssurances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllAssurances.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllAssurances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllAssurances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAssurances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllAssurances.ColumnHeadersHeight = 17;
            this.dgvAllAssurances.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAssurances.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvAllAssurances.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgvAllAssurances.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllAssurances_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.renevoulerToolStripMenuItem,
            this.trouverToolStripMenuItem,
            this.suprimerToolStripMenuItem,
            this.archivéToolStripMenuItem,
            this.restauréToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 256);
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
            this.trouverToolStripMenuItem.Click += new System.EventHandler(this.trouverToolStripMenuItem_Click);
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
            // archivéToolStripMenuItem
            // 
            this.archivéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.archivéToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.archive_24;
            this.archivéToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.archivéToolStripMenuItem.Name = "archivéToolStripMenuItem";
            this.archivéToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.archivéToolStripMenuItem.Text = "Archivé";
            this.archivéToolStripMenuItem.Click += new System.EventHandler(this.archivéToolStripMenuItem_Click);
            // 
            // restauréToolStripMenuItem
            // 
            this.restauréToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.restauréToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.restore_24;
            this.restauréToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restauréToolStripMenuItem.Name = "restauréToolStripMenuItem";
            this.restauréToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.restauréToolStripMenuItem.Text = "Restauré";
            this.restauréToolStripMenuItem.Click += new System.EventHandler(this.restauréToolStripMenuItem_Click);
            // 
            // lblRecordTitle
            // 
            this.lblRecordTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblRecordTitle.Location = new System.Drawing.Point(12, 861);
            this.lblRecordTitle.Name = "lblRecordTitle";
            this.lblRecordTitle.Size = new System.Drawing.Size(382, 46);
            this.lblRecordTitle.TabIndex = 7;
            this.lblRecordTitle.Text = "Nombre d\'enregistrements : ";
            this.lblRecordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(400, 859);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(261, 46);
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
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblMessage.Location = new System.Drawing.Point(667, 861);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(345, 46);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Assurances.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbAnnee.Location = new System.Drawing.Point(749, 158);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.OnHoverItemBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.cbAnnee.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbAnnee.Size = new System.Drawing.Size(198, 35);
            this.cbAnnee.TabIndex = 11;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
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
            this.cbMois.Location = new System.Drawing.Point(972, 158);
            this.cbMois.Name = "cbMois";
            this.cbMois.OnHoverItemBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.cbMois.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMois.Size = new System.Drawing.Size(198, 35);
            this.cbMois.TabIndex = 12;
            this.cbMois.SelectedIndexChanged += new System.EventHandler(this.cbMois_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(967, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mois :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(744, 119);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(94, 29);
            this.lblDebut.TabIndex = 40;
            this.lblDebut.Text = "Annee :";
            // 
            // txtDu
            // 
            this.txtDu.Animated = true;
            this.txtDu.BackColor = System.Drawing.Color.White;
            this.txtDu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDu.FocusedLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtDu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDu.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDu.LineSize = 2;
            this.txtDu.Location = new System.Drawing.Point(1194, 158);
            this.txtDu.Name = "txtDu";
            this.txtDu.PasswordChar = '\0';
            this.txtDu.SelectedText = "";
            this.txtDu.Size = new System.Drawing.Size(121, 37);
            this.txtDu.TabIndex = 43;
            this.txtDu.Visible = false;
            // 
            // txtAu
            // 
            this.txtAu.Animated = true;
            this.txtAu.BackColor = System.Drawing.Color.White;
            this.txtAu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAu.FocusedLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtAu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAu.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAu.LineSize = 2;
            this.txtAu.Location = new System.Drawing.Point(1343, 157);
            this.txtAu.Name = "txtAu";
            this.txtAu.PasswordChar = '\0';
            this.txtAu.SelectedText = "";
            this.txtAu.Size = new System.Drawing.Size(121, 37);
            this.txtAu.TabIndex = 44;
            this.txtAu.Visible = false;
            // 
            // lblDu
            // 
            this.lblDu.AutoSize = true;
            this.lblDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDu.Location = new System.Drawing.Point(1189, 119);
            this.lblDu.Name = "lblDu";
            this.lblDu.Size = new System.Drawing.Size(55, 29);
            this.lblDu.TabIndex = 45;
            this.lblDu.Text = "Du :";
            this.lblDu.Visible = false;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAu.Location = new System.Drawing.Point(1338, 119);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(53, 29);
            this.lblAu.TabIndex = 46;
            this.lblAu.Text = "Au :";
            this.lblAu.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.AnimationHoverSpeed = 1.7F;
            this.btnFind.AnimationSpeed = 1.7F;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BaseColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnFind.BorderSize = 1;
            this.btnFind.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFind.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFind.CheckedForeColor = System.Drawing.Color.White;
            this.btnFind.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFind.CheckedImage")));
            this.btnFind.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::GestionAssurances.Properties.Resources.search_16_green;
            this.btnFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFind.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFind.Location = new System.Drawing.Point(1491, 137);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = global::GestionAssurances.Properties.Resources.search_16_white;
            this.btnFind.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 8;
            this.btnFind.Size = new System.Drawing.Size(58, 56);
            this.btnFind.TabIndex = 47;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Animated = true;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 1.7F;
            this.gunaAdvenceButton2.AnimationSpeed = 1.7F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton2.BorderSize = 1;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = global::GestionAssurances.Properties.Resources.calculator;
            this.gunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(1686, 120);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = global::GestionAssurances.Properties.Resources.calculator_16_white;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 8;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(79, 74);
            this.gunaAdvenceButton2.TabIndex = 42;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
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
            this.gunaAdvenceButton1.Image = global::GestionAssurances.Properties.Resources.add_16_green;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1776, 120);
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
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(882, 404);
            this.gunaWinCircleProgressIndicator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(120, 120);
            this.gunaWinCircleProgressIndicator1.TabIndex = 48;
            this.gunaWinCircleProgressIndicator1.Visible = false;
            // 
            // frmListOfAssurances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1885, 928);
            this.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblAu);
            this.Controls.Add(this.lblDu);
            this.Controls.Add(this.txtAu);
            this.Controls.Add(this.txtDu);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.cbMois);
            this.Controls.Add(this.cbAnnee);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblRecordTitle);
            this.Controls.Add(this.dgvAllAssurances);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmListOfAssurances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListOfAssurances_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssurances)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaLineTextBox txtFilterByValue;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaDataGridView dgvAllAssurances;
        private Guna.UI.WinForms.GunaLabel lblRecordTitle;
        private Guna.UI.WinForms.GunaLabel lblRecord;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trouverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renevoulerToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI.WinForms.GunaComboBox cbAnnee;
        private Guna.UI.WinForms.GunaComboBox cbMois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebut;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaLineTextBox txtDu;
        private Guna.UI.WinForms.GunaLineTextBox txtAu;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.Label lblAu;
        private Guna.UI.WinForms.GunaAdvenceButton btnFind;
        private System.Windows.Forms.ToolStripMenuItem archivéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restauréToolStripMenuItem;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
    }
}

