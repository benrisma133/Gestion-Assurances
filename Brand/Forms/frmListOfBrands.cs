using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Brand.Forms
{
    public partial class frmListOfBrands : Form
    {

        DataTable _dtBrands;

        public frmListOfBrands()
        {
            InitializeComponent();

            // Use these to force the whole window to exactly 1048x823
            this.Size = new System.Drawing.Size(700, 530);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // or FixedDialog, Fixed3D
            this.MaximizeBox = false;   // disable maximize button
            this.MinimizeBox = false;    // optional: keep minimize if you want

            // Make sure user cannot change by resizing
            this.MinimumSize = this.MaximumSize = this.Size;

            // Optional: don't auto-scale to avoid unexpected DPI resizing
            this.AutoScaleMode = AutoScaleMode.None;

            // Optional: center on screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void _LoadRecors()
        {
            lblRecord.Text = dgvAllBrands.Rows.Count.ToString();
        }

        void _LoadData()
        {
            _dtBrands = GA_BLL.clsBrand.AllBrands();
            dgvAllBrands.DataSource = _dtBrands;

            dgvAllBrands.Columns["BrandID"].HeaderText = "MarqueID";
            dgvAllBrands.Columns["BrandID"].Width = 150;

            dgvAllBrands.Columns["Name"].HeaderText = "Nom de la marque";
            dgvAllBrands.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            _LoadRecors();

            cbFilterBy.SelectedIndex = 0;
        }

        private void frmListOfBrands_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmAddEditBrand frm = new frmAddEditBrand();
            frm.ShowDialog();
            frmListOfBrands_Load(null, null);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBrand frm = new frmAddEditBrand();
            frm.ShowDialog();
            frmListOfBrands_Load(null, null);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BrandID = Convert.ToInt32(dgvAllBrands.CurrentRow.Cells[0].Value);
            frmAddEditBrand frm = new frmAddEditBrand(BrandID);
            frm.ShowDialog();
            frmListOfBrands_Load(null, null);
        }

        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BrandID = Convert.ToInt32(dgvAllBrands.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette marque ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (GA_BLL.clsBrand.DeleteByID(BrandID))
            {
                MessageBox.Show("Marque supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListOfBrands_Load(null, null);
                return;
            }

            MessageBox.Show("Échec de la suppression de la marque. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterByValue.Visible = (cbFilterBy.Text != "Aucun");

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Focus();
                txtFilterByValue.Text = string.Empty;
            }
            else
            {
                txtFilterByValue.Text = string.Empty;
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = string.Empty;

            switch (cbFilterBy.Text)
            {
                case "Aucun":
                    filterExpression = "Aucun";
                    break;

                case "Marque":
                    filterExpression = "Name";
                    break;

            }

            if(txtFilterByValue.Text.Trim() != string.Empty && filterExpression != "Aucun")
            {
                _dtBrands.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", filterExpression, txtFilterByValue.Text.Trim().Replace("'", "''"));
            }
            else
            {
                _dtBrands.DefaultView.RowFilter = string.Empty;
            }

            _LoadRecors();

        }
    }
}
