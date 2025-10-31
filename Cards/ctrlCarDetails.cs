using GestionAssurances.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            if(filterData == null)
            {
                ctrlLabelFieldAnnee.FieldValue = "N/A";
                ctrlLabelFieldMois.FieldValue = "N/A";

                ctrlLabelFieldFilteringName.FieldValue = "N/A";
                ctrlLabelFieldFilteringName.FieldName = "N/A";
                return;
            }

            ctrlLabelFieldFilteringName.FieldName = filterData.FilterName;
            ctrlLabelFieldFilteringName.FieldValue = filterData.FilterValue;


            if (filterData.Annee.HasValue && filterData.Mois.HasValue)
            {
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.FieldValue = new DateTime(1, filterData.Mois.Value, 1).ToString("MMMM");
                return;
            }
            else if(filterData.Annee.HasValue)
            {
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.FieldValue = "N/A";
            }
            else if(filterData.Mois.HasValue)
            {
                ctrlLabelFieldMois.FieldValue = new DateTime(1, filterData.Mois.Value, 1).ToString("MMMM");
                ctrlLabelFieldAnnee.FieldValue = "N/A";
            }
            else
            {
                ctrlLabelFieldAnnee.FieldValue = "N/A";
                ctrlLabelFieldMois.FieldValue = "N/A";
            }

        }


    }
}
