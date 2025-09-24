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
            this.ctrlClientCard1 = new GestionAssurances.Cards.ctrlClientCard();
            this.ctrlCarCard1 = new GestionAssurances.Cards.ctrlCarCard();
            this.ctrlDurationCard1 = new GestionAssurances.Cards.ctrlDurationCard();
            this.ctrlPaymentCard1 = new GestionAssurances.Cards.ctrlPaymentCard();
            this.SuspendLayout();
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.ctrlClientCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlClientCard1.TabIndex = 0;
            // 
            // ctrlCarCard1
            // 
            this.ctrlCarCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ctrlCarCard1.Location = new System.Drawing.Point(3, 369);
            this.ctrlCarCard1.Name = "ctrlCarCard1";
            this.ctrlCarCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlCarCard1.TabIndex = 1;
            // 
            // ctrlDurationCard1
            // 
            this.ctrlDurationCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(230)))));
            this.ctrlDurationCard1.Location = new System.Drawing.Point(569, 3);
            this.ctrlDurationCard1.Name = "ctrlDurationCard1";
            this.ctrlDurationCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlDurationCard1.TabIndex = 2;
            // 
            // ctrlPaymentCard1
            // 
            this.ctrlPaymentCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.ctrlPaymentCard1.Location = new System.Drawing.Point(569, 369);
            this.ctrlPaymentCard1.Name = "ctrlPaymentCard1";
            this.ctrlPaymentCard1.Size = new System.Drawing.Size(550, 350);
            this.ctrlPaymentCard1.TabIndex = 3;
            // 
            // ctrlAssuranceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPaymentCard1);
            this.Controls.Add(this.ctrlDurationCard1);
            this.Controls.Add(this.ctrlCarCard1);
            this.Controls.Add(this.ctrlClientCard1);
            this.Name = "ctrlAssuranceCard";
            this.Size = new System.Drawing.Size(1136, 733);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClientCard ctrlClientCard1;
        private ctrlCarCard ctrlCarCard1;
        private ctrlDurationCard ctrlDurationCard1;
        private ctrlPaymentCard ctrlPaymentCard1;
    }
}
