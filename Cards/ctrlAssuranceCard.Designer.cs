namespace GestionAssurances.Cards
{
    partial class ctrlAssuranceCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ctrlLabelFieldIsCurrent = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelFieldVersion = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlLabelFieldStatus = new GestionAssurances.Controls.ctrlLabelField();
            this.ctrlPaymentCard1 = new GestionAssurances.Cards.ctrlPaymentCard();
            this.ctrlDurationCard1 = new GestionAssurances.Cards.ctrlDurationCard();
            this.ctrlCarCard1 = new GestionAssurances.Cards.ctrlCarCard();
            this.ctrlClientCard1 = new GestionAssurances.Cards.ctrlClientCard();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(7, 739);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 6;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1236, 48);
            this.gunaGroupBox1.TabIndex = 4;
            this.gunaGroupBox1.Text = "Détails du Client";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // ctrlLabelFieldIsCurrent
            // 
            this.ctrlLabelFieldIsCurrent.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldIsCurrent.FieldIconAccept = global::GestionAssurances.Properties.Resources.Current;
            this.ctrlLabelFieldIsCurrent.FieldName = "  Is Current";
            this.ctrlLabelFieldIsCurrent.FieldNameColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldIsCurrent.FieldValue = "Yes";
            this.ctrlLabelFieldIsCurrent.FieldValueColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldIsCurrent.Location = new System.Drawing.Point(825, 804);
            this.ctrlLabelFieldIsCurrent.Name = "ctrlLabelFieldIsCurrent";
            this.ctrlLabelFieldIsCurrent.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelFieldIsCurrent.TabIndex = 7;
            // 
            // ctrlLabelFieldVersion
            // 
            this.ctrlLabelFieldVersion.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldVersion.FieldIconAccept = global::GestionAssurances.Properties.Resources.version;
            this.ctrlLabelFieldVersion.FieldName = "  Version";
            this.ctrlLabelFieldVersion.FieldNameColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldVersion.FieldValue = "1";
            this.ctrlLabelFieldVersion.FieldValueColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldVersion.Location = new System.Drawing.Point(430, 804);
            this.ctrlLabelFieldVersion.Name = "ctrlLabelFieldVersion";
            this.ctrlLabelFieldVersion.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelFieldVersion.TabIndex = 6;
            // 
            // ctrlLabelFieldStatus
            // 
            this.ctrlLabelFieldStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldStatus.FieldIconAccept = global::GestionAssurances.Properties.Resources.accept_16_green;
            this.ctrlLabelFieldStatus.FieldName = "  Statut";
            this.ctrlLabelFieldStatus.FieldNameColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldStatus.FieldValue = "label";
            this.ctrlLabelFieldStatus.FieldValueColor = System.Drawing.SystemColors.ControlText;
            this.ctrlLabelFieldStatus.Location = new System.Drawing.Point(35, 804);
            this.ctrlLabelFieldStatus.Name = "ctrlLabelFieldStatus";
            this.ctrlLabelFieldStatus.Size = new System.Drawing.Size(387, 63);
            this.ctrlLabelFieldStatus.TabIndex = 5;
            // 
            // ctrlPaymentCard1
            // 
            this.ctrlPaymentCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlPaymentCard1.Location = new System.Drawing.Point(640, 369);
            this.ctrlPaymentCard1.Name = "ctrlPaymentCard1";
            this.ctrlPaymentCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlPaymentCard1.TabIndex = 3;
            // 
            // ctrlDurationCard1
            // 
            this.ctrlDurationCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlDurationCard1.Location = new System.Drawing.Point(640, 3);
            this.ctrlDurationCard1.Name = "ctrlDurationCard1";
            this.ctrlDurationCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlDurationCard1.TabIndex = 2;
            // 
            // ctrlCarCard1
            // 
            this.ctrlCarCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlCarCard1.Location = new System.Drawing.Point(52, 369);
            this.ctrlCarCard1.Name = "ctrlCarCard1";
            this.ctrlCarCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlCarCard1.TabIndex = 1;
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlClientCard1.Location = new System.Drawing.Point(52, 3);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlClientCard1.TabIndex = 0;
            // 
            // ctrlAssuranceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLabelFieldIsCurrent);
            this.Controls.Add(this.ctrlLabelFieldVersion);
            this.Controls.Add(this.ctrlLabelFieldStatus);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.ctrlPaymentCard1);
            this.Controls.Add(this.ctrlDurationCard1);
            this.Controls.Add(this.ctrlCarCard1);
            this.Controls.Add(this.ctrlClientCard1);
            this.Name = "ctrlAssuranceCard";
            this.Size = new System.Drawing.Size(1246, 910);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClientCard ctrlClientCard1;
        private ctrlCarCard ctrlCarCard1;
        private ctrlDurationCard ctrlDurationCard1;
        private ctrlPaymentCard ctrlPaymentCard1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Controls.ctrlLabelField ctrlLabelFieldStatus;
        private Controls.ctrlLabelField ctrlLabelFieldVersion;
        private Controls.ctrlLabelField ctrlLabelFieldIsCurrent;
    }
}
