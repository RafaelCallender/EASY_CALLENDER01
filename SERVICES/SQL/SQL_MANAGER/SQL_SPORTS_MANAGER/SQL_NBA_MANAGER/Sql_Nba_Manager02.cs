using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA
{
    internal class Sql_Manager02
    {
          		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={ 


Sql_H01.build_connection_string01(
        (int)Sql_Helper01.connectionStringdatabase.Nba_Database01,
        (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
        true),
Sql_H01.build_connection_string02(
        (int)Sql_Helper01.connectionStringdatabase.Nba_Database01,
        (int)Sql_Helper01.connectionStringServer.Azure_server,
        true)


    
};
					
private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1])


                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;

        private static SqlCommand[] cmd_ = {
            new SqlCommand("insert_Leagues", conn_[index]), // 0
            new SqlCommand("view_Leagues", conn_[index]), // 1

        };

        public static SqlCommand[] cmd
        {
            get { return cmd_; }
            set { cmd_ = value; }
        }

        public static SqlConnection[] conn
        {
            get { return conn_; }
            set { conn_ = value; }
        }
        public enum Connection_strings
        {
            Connection01 = 0
        }
        public enum command_strings
        {
            insert_Leagues = 0,
            view_Leagues = 1,
        }
    }
}