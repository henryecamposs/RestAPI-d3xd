using System.Configuration;
using System.Data.OleDb;

namespace wResAPI_d3xd
{
    ///
    /// This class is used to connect to sql server database
    ///
    public class DBConnect
    {

        private static OleDbConnection NewCon;
        private static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static OleDbConnection getConnection()
        {
            NewCon = new OleDbConnection(conStr);
            return NewCon;

        }
        public DBConnect()
        {

        }

    }
}