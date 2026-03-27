using System;
using System.Collections.Generic;

namespace GestionAssurances.Modals
{
    public class clsFilterData
    {
        public enum enDateSelection
        {
            ParMois,
            ParAnnee,
            ParPeriode // ✅ Added for month range
        }

        public string FilterName { get; set; }
        public string FilterValue { get; set; }
        public int? Annee { get; set; }
        public int? Mois { get; set; }

        // ✅ New properties for month range (optional)
        public int? MoisDebut { get; set; }
        public int? MoisFin { get; set; }

        public enDateSelection? DateSelection { get; set; }

        // ✅ Constructor for full date (Year + Month)
        public clsFilterData(string name, string value, int annee, int mois)
        {
            FilterName = name;
            FilterValue = value;
            Annee = annee;
            Mois = mois;
            DateSelection = enDateSelection.ParMois;
        }

        // ✅ Constructor for Year or Month
        public clsFilterData(string name, string value, int dateValue, enDateSelection selection)
        {
            FilterName = name;
            FilterValue = value;
            DateSelection = selection;

            switch (selection)
            {
                case enDateSelection.ParAnnee:
                    Annee = dateValue;
                    Mois = null;
                    break;
                case enDateSelection.ParMois:
                    Mois = dateValue;
                    Annee = null;
                    break;
                default:
                    Annee = null;
                    Mois = null;
                    break;
            }
        }

        // ✅ Simple text filter (no date)
        public clsFilterData(string name, string value)
        {
            FilterName = name;
            FilterValue = value;
            DateSelection = null;
        }

        // ✅ Range of months (Periode)
        public clsFilterData(string name, string value, int annee, int moisDebut, int moisFin)
        {
            FilterName = name;
            FilterValue = value;
            Annee = annee;
            MoisDebut = moisDebut;
            MoisFin = moisFin;
            DateSelection = enDateSelection.ParPeriode;
        }

        // ✅ Simplified constructor (year + month)
        public clsFilterData(int annee, int mois)
        {
            Annee = annee;
            Mois = mois;
            DateSelection = enDateSelection.ParMois;
        }

        // ✅ Simple constructor for either year or month
        public clsFilterData(int anneeOrMois, bool isAnneeOrMois)
        {
            if (isAnneeOrMois)
                Mois = anneeOrMois;
            else
                Annee = anneeOrMois;
        }

        // ✅ New constructor for period
        
    }
}
