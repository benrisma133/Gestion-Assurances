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
            this.ctrlLabelFieldFilteringName = new GestionAssurances.Cards.ctrlLbaelField2();
            this.ctrlLabelFieldMois = new GestionAssurances.Cards.ctrlLbaelField2();
            this.ctrlLabelFieldAnnee = new GestionAssurances.Cards.ctrlLbaelField2();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // ctrlLabelFieldFilteringName
            // 
            this.ctrlLabelFieldFilteringName.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldFilteringName.BorderColor = System.Drawing.Color.MediumBlue;
            this.ctrlLabelFieldFilteringName.FieldName = "Client";
            this.ctrlLabelFieldFilteringName.FieldValue = "????";
            this.ctrlLabelFieldFilteringName.Location = new System.Drawing.Point(12, 183);
            this.ctrlLabelFieldFilteringName.Name = "ctrlLabelFieldFilteringName";
            this.ctrlLabelFieldFilteringName.Size = new System.Drawing.Size(326, 63);
            this.ctrlLabelFieldFilteringName.TabIndex = 3;
            // 
            // ctrlLabelFieldMois
            // 
            this.ctrlLabelFieldMois.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldMois.BorderColor = System.Drawing.Color.MediumBlue;
            this.ctrlLabelFieldMois.FieldName = "Mois";
            this.ctrlLabelFieldMois.FieldValue = "????";
            this.ctrlLabelFieldMois.Location = new System.Drawing.Point(12, 100);
            this.ctrlLabelFieldMois.Name = "ctrlLabelFieldMois";
            this.ctrlLabelFieldMois.Size = new System.Drawing.Size(326, 63);
            this.ctrlLabelFieldMois.TabIndex = 1;
            // 
            // ctrlLabelFieldAnnee
            // 
            this.ctrlLabelFieldAnnee.BackColor = System.Drawing.SystemColors.Menu;
            this.ctrlLabelFieldAnnee.BorderColor = System.Drawing.Color.MediumBlue;
            this.ctrlLabelFieldAnnee.FieldName = "Annee";
            this.ctrlLabelFieldAnnee.FieldValue = "????";
            this.ctrlLabelFieldAnnee.Location = new System.Drawing.Point(12, 16);
            this.ctrlLabelFieldAnnee.Name = "ctrlLabelFieldAnnee";
            this.ctrlLabelFieldAnnee.Size = new System.Drawing.Size(326, 63);
            this.ctrlLabelFieldAnnee.TabIndex = 0;
            // 
            // ctrlCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLabelFieldFilteringName);
            this.Controls.Add(this.ctrlLabelFieldMois);
            this.Controls.Add(this.ctrlLabelFieldAnnee);
            this.Name = "ctrlCarDetails";
            this.Size = new System.Drawing.Size(715, 265);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private ctrlLbaelField2 ctrlLabelFieldAnnee;
        private ctrlLbaelField2 ctrlLabelFieldMois;
        private ctrlLbaelField2 ctrlLabelFieldFilteringName;
    }
}
