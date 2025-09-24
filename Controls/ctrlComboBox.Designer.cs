namespace GestionAssurances.Controls
{
    partial class ctrlComboBox
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
            this.cbValue = new Guna.UI.WinForms.GunaComboBox();
            this.pbIconAccept = new Guna.UI.WinForms.GunaPictureBox();
            this.pbIcon = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(2, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 43);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbValue
            // 
            this.cbValue.BackColor = System.Drawing.Color.Transparent;
            this.cbValue.BaseColor = System.Drawing.Color.White;
            this.cbValue.BorderColor = System.Drawing.Color.Gray;
            this.cbValue.BorderSize = 1;
            this.cbValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FocusedColor = System.Drawing.Color.Empty;
            this.cbValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbValue.ForeColor = System.Drawing.Color.Black;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(222, 4);
            this.cbValue.Name = "cbValue";
            this.cbValue.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbValue.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbValue.Radius = 4;
            this.cbValue.Size = new System.Drawing.Size(394, 35);
            this.cbValue.TabIndex = 8;
            // 
            // pbIconAccept
            // 
            this.pbIconAccept.BaseColor = System.Drawing.Color.White;
            this.pbIconAccept.Image = global::GestionAssurances.Properties.Resources.main_add_24_green;
            this.pbIconAccept.Location = new System.Drawing.Point(622, 0);
            this.pbIconAccept.Name = "pbIconAccept";
            this.pbIconAccept.Size = new System.Drawing.Size(42, 43);
            this.pbIconAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAccept.TabIndex = 7;
            this.pbIconAccept.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BaseColor = System.Drawing.Color.White;
            this.pbIcon.Image = global::GestionAssurances.Properties.Resources.main_add_24_green;
            this.pbIcon.Location = new System.Drawing.Point(174, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(42, 43);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // ctrlComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.pbIconAccept);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblName);
            this.Name = "ctrlComboBox";
            this.Size = new System.Drawing.Size(685, 43);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pbIconAccept;
        private Guna.UI.WinForms.GunaPictureBox pbIcon;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaComboBox cbValue;
    }
}
