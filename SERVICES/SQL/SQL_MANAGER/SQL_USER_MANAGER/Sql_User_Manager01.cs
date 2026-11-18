using Microsoft.Data.SqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_USER_MANAGER
{
    public class Sql_Manager01
    {


        private static string[] data01 = new string[100];
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();
        private static Sql_Services01 Sql_S01 = new Sql_Services01();

        private static string[] connection_string ={

Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.User_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.User_Database,
            true),



};

        private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),


                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;

        private static SqlCommand[] cmd_ = {
            new SqlCommand("delete_user_using_phonenumber", conn_[index]),
            new SqlCommand("delete_user_using_username", conn_[index]),
            new SqlCommand("find_email_using_email", conn_[index]),
            new SqlCommand("find_email_using_username", conn_[index]),
            new SqlCommand("find_password_using_email", conn_[index]),
            new SqlCommand("find_password_using_username", conn_[index]),
            new SqlCommand("find_phonenumber_using_email", conn_[index]),
            new SqlCommand("find_phonenumber_using_phonenumber", conn_[index]),
            new SqlCommand("find_phonenumber_using_username", conn_[index]),
            new SqlCommand("find_user_location_using_email", conn_[index]),
            new SqlCommand("find_user_location_using_username", conn_[index]),
            new SqlCommand("find_username_password", conn_[index]),
            new SqlCommand("find_username_using_email", conn_[index]),
            new SqlCommand("find_username_using_username", conn_[index]),
            new SqlCommand("find_usernmae_using_username", conn_[index]),
            new SqlCommand("insert_text_file_using_username", conn_[index]),
            new SqlCommand("insert_user", conn_[index]),
            new SqlCommand("insert_user_audio_file_using_username", conn_[index]),
            new SqlCommand("insert_user_text_file_using_username", conn_[index]),
            new SqlCommand("update_email_using_email", conn_[index]),
            new SqlCommand("update_email_using_username", conn_[index]),
            new SqlCommand("update_password_using_email", conn_[index]),
            new SqlCommand("update_password_using_phonenumber", conn_[index]),
            new SqlCommand("update_password_using_username", conn_[index]),
            new SqlCommand("update_phonenumber_using_email", conn_[index]),
            new SqlCommand("update_phonenumber_using_username ", conn_[index]),
            new SqlCommand("update_user_location_using_email", conn_[index]),
            new SqlCommand("update_user_location_using_name", conn_[index]),
           new SqlCommand("update_user_location_using_phonenumber", conn_[index]),
            new SqlCommand("update_user_location_using_username", conn_[index]),
            new SqlCommand("update_username_using_email", conn_[index]),
            new SqlCommand("update_username_using_phonenumber", conn_[index]),
            new SqlCommand("update_username_using_username", conn_[index]),
            new SqlCommand("user_login", conn_[index]),
            new SqlCommand("view_all_emails", conn_[index]),
            new SqlCommand("view_all_passwords", conn_[index]),
            new SqlCommand("view_all_phonenumber", conn_[index]),
            new SqlCommand("view_all_username", conn_[index]),
            new SqlCommand("view_user_table", conn_[index]),
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
            Connection02 = 1,
            Connection03 = 2
        }
        public enum command_strings
        {
            delete_user_using_phonenumber = 0,
            delete_user_using_username = 1,
            find_email_using_email = 2,
            find_email_using_username = 3,
            find_password_using_email = 4,
            find_password_using_username = 5,
            find_phonenumber_using_email = 6,
            find_phonenumber_using_phonenumber = 7,
            find_phonenumber_using_username = 8,
            find_user_location_using_email = 9,
            find_user_location_using_username = 10,
            find_username_password = 11,
            find_username_using_email = 12,
            find_username_using_username = 13,
            find_usernmae_using_username = 14,
            insert_text_file_using_username = 15,
            insert_user = 16,
            insert_user_audio_file_using_username = 17,
            insert_user_text_file_using_username = 18,
            update_email_using_email = 19,
            update_email_using_username = 20,
            update_password_using_email = 21,
            update_password_using_phonenumber = 22,
            update_password_using_username = 23,
            update_phonenumber_using_email = 24,
            update_phonenumber_using_username = 25,
            update_user_location_using_email = 26,
            update_user_location_using_name = 27,
            update_user_location_using_phonenumber = 28,
            update_user_location_using_username = 29,
            update_username_using_email = 30,
            update_username_using_phonenumber = 31,
            update_username_using_username = 32,
            user_login = 33,
            view_all_emails = 34,
            view_all_passwords = 35,
            view_all_phonenumber = 36,
            view_all_username = 37,
            view_user_table = 38,
            view_user_database_storedprocedures = 39
        }

    }
}