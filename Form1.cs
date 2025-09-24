using GA_BLL;
using GestionAssurances.Assurance;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAllAssurances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvAllAssurances.ColumnHeadersHeight = 48; // change 40 to whatever height you want


            dgvAllAssurances.ScrollBars = ScrollBars.Both; // or ScrollBars.Horizontal

            //dgvAllAssurances.DataSource = clsAssurance.GetAllAssurances();

            _LoadData();

        }

        void _LoadData()
        {
            dgvAllAssurances.DataSource = clsAssurance.GetAllAssurances();

            if(dgvAllAssurances.Rows.Count > 0)
            {

                // I have ClientFullName ,ClientPhone ,VoitureMarque ,DurationMonths ,DurationStart ,
                // DurationEnd ,PaymentEspece ,PaymentCheque ,PaymentVirBank ,PaymentWafaSalaf ,
                // TotalPayment ,ComercialUsername ,Version ,IsCurrent


                // I want to set width for each column and header text
                // For User i want to put titles an Francais



                dgvAllAssurances.Columns["ClientFullName"].Width = 150;
                dgvAllAssurances.Columns["ClientFullName"].HeaderText = "Client";

                dgvAllAssurances.Columns["ClientPhone"].Width = 120;
                dgvAllAssurances.Columns["ClientPhone"].HeaderText = "Téléphone";

                dgvAllAssurances.Columns["ClientEmail"].Width = 150;
                dgvAllAssurances.Columns["ClientEmail"].HeaderText = "Email";

                dgvAllAssurances.Columns["Marque"].Width = 120;
                dgvAllAssurances.Columns["Marque"].HeaderText = "Marque";

                dgvAllAssurances.Columns["Model"].Width = 120;
                dgvAllAssurances.Columns["Model"].HeaderText = "Modèle";

                dgvAllAssurances.Columns["Matricule"].Width = 100;
                dgvAllAssurances.Columns["Matricule"].HeaderText = "Matricule";

                dgvAllAssurances.Columns["Dure"].Width = 70;
                dgvAllAssurances.Columns["Dure"].HeaderText = "Durée";

                dgvAllAssurances.Columns["Debut"].Width = 90;
                dgvAllAssurances.Columns["Debut"].HeaderText = "Début";

                dgvAllAssurances.Columns["Fin"].Width = 90;
                dgvAllAssurances.Columns["Fin"].HeaderText = "Fin";

                dgvAllAssurances.Columns["Espece"].Width = 90;
                dgvAllAssurances.Columns["Espece"].HeaderText = "Espèce";

                dgvAllAssurances.Columns["Cheque"].Width = 90;
                dgvAllAssurances.Columns["Cheque"].HeaderText = "Chèque";

                dgvAllAssurances.Columns["VirBank"].Width = 100;
                dgvAllAssurances.Columns["VirBank"].HeaderText = "Vir. Bank";

                dgvAllAssurances.Columns["WafaSalaf"].Width = 100;
                dgvAllAssurances.Columns["WafaSalaf"].HeaderText = "WafaSalaf";

                dgvAllAssurances.Columns["Total"].Width = 100;
                dgvAllAssurances.Columns["Total"].HeaderText = "Total";

                dgvAllAssurances.Columns["ComercialUsername"].Width = 120;
                dgvAllAssurances.Columns["ComercialUsername"].HeaderText = "Commercial";

                dgvAllAssurances.Columns["Status"].Width = 100;
                dgvAllAssurances.Columns["Status"].HeaderText = "Statut";

                dgvAllAssurances.Columns["Version"].Width = 60;
                dgvAllAssurances.Columns["Version"].HeaderText = "Version";

                dgvAllAssurances.Columns["IsCurrent"].Width = 60;
                dgvAllAssurances.Columns["IsCurrent"].HeaderText = "Actuel";





            }

            lblRecord.Text = $" # {dgvAllAssurances.Rows.Count.ToString()}";

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance();
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AssuranceID = Convert.ToInt32(dgvAllAssurances.CurrentRow.Cells[0].Value);
            frmAddEditRenewAssurance frmAddEditRenewAssurance = new frmAddEditRenewAssurance(AssuranceID);
            frmAddEditRenewAssurance.ShowDialog();
            Form1_Load(null, null);
        }
    }
}
