using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType dbType)
        {
            switch (dbType)
            {
                case DatabaseType.Sql:
                    // TODO: Setup the SQL Connector properly
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    // TODO: Setup the Text Connector properly
                    TextConnector tc = new TextConnector();
                    Connection = tc;
                    break;
                default:
                    break;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
