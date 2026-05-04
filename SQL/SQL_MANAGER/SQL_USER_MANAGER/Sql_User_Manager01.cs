using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_USER
{
    internal class Sql_Manager01
    {

     		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={


Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.User_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.User_Database,
            true)



    
};
					
private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),
                        

                                       };
        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;

        private static SqlCommand[] cmd_ = {  new SqlCommand("find_email_using_email", conn_[index]),               // 0
                                              new SqlCommand("find_email_using_username", conn_[index]),            // 1
                                              new SqlCommand("find_phonenumber_using_email", conn_[index]),         // 2
                                              new SqlCommand("find_phonenumber_using_username", conn_[index]),      // 3
                                              new SqlCommand("find_user_location_using_email", conn_[index]),       // 4
                                              new SqlCommand("find_user_location_using_username", conn_[index]),    // 5
                                              new SqlCommand("find_username_using_email", conn_[index]),            // 6
                                              new SqlCommand("find_username_using_username", conn_[index]),         // 7
                                              new SqlCommand("find_usernmae_using_username", conn_[index]),         // 8
                                              new SqlCommand("insert_user", conn_[index]),//9
                                              new SqlCommand("update_user_location_using_email", conn_[index]),     // 10
                                              new SqlCommand("update_user_location_using_name", conn_[index]),      // 11
                                              new SqlCommand("update_user_location_using_phonenumber", conn_[index]),//12
                                              new SqlCommand("update_user_location_using_username", conn_[index]),   //13
                                              new SqlCommand("update_email_using_email", conn_[index]),   //14
                                              new SqlCommand("update_email_using_username", conn_[index]),   //15
                                              new SqlCommand("update_password_using_email", conn_[index]),   //16
                                              new SqlCommand("update_password_using_phonenumber", conn_[index]),   //17
                                              new SqlCommand("update_password_using_username", conn_[index]),   //18
                                              new SqlCommand("update_phonenumber_using_email", conn_[index]),   //19
                                              new SqlCommand("update_phonenumber_using_username", conn_[index]),   //20
                                              new SqlCommand("update_username_using_email", conn_[index]),   //21
                                              new SqlCommand("update_username_using_phonenumber", conn_[index]), //22
                                              new SqlCommand("update_username_using_username", conn_[index]), //23
                                              new SqlCommand("delete_user_using_email", conn_[index]), //24
                                              new SqlCommand("delete_user_using_phonenumber", conn_[index]), //25
                                              new SqlCommand("delete_user_using_username", conn_[index]), //26
                                              new SqlCommand("find_phonenumber_using_phonenumber", conn_[index]), //27
                                              new SqlCommand("find_password_using_email", conn_[index]), //28
                                              new SqlCommand("find_password_using_username", conn_[index]), //29
                                              new SqlCommand("find_username_password", conn_[index]), //30
                                              new SqlCommand("view_all_users", conn_[index]), //31     
                                              new SqlCommand("view_all_passwords", conn_[index]), //32
                                              new SqlCommand("view_all_username", conn_[index]), //33
                                              new SqlCommand("view_all_emails", conn_[index]), //34
                                              new SqlCommand("view_all_phonenumber", conn_[index]), //35
                                              new SqlCommand("insert_user_audio_file_using_username", conn_[index]), //36
                                              new SqlCommand("insert_user_text_file_using_username", conn_[index]), //37 
                                              new SqlCommand("user_login", conn_[index]), //37 
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
            find_email_using_email = 0,
            find_email_using_username = 1,
            find_phonenumber_using_email = 2,
            find_phonenumber_using_username = 3,
            find_user_location_using_email = 4,
            find_user_location_using_username = 5,
            find_username_using_email = 6,
            find_username_using_username = 7,
            find_usernmae_using_username = 8,
            insert_user = 9,
            update_user_location_using_email = 10,
            update_user_location_using_name = 11,
            update_user_location_using_phonenumber = 12,
            update_user_location_using_username = 13,
            update_email_using_email = 14,
            update_email_using_username = 15,
            update_password_using_email = 16,
            update_password_using_phonenumber = 17,
            update_password_using_username = 18,
            update_phonenumber_using_email = 19,
            update_phonenumber_using_username = 20,
            update_username_using_email = 21,
            update_username_using_phonenumber = 22,
            update_username_using_username = 23,
            delete_user_using_email = 24,
            delete_user_using_phonenumber = 25,
            delete_user_using_username = 26,
            find_phonenumber_using_phonenumber = 27,
            find_password_using_email = 28,
            find_password_using_username = 29,
            find_username_password = 30,
            view_all_username = 31,
            view_all_password = 32,
            view_all_email = 33,
            view_all_phonenumber = 34,
            insert_user_audio_file_using_username=35,
            insert_user_text_file_using_username=36,
            user_login= 37,
            view_user_database_storedprocedures=39
        }
    }
}