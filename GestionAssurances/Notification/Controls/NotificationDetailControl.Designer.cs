using System.Drawing;
using System.Windows.Forms;

namespace GestionAssurances.Notification.Controls
{
    partial class NotificationDetailControl
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitle;

        private GroupBox groupClient;
        private Label label1;
        private Label label2;
        private Label Label80;
        private Label label3;
        private Label label4;

        private GroupBox groupDates;
        private Label label5;
        private Label label81;
        private Label label82;

        private GroupBox groupNotification;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;

        private GroupBox groupResponse;
        private Label label87;
        private TextBox txtSentBy;
        private CheckBox chkHasContacted;
        private CheckBox chkRenewalAccepted;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblActionDate;
        private TextBox txtActionDate;
        private Button btnSaveResponse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblAssuranceID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label80 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupDates = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.groupNotification = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.lblReminderCount = new System.Windows.Forms.Label();
            this.lblNextReminder = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.lblSentDate = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.groupResponse = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSentBy = new System.Windows.Forms.TextBox();
            this.chkHasContacted = new System.Windows.Forms.CheckBox();
            this.chkRenewalAccepted = new System.Windows.Forms.CheckBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblActionDate = new System.Windows.Forms.Label();
            this.txtActionDate = new System.Windows.Forms.TextBox();
            this.btnSaveResponse = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupClient.SuspendLayout();
            this.groupDates.SuspendLayout();
            this.groupNotification.SuspendLayout();
            this.groupResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1218, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notification Details";
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.label6);
            this.groupClient.Controls.Add(this.label7);
            this.groupClient.Controls.Add(this.label8);
            this.groupClient.Controls.Add(this.label9);
            this.groupClient.Controls.Add(this.label10);
            this.groupClient.Controls.Add(this.lblCar);
            this.groupClient.Controls.Add(this.lblBrand);
            this.groupClient.Controls.Add(this.lblAssuranceID);
            this.groupClient.Controls.Add(this.lblPhone);
            this.groupClient.Controls.Add(this.lblClientName);
            this.groupClient.Controls.Add(this.label1);
            this.groupClient.Controls.Add(this.label2);
            this.groupClient.Controls.Add(this.Label80);
            this.groupClient.Controls.Add(this.label3);
            this.groupClient.Controls.Add(this.label4);
            this.groupClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupClient.Location = new System.Drawing.Point(22, 77);
            this.groupClient.Name = "groupClient";
            this.groupClient.Size = new System.Drawing.Size(586, 235);
            this.groupClient.TabIndex = 1;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Informations du Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 28);
            this.label10.TabIndex = 15;
            this.label10.Text = ":";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCar.Location = new System.Drawing.Point(281, 190);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(156, 28);
            this.lblCar.TabIndex = 14;
            this.lblCar.Text = "############";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBrand.Location = new System.Drawing.Point(281, 147);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(156, 28);
            this.lblBrand.TabIndex = 13;
            this.lblBrand.Text = "############";
            // 
            // lblAssuranceID
            // 
            this.lblAssuranceID.AutoSize = true;
            this.lblAssuranceID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssuranceID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAssuranceID.Location = new System.Drawing.Point(281, 110);
            this.lblAssuranceID.Name = "lblAssuranceID";
            this.lblAssuranceID.Size = new System.Drawing.Size(156, 28);
            this.lblAssuranceID.TabIndex = 12;
            this.lblAssuranceID.Text = "############";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPhone.Location = new System.Drawing.Point(281, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(156, 28);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "############";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblClientName.Location = new System.Drawing.Point(281, 30);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(156, 28);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "############";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Téléphone";
            // 
            // Label80
            // 
            this.Label80.AutoSize = true;
            this.Label80.Location = new System.Drawing.Point(20, 110);
            this.Label80.Name = "Label80";
            this.Label80.Size = new System.Drawing.Size(209, 28);
            this.Label80.TabIndex = 4;
            this.Label80.Text = "Numéro d’Assurance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model";
            // 
            // groupDates
            // 
            this.groupDates.Controls.Add(this.label11);
            this.groupDates.Controls.Add(this.label5);
            this.groupDates.Controls.Add(this.label12);
            this.groupDates.Controls.Add(this.label13);
            this.groupDates.Controls.Add(this.label81);
            this.groupDates.Controls.Add(this.lblDaysRemaining);
            this.groupDates.Controls.Add(this.lblEndDate);
            this.groupDates.Controls.Add(this.label82);
            this.groupDates.Controls.Add(this.lblStartDate);
            this.groupDates.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupDates.Location = new System.Drawing.Point(20, 320);
            this.groupDates.Name = "groupDates";
            this.groupDates.Size = new System.Drawing.Size(588, 163);
            this.groupDates.TabIndex = 2;
            this.groupDates.TabStop = false;
            this.groupDates.Text = "Dates de l’Assurance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date de Début";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = ":";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(20, 70);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(120, 28);
            this.label81.TabIndex = 2;
            this.label81.Text = "Date de Fin";
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRemaining.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDaysRemaining.Location = new System.Drawing.Point(283, 116);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(156, 28);
            this.lblDaysRemaining.TabIndex = 22;
            this.lblDaysRemaining.Text = "############";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEndDate.Location = new System.Drawing.Point(283, 73);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(156, 28);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "############";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(20, 110);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(149, 28);
            this.label82.TabIndex = 4;
            this.label82.Text = "Jours Restants";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStartDate.Location = new System.Drawing.Point(283, 36);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(156, 28);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "############";
            // 
            // groupNotification
            // 
            this.groupNotification.Controls.Add(this.label23);
            this.groupNotification.Controls.Add(this.lblMessage);
            this.groupNotification.Controls.Add(this.label17);
            this.groupNotification.Controls.Add(this.label83);
            this.groupNotification.Controls.Add(this.label18);
            this.groupNotification.Controls.Add(this.label19);
            this.groupNotification.Controls.Add(this.label84);
            this.groupNotification.Controls.Add(this.lblReminderCount);
            this.groupNotification.Controls.Add(this.lblNextReminder);
            this.groupNotification.Controls.Add(this.label85);
            this.groupNotification.Controls.Add(this.lblSentDate);
            this.groupNotification.Controls.Add(this.label86);
            this.groupNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupNotification.Location = new System.Drawing.Point(628, 77);
            this.groupNotification.Name = "groupNotification";
            this.groupNotification.Size = new System.Drawing.Size(563, 406);
            this.groupNotification.TabIndex = 3;
            this.groupNotification.TabStop = false;
            this.groupNotification.Text = "Informations de Notification";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(243, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 28);
            this.label23.TabIndex = 33;
            this.label23.Text = ":";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMessage.Location = new System.Drawing.Point(268, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(281, 120);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "############";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(243, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 28);
            this.label17.TabIndex = 31;
            this.label17.Text = ":";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(20, 30);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(94, 28);
            this.label83.TabIndex = 0;
            this.label83.Text = "Message";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 28);
            this.label18.TabIndex = 30;
            this.label18.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 28);
            this.label19.TabIndex = 29;
            this.label19.Text = ":";
            // 
            // label84
            // 
            this.label84.Location = new System.Drawing.Point(20, 182);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(174, 31);
            this.label84.TabIndex = 2;
            this.label84.Text = "Date d’Envoi";
            // 
            // lblReminderCount
            // 
            this.lblReminderCount.AutoSize = true;
            this.lblReminderCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminderCount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblReminderCount.Location = new System.Drawing.Point(268, 263);
            this.lblReminderCount.Name = "lblReminderCount";
            this.lblReminderCount.Size = new System.Drawing.Size(156, 28);
            this.lblReminderCount.TabIndex = 28;
            this.lblReminderCount.Text = "############";
            // 
            // lblNextReminder
            // 
            this.lblNextReminder.AutoSize = true;
            this.lblNextReminder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextReminder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNextReminder.Location = new System.Drawing.Point(268, 220);
            this.lblNextReminder.Name = "lblNextReminder";
            this.lblNextReminder.Size = new System.Drawing.Size(156, 28);
            this.lblNextReminder.TabIndex = 27;
            this.lblNextReminder.Text = "############";
            // 
            // label85
            // 
            this.label85.Location = new System.Drawing.Point(20, 222);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(174, 31);
            this.label85.TabIndex = 4;
            this.label85.Text = "Prochain Rappel";
            // 
            // lblSentDate
            // 
            this.lblSentDate.AutoSize = true;
            this.lblSentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSentDate.Location = new System.Drawing.Point(268, 183);
            this.lblSentDate.Name = "lblSentDate";
            this.lblSentDate.Size = new System.Drawing.Size(156, 28);
            this.lblSentDate.TabIndex = 26;
            this.lblSentDate.Text = "############";
            // 
            // label86
            // 
            this.label86.Location = new System.Drawing.Point(20, 262);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(217, 35);
            this.label86.TabIndex = 6;
            this.label86.Text = "Nombre de Rappels";
            // 
            // groupResponse
            // 
            this.groupResponse.Controls.Add(this.label25);
            this.groupResponse.Controls.Add(this.label87);
            this.groupResponse.Controls.Add(this.label26);
            this.groupResponse.Controls.Add(this.txtSentBy);
            this.groupResponse.Controls.Add(this.chkHasContacted);
            this.groupResponse.Controls.Add(this.chkRenewalAccepted);
            this.groupResponse.Controls.Add(this.lblNotes);
            this.groupResponse.Controls.Add(this.txtNotes);
            this.groupResponse.Controls.Add(this.lblActionDate);
            this.groupResponse.Controls.Add(this.txtActionDate);
            this.groupResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupResponse.Location = new System.Drawing.Point(22, 494);
            this.groupResponse.Name = "groupResponse";
            this.groupResponse.Size = new System.Drawing.Size(1169, 253);
            this.groupResponse.TabIndex = 4;
            this.groupResponse.TabStop = false;
            this.groupResponse.Text = "Réponse du Commercial";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(658, 195);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 28);
            this.label25.TabIndex = 35;
            this.label25.Text = ":";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(21, 41);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(117, 28);
            this.label87.TabIndex = 0;
            this.label87.Text = "Envoyé Par";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(658, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 28);
            this.label26.TabIndex = 34;
            this.label26.Text = ":";
            // 
            // txtSentBy
            // 
            this.txtSentBy.Location = new System.Drawing.Point(176, 41);
            this.txtSentBy.Name = "txtSentBy";
            this.txtSentBy.ReadOnly = true;
            this.txtSentBy.Size = new System.Drawing.Size(250, 34);
            this.txtSentBy.TabIndex = 1;
            // 
            // chkHasContacted
            // 
            this.chkHasContacted.Location = new System.Drawing.Point(23, 146);
            this.chkHasContacted.Name = "chkHasContacted";
            this.chkHasContacted.Size = new System.Drawing.Size(189, 31);
            this.chkHasContacted.TabIndex = 2;
            this.chkHasContacted.Text = "Client Contacté";
            // 
            // chkRenewalAccepted
            // 
            this.chkRenewalAccepted.Location = new System.Drawing.Point(23, 193);
            this.chkRenewalAccepted.Name = "chkRenewalAccepted";
            this.chkRenewalAccepted.Size = new System.Drawing.Size(333, 34);
            this.chkRenewalAccepted.TabIndex = 3;
            this.chkRenewalAccepted.Text = "Renouvellement Accepté";
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(456, 43);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(122, 31);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(681, 32);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(470, 145);
            this.txtNotes.TabIndex = 5;
            // 
            // lblActionDate
            // 
            this.lblActionDate.Location = new System.Drawing.Point(456, 195);
            this.lblActionDate.Name = "lblActionDate";
            this.lblActionDate.Size = new System.Drawing.Size(193, 31);
            this.lblActionDate.TabIndex = 6;
            this.lblActionDate.Text = "Date de l’Action";
            // 
            // txtActionDate
            // 
            this.txtActionDate.Location = new System.Drawing.Point(681, 192);
            this.txtActionDate.Name = "txtActionDate";
            this.txtActionDate.Size = new System.Drawing.Size(200, 34);
            this.txtActionDate.TabIndex = 7;
            // 
            // btnSaveResponse
            // 
            this.btnSaveResponse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveResponse.ForeColor = System.Drawing.Color.White;
            this.btnSaveResponse.Location = new System.Drawing.Point(928, 753);
            this.btnSaveResponse.Name = "btnSaveResponse";
            this.btnSaveResponse.Size = new System.Drawing.Size(263, 60);
            this.btnSaveResponse.TabIndex = 8;
            this.btnSaveResponse.Text = "Enregistrer la Réponse";
            this.btnSaveResponse.UseVisualStyleBackColor = false;
            this.btnSaveResponse.Click += new System.EventHandler(this.btnSaveResponse_Click);
            // 
            // NotificationDetailControl
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupClient);
            this.Controls.Add(this.groupDates);
            this.Controls.Add(this.groupNotification);
            this.Controls.Add(this.groupResponse);
            this.Controls.Add(this.btnSaveResponse);
            this.Name = "NotificationDetailControl";
            this.Size = new System.Drawing.Size(1218, 821);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupClient.ResumeLayout(false);
            this.groupClient.PerformLayout();
            this.groupDates.ResumeLayout(false);
            this.groupDates.PerformLayout();
            this.groupNotification.ResumeLayout(false);
            this.groupNotification.PerformLayout();
            this.groupResponse.ResumeLayout(false);
            this.groupResponse.PerformLayout();
            this.ResumeLayout(false);

        }



        // Helper function
        private void AddLabel(Control parent, Label label, string text, int x, int y)
        {
            label.Text = text;
            label.AutoSize = true;
            label.Location = new Point(x, y + 3);
            label.Font = new Font("Segoe UI", 9);
            parent.Controls.Add(label);
        }

        private void AddTextBox(Control parent, TextBox txt, int x, int y)
        {
            txt.Size = new Size(250, 25);
            txt.Location = new Point(x, y);
            txt.Font = new Font("Segoe UI", 9);
            txt.ReadOnly = true;
            parent.Controls.Add(txt);
        }

        private Label lblPhone;
        private Label lblClientName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblCar;
        private Label lblBrand;
        private Label lblAssuranceID;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblDaysRemaining;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label lblReminderCount;
        private Label lblNextReminder;
        private Label lblSentDate;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label lblMessage;
    }
}
