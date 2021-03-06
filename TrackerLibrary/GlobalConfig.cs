﻿ using System;
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

        public static void InitializeConnections(DatabaseType db)   //not scability method only connect database and text file
        {
            switch (db)
            
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default:
                    break;
            }
            /*if(db == DatabaseType.Sql)
            {
                //TODO-Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections= sql; 
            }

            else if(db == DatabaseType.TextFile)
            {
                //TODO- Create the Text Connection
                TextConnector text = new TextConnector();
                Connections=text; 
            }*/


        }
        public static string CnnString(string name) //go to the AppConfig and get the connection string name
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; 
        }
    }
}
