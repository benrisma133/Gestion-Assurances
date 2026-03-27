using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Assurance
{
    public partial class frmAssuranceInfo : Form
    {

        int _AssuranceID = -1;
        public frmAssuranceInfo(int AssuranceID)
        {
            InitializeComponent();

            _AssuranceID = AssuranceID;

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Get the working area of the screen (excludes taskbar)
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            // Resize if too big
            if (this.Width > screen.Width) this.Width = screen.Width;
            if (this.Height > screen.Height) this.Height = screen.Height;

            // Center the form
            this.Left = (screen.Width - this.Width) / 2;
            this.Top = (screen.Height - this.Height) / 2;
        }

        private void frmAssuranceInfo_Load(object sender, EventArgs e)
        {
            ctrlAssuranceCard1.LoadAssuranceDataByID(_AssuranceID);
        }
    }
}
