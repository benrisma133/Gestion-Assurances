using GestionAssurances.Controls;

namespace GestionAssurances.Comercial.Forms
{
    partial class frmAddEditComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditComercial));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.fieldUsername = new GestionAssurances.Controls.ctrlTextBox();
            this.fieldEmail = new GestionAssurances.Controls.ctrlTextBox();
            this.fieldNom = new GestionAssurances.Controls.ctrlTextBox();
            this.fieldTele = new GestionAssurances.Controls.ctrlTextBox();
            this.fieldPrenom = new GestionAssurances.Controls.ctrlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1112, 86);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Ajouter un Comercial";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.BorderSize = 1;
            this.btnSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSave.CheckedImage")));
            this.btnSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.Image = global::GestionAssurances.Properties.Resources.save_24_mainColor;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.Location = new System.Drawing.Point(866, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = global::GestionAssurances.Properties.Resources.save_24_white;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(234, 58);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fieldUsername
            // 
            this.fieldUsername.FieldIcon = global::GestionAssurances.Properties.Resources.char_u_green;
            this.fieldUsername.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("fieldUsername.FieldIconAccept")));
            this.fieldUsername.FieldName = "Username";
            this.fieldUsername.FieldValue = "";
            this.fieldUsername.IsVisibleIconAccept = false;
            this.fieldUsername.Location = new System.Drawing.Point(199, 447);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(681, 43);
            this.fieldUsername.TabIndex = 5;
            // 
            // fieldEmail
            // 
            this.fieldEmail.FieldIcon = global::GestionAssurances.Properties.Resources.char_e_green;
            this.fieldEmail.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("fieldEmail.FieldIconAccept")));
            this.fieldEmail.FieldName = "Email";
            this.fieldEmail.FieldValue = "";
            this.fieldEmail.IsVisibleIconAccept = false;
            this.fieldEmail.Location = new System.Drawing.Point(199, 388);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(681, 43);
            this.fieldEmail.TabIndex = 3;
            // 
            // fieldNom
            // 
            this.fieldNom.FieldIcon = global::GestionAssurances.Properties.Resources.char_n_green;
            this.fieldNom.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("fieldNom.FieldIconAccept")));
            this.fieldNom.FieldName = "Nom";
            this.fieldNom.FieldValue = "";
            this.fieldNom.IsVisibleIconAccept = false;
            this.fieldNom.Location = new System.Drawing.Point(199, 270);
            this.fieldNom.Name = "fieldNom";
            this.fieldNom.Size = new System.Drawing.Size(681, 43);
            this.fieldNom.TabIndex = 2;
            this.fieldNom.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.fieldPrenom_ValidatingTextChanged);
            // 
            // fieldTele
            // 
            this.fieldTele.FieldIcon = global::GestionAssurances.Properties.Resources.char_t_green;
            this.fieldTele.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("fieldTele.FieldIconAccept")));
            this.fieldTele.FieldName = "Telephone";
            this.fieldTele.FieldValue = "";
            this.fieldTele.IsVisibleIconAccept = false;
            this.fieldTele.Location = new System.Drawing.Point(199, 329);
            this.fieldTele.Name = "fieldTele";
            this.fieldTele.Size = new System.Drawing.Size(681, 43);
            this.fieldTele.TabIndex = 1;
            // 
            // fieldPrenom
            // 
            this.fieldPrenom.FieldIcon = global::GestionAssurances.Properties.Resources.char_p_green;
            this.fieldPrenom.FieldIconAccept = global::GestionAssurances.Properties.Resources.accept_16_green;
            this.fieldPrenom.FieldName = "Prenom";
            this.fieldPrenom.FieldValue = "";
            this.fieldPrenom.IsVisibleIconAccept = false;
            this.fieldPrenom.Location = new System.Drawing.Point(199, 211);
            this.fieldPrenom.Name = "fieldPrenom";
            this.fieldPrenom.Size = new System.Drawing.Size(681, 43);
            this.fieldPrenom.TabIndex = 0;
            this.fieldPrenom.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.fieldPrenom_ValidatingTextChanged);
            // 
            // frmAddEditComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 648);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.fieldEmail);
            this.Controls.Add(this.fieldNom);
            this.Controls.Add(this.fieldTele);
            this.Controls.Add(this.fieldPrenom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEdit";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTextBox fieldPrenom;
        private ctrlTextBox fieldTele;
        private ctrlTextBox fieldNom;
        private ctrlTextBox fieldEmail;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private ctrlTextBox fieldUsername;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}