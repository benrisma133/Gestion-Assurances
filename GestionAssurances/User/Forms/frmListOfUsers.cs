using GA_BLL;
using Guna.UI.WinForms;
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
    public partial class frmListOfUsers : Form
    {
        DataTable _dtAllUsers;
        public frmListOfUsers()
        {
            InitializeComponent();
        }

        void _LoadUsers()
        {
            // 1. جلب جميع المستخدمين
            _dtAllUsers = clsUser.GetAllUsers();

            // 2. check if there is data
            if (_dtAllUsers.Rows.Count == 0)
            {
                dgvAllComerciaux.DataSource = null;
                lblRecord.Text = "# 0";
                return; // exit: no data to show
            }

            // 3. تعديل Address فارغ → "N/A"
            foreach (DataRow row in _dtAllUsers.Rows)
            {
                if (string.IsNullOrWhiteSpace(row["Address"].ToString()))
                    row["Address"] = "N/A";
            }

            // 4. ربط DataGridView
            dgvAllComerciaux.DataSource = _dtAllUsers;

            // 5. تعديل ارتفاع headers
            dgvAllComerciaux.ColumnHeadersHeight = 40;

            // 6. تحديث lblRecord
            lblRecord.Text = $"# {_dtAllUsers.Rows.Count}";

        }

        private void frmListOfUsers_Load(object sender, EventArgs e)
        {
            _LoadUsers();

            cbFilterByStatus.SelectedIndex = 1;
            cbFindBy.SelectedIndex = 0;

            DataView dv = new DataView(_dtAllUsers); // create a view to filter

            switch (cbFilterByStatus.SelectedIndex)
            {
                case 0: // All
                    dv.RowFilter = ""; // show all
                    break;
                case 1: // Active
                    dv.RowFilter = "IsActive = true"; // only active users
                    break;
                case 2: // Inactive
                    dv.RowFilter = "IsActive = false"; // only inactive users
                    break;
            }

            // مثلا عندك DataGridView اسمه dgvUsers
            dgvAllComerciaux.DataSource = dv;
            lblRecord.Text = $"# {dgvAllComerciaux.Rows.Count}";
        }

        private void txtFindBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;

            switch (cbFindBy.Text)
            {
                case "UserID": FilterColumn = "UserID"; break;
                case "Username": FilterColumn = "Username"; break;
                case "FullName": FilterColumn = "FullName"; break;
                case "Email": FilterColumn = "Email"; break;
                case "Phone": FilterColumn = "Phone"; break;
                case "Address": FilterColumn = "Address"; break;
                default: FilterColumn = "None"; break;
            }

            string rowFilter = "";

            if (FilterColumn != "None" && !string.IsNullOrWhiteSpace(txtFindBy.Text))
            {
                string text = txtFindBy.Text.Trim().Replace("'", "''");
                if (FilterColumn == "UserID")
                    rowFilter = $"[{FilterColumn}] = {text}";
                else
                    rowFilter = $"[{FilterColumn}] LIKE '{text}%'";
            }

            // دمج مع filter ديال status
            string statusFilter = GetStatusFilter();
            if (!string.IsNullOrEmpty(statusFilter))
            {
                if (!string.IsNullOrEmpty(rowFilter))
                    rowFilter += " AND " + statusFilter;
                else
                    rowFilter = statusFilter;
            }

            _dtAllUsers.DefaultView.RowFilter = rowFilter;
            dgvAllComerciaux.DataSource = _dtAllUsers.DefaultView;

            lblRecord.Text = $"# {_dtAllUsers.DefaultView.Count}";
        }

        // function helper باش ترجع filter ديال status
        private string GetStatusFilter()
        {
            switch (cbFilterByStatus.SelectedIndex)
            {
                case 1: // Active
                    return "IsActive = true";
                case 2: // Inactive
                    return "IsActive = false";
                default: // 0 = All
                    return "";
            }
        }

        private void txtFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Apply numeric-only rule ONLY when Comercial ID is selected
            if (cbFindBy.Text == "UserID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // block non-numeric input
                    return;
                }

                // Block 0 as first digit or single value
                if (e.KeyChar == '0' && ((GunaLineTextBox)sender).Text.Length == 0)
                {
                    e.Handled = true;
                }
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

        private void cbFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(_dtAllUsers); // create a view to filter

            switch (cbFilterByStatus.SelectedIndex)
            {
                case 0: // All
                    dv.RowFilter = ""; // show all
                    break;
                case 1: // Active
                    dv.RowFilter = "IsActive = true"; // only active users
                    break;
                case 2: // Inactive
                    dv.RowFilter = "IsActive = false"; // only inactive users
                    break;
            }

            // مثلا عندك DataGridView اسمه dgvUsers
            dgvAllComerciaux.DataSource = dv;
            lblRecord.Text = $"# {dgvAllComerciaux.Rows.Count}";

        }

        private void btnAddComercial_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.ShowDialog();
            frmListOfUsers_Load(null, null);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.ShowDialog();
            frmListOfUsers_Load(null, null);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(int.Parse(dgvAllComerciaux.CurrentRow.Cells["UserID"].Value.ToString()));
            frmAddEditUser.ShowDialog();
            frmListOfUsers_Load(null, null);
        }

        private void trouverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(int.Parse(dgvAllComerciaux.CurrentRow.Cells["UserID"].Value.ToString()));
            frmUserInfo.ShowDialog();
            frmListOfUsers_Load(null, null);
        }

        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllComerciaux.CurrentRow == null)
                return; // ما كاين حتى صف مختار

            int userID = int.Parse(dgvAllComerciaux.CurrentRow.Cells["UserID"].Value.ToString());

            // confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool deleted = clsUser.DeleteUser(userID);

                if (deleted)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListOfUsers_Load(null, null); // إعادة تحميل القائمة بعد الحذف
                }
                else
                {
                    MessageBox.Show("Failed to delete the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAllComerciaux.CurrentRow == null)
                return;

            bool isActive = Convert.ToBoolean(dgvAllComerciaux.CurrentRow.Cells["IsActive"].Value);

            if (isActive)
            {
                activateToolStripMenuItem.Text = "Deactivate";
                activateToolStripMenuItem.Image = Properties.Resources.switch_active_24;
            }
            else
            {
                activateToolStripMenuItem.Text = "Activate";
                activateToolStripMenuItem.Image = Properties.Resources.switch_nonactive_24;
            }
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllComerciaux.CurrentRow == null)
                return;

            int userID = Convert.ToInt32(dgvAllComerciaux.CurrentRow.Cells["UserID"].Value);
            bool isActive = Convert.ToBoolean(dgvAllComerciaux.CurrentRow.Cells["IsActive"].Value);

            // Toggle
            bool newStatus = !isActive;

            // Call update function
            if (clsUser.UpdateUserStatus(userID, newStatus)) // هادي خاصك تديرها فال clsUser
            {
                dgvAllComerciaux.CurrentRow.Cells["IsActive"].Value = newStatus;

                MessageBox.Show(
                    $"User has been {(newStatus ? "activated" : "deactivated")}.",
                    "Status Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmListOfUsers_Load(null, null); // إعادة تحميل القائمة لتحديث الفلترة
            }
            else
            {
                MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
