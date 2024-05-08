using kssLibWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wResAPI_d3xd
{
    public class clsConfigApp : clsConfigAPPXML
    {
        private string urlServidorAPI= "http://localhost:23250/Handler1.ashx";



        public bool Save()
        {

            this.appCadenaConexionHost = urlServidorAPI;
            return base.guardar_config();
        }

        public void Load()
        {
            base.leer_config();
            urlServidorAPI = appCadenaConexionHost;
        }
    }
}