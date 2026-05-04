using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_LANGUAGE
{
    internal class MySql_Language_Manager01
    {
    	private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 



MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Language_Database,
            true),


};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),


                                       };
        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;

        private static MySqlCommand[] cmd_ = {   new MySqlCommand("find_code_using_code", conn_[index]),                 // 0
                                               new MySqlCommand("find_code_using_language", conn_[index]),             // 1
                                               new MySqlCommand("find_language_using_code", conn_[index]),             // 2
                                               new MySqlCommand("find_language_using_Language", conn_[index]),         // 3
                                               new MySqlCommand("insert_language", conn_[index]),                      // 4
                                               new MySqlCommand("view_all_data_from_language_table", conn_[index]),    // 5
        
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
            find_code_using_code = 0,
            find_code_using_language = 1,
            find_language_using_code = 2,
            find_language_using_Language = 3,
            insert_language = 4,
            view_all_data_from_language_table = 5,
        }
    }
}