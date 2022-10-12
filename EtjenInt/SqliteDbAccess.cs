using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace EtjenInt
{
    internal class SqliteDbAccess
    {
        public static List<Agents> LoadAgents()
        {
            using (IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                var readDB = dbConnection.Query<Agents>("select * from Agents", new DynamicParameters());
                return readDB.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
