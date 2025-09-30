namespace GestionAssurances
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.button1 = new System.Windows.Forms.Button();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.ctrlLabelField6 = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelField5 = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelField4 = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelField3 = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelField2 = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelField1 = new GestionAssurances.Controls.ctrlLabelField();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 166);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(548, 10);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 12;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 90;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(320, 200);
            this.gunaShadowPanel1.TabIndex = 5;
            this.gunaShadowPanel1.UseTransfarantBackground = true;
            this.gunaShadowPanel1.MouseEnter += new System.EventHandler(this.gunaShadowPanel1_MouseEnter);
            this.gunaShadowPanel1.MouseLeave += new System.EventHandler(this.gunaShadowPanel1_MouseLeave);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(320, 38);
            this.gunaPanel1.TabIndex = 0;
            // 
            // ctrlLabelField6
            // 
            this.ctrlLabelField6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField6.FieldIconAccept = global::GestionAssurances.Properties.Resources.version;
            this.ctrlLabelField6.Location = new System.Drawing.Point(62, 517);
            this.ctrlLabelField6.Name = "ctrlLabelField6";
            this.ctrlLabelField6.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField6.TabIndex = 11;
            // 
            // ctrlLabelField5
            // 
            this.ctrlLabelField5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField5.FieldIconAccept = global::GestionAssurances.Properties.Resources.not_current;
            this.ctrlLabelField5.Location = new System.Drawing.Point(62, 443);
            this.ctrlLabelField5.Name = "ctrlLabelField5";
            this.ctrlLabelField5.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField5.TabIndex = 10;
            // 
            // ctrlLabelField4
            // 
            this.ctrlLabelField4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField4.FieldIconAccept = global::GestionAssurances.Properties.Resources.expired;
            this.ctrlLabelField4.Location = new System.Drawing.Point(62, 221);
            this.ctrlLabelField4.Name = "ctrlLabelField4";
            this.ctrlLabelField4.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField4.TabIndex = 9;
            // 
            // ctrlLabelField3
            // 
            this.ctrlLabelField3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField3.FieldIconAccept = global::GestionAssurances.Properties.Resources.pending;
            this.ctrlLabelField3.Location = new System.Drawing.Point(62, 295);
            this.ctrlLabelField3.Name = "ctrlLabelField3";
            this.ctrlLabelField3.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField3.TabIndex = 8;
            // 
            // ctrlLabelField2
            // 
            this.ctrlLabelField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField2.FieldIconAccept = global::GestionAssurances.Properties.Resources.Current;
            this.ctrlLabelField2.Location = new System.Drawing.Point(62, 369);
            this.ctrlLabelField2.Name = "ctrlLabelField2";
            this.ctrlLabelField2.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField2.TabIndex = 7;
            // 
            // ctrlLabelField1
            // 
            this.ctrlLabelField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ctrlLabelField1.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("ctrlLabelField1.FieldIconAccept")));
            this.ctrlLabelField1.Location = new System.Drawing.Point(62, 147);
            this.ctrlLabelField1.Name = "ctrlLabelField1";
            this.ctrlLabelField1.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelField1.TabIndex = 6;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1414, 870);
            this.Controls.Add(this.ctrlLabelField6);
            this.Controls.Add(this.ctrlLabelField5);
            this.Controls.Add(this.ctrlLabelField4);
            this.Controls.Add(this.ctrlLabelField3);
            this.Controls.Add(this.ctrlLabelField2);
            this.Controls.Add(this.ctrlLabelField1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.button1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Controls.ctrlLabelField ctrlLabelField1;
        private Controls.ctrlLabelField ctrlLabelField2;
        private Controls.ctrlLabelField ctrlLabelField3;
        private Controls.ctrlLabelField ctrlLabelField4;
        private Controls.ctrlLabelField ctrlLabelField5;
        private Controls.ctrlLabelField ctrlLabelField6;
    }
}