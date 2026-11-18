using Microsoft.Data.SqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_JOURNAL_MANAGER
{
    internal class Sql_Journal_Manager01
    {
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();

        public static string[] connection_string ={

Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.Email_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.Email_Database,
            true)



};

        private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1])

                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;




        private static SqlCommand[] cmd_ = {

               new SqlCommand("find_message_using_message", conn_[index]),
new SqlCommand("find_message_using_upload", conn_[index]),
new SqlCommand("find_message_using_username", conn_[index]),
new SqlCommand("find_upload_using_message", conn_[index]),
new SqlCommand("find_upload_using_upload", conn_[index]),
new SqlCommand("find_upload_using_username", conn_[index]),
new SqlCommand("find_username_using_message", conn_[index]),
new SqlCommand("find_username_using_upload", conn_[index]),
new SqlCommand("find_username_using_username", conn_[index]),
new SqlCommand("insert_journal", conn_[index]),
                            new SqlCommand("SELECT name FROM sys.procedures ORDER BY name", conn_[index]),


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
            Connection01 = 0,
            Connection02 = 1
        }
        public enum command_strings
        {

            find_message_using_message = 0,
            find_message_using_upload = 1,
            find_message_using_username = 2,
            find_upload_using_message = 3,
            find_upload_using_upload = 4,
            find_upload_using_username = 5,
            find_username_using_message = 6,
            find_username_using_upload = 7,
            find_username_using_username = 8,
            insert_journal = 9,
            view_journal_database_storedprocedures = 10
        }


    }
}
