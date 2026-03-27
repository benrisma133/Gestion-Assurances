namespace GestionAssurances.Notification.Forms
{
    partial class frmNotificationScreen
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.flowNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetails = new Guna.UI.WinForms.GunaPanel();
            this.lblNoNotificationMessage = new Guna.UI.WinForms.GunaLabel();
            this.notificationDetailControl1 = new GestionAssurances.Notification.Controls.NotificationDetailControl();
            this.gunaPanel1.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunaLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1793, 86);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Notifications";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.flowNotifications);
            this.gunaPanel1.Controls.Add(this.pnlDetails);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 86);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1793, 745);
            this.gunaPanel1.TabIndex = 3;
            // 
            // flowNotifications
            // 
            this.flowNotifications.AutoScroll = true;
            this.flowNotifications.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowNotifications.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowNotifications.Location = new System.Drawing.Point(0, 0);
            this.flowNotifications.Name = "flowNotifications";
            this.flowNotifications.Size = new System.Drawing.Size(579, 745);
            this.flowNotifications.TabIndex = 18;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblNoNotificationMessage);
            this.pnlDetails.Controls.Add(this.notificationDetailControl1);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(576, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1217, 745);
            this.pnlDetails.TabIndex = 17;
            // 
            // lblNoNotificationMessage
            // 
            this.lblNoNotificationMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoNotificationMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNoNotificationMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNoNotificationMessage.Location = new System.Drawing.Point(0, 0);
            this.lblNoNotificationMessage.Name = "lblNoNotificationMessage";
            this.lblNoNotificationMessage.Size = new System.Drawing.Size(1217, 745);
            this.lblNoNotificationMessage.TabIndex = 1;
            this.lblNoNotificationMessage.Text = "« Aucune notification sélectionnée »";
            this.lblNoNotificationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notificationDetailControl1
            // 
            this.notificationDetailControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notificationDetailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationDetailControl1.Location = new System.Drawing.Point(0, 0);
            this.notificationDetailControl1.Name = "notificationDetailControl1";
            this.notificationDetailControl1.Size = new System.Drawing.Size(1217, 745);
            this.notificationDetailControl1.TabIndex = 0;
            this.notificationDetailControl1.Visible = false;
            // 
            // frmNotificationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1793, 831);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "frmNotificationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotificationScreen";
            this.Load += new System.EventHandler(this.frmNotificationScreen_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnlDetails;
        private System.Windows.Forms.FlowLayoutPanel flowNotifications;
        private Controls.NotificationDetailControl notificationDetailControl1;
        private Guna.UI.WinForms.GunaLabel lblNoNotificationMessage;
    }
}