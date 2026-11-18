using MySql.Data.MySqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_HELPER;





namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_UPLOAD_MANAGER
{
    internal class MySql_Upload_Manager01
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

 new MySqlCommand("delete_FilePath_using_FilePath", conn_[index]),
new MySqlCommand("delete_OriginalName_using_OriginalName", conn_[index]),
new MySqlCommand("delete_StoredName_using_StoredName", conn_[index]),
new MySqlCommand("delete_Username_using_Username", conn_[index]),
new MySqlCommand("find_OriginalName_using_FilePath", conn_[index]),
new MySqlCommand("find_OriginalName_using_OriginalName", conn_[index]),
new MySqlCommand("find_OriginalName_using_StoredName", conn_[index]),
new MySqlCommand("find_OriginalName_using_Username", conn_[index]),
new MySqlCommand("find_StoredName_using_StoredName", conn_[index]),
new MySqlCommand("find_StoredName_using_Username", conn_[index]),
new MySqlCommand("find_username_using_FilePath", conn_[index]),
new MySqlCommand("find_username_using_OriginalName", conn_[index]),
new MySqlCommand("find_username_using_StoredName", conn_[index]),
new MySqlCommand("find_username_using_username", conn_[index]),
new MySqlCommand("insert_data", conn_[index]),
new MySqlCommand("update_OriginalName_using_OriginalName", conn_[index]),
new MySqlCommand("update_StoredName_using_StoredName", conn_[index]),
new MySqlCommand("update_username_using_username", conn_[index]),
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
            delete_FilePath_using_FilePath = 0,
            delete_OriginalName_using_OriginalName = 1,
            delete_StoredName_using_StoredName = 2,
            delete_Username_using_Username = 3,
            find_OriginalName_using_FilePath = 4,
            find_OriginalName_using_OriginalName = 5,
            find_OriginalName_using_StoredName = 6,
            find_OriginalName_using_Username = 7,
            find_StoredName_using_StoredName = 8,
            find_StoredName_using_Username = 9,
            find_username_using_FilePath = 10,
            find_username_using_OriginalName = 11,
            find_username_using_StoredName = 12,
            find_username_using_username = 13,
            insert_data = 14,
            update_OriginalName_using_OriginalName = 15,
            update_StoredName_using_StoredName = 16,
            update_username_using_username = 17,
            view_database_storedprocedures = 18

        }

    }
}
