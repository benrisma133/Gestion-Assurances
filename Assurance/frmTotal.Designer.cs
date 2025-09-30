namespace GestionAssurances.Assurance
{
    partial class frmTotal
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
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.ctrlMoneyCard1 = new GestionAssurances.Controls.ctrlMoneyCard();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(-2, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(969, 87);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Créer un Nouveau Assurance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlMoneyCard1
            // 
            this.ctrlMoneyCard1.BackColor = System.Drawing.Color.White;
            this.ctrlMoneyCard1.Location = new System.Drawing.Point(12, 118);
            this.ctrlMoneyCard1.Name = "ctrlMoneyCard1";
            this.ctrlMoneyCard1.Size = new System.Drawing.Size(647, 415);
            this.ctrlMoneyCard1.TabIndex = 3;
            // 
            // frmTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 682);
            this.Controls.Add(this.ctrlMoneyCard1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTotal";
            this.Load += new System.EventHandler(this.frmTotal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Controls.ctrlMoneyCard ctrlMoneyCard1;
    }
}