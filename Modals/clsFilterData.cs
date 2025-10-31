using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAssurances.Modals
{
    public class clsFilterData
    {

        public enum enDateSelection
        {
            ParMois,
            ParAnnee
        }

        //enDateSelection DateSelection;

        public string FilterName { get; set; }
        public string FilterValue { get; set; }
        public int? Annee { get; set; }
        public int? Mois {  get; set; }

        
        public clsFilterData(string name, string value, int annee, int mois)
        {
            FilterName = name;
            FilterValue = value;
            Annee = annee;
            Mois = mois;
        }

        public clsFilterData(string name, string value, int dateValue ,enDateSelection selection)
        {
            FilterName = name;
            FilterValue = value;

            switch(selection)
            {
                case enDateSelection.ParAnnee:
                    Annee = dateValue;
                    Mois = null;
                    break;
                case enDateSelection.ParMois:
                    Annee = null;
                    Mois = dateValue;
                    break;
                default:
                    Annee = null;
                    Mois = null;
                    break;
            }
        }

        public clsFilterData(string name, string value)
        {
            FilterName = name;
            FilterValue = value;
        }

        public clsFilterData(int Annee ,int Mois)
        {
            this.Annee = Annee;
            this.Mois = Mois;
        }

        public clsFilterData(int AnneeOrMois ,bool isAnneeOrMois)
        {
            if(isAnneeOrMois)
            {
                Mois = AnneeOrMois;
            }
            else
            {
                Annee = AnneeOrMois;
            }

        }

        



    }
}
