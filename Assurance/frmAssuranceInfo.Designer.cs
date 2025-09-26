namespace GestionAssurances.Assurance
{
    partial class frmAssuranceInfo
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ctrlAssuranceCard1 = new GestionAssurances.Cards.ctrlAssuranceCard();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(1, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1160, 86);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Information du Assurance";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlAssuranceCard1
            // 
            this.ctrlAssuranceCard1.Location = new System.Drawing.Point(10, 101);
            this.ctrlAssuranceCard1.Name = "ctrlAssuranceCard1";
            this.ctrlAssuranceCard1.Size = new System.Drawing.Size(1151, 881);
            this.ctrlAssuranceCard1.TabIndex = 0;
            // 
            // frmAssuranceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1162, 994);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.ctrlAssuranceCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssuranceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAssuranceInfo";
            this.Load += new System.EventHandler(this.frmAssuranceInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Cards.ctrlAssuranceCard ctrlAssuranceCard1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}