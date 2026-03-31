namespace GestionAssurances.Cards
{
    partial class ctrlPersonCard
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
            this.lblCreatedAt = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblAddress = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblPhone = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblEmail = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblLastName = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblFirstName = new GestionAssurances.Cards.ctrlLbaelField2();
            this.SuspendLayout();
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblCreatedAt.FieldName = "Created At";
            this.lblCreatedAt.FieldValue = "[??????????]";
            this.lblCreatedAt.Location = new System.Drawing.Point(495, 141);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(483, 63);
            this.lblCreatedAt.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblAddress.FieldName = "Address";
            this.lblAddress.FieldValue = "[??????????]";
            this.lblAddress.Location = new System.Drawing.Point(495, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(486, 63);
            this.lblAddress.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblPhone.FieldName = "Phone";
            this.lblPhone.FieldValue = "[??????????]";
            this.lblPhone.Location = new System.Drawing.Point(495, 3);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(486, 63);
            this.lblPhone.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblEmail.FieldName = "Email";
            this.lblEmail.FieldValue = " [??????????]";
            this.lblEmail.Location = new System.Drawing.Point(3, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(483, 63);
            this.lblEmail.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblLastName.FieldName = "Last Name";
            this.lblLastName.FieldValue = "[??????????]";
            this.lblLastName.Location = new System.Drawing.Point(3, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(486, 63);
            this.lblLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblFirstName.FieldName = "First Name";
            this.lblFirstName.FieldValue = "[??????????]";
            this.lblFirstName.Location = new System.Drawing.Point(3, 3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(486, 63);
            this.lblFirstName.TabIndex = 0;
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(996, 213);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLbaelField2 lblFirstName;
        private ctrlLbaelField2 lblLastName;
        private ctrlLbaelField2 lblEmail;
        private ctrlLbaelField2 lblCreatedAt;
        private ctrlLbaelField2 lblAddress;
        private ctrlLbaelField2 lblPhone;
    }
}
