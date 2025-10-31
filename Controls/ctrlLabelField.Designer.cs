namespace GestionAssurances.Controls
{
    partial class ctrlLabelField
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.pbIconAccept = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(205)))), ((int)(((byte)(140)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(10, 63);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 63);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(173, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(160, 63);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "label";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIconAccept
            // 
            this.pbIconAccept.BaseColor = System.Drawing.Color.White;
            this.pbIconAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbIconAccept.Image = global::GestionAssurances.Properties.Resources.cancel;
            this.pbIconAccept.Location = new System.Drawing.Point(342, 0);
            this.pbIconAccept.Name = "pbIconAccept";
            this.pbIconAccept.Size = new System.Drawing.Size(52, 63);
            this.pbIconAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAccept.TabIndex = 3;
            this.pbIconAccept.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlLabelField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbIconAccept);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ctrlLabelField";
            this.Size = new System.Drawing.Size(394, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaPictureBox pbIconAccept;
        private System.Windows.Forms.Label label1;
    }
}
