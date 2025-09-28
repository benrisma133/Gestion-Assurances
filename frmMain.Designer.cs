namespace GestionAssurances
{
    partial class frmMain
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
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listDesMarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notificationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notificationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(310, 0, 0, 0);
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(78, 68);
            this.notificationsToolStripMenuItem.Text = "10";
            this.notificationsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voituresToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.comercialsToolStripMenuItem,
            this.historiquesToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1776, 72);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voituresToolStripMenuItem
            // 
            this.voituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDesToolStripMenuItem,
            this.historiquesToolStripMenuItem1,
            this.listDesMarquesToolStripMenuItem});
            this.voituresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voituresToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.assurance_64_green;
            this.voituresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.voituresToolStripMenuItem.Name = "voituresToolStripMenuItem";
            this.voituresToolStripMenuItem.Size = new System.Drawing.Size(286, 68);
            this.voituresToolStripMenuItem.Text = "Assurances";
            this.voituresToolStripMenuItem.Click += new System.EventHandler(this.voituresToolStripMenuItem_Click);
            // 
            // listDesToolStripMenuItem
            // 
            this.listDesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDesToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.list_24_green;
            this.listDesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listDesToolStripMenuItem.Name = "listDesToolStripMenuItem";
            this.listDesToolStripMenuItem.Size = new System.Drawing.Size(332, 40);
            this.listDesToolStripMenuItem.Text = "List des Assurances";
            this.listDesToolStripMenuItem.Click += new System.EventHandler(this.listDesToolStripMenuItem_Click);
            // 
            // historiquesToolStripMenuItem1
            // 
            this.historiquesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiquesToolStripMenuItem1.Image = global::GestionAssurances.Properties.Resources.history_24_green;
            this.historiquesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historiquesToolStripMenuItem1.Name = "historiquesToolStripMenuItem1";
            this.historiquesToolStripMenuItem1.Size = new System.Drawing.Size(332, 40);
            this.historiquesToolStripMenuItem1.Text = "Historiques";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comercialsToolStripMenuItem1});
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.stitistics_64_green;
            this.statistiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiquesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(295, 68);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // comercialsToolStripMenuItem1
            // 
            this.comercialsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comercialsToolStripMenuItem1.Image = global::GestionAssurances.Properties.Resources.comercials_32_green;
            this.comercialsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comercialsToolStripMenuItem1.Name = "comercialsToolStripMenuItem1";
            this.comercialsToolStripMenuItem1.Size = new System.Drawing.Size(273, 46);
            this.comercialsToolStripMenuItem1.Text = "Comercials";
            this.comercialsToolStripMenuItem1.Click += new System.EventHandler(this.comercialsToolStripMenuItem1_Click);
            // 
            // comercialsToolStripMenuItem
            // 
            this.comercialsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comercialsToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.comercials_64_green;
            this.comercialsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comercialsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.comercialsToolStripMenuItem.Name = "comercialsToolStripMenuItem";
            this.comercialsToolStripMenuItem.Size = new System.Drawing.Size(282, 68);
            this.comercialsToolStripMenuItem.Text = "Comercials";
            this.comercialsToolStripMenuItem.Click += new System.EventHandler(this.comercialsToolStripMenuItem_Click);
            // 
            // historiquesToolStripMenuItem
            // 
            this.historiquesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiquesToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.settings_64_green;
            this.historiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historiquesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.historiquesToolStripMenuItem.Name = "historiquesToolStripMenuItem";
            this.historiquesToolStripMenuItem.Size = new System.Drawing.Size(233, 68);
            this.historiquesToolStripMenuItem.Text = "Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GestionAssurances.Properties.Resources.ChatGPT_Image_May_8__2025__10_14_00_AM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1776, 670);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listDesMarquesToolStripMenuItem
            // 
            this.listDesMarquesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDesMarquesToolStripMenuItem.Image = global::GestionAssurances.Properties.Resources.list_24_green;
            this.listDesMarquesToolStripMenuItem.Name = "listDesMarquesToolStripMenuItem";
            this.listDesMarquesToolStripMenuItem.Size = new System.Drawing.Size(332, 40);
            this.listDesMarquesToolStripMenuItem.Text = "List des Marques";
            this.listDesMarquesToolStripMenuItem.Click += new System.EventHandler(this.listDesMarquesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem voituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comercialsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historiquesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listDesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesMarquesToolStripMenuItem;
    }
}