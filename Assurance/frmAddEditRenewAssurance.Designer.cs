namespace GestionAssurances.Assurance
{
    partial class frmAddEditRenewAssurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditRenewAssurance));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbClient = new System.Windows.Forms.TabPage();
            this.btnNextAddClient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtFieldPrenom = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldNom = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldTelephone = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldEmail = new GestionAssurances.Controls.ctrlTextBox();
            this.tbVehiculDetails = new System.Windows.Forms.TabPage();
            this.btnBackAddCar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNextAddCar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbFieldComercial = new GestionAssurances.Controls.ctrlComboBox();
            this.cbFieldMarque = new GestionAssurances.Controls.ctrlComboBox();
            this.txtFieldModel = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldMatricule = new GestionAssurances.Controls.ctrlTextBox();
            this.tbVehiculDure = new System.Windows.Forms.TabPage();
            this.btnBackAddDure = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNextAddDure = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFieldJour = new GestionAssurances.Controls.ctrlComboBox();
            this.cbFieldMois = new GestionAssurances.Controls.ctrlComboBox();
            this.cbFieldAnnee = new GestionAssurances.Controls.ctrlComboBox();
            this.cbFieldDure = new GestionAssurances.Controls.ctrlComboBox();
            this.tbPaiment = new System.Windows.Forms.TabPage();
            this.btnBackAddPayment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtFieldEspece = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldCheque = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldVirBank = new GestionAssurances.Controls.ctrlTextBox();
            this.txtFieldWafaSalaf = new GestionAssurances.Controls.ctrlTextBox();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbClient.SuspendLayout();
            this.tbVehiculDetails.SuspendLayout();
            this.tbVehiculDure.SuspendLayout();
            this.tbPaiment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(105, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1301, 87);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Créer un Nouveau Assurance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbClient);
            this.tabControl1.Controls.Add(this.tbVehiculDetails);
            this.tabControl1.Controls.Add(this.tbVehiculDure);
            this.tabControl1.Controls.Add(this.tbPaiment);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1403, 695);
            this.tabControl1.TabIndex = 3;
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.btnNextAddClient);
            this.tbClient.Controls.Add(this.txtFieldPrenom);
            this.tbClient.Controls.Add(this.txtFieldNom);
            this.tbClient.Controls.Add(this.txtFieldTelephone);
            this.tbClient.Controls.Add(this.txtFieldEmail);
            this.tbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(4, 35);
            this.tbClient.Name = "tbClient";
            this.tbClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbClient.Size = new System.Drawing.Size(1395, 656);
            this.tbClient.TabIndex = 0;
            this.tbClient.Text = "Ajouter un client";
            this.tbClient.UseVisualStyleBackColor = true;
            // 
            // btnNextAddClient
            // 
            this.btnNextAddClient.Animated = true;
            this.btnNextAddClient.AnimationHoverSpeed = 0.07F;
            this.btnNextAddClient.AnimationSpeed = 0.03F;
            this.btnNextAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnNextAddClient.BaseColor = System.Drawing.Color.White;
            this.btnNextAddClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddClient.BorderSize = 1;
            this.btnNextAddClient.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNextAddClient.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNextAddClient.CheckedForeColor = System.Drawing.Color.White;
            this.btnNextAddClient.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNextAddClient.CheckedImage")));
            this.btnNextAddClient.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNextAddClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextAddClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextAddClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddClient.Image = global::GestionAssurances.Properties.Resources.arrow_next_16_green;
            this.btnNextAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextAddClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextAddClient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddClient.Location = new System.Drawing.Point(1145, 582);
            this.btnNextAddClient.Name = "btnNextAddClient";
            this.btnNextAddClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextAddClient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextAddClient.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_next_16_white;
            this.btnNextAddClient.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextAddClient.Radius = 10;
            this.btnNextAddClient.Size = new System.Drawing.Size(234, 58);
            this.btnNextAddClient.TabIndex = 8;
            this.btnNextAddClient.Text = "Suivant";
            this.btnNextAddClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNextAddClient.Click += new System.EventHandler(this.btnNextAddClient_Click);
            // 
            // txtFieldPrenom
            // 
            this.txtFieldPrenom.FieldIcon = global::GestionAssurances.Properties.Resources.char_p_green;
            this.txtFieldPrenom.FieldIconAccept = global::GestionAssurances.Properties.Resources.accept_16_green;
            this.txtFieldPrenom.FieldName = "Prénom";
            this.txtFieldPrenom.FieldValue = "";
            this.txtFieldPrenom.IsVisibleIconAccept = false;
            this.txtFieldPrenom.Location = new System.Drawing.Point(350, 218);
            this.txtFieldPrenom.Name = "txtFieldPrenom";
            this.txtFieldPrenom.Size = new System.Drawing.Size(689, 64);
            this.txtFieldPrenom.TabIndex = 4;
            this.txtFieldPrenom.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.addTab_ValidatingTextChanged);
            // 
            // txtFieldNom
            // 
            this.txtFieldNom.FieldIcon = global::GestionAssurances.Properties.Resources.char_n_green;
            this.txtFieldNom.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldNom.FieldIconAccept")));
            this.txtFieldNom.FieldName = "Nom";
            this.txtFieldNom.FieldValue = "";
            this.txtFieldNom.IsVisibleIconAccept = false;
            this.txtFieldNom.Location = new System.Drawing.Point(350, 288);
            this.txtFieldNom.Name = "txtFieldNom";
            this.txtFieldNom.Size = new System.Drawing.Size(689, 64);
            this.txtFieldNom.TabIndex = 5;
            this.txtFieldNom.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.addTab_ValidatingTextChanged);
            // 
            // txtFieldTelephone
            // 
            this.txtFieldTelephone.FieldIcon = global::GestionAssurances.Properties.Resources.char_t_green;
            this.txtFieldTelephone.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldTelephone.FieldIconAccept")));
            this.txtFieldTelephone.FieldName = "Téléphone";
            this.txtFieldTelephone.FieldValue = "";
            this.txtFieldTelephone.IsVisibleIconAccept = false;
            this.txtFieldTelephone.Location = new System.Drawing.Point(350, 358);
            this.txtFieldTelephone.Name = "txtFieldTelephone";
            this.txtFieldTelephone.Size = new System.Drawing.Size(689, 64);
            this.txtFieldTelephone.TabIndex = 6;
            this.txtFieldTelephone.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.addTab_ValidatingTextChanged);
            // 
            // txtFieldEmail
            // 
            this.txtFieldEmail.FieldIcon = global::GestionAssurances.Properties.Resources.char_e_green;
            this.txtFieldEmail.FieldIconAccept = null;
            this.txtFieldEmail.FieldName = "Email";
            this.txtFieldEmail.FieldValue = "";
            this.txtFieldEmail.IsVisibleIconAccept = false;
            this.txtFieldEmail.Location = new System.Drawing.Point(350, 428);
            this.txtFieldEmail.Name = "txtFieldEmail";
            this.txtFieldEmail.Size = new System.Drawing.Size(689, 50);
            this.txtFieldEmail.TabIndex = 7;
            // 
            // tbVehiculDetails
            // 
            this.tbVehiculDetails.Controls.Add(this.btnBackAddCar);
            this.tbVehiculDetails.Controls.Add(this.btnNextAddCar);
            this.tbVehiculDetails.Controls.Add(this.cbFieldComercial);
            this.tbVehiculDetails.Controls.Add(this.cbFieldMarque);
            this.tbVehiculDetails.Controls.Add(this.txtFieldModel);
            this.tbVehiculDetails.Controls.Add(this.txtFieldMatricule);
            this.tbVehiculDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiculDetails.Location = new System.Drawing.Point(4, 35);
            this.tbVehiculDetails.Name = "tbVehiculDetails";
            this.tbVehiculDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehiculDetails.Size = new System.Drawing.Size(1395, 656);
            this.tbVehiculDetails.TabIndex = 1;
            this.tbVehiculDetails.Text = "Détails du véhicule";
            this.tbVehiculDetails.UseVisualStyleBackColor = true;
            // 
            // btnBackAddCar
            // 
            this.btnBackAddCar.Animated = true;
            this.btnBackAddCar.AnimationHoverSpeed = 0.07F;
            this.btnBackAddCar.AnimationSpeed = 0.03F;
            this.btnBackAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAddCar.BaseColor = System.Drawing.Color.White;
            this.btnBackAddCar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddCar.BorderSize = 1;
            this.btnBackAddCar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackAddCar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackAddCar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackAddCar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBackAddCar.CheckedImage")));
            this.btnBackAddCar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackAddCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackAddCar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackAddCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackAddCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddCar.Image = global::GestionAssurances.Properties.Resources.arrow_back_16_green;
            this.btnBackAddCar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackAddCar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddCar.Location = new System.Drawing.Point(16, 582);
            this.btnBackAddCar.Name = "btnBackAddCar";
            this.btnBackAddCar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddCar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackAddCar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackAddCar.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_back_16_white;
            this.btnBackAddCar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddCar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackAddCar.Radius = 10;
            this.btnBackAddCar.Size = new System.Drawing.Size(234, 58);
            this.btnBackAddCar.TabIndex = 10;
            this.btnBackAddCar.Text = "Précédent";
            this.btnBackAddCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackAddCar.Click += new System.EventHandler(this.btnBackAddCar_Click);
            // 
            // btnNextAddCar
            // 
            this.btnNextAddCar.Animated = true;
            this.btnNextAddCar.AnimationHoverSpeed = 0.07F;
            this.btnNextAddCar.AnimationSpeed = 0.03F;
            this.btnNextAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnNextAddCar.BaseColor = System.Drawing.Color.White;
            this.btnNextAddCar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddCar.BorderSize = 1;
            this.btnNextAddCar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNextAddCar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNextAddCar.CheckedForeColor = System.Drawing.Color.White;
            this.btnNextAddCar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNextAddCar.CheckedImage")));
            this.btnNextAddCar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNextAddCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextAddCar.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextAddCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextAddCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddCar.Image = global::GestionAssurances.Properties.Resources.arrow_next_16_green;
            this.btnNextAddCar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextAddCar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextAddCar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddCar.Location = new System.Drawing.Point(1145, 582);
            this.btnNextAddCar.Name = "btnNextAddCar";
            this.btnNextAddCar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddCar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextAddCar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextAddCar.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_next_16_white;
            this.btnNextAddCar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddCar.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextAddCar.Radius = 10;
            this.btnNextAddCar.Size = new System.Drawing.Size(234, 58);
            this.btnNextAddCar.TabIndex = 9;
            this.btnNextAddCar.Text = "Suivant";
            this.btnNextAddCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNextAddCar.Click += new System.EventHandler(this.btnNextAddCar_Click);
            // 
            // cbFieldComercial
            // 
            this.cbFieldComercial.FieldIcon = global::GestionAssurances.Properties.Resources.char_c_green;
            this.cbFieldComercial.FieldName = "Comercial";
            this.cbFieldComercial.FieldValue = null;
            this.cbFieldComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldComercial.IsVisibleIconAccept = false;
            this.cbFieldComercial.Location = new System.Drawing.Point(350, 434);
            this.cbFieldComercial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldComercial.Name = "cbFieldComercial";
            this.cbFieldComercial.Size = new System.Drawing.Size(689, 64);
            this.cbFieldComercial.TabIndex = 8;
            // 
            // cbFieldMarque
            // 
            this.cbFieldMarque.FieldIcon = global::GestionAssurances.Properties.Resources.char_m_green;
            this.cbFieldMarque.FieldName = "La marque";
            this.cbFieldMarque.FieldValue = null;
            this.cbFieldMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldMarque.IsVisibleIconAccept = false;
            this.cbFieldMarque.Location = new System.Drawing.Point(350, 218);
            this.cbFieldMarque.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldMarque.Name = "cbFieldMarque";
            this.cbFieldMarque.Size = new System.Drawing.Size(689, 64);
            this.cbFieldMarque.TabIndex = 0;
            // 
            // txtFieldModel
            // 
            this.txtFieldModel.FieldIcon = global::GestionAssurances.Properties.Resources.char_m_green;
            this.txtFieldModel.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldModel.FieldIconAccept")));
            this.txtFieldModel.FieldName = "Model";
            this.txtFieldModel.FieldValue = "";
            this.txtFieldModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldModel.IsVisibleIconAccept = false;
            this.txtFieldModel.Location = new System.Drawing.Point(350, 290);
            this.txtFieldModel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFieldModel.Name = "txtFieldModel";
            this.txtFieldModel.Size = new System.Drawing.Size(689, 64);
            this.txtFieldModel.TabIndex = 6;
            this.txtFieldModel.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VDetailsTab_ValidatingTextChanged);
            // 
            // txtFieldMatricule
            // 
            this.txtFieldMatricule.FieldIcon = global::GestionAssurances.Properties.Resources.char_m_green;
            this.txtFieldMatricule.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldMatricule.FieldIconAccept")));
            this.txtFieldMatricule.FieldName = "Matricule";
            this.txtFieldMatricule.FieldValue = "";
            this.txtFieldMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldMatricule.IsVisibleIconAccept = false;
            this.txtFieldMatricule.Location = new System.Drawing.Point(350, 362);
            this.txtFieldMatricule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFieldMatricule.Name = "txtFieldMatricule";
            this.txtFieldMatricule.Size = new System.Drawing.Size(689, 64);
            this.txtFieldMatricule.TabIndex = 7;
            this.txtFieldMatricule.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VDetailsTab_ValidatingTextChanged);
            // 
            // tbVehiculDure
            // 
            this.tbVehiculDure.Controls.Add(this.btnBackAddDure);
            this.tbVehiculDure.Controls.Add(this.btnNextAddDure);
            this.tbVehiculDure.Controls.Add(this.label2);
            this.tbVehiculDure.Controls.Add(this.cbFieldJour);
            this.tbVehiculDure.Controls.Add(this.cbFieldMois);
            this.tbVehiculDure.Controls.Add(this.cbFieldAnnee);
            this.tbVehiculDure.Controls.Add(this.cbFieldDure);
            this.tbVehiculDure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiculDure.Location = new System.Drawing.Point(4, 35);
            this.tbVehiculDure.Name = "tbVehiculDure";
            this.tbVehiculDure.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehiculDure.Size = new System.Drawing.Size(1395, 656);
            this.tbVehiculDure.TabIndex = 2;
            this.tbVehiculDure.Text = "Durée du véhicule";
            this.tbVehiculDure.UseVisualStyleBackColor = true;
            // 
            // btnBackAddDure
            // 
            this.btnBackAddDure.Animated = true;
            this.btnBackAddDure.AnimationHoverSpeed = 0.07F;
            this.btnBackAddDure.AnimationSpeed = 0.03F;
            this.btnBackAddDure.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAddDure.BaseColor = System.Drawing.Color.White;
            this.btnBackAddDure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddDure.BorderSize = 1;
            this.btnBackAddDure.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackAddDure.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackAddDure.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackAddDure.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBackAddDure.CheckedImage")));
            this.btnBackAddDure.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackAddDure.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackAddDure.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackAddDure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackAddDure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddDure.Image = global::GestionAssurances.Properties.Resources.arrow_back_16_green;
            this.btnBackAddDure.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackAddDure.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddDure.Location = new System.Drawing.Point(16, 582);
            this.btnBackAddDure.Name = "btnBackAddDure";
            this.btnBackAddDure.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddDure.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackAddDure.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackAddDure.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_back_16_white;
            this.btnBackAddDure.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddDure.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackAddDure.Radius = 10;
            this.btnBackAddDure.Size = new System.Drawing.Size(234, 58);
            this.btnBackAddDure.TabIndex = 41;
            this.btnBackAddDure.Text = "Précédent";
            this.btnBackAddDure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackAddDure.Click += new System.EventHandler(this.btnBackAddDure_Click);
            // 
            // btnNextAddDure
            // 
            this.btnNextAddDure.Animated = true;
            this.btnNextAddDure.AnimationHoverSpeed = 0.07F;
            this.btnNextAddDure.AnimationSpeed = 0.03F;
            this.btnNextAddDure.BackColor = System.Drawing.Color.Transparent;
            this.btnNextAddDure.BaseColor = System.Drawing.Color.White;
            this.btnNextAddDure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddDure.BorderSize = 1;
            this.btnNextAddDure.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNextAddDure.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNextAddDure.CheckedForeColor = System.Drawing.Color.White;
            this.btnNextAddDure.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNextAddDure.CheckedImage")));
            this.btnNextAddDure.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNextAddDure.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextAddDure.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextAddDure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextAddDure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddDure.Image = global::GestionAssurances.Properties.Resources.arrow_next_16_green;
            this.btnNextAddDure.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextAddDure.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextAddDure.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddDure.Location = new System.Drawing.Point(1145, 582);
            this.btnNextAddDure.Name = "btnNextAddDure";
            this.btnNextAddDure.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddDure.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextAddDure.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextAddDure.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_next_16_white;
            this.btnNextAddDure.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnNextAddDure.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextAddDure.Radius = 10;
            this.btnNextAddDure.Size = new System.Drawing.Size(234, 58);
            this.btnNextAddDure.TabIndex = 40;
            this.btnNextAddDure.Text = "Suivant";
            this.btnNextAddDure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNextAddDure.Click += new System.EventHandler(this.btnNextAddDure_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(263, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 37);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sélectionnez les dates de début et de fin :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFieldJour
            // 
            this.cbFieldJour.FieldIcon = global::GestionAssurances.Properties.Resources.char_j_green;
            this.cbFieldJour.FieldName = "Le Jour";
            this.cbFieldJour.FieldValue = null;
            this.cbFieldJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldJour.IsVisibleIconAccept = false;
            this.cbFieldJour.Location = new System.Drawing.Point(350, 494);
            this.cbFieldJour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldJour.Name = "cbFieldJour";
            this.cbFieldJour.Size = new System.Drawing.Size(689, 44);
            this.cbFieldJour.TabIndex = 11;
            // 
            // cbFieldMois
            // 
            this.cbFieldMois.FieldIcon = global::GestionAssurances.Properties.Resources.char_m_green;
            this.cbFieldMois.FieldName = "Le Mois";
            this.cbFieldMois.FieldValue = null;
            this.cbFieldMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldMois.IsVisibleIconAccept = false;
            this.cbFieldMois.Location = new System.Drawing.Point(350, 429);
            this.cbFieldMois.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldMois.Name = "cbFieldMois";
            this.cbFieldMois.Size = new System.Drawing.Size(689, 44);
            this.cbFieldMois.TabIndex = 10;
            this.cbFieldMois.ComboBoxSelectedIndexChanged += new System.EventHandler(this.cbFieldMois_ComboBoxSelectedIndexChanged);
            // 
            // cbFieldAnnee
            // 
            this.cbFieldAnnee.FieldIcon = global::GestionAssurances.Properties.Resources.char_a_green;
            this.cbFieldAnnee.FieldName = "L\'Année";
            this.cbFieldAnnee.FieldValue = null;
            this.cbFieldAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldAnnee.IsVisibleIconAccept = false;
            this.cbFieldAnnee.Location = new System.Drawing.Point(350, 368);
            this.cbFieldAnnee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldAnnee.Name = "cbFieldAnnee";
            this.cbFieldAnnee.Size = new System.Drawing.Size(689, 44);
            this.cbFieldAnnee.TabIndex = 9;
            this.cbFieldAnnee.ComboBoxSelectedIndexChanged += new System.EventHandler(this.cbFieldAnnee_ComboBoxSelectedIndexChanged);
            // 
            // cbFieldDure
            // 
            this.cbFieldDure.FieldIcon = global::GestionAssurances.Properties.Resources.char_d_green;
            this.cbFieldDure.FieldName = "Durée d\'Assurance";
            this.cbFieldDure.FieldValue = null;
            this.cbFieldDure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFieldDure.IsVisibleIconAccept = false;
            this.cbFieldDure.Location = new System.Drawing.Point(350, 218);
            this.cbFieldDure.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFieldDure.Name = "cbFieldDure";
            this.cbFieldDure.Size = new System.Drawing.Size(689, 44);
            this.cbFieldDure.TabIndex = 8;
            // 
            // tbPaiment
            // 
            this.tbPaiment.Controls.Add(this.btnBackAddPayment);
            this.tbPaiment.Controls.Add(this.btnSave);
            this.tbPaiment.Controls.Add(this.txtFieldEspece);
            this.tbPaiment.Controls.Add(this.txtFieldCheque);
            this.tbPaiment.Controls.Add(this.txtFieldVirBank);
            this.tbPaiment.Controls.Add(this.txtFieldWafaSalaf);
            this.tbPaiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaiment.Location = new System.Drawing.Point(4, 35);
            this.tbPaiment.Name = "tbPaiment";
            this.tbPaiment.Padding = new System.Windows.Forms.Padding(3);
            this.tbPaiment.Size = new System.Drawing.Size(1395, 656);
            this.tbPaiment.TabIndex = 3;
            this.tbPaiment.Text = "Mode de paiment";
            this.tbPaiment.UseVisualStyleBackColor = true;
            // 
            // btnBackAddPayment
            // 
            this.btnBackAddPayment.Animated = true;
            this.btnBackAddPayment.AnimationHoverSpeed = 0.07F;
            this.btnBackAddPayment.AnimationSpeed = 0.03F;
            this.btnBackAddPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAddPayment.BaseColor = System.Drawing.Color.White;
            this.btnBackAddPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddPayment.BorderSize = 1;
            this.btnBackAddPayment.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackAddPayment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackAddPayment.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackAddPayment.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBackAddPayment.CheckedImage")));
            this.btnBackAddPayment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackAddPayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackAddPayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackAddPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackAddPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddPayment.Image = global::GestionAssurances.Properties.Resources.arrow_back_16_green;
            this.btnBackAddPayment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackAddPayment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddPayment.Location = new System.Drawing.Point(16, 582);
            this.btnBackAddPayment.Name = "btnBackAddPayment";
            this.btnBackAddPayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddPayment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackAddPayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackAddPayment.OnHoverImage = global::GestionAssurances.Properties.Resources.arrow_back_16_white;
            this.btnBackAddPayment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnBackAddPayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackAddPayment.Radius = 10;
            this.btnBackAddPayment.Size = new System.Drawing.Size(234, 58);
            this.btnBackAddPayment.TabIndex = 11;
            this.btnBackAddPayment.Text = "Précédent";
            this.btnBackAddPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackAddPayment.Click += new System.EventHandler(this.btnBackAddPayment_Click);
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
            this.btnSave.Location = new System.Drawing.Point(1145, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = global::GestionAssurances.Properties.Resources.save_24_white;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(234, 58);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFieldEspece
            // 
            this.txtFieldEspece.FieldIcon = global::GestionAssurances.Properties.Resources.char_e_green;
            this.txtFieldEspece.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldEspece.FieldIconAccept")));
            this.txtFieldEspece.FieldName = "Espece";
            this.txtFieldEspece.FieldValue = "";
            this.txtFieldEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldEspece.IsVisibleIconAccept = false;
            this.txtFieldEspece.Location = new System.Drawing.Point(350, 218);
            this.txtFieldEspece.Name = "txtFieldEspece";
            this.txtFieldEspece.Size = new System.Drawing.Size(689, 64);
            this.txtFieldEspece.TabIndex = 4;
            this.txtFieldEspece.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VPayments_ValidatingTextChanged);
            // 
            // txtFieldCheque
            // 
            this.txtFieldCheque.FieldIcon = global::GestionAssurances.Properties.Resources.char_c_green;
            this.txtFieldCheque.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldCheque.FieldIconAccept")));
            this.txtFieldCheque.FieldName = "Cheque";
            this.txtFieldCheque.FieldValue = "";
            this.txtFieldCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldCheque.IsVisibleIconAccept = false;
            this.txtFieldCheque.Location = new System.Drawing.Point(350, 288);
            this.txtFieldCheque.Name = "txtFieldCheque";
            this.txtFieldCheque.Size = new System.Drawing.Size(689, 64);
            this.txtFieldCheque.TabIndex = 5;
            this.txtFieldCheque.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VPayments_ValidatingTextChanged);
            // 
            // txtFieldVirBank
            // 
            this.txtFieldVirBank.FieldIcon = global::GestionAssurances.Properties.Resources.char_v_green;
            this.txtFieldVirBank.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldVirBank.FieldIconAccept")));
            this.txtFieldVirBank.FieldName = "Vir. Bank";
            this.txtFieldVirBank.FieldValue = "";
            this.txtFieldVirBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldVirBank.IsVisibleIconAccept = false;
            this.txtFieldVirBank.Location = new System.Drawing.Point(350, 358);
            this.txtFieldVirBank.Name = "txtFieldVirBank";
            this.txtFieldVirBank.Size = new System.Drawing.Size(689, 64);
            this.txtFieldVirBank.TabIndex = 6;
            this.txtFieldVirBank.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VPayments_ValidatingTextChanged);
            // 
            // txtFieldWafaSalaf
            // 
            this.txtFieldWafaSalaf.FieldIcon = global::GestionAssurances.Properties.Resources.char_w_green;
            this.txtFieldWafaSalaf.FieldIconAccept = ((System.Drawing.Image)(resources.GetObject("txtFieldWafaSalaf.FieldIconAccept")));
            this.txtFieldWafaSalaf.FieldName = "WafaSalaf";
            this.txtFieldWafaSalaf.FieldValue = "";
            this.txtFieldWafaSalaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldWafaSalaf.IsVisibleIconAccept = false;
            this.txtFieldWafaSalaf.Location = new System.Drawing.Point(350, 428);
            this.txtFieldWafaSalaf.Name = "txtFieldWafaSalaf";
            this.txtFieldWafaSalaf.Size = new System.Drawing.Size(689, 64);
            this.txtFieldWafaSalaf.TabIndex = 7;
            this.txtFieldWafaSalaf.ValidatingTextChanged += new System.EventHandler<GestionAssurances.Controls.ctrlTextBox.ValidationEventArgs>(this.VPayments_ValidatingTextChanged);
            // 
            // pbTitle
            // 
            this.pbTitle.Image = global::GestionAssurances.Properties.Resources.renew_32_green;
            this.pbTitle.Location = new System.Drawing.Point(3, 3);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(99, 87);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTitle.TabIndex = 2;
            this.pbTitle.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditRenewAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1409, 870);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditRenewAssurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditRenewAssurance";
            this.Load += new System.EventHandler(this.frmAddEditRenewAssurance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbClient.ResumeLayout(false);
            this.tbVehiculDetails.ResumeLayout(false);
            this.tbVehiculDure.ResumeLayout(false);
            this.tbPaiment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbClient;
        private System.Windows.Forms.TabPage tbVehiculDetails;
        private System.Windows.Forms.TabPage tbVehiculDure;
        private System.Windows.Forms.TabPage tbPaiment;
        private Controls.ctrlTextBox txtFieldPrenom;
        private Controls.ctrlTextBox txtFieldNom;
        private Controls.ctrlTextBox txtFieldTelephone;
        private Controls.ctrlTextBox txtFieldEmail;
        private Controls.ctrlTextBox txtFieldModel;
        private Controls.ctrlTextBox txtFieldMatricule;
        private Controls.ctrlComboBox cbFieldMarque;
        private Controls.ctrlComboBox cbFieldComercial;
        private Controls.ctrlComboBox cbFieldJour;
        private Controls.ctrlComboBox cbFieldMois;
        private Controls.ctrlComboBox cbFieldAnnee;
        private Controls.ctrlComboBox cbFieldDure;
        private System.Windows.Forms.Label label2;
        private Controls.ctrlTextBox txtFieldEspece;
        private Controls.ctrlTextBox txtFieldCheque;
        private Controls.ctrlTextBox txtFieldVirBank;
        private Controls.ctrlTextBox txtFieldWafaSalaf;
        private Guna.UI.WinForms.GunaAdvenceButton btnNextAddClient;
        private Guna.UI.WinForms.GunaAdvenceButton btnNextAddCar;
        private Guna.UI.WinForms.GunaAdvenceButton btnNextAddDure;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackAddCar;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackAddDure;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackAddPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}