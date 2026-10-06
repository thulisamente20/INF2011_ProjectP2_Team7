using System.Configuration;
using System.Data.SqlClient;

namespace INF2011_ProjectP2_Team7
{
    public static class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["FuturePathDB"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}