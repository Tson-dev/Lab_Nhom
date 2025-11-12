using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        public static string strConn = @"Data Source=NGOCTUAN\NGOCTUAN;Initial Catalog=ShoeShop;Integrated Security=True;Encrypt=False;";
        private static string strName="ShoeShop";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[strName].ConnectionString;
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public const string Items_GetAll = "GetAllItem";

    }
}
