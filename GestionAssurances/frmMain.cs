using GA_BLL;
using GA_DAL;
using GestionAssurances.Brand.Forms;
using GestionAssurances.Comercial.Forms;
using GestionAssurances.Notification.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int unreadCount = 0;

        private void voituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comercialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfComercials frmListOfComercials = new frmListOfComercials();
            frmListOfComercials.ShowDialog();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comercialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void listDesMarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfBrands frm = new frmListOfBrands();
            frm.ShowDialog();
        }

        private void listDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfAssurances frm = new frmListOfAssurances();
            frm.ShowDialog();
        }

        private void historiquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListOfAssurances frmListOfAssurances = new frmListOfAssurances(frmListOfAssurances.enAssuranceViewMode.Historique);
            frmListOfAssurances.ShowDialog();
        }

        private void assurancesArchivéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfAssurances frmListOfAssurances = new frmListOfAssurances(frmListOfAssurances.enAssuranceViewMode.Archive);
            frmListOfAssurances.ShowDialog();
        }

        //private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //    frmNotificationScreen frmNotificationScreen = new frmNotificationScreen();
        //    frmNotificationScreen.ShowDialog();
        //}

        // ======== Global Variables ========
        private int _notificationCount = 0;


        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1) Get unread notifications count
            _notificationCount = clsNotificationData.CountUnreadNotifications();

            // 2) Set icon
            if (_notificationCount == 0)
            {
                notificationsToolStripMenuItem.Image = Properties.Resources.bell_64;
                notificationsToolStripMenuItem.ForeColor = Color.Black;
            }
            else
            {
                notificationsToolStripMenuItem.Image = Properties.Resources.bell_notify_64;
                notificationsToolStripMenuItem.ForeColor = Color.FromArgb(40, 205, 140);
            }

            // 3) Update text
            notificationsToolStripMenuItem.Text = $"Notifications ({_notificationCount})";

        }


        private void UpdateNotificationCount()
        {
            // Get the latest unread count
            _notificationCount = clsNotificationData.CountUnreadNotifications();

            // Set icon and color
            if (_notificationCount == 0)
            {
                notificationsToolStripMenuItem.Image = Properties.Resources.bell_64;
                notificationsToolStripMenuItem.ForeColor = Color.Black;
            }
            else
            {
                notificationsToolStripMenuItem.Image = Properties.Resources.bell_notify_64;
                notificationsToolStripMenuItem.ForeColor = Color.FromArgb(40, 205, 140);
            }

            // Update text
            notificationsToolStripMenuItem.Text = $"Notifications ({_notificationCount})";
        }


        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotificationScreen frmNotificationScreen = new frmNotificationScreen();
            frmNotificationScreen.NotificationsUpdated += UpdateNotificationCount;
            frmNotificationScreen.ShowDialog();

            // refresh unread count after closing notifications window
            _notificationCount = clsNotificationData.CountUnreadNotifications();
            notificationsToolStripMenuItem.Invalidate(); // repaint to update the number
        }

    }
}
