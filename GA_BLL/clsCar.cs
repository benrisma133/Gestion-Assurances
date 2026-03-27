using GA_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BLL
{
    public class clsCar
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string Matricule { get; set; }

        private clsCar(int carID, int brandID, string model, string matricule)
        {
            CarID = carID;
            BrandID = brandID;
            Model = model;
            Matricule = matricule;
        }

        static public clsCar FindByID(int CarID)
        {
            int BrandID = -1;
            string Model = string.Empty;
            string Matricule = string.Empty;

            if(clsCarData.GetCarByID(CarID ,ref BrandID ,ref Model ,ref Matricule))
            {
                return new clsCar(CarID, BrandID, Model,Matricule);
            }

            return null;

        }

    }
}
