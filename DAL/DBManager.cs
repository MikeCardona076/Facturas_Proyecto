using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.DAL
{
    public static class DBManager
    {

        public static String GetConnectionString(String db)
        {
            String strcon = "";
            try
            {
                
                strcon = System.Configuration.ConfigurationManager.ConnectionStrings[db].ConnectionString;


            }
            catch (Exception ex)
            {
            }

            return strcon;
        }

    }
}