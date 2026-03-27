using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DAL
{
    public static class clsDataAccessSetting
    {
        //public static string connectionString = "Server=localhost;Database=WafaAssurance;Uid=root;Pwd=sa123456;";
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
    }
}
