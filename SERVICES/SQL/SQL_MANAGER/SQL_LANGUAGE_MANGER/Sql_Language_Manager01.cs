using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;
namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_LANGUAGE
{
    internal class Sql_Manager01
    {
      		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={ 



Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.local_server,
            (int)Sql_Helper01.connectionStringdatabase.Language_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.local_server01,
            (int)Sql_Helper01.connectionStringdatabase.Language_Database,
            true),
Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.Language_Database,
            true)

};
					
private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),
                                         new SqlConnection(connection_string[2])

                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.local_server;

        private static SqlCommand[] cmd_ = {   new SqlCommand("find_code_using_code", conn_[index]),                 // 0
                                               new SqlCommand("find_code_using_language", conn_[index]),             // 1
                                               new SqlCommand("find_language_using_code", conn_[index]),             // 2
                                               new SqlCommand("find_language_using_Language", conn_[index]),         // 3
                                               new SqlCommand("insert_language", conn_[index]),                      // 4
                                               new SqlCommand("view_all_data_from_language_table", conn_[index]),    // 5
        
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
            find_code_using_code = 0,
            find_code_using_language = 1,
            find_language_using_code = 2,
            find_language_using_Language = 3,
            insert_language = 4,
            view_all_data_from_language_table = 5,
        }
    }
}