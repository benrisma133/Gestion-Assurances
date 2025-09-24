using GestionAssurances.Comercial.Forms;
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

        private void voituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void comercialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfComercials frmListOfComercials = new frmListOfComercials();
            frmListOfComercials.ShowDialog();
        }
    }
}
