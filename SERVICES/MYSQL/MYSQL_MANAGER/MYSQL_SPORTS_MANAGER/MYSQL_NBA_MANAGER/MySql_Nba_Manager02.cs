using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_NBA
{
    internal class MySql_Nba_Manager02
    {
          		private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 


MySql_H01.build_connection_string01(
        (int)MySql_Helper01.connectionStringdatabase.Nba_Database01,
        (int)MySql_Helper01.connectionStringUser.root,
        (int)MySql_Helper01.connectionStringServer.MySql_server,
        true),


};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
                      

                                       };
        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;

        private static MySqlCommand[] cmd_ = {
            new MySqlCommand("insert_Leagues", conn_[index]), // 0
            new MySqlCommand("view_Leagues", conn_[index]), // 1

        };

        public static MySqlCommand[] cmd
        {
            get { return cmd_; }
            set { cmd_ = value; }
        }

        public static MySqlConnection[] conn
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