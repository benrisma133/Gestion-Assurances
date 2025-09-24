namespace GestionAssurances.Controls
{
    partial class ctrlTextBox
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
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pbIconAccept = new Guna.UI.WinForms.GunaPictureBox();
            this.pbIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.txtValue = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 43);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIconAccept
            // 
            this.pbIconAccept.BaseColor = System.Drawing.Color.White;
            this.pbIconAccept.Image = global::GestionAssurances.Properties.Resources.accept_16_green;
            this.pbIconAccept.Location = new System.Drawing.Point(625, 1);
            this.pbIconAccept.Name = "pbIconAccept";
            this.pbIconAccept.Size = new System.Drawing.Size(42, 43);
            this.pbIconAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAccept.TabIndex = 3;
            this.pbIconAccept.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BaseColor = System.Drawing.Color.White;
            this.pbIcon.Image = global::GestionAssurances.Properties.Resources.main_add_24_green;
            this.pbIcon.Location = new System.Drawing.Point(172, 2);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(42, 43);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // txtValue
            // 
            this.txtValue.Animated = true;
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.FocusedLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.LineColor = System.Drawing.Color.Gainsboro;
            this.txtValue.LineSize = 2;
            this.txtValue.Location = new System.Drawing.Point(223, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.SelectedText = "";
            this.txtValue.Size = new System.Drawing.Size(394, 37);
            this.txtValue.TabIndex = 4;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            // 
            // ctrlTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.pbIconAccept);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblName);
            this.Name = "ctrlTextBox";
            this.Size = new System.Drawing.Size(685, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaPictureBox pbIcon;
        private Guna.UI.WinForms.GunaPictureBox pbIconAccept;
        private Guna.UI.WinForms.GunaLineTextBox txtValue;
    }
}
