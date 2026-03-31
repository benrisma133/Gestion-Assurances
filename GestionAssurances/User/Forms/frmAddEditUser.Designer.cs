namespace GestionAssurances.User.Forms
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtUsername = new GestionAssurances.Controls.ctrlTextBox();
            this.txtPassword = new GestionAssurances.Controls.ctrlTextBox();
            this.txtConfirmPassword = new GestionAssurances.Controls.ctrlTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtAddress = new GestionAssurances.Controls.ctrlTextBox();
            this.txtPhone = new GestionAssurances.Controls.ctrlTextBox();
            this.txtEmail = new GestionAssurances.Controls.ctrlTextBox();
            this.txtLastName = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFirstName = new GestionAssurances.Controls.ctrlTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.FieldIcon = global::GestionAssurances.Properties.Resources.name_green_24;
            this.txtUsername.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtUsername.FieldIconAccept")));
            this.txtUsername.FieldName = "Username";
            this.txtUsername.FieldValue = "";
            this.txtUsername.IsPassword = false;
            this.txtUsername.IsVisibleIconAccept = false;
            this.txtUsername.Location = new System.Drawing.Point(56, 449);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(685, 46);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.txtFirstName_ValidatingTextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.FieldIcon = global::GestionAssurances.Properties.Resources.password_green_24;
            this.txtPassword.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtPassword.FieldIconAccept")));
            this.txtPassword.FieldName = "Password";
            this.txtPassword.FieldValue = "";
            this.txtPassword.IsPassword = true;
            this.txtPassword.IsVisibleIconAccept = false;
            this.txtPassword.Location = new System.Drawing.Point(56, 505);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(685, 46);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.txtPassword_ValidatingTextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.FieldIcon = global::GestionAssurances.Properties.Resources.password_green_24;
            this.txtConfirmPassword.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtConfirmPassword.FieldIconAccept")));
            this.txtConfirmPassword.FieldName = "Confirm Pass";
            this.txtConfirmPassword.FieldValue = "";
            this.txtConfirmPassword.IsPassword = true;
            this.txtConfirmPassword.IsVisibleIconAccept = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(56, 561);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(685, 46);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.txtConfirmPassword_ValidatingTextChanged);
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
            this.btnSave.Location = new System.Drawing.Point(554, 682);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = global::GestionAssurances.Properties.Resources.save_24_white;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(234, 58);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.FieldIcon = global::GestionAssurances.Properties.Resources.address_green_24;
            this.txtAddress.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtAddress.FieldIconAccept")));
            this.txtAddress.FieldName = "Address";
            this.txtAddress.FieldValue = "";
            this.txtAddress.IsPassword = false;
            this.txtAddress.IsVisibleIconAccept = false;
            this.txtAddress.Location = new System.Drawing.Point(56, 393);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(685, 46);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.FieldIcon = global::GestionAssurances.Properties.Resources.phone_green_24;
            this.txtPhone.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtPhone.FieldIconAccept")));
            this.txtPhone.FieldName = "Phone";
            this.txtPhone.FieldValue = "";
            this.txtPhone.IsPassword = false;
            this.txtPhone.IsVisibleIconAccept = false;
            this.txtPhone.Location = new System.Drawing.Point(56, 337);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(685, 46);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.FieldIcon = global::GestionAssurances.Properties.Resources.email_green_24;
            this.txtEmail.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtEmail.FieldIconAccept")));
            this.txtEmail.FieldName = "Email";
            this.txtEmail.FieldValue = "";
            this.txtEmail.IsPassword = false;
            this.txtEmail.IsVisibleIconAccept = false;
            this.txtEmail.Location = new System.Drawing.Point(56, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(685, 46);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.FieldIcon = global::GestionAssurances.Properties.Resources.name_green_24;
            this.txtLastName.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtLastName.FieldIconAccept")));
            this.txtLastName.FieldName = "Last Name";
            this.txtLastName.FieldValue = "";
            this.txtLastName.IsPassword = false;
            this.txtLastName.IsVisibleIconAccept = false;
            this.txtLastName.Location = new System.Drawing.Point(56, 225);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(685, 46);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.txtFirstName_ValidatingTextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.FieldIcon = global::GestionAssurances.Properties.Resources.name_green_24;
            this.txtFirstName.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFirstName.FieldIconAccept")));
            this.txtFirstName.FieldName = "First Name";
            this.txtFirstName.FieldValue = "";
            this.txtFirstName.IsPassword = false;
            this.txtFirstName.IsVisibleIconAccept = false;
            this.txtFirstName.Location = new System.Drawing.Point(56, 169);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(685, 46);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.txtFirstName_ValidatingTextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Controls.ctrlTextBox txtFirstName;
        private Controls.ctrlTextBox txtLastName;
        private Controls.ctrlTextBox txtEmail;
        private Controls.ctrlTextBox txtPhone;
        private Controls.ctrlTextBox txtAddress;
        private Controls.ctrlTextBox txtUsername;
        private Controls.ctrlTextBox txtPassword;
        private Controls.ctrlTextBox txtConfirmPassword;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}