using GA_BLL;
using GestionAssurances.Global;
using GestionAssurances.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashedPassword = clsUtil.HashPassword(txtPassword.FieldValue);
            clsUser User = clsUser.Login(txtUsername.FieldValue, hashedPassword);

            if (User != null)
            {

                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUsername.FieldValue.Trim(), hashedPassword);
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.IsActive)
                {
                    MessageBox.Show("Your account is not Active ,Contact Admin", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = User;
                this.Hide();
                frmMain frmMain = new frmMain(this);
                frmMain.ShowDialog();

            }

            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = string.Empty;
            string hashedPassword = string.Empty;

            if (clsGlobal.GetStoredCredential(ref username, ref hashedPassword))
            {
                // نحاول login مباشرة
                clsUser user = clsUser.Login(username, hashedPassword);

                if (user != null && user.IsActive)
                {
                    clsGlobal.CurrentUser = user;

                    this.Hide();
                    frmMain frm = new frmMain(this);
                    frm.ShowDialog();
                    return;
                }

                // إلا فشل login (مثلاً password تبدل)
                clsGlobal.RememberUsernameAndPassword("", "");
            }

            // default UI
            txtUsername.FieldValue = username;
            txtPassword.FieldValue = "";
            txtUsername.Focus();
        }
    }
}
