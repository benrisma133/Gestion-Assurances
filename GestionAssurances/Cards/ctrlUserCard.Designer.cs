namespace GestionAssurances.Cards
{
    partial class ctrlUserCard
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
            this.lblIsActive = new GestionAssurances.Cards.ctrlLbaelField2();
            this.lblUsername = new GestionAssurances.Cards.ctrlLbaelField2();
            this.SuspendLayout();
            // 
            // lblIsActive
            // 
            this.lblIsActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblIsActive.FieldName = "IsActive";
            this.lblIsActive.FieldValue = "[??????????]";
            this.lblIsActive.Location = new System.Drawing.Point(495, 3);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(486, 63);
            this.lblIsActive.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lblUsername.FieldName = "Username";
            this.lblUsername.FieldValue = "[??????????]";
            this.lblUsername.Location = new System.Drawing.Point(3, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(486, 63);
            this.lblUsername.TabIndex = 4;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lblUsername);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(996, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLbaelField2 lblIsActive;
        private ctrlLbaelField2 lblUsername;
    }
}
