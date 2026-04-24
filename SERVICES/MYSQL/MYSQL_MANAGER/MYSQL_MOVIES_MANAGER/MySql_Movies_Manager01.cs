using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MOVIES_MANAGER
{
    internal class MySql_Movies_Manager01
    {
        
        
       private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 


MySql_H01.build_connection_string01(
        (int)MySql_Helper01.connectionStringdatabase.Movies_Database,
           (int)MySql_Helper01.connectionStringUser.root,
        (int)MySql_Helper01.connectionStringServer.MySql_server,
        true),


};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
                                

                                       };
        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;
        
        private static MySqlCommand[] cmd_ = { new MySqlCommand("insert_movies", conn_[index]),                 // 0
                                             new MySqlCommand("find_location_using_file_name", conn_[index]),    // 1 
                                             new MySqlCommand("find_file_name_using_file_location", conn_[index]),// 2
                                             new MySqlCommand("view_all_movies", conn_[index]),// 3
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
            insert_movies = 0,
            find_location_using_file_name = 1,
            find_file_name_using_file_location = 2,
            view_all_movies = 3
        }
    }
}