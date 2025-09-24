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

namespace GestionAssurances.Comercial.Forms
{
    public partial class frmListOfComercials : Form
    {
        DataTable _dtComercials;

        public frmListOfComercials()
        {
            InitializeComponent();
        }

        void _LoadComercials()
        {
            dgvAllComerciaux.ColumnHeadersHeight = 40; // change 40 to whatever height you want
            _dtComercials = clsComercial.AllComercials();

            dgvAllComerciaux.DataSource = _dtComercials;

            if(dgvAllComerciaux.Rows.Count > 0)
            {
                dgvAllComerciaux.Columns["ComercialID"].HeaderText = "ID";

                dgvAllComerciaux.Columns["FirstName"].HeaderText = "Prénom";

                dgvAllComerciaux.Columns["LastName"].HeaderText = "Nom";

                dgvAllComerciaux.Columns["Phone"].HeaderText = "Téléphone";

                dgvAllComerciaux.Columns["Email"].HeaderText = "Email";

                dgvAllComerciaux.Columns["Username"].HeaderText = "Nom d'utilisateur";

            }

            lblRecord.Text = $"# {dgvAllComerciaux.Rows.Count}";

        }

        private void frmListOfComercials_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;

            _LoadComercials();
        }

        private void btnAddComercial_Click(object sender, EventArgs e)
        {
            frmAddEditComercial frmAddEditComercial = new frmAddEditComercial();
            frmAddEditComercial.ShowDialog();
            frmListOfComercials_Load(null, null);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditComercial frmAddEditComercial = new frmAddEditComercial();
            frmAddEditComercial.ShowDialog();
            frmListOfComercials_Load(null, null);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditComercial frmAddEditComercial = new frmAddEditComercial(Convert.ToInt32(dgvAllComerciaux.CurrentRow.Cells[0].Value));
            frmAddEditComercial.ShowDialog();
            frmListOfComercials_Load(null, null);
        }

        private void trouverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComercialInfo frmComercialInfo = new frmComercialInfo(Convert.ToInt32(dgvAllComerciaux.CurrentRow.Cells[0].Value)); 
            frmComercialInfo.ShowDialog();
        }

        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            // message box an francais : delete or not delete
            if (MessageBox.Show(Text = "Êtes-vous sûr de vouloir supprimer ce commercial?", caption: "Confirmer la suppression", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool result = clsComercial.DeleteByID(Convert.ToInt32(dgvAllComerciaux.CurrentRow.Cells[0].Value));
                if (result)
                {
                    MessageBox.Show("Comercial supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListOfComercials_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du comercial.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // User chose not to delete
                MessageBox.Show("Suppression annulée.", "Annulé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFindBy.Visible = cbFindBy.Text != "Aucun";

            if (txtFindBy.Visible)
            {
                txtFindBy.Text = string.Empty;
                txtFindBy.Focus();
            }
        }

        private void txtFindBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFindBy.Text)
            {
                case "Comercial ID":
                    FilterColumn = "ComercialID";
                    break;

                case "Nom":
                    FilterColumn = "LastName";
                    break;

                case "Prenom":
                    FilterColumn = "FirstName";
                    break;

                case "Telephone":
                    FilterColumn = "Phone";
                    break;

                case "Nom d'utilisateur":
                    FilterColumn = "Username";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFindBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtComercials.DefaultView.RowFilter = "";
                if (dgvAllComerciaux.Rows.Count > 1)
                    lblRecord.Text = "# " + dgvAllComerciaux.Rows.Count.ToString() ;
                else
                    lblRecord.Text = "# " + dgvAllComerciaux.Rows.Count.ToString() ;

                return;
            }

            if (FilterColumn == "ComercialID")
            {
                _dtComercials.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFindBy.Text.Trim());
            }
            else
            {
                _dtComercials.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFindBy.Text.Trim());
            }

            dgvAllComerciaux.DataSource = _dtComercials;

            if (dgvAllComerciaux.Rows.Count > 1)
                lblRecord.Text = "# " + dgvAllComerciaux.Rows.Count.ToString();
            else
                lblRecord.Text = "# " + dgvAllComerciaux.Rows.Count.ToString();
        }
    }
}
