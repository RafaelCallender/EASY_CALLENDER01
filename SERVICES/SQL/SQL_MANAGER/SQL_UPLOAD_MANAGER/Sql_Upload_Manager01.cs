using Microsoft.Data.SqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_UPLOAD_MANAGER
{
    internal class Sql_Upload_Manager01
    {
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();
        private static string[] connection_string ={

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

 new SqlCommand("delete_FilePath_using_FilePath", conn_[index]),
new SqlCommand("delete_OriginalName_using_OriginalName", conn_[index]),
new SqlCommand("delete_StoredName_using_StoredName", conn_[index]),
new SqlCommand("delete_Username_using_Username", conn_[index]),
new SqlCommand("find_OriginalName_using_FilePath", conn_[index]),
new SqlCommand("find_OriginalName_using_OriginalName", conn_[index]),
new SqlCommand("find_OriginalName_using_StoredName", conn_[index]),
new SqlCommand("find_OriginalName_using_Username", conn_[index]),
new SqlCommand("find_StoredName_using_StoredName", conn_[index]),
new SqlCommand("find_StoredName_using_Username", conn_[index]),
new SqlCommand("find_username_using_FilePath", conn_[index]),
new SqlCommand("find_username_using_OriginalName", conn_[index]),
new SqlCommand("find_username_using_StoredName", conn_[index]),
new SqlCommand("find_username_using_username", conn_[index]),
new SqlCommand("insert_data", conn_[index]),
new SqlCommand("update_OriginalName_using_OriginalName", conn_[index]),
new SqlCommand("update_StoredName_using_StoredName", conn_[index]),
new SqlCommand("update_username_using_username", conn_[index]),
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
