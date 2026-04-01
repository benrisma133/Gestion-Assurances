using GA_BLL;
using GA_DAL;
using GestionAssurances.Brand.Forms;
using GestionAssurances.Comercial.Forms;
using GestionAssurances.Global;
using GestionAssurances.Login;
using GestionAssurances.Notification.Forms;
using GestionAssurances.User.Forms;
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
        frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
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
            _LoadDashboard();
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

        void _LoadNotifications()
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

        private void _LoadDashboardStats()
        {
            // Clear first
            lblCurrentAssurances.Text = "";
            lblExpiredAssurances.Text = "";
            lblTodayRevenue.Text = "";
            lblTopBrand.Text = "";
            lblTopComercial.Text = "";
            lblTotalAssurances.Text = "";
            lblTotalClients.Text = "";
            lblTotalRevenue.Text = "";

            try
            {
                // Get data from BLL
                var dto = GA_BLL.clsDashboardStats.GetDashboard();

                // Set labels
                lblTotalAssurances.Text = dto.TotalAssurances.ToString();
                lblCurrentAssurances.Text = dto.CurrentAssurances.ToString();
                lblTotalClients.Text = dto.TotalClients.ToString();
                lblExpiredAssurances.Text = dto.ExpiredAssurances.ToString();
                lblTotalRevenue.Text = dto.TotalRevenue.ToString() + " MAD";    // formatted as currency
                lblTodayRevenue.Text = dto.RevenueToday.ToString() + " MAD";     // formatted as currency
                lblTopComercial.Text = $"{dto.TopComercialName} ({dto.TopComercialCount})";
                lblTopBrand.Text = $"{dto.TopBrandName} ({dto.TopBrandCount})";
            }
            catch (Exception ex)
            {
                // Optional: log or show error
                MessageBox.Show("Failed to load dashboard: " + ex.Message);
            }
        }

        private void _LoadStatusChart()
        {
            try
            {
                // Clear old data
                chartStatus.Series.Clear();
                chartStatus.Titles.Clear();

                // Get data
                var list = GA_BLL.clsDashboardStats.GetAssurancesByStatus();

                // ✅ هنا دير check قبل ما تكري series
                if (list.Count == 0)
                {
                    chartStatus.Titles.Add("No Data Available");
                    return;
                }

                // Create series
                var series = chartStatus.Series.Add("Statuses");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // Add data
                foreach (var item in list)
                {
                    series.Points.AddXY(item.StatusName, item.Total);
                }

                // ✅ هنا تحط styling ديال pie
                series.IsValueShownAsLabel = true;
                series["PieLabelStyle"] = "Outside";
                series["PieLineColor"] = "Black";

                // Title
                chartStatus.Titles.Add("Assurances by Status");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }

        private void _LoadMonthlyChart()
        {
            try
            {
                chartMonthly.Series.Clear();
                chartMonthly.Titles.Clear();

                var list = GA_BLL.clsDashboardStats.GetAssurancesByMonth();

                if (list.Count == 0)
                {
                    chartMonthly.Titles.Add("No Data Available");
                    return;
                }

                var series = chartMonthly.Series.Add("Assurances");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.BorderWidth = 3;

                foreach (var item in list)
                {
                    string monthName = new DateTime(1, item.Month, 1).ToString("MMM");
                    series.Points.AddXY(monthName, item.Total);
                }

                series.IsValueShownAsLabel = true;

                // ✅ إعدادات المحور X
                chartMonthly.ChartAreas[0].AxisX.Interval = 1;

                // ✅ هنا تحطها (إخفاء grid lines)
                chartMonthly.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartMonthly.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                chartMonthly.Titles.Add("Assurances per Month");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _LoadDashboard()
        {
            _LoadDashboardStats();
            //_LoadNotifications();
            _LoadStatusChart();
            _LoadMonthlyChart();
        }

        private void SetWelcomeMessage(string username)
        {
            string greeting;

            if (DateTime.Now.Hour < 12)
                greeting = "Good morning";
            else if (DateTime.Now.Hour < 18)
                greeting = "Good afternoon";
            else
                greeting = "Good evening";

            lblGreating.Text = $"{greeting}, {username} 👋";
            //lblWelcome.Text = "Welcome back to Gestion Assurances System";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadDashboard();
            flowLayoutPanel1.SuspendLayout();

            flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);

            flowLayoutPanel1.ResumeLayout();

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[0]);
            }

            this.BeginInvoke(new Action(() =>
            {
                flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            }));

            string username = clsGlobal.CurrentUser.Username;
            SetWelcomeMessage(username);
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

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMain_Load(null, null);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfUsers frmListOfUsers = new frmListOfUsers();
            frmListOfUsers.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLogin.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            clsGlobal.RememberUsernameAndPassword("", "");
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frmUserInfo.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
