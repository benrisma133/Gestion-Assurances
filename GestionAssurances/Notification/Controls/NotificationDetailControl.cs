using GA_BLL;
using System;
using System.Windows.Forms;

namespace GestionAssurances.Notification.Controls
{
    public partial class NotificationDetailControl : UserControl
    {
        public NotificationDetailControl()
        {
            InitializeComponent();
        }

        private int _NotificationID;
        private int _CommercialID; // Placeholder for the logged-in commercial ID
        private clsResponse _CurrentResponse;

        public void LoadData(int NotificationID)
        {
            clsNotification notification = clsNotification.Find(NotificationID);

            if (notification == null)
            {
                MessageBox.Show("Notification introuvable !");
                return;
            }

            _NotificationID = NotificationID;
            _CommercialID = notification.Assurance.ComercialID; // store for saving

            // =============================
            // CLIENT & ASSURANCE DETAILS
            // =============================
            lblClientName.Text = notification.Assurance.ClientInfo.FullName;
            lblPhone.Text = notification.Assurance.Assurance.Phone;
            lblAssuranceID.Text = notification.AssuranceID.ToString();
            lblBrand.Text = clsBrand.FindByID(notification.Assurance.CarInfo.BrandID).Name;
            lblCar.Text = notification.Assurance.CarInfo.Model;
            lblStartDate.Text = notification.Assurance.DurationInfo.StartDate.ToShortDateString();
            lblEndDate.Text = notification.Assurance.DurationInfo.EndDate.ToShortDateString();
            lblDaysRemaining.Text = notification.DaysRemainin.ToString();

            // =============================
            // NOTIFICATION DETAILS
            // =============================
            lblMessage.Text = notification.Message;
            lblSentDate.Text = notification.SentDate.ToShortDateString();
            lblNextReminder.Text = notification.NextReminderDate.ToShortDateString();
            lblReminderCount.Text = notification.ReminderCount.ToString();

            // =============================
            // RESPONSE / ACTION
            // =============================
            if (notification.Response != null)
            {
                _CurrentResponse = notification.Response;

                txtSentBy.Text = clsComercial.FindByID(notification.Response.CommercialID).Username;
                chkHasContacted.Checked = notification.Response.HasContactedClient;
                chkRenewalAccepted.Checked = notification.Response.RenewalAccepted;
                txtNotes.Text = notification.Response.Notes;

                txtActionDate.Text = notification.ActionDate.HasValue
                    ? notification.ActionDate.Value.ToShortDateString()
                    : "";
            }
            else
            {
                // No response → clear controls
                _CurrentResponse = null;
                txtSentBy.Text = ""; // keep _CommercialID intact
                chkHasContacted.Checked = false;
                chkRenewalAccepted.Checked = false;
                txtNotes.Text = "";
                txtActionDate.Text = "";
            }
        }
        
        private void btnSaveResponse_Click(object sender, EventArgs e)
        {
            try
            {

                // 2. Try to find existing response
                clsResponse response = clsResponse.FindByNotificationID(_NotificationID);

                if (response == null)
                {
                    // No existing response → create new
                    response = new clsResponse
                    {
                        NotificationID = _NotificationID,
                        CommercialID = _CommercialID,
                        HasContactedClient = chkHasContacted.Checked,
                        RenewalAccepted = chkRenewalAccepted.Checked,
                        Notes = txtNotes.Text
                    };
                }
                else
                {
                    // Existing response → update
                    response.HasContactedClient = chkHasContacted.Checked;
                    response.RenewalAccepted = chkRenewalAccepted.Checked;
                    response.Notes = txtNotes.Text;
                }

                // 3. Save (Add or Update)
                if (response.Save())
                {
                    MessageBox.Show("Réponse enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Update UI if needed
                    txtActionDate.Text = response.ActionDate.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Échec de l'enregistrement de la réponse.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
