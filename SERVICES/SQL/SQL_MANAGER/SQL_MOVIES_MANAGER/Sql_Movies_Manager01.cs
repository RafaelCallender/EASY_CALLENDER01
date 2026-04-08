using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;
namespace EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_MOVIES_MANAGER
{
    internal class Sql_Movies_Manager01
    {
      		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={ 


Sql_H01.build_connection_string(
        (int)Sql_Helper01.connectionStringdatabase.Movies_Database,
        (int)Sql_Helper01.connectionStringServer.local_server,
        true),
Sql_H01.build_connection_string(
        (int)Sql_Helper01.connectionStringdatabase.Movies_Database,
        (int)Sql_Helper01.connectionStringServer.Azure_server,
        true),
Sql_H01.build_connection_string(
        (int)Sql_Helper01.connectionStringdatabase.Movies_Database,
        (int)Sql_Helper01.connectionStringServer.local_server01,
        true)

};
					
private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),
                                         new SqlConnection(connection_string[2])

                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.local_server;
        private static SqlCommand[] cmd_ = { new SqlCommand("insert_movies", conn_[index]),                 // 0
                                             new SqlCommand("find_location_using_file_name", conn_[index]),    // 1 
                                             new SqlCommand("find_file_name_using_file_location", conn_[index]),// 2
                                             new SqlCommand("view_all_movies", conn_[index]),// 3
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
            insert_movies = 0,
            find_location_using_file_name = 1,
            find_file_name_using_file_location = 2,
            view_all_movies = 3
        }
    }
}