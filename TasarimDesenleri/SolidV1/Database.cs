using System.Data.SqlClient;

namespace SolidV1
{
    public class Database
    {
        private static object objectLock = new Object();
        private static Database database;
        private static string connectionString = string.Empty;
        private static SqlConnection conn;

        public static Database GetInstance()
        {
            if (database == null)
            {
                lock (objectLock)
                {
                    if (database == null)
                    {
                        database = new Database();
                    }
                }
            }
            return database;
        }
    }
}
