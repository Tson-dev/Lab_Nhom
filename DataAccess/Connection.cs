using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private static readonly string strName = "ShoeShop";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[strName].ConnectionString;
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public const string Items_GetAll = "GetAllItem";

    }
}
