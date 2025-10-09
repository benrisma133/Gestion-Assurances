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
            ctrlLabelFieldFilteringName.FieldName = filterData.FilterName;
            ctrlLabelFieldFilteringName.FieldValue = filterData.FilterValue;
            
            if(filterData.Annee.HasValue)
            {
                ctrlLabelFieldAnnee.FieldValue = filterData.Annee.Value.ToString();
                ctrlLabelFieldMois.Visible = false;
            }
            else if(filterData.Mois.HasValue)
            {
                ctrlLabelFieldMois.FieldValue = new DateTime(1, filterData.Mois.Value, 1).ToString("MMMM");
                ctrlLabelFieldAnnee.Visible = false;
            }
            else
            {
                ctrlLabelFieldAnnee.FieldValue = "N/A";
                ctrlLabelFieldMois.FieldValue = "N/A";
            }

        }

    }
}
