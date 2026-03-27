using GestionAssurances.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Cards
{
    public partial class ctrlCarDetails : UserControl
    {
        public ctrlCarDetails()
        {
            InitializeComponent();
        }

        public void _LoadData(clsFilterData filterData)
        {

            CultureInfo fr = new CultureInfo("fr-FR"); // use once

            if(filterData == null)
            {
                ctrlLabelFieldAnnee.FieldValue = "N/A";
                ctrlLabelFieldMois.FieldValue = "N/A";
                ctrlLabelFieldFilteringName.FieldValue = "N/A";
                return;
            }

            if (filterData.Annee.HasValue && filterData.MoisDebut.HasValue && filterData.MoisFin.HasValue)
            {
                int startMonth = Math.Min(filterData.MoisDebut.Value, filterData.MoisFin.Value);
                int endMonth = Math.Max(filterData.MoisDebut.Value, filterData.MoisFin.Value);
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.FieldName = "Période";
                ctrlLabelFieldMois.FieldValue =
                    $"De {new DateTime(1, startMonth, 1).ToString("MMMM", fr)} à {new DateTime(1, endMonth, 1).ToString("MMMM", fr)}";
                
            }
            else if (filterData.Annee.HasValue && filterData.Mois.HasValue)
            {
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.FieldValue = new DateTime(1, filterData.Mois.Value, 1).ToString("MMMM", fr);
            }
            else if (filterData.Annee.HasValue)
            {
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.FieldValue = "N/A";
            }
            else if (filterData.Mois.HasValue)
            {
                ctrlLabelFieldMois.FieldValue = new DateTime(1, filterData.Mois.Value, 1).ToString("MMMM", fr);
                ctrlLabelFieldAnnee.FieldValue = "N/A";
            }
            else
            {
                ctrlLabelFieldAnnee.FieldValue = "N/A";
                ctrlLabelFieldMois.FieldValue = "N/A";
            }

            ctrlLabelFieldFilteringName.FieldValue = filterData.FilterValue;

        }

        private void ctrlCarDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
