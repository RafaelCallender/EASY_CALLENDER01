using MySql.Data.MySqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_JOURNAL_MANAGER
{
    internal class MySql_Journal_Manager01
    {
        private static MySql_Helper01 MySql_H01 = new MySql_Helper01();

        private static string[] connection_string ={



MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Email_Database,
            true),


};

        private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),


                                       };
        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;




        private static MySqlCommand[] cmd_ = {
                new MySqlCommand("find_message_using_message", conn_[index]),
new MySqlCommand("find_message_using_upload", conn_[index]),
new MySqlCommand("find_message_using_username", conn_[index]),
new MySqlCommand("find_upload_using_message", conn_[index]),
new MySqlCommand("find_upload_using_upload", conn_[index]),
new MySqlCommand("find_upload_using_username", conn_[index]),
new MySqlCommand("find_username_using_message", conn_[index]),
new MySqlCommand("find_username_using_upload", conn_[index]),
new MySqlCommand("find_username_using_username", conn_[index]),
new MySqlCommand("insert_journal", conn_[index]),
                            new MySqlCommand("SELECT name FROM sys.procedures ORDER BY name", conn_[index]),


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
            view_journal_database_storedprocedures=10
        }


    }
}
