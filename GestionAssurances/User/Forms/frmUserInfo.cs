using GA_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.User.Forms
{
    public partial class frmUserInfo : Form
    {
        clsUser _User;
        int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            _User = clsUser.GetUserByID(_UserID);

            if(_User == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonData(clsPerson.GetPersonByID(_User.PersonID));
            ctrlUserCard1.LoadUserData(_User.Username ,_User.IsActive);

        }
    }
}
