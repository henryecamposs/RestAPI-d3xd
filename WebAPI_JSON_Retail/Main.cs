using kssLibWeb;
using System.Configuration;
using System.Web.Configuration;

namespace wResAPI_d3xd
{
    public static class Program
    {
        //public static Properties.Settings miConfig = new Properties.Settings();
        public static clsConfigApp clsConfig;
        //Remote
        public static bool esSQLServer;
        public static bool esRemoteAPI;
        public static bool esRetailBD;
        //Local
        public static string empresa_nombre;
        public static string empresa_rif;
        public static string DirHuespedServer;
        public static string ConexionHuesped_Server;
        public static string urlServerAPI;
        public static string nroEstaciones;
        public static string codigoPetro;
        public static string codigoDolar;
        public static string codigoBolivar;
        public static string nomenBolivar;
        public static string nomenDolar;
        public static string nomenPetro;
        public static System.Globalization.NumberFormatInfo provider;
        public static void Main()
        {

            // Create a NumberFormatInfo object 
            // and set some of its properties. 
            provider = new System.Globalization.NumberFormatInfo();
            provider.NumberDecimalSeparator = ", ";
            provider.NumberGroupSeparator = ".";
            provider.NumberGroupSizes = new int[] { 3 };
            clsConfig = new clsConfigApp();
            loadConfig();
        }
        internal static void loadConfig()
        {
            bool loaded = clsConfig.leer_config();
            empresa_nombre = loadAppConfig("empresa_nombre");
            empresa_rif = loadAppConfig("empresa_rif");
            DirHuespedServer = loadAppConfig("DirHuespedServer");
            ConexionHuesped_Server = loadAppConfig("ConexionHuesped_Server");
            urlServerAPI = loadAppConfig("urlServerAPI");
            nroEstaciones = loadAppConfig("nroEstaciones");
            codigoPetro = loadAppConfig("codigoPetro");
            codigoDolar = loadAppConfig("codigoDolar");
            codigoBolivar = loadAppConfig("codigoBolivar");
            nomenBolivar = loadAppConfig("nomenBolivar");
            nomenDolar = loadAppConfig("nomenDolar");
            nomenPetro = loadAppConfig("nomenPetro");
            //
            esSQLServer = System.Convert.ToBoolean(loadAppConfig("esSQLServer") ?? "false");
            esRemoteAPI = System.Convert.ToBoolean(loadAppConfig("esRemoteAPI") ?? "false");
            esRetailBD = System.Convert.ToBoolean(loadAppConfig("esRetailBD") ?? "true");

        }
        public static void saveAppConfig(string key, string value)
        {
            Configuration webConfigApp = WebConfigurationManager.OpenWebConfiguration("~");
            if (webConfigApp.AppSettings.Settings[key] != null)
            {
                webConfigApp.AppSettings.Settings[key].Value = value;
                webConfigApp.Save();
            }
        }
        public static string loadAppConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

    }
}