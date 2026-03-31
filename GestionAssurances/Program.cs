using GestionAssurances.Assurance;
using GestionAssurances.Comercial.Forms;
using GestionAssurances.Login;
using GestionAssurances.Notification.Forms;
using GestionAssurances.User.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmMain());
            //Application.Run(new frmLogin());
            //Application.Run(new frmNotificationScreen());
            //Application.Run(new frmAssuranceInfo());
            //Application.Run(new frmTest());
            //Application.Run(new frmAddEditUser());
            //Application.Run(new frmUserInfo(1));
            Application.Run(new frmListOfUsers());
            //Application.Run(new frmAddEditRenewAssurance());
            //Application.Run(new frmAddEditComercial(1));
            //Application.Run(new frmListOfComercials());
        }
    }
}
