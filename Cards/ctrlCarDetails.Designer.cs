namespace GestionAssurances.Cards
{
    partial class ctrlCarDetails
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ctrlLbaelFieldTotalAssurances = new GestionAssurances.Cards.ctrlLbaelField2();
            this.ctrlLbaelFieldMois = new GestionAssurances.Cards.ctrlLbaelField2();
            this.ctrlLbaelFieldAnnee = new GestionAssurances.Cards.ctrlLbaelField2();
            this.ctrlLbaelField21 = new GestionAssurances.Cards.ctrlLbaelField2();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // ctrlLbaelFieldTotalAssurances
            // 
            this.ctrlLbaelFieldTotalAssurances.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLbaelFieldTotalAssurances.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(188)))), ((int)(((byte)(5)))));
            this.ctrlLbaelFieldTotalAssurances.Location = new System.Drawing.Point(373, 91);
            this.ctrlLbaelFieldTotalAssurances.Name = "ctrlLbaelFieldTotalAssurances";
            this.ctrlLbaelFieldTotalAssurances.Size = new System.Drawing.Size(326, 63);
            this.ctrlLbaelFieldTotalAssurances.TabIndex = 2;
            // 
            // ctrlLbaelFieldMois
            // 
            this.ctrlLbaelFieldMois.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLbaelFieldMois.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.ctrlLbaelFieldMois.Location = new System.Drawing.Point(12, 91);
            this.ctrlLbaelFieldMois.Name = "ctrlLbaelFieldMois";
            this.ctrlLbaelFieldMois.Size = new System.Drawing.Size(326, 63);
            this.ctrlLbaelFieldMois.TabIndex = 1;
            // 
            // ctrlLbaelFieldAnnee
            // 
            this.ctrlLbaelFieldAnnee.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLbaelFieldAnnee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.ctrlLbaelFieldAnnee.Location = new System.Drawing.Point(12, 17);
            this.ctrlLbaelFieldAnnee.Name = "ctrlLbaelFieldAnnee";
            this.ctrlLbaelFieldAnnee.Size = new System.Drawing.Size(326, 63);
            this.ctrlLbaelFieldAnnee.TabIndex = 0;
            // 
            // ctrlLbaelField21
            // 
            this.ctrlLbaelField21.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLbaelField21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(188)))), ((int)(((byte)(5)))));
            this.ctrlLbaelField21.Location = new System.Drawing.Point(373, 17);
            this.ctrlLbaelField21.Name = "ctrlLbaelField21";
            this.ctrlLbaelField21.Size = new System.Drawing.Size(326, 63);
            this.ctrlLbaelField21.TabIndex = 3;
            // 
            // ctrlCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLbaelField21);
            this.Controls.Add(this.ctrlLbaelFieldTotalAssurances);
            this.Controls.Add(this.ctrlLbaelFieldMois);
            this.Controls.Add(this.ctrlLbaelFieldAnnee);
            this.Name = "ctrlCarDetails";
            this.Size = new System.Drawing.Size(715, 265);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private ctrlLbaelField2 ctrlLbaelFieldAnnee;
        private ctrlLbaelField2 ctrlLbaelFieldTotalAssurances;
        private ctrlLbaelField2 ctrlLbaelFieldMois;
        private ctrlLbaelField2 ctrlLbaelField21;
    }
}
