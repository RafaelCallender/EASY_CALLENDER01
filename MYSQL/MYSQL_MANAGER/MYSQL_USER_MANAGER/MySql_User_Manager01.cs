using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;


namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_USER_MANAGER
{
    internal class MySql_Client_Manager01
    {

     		private static MySql_Helper01 MySql_H01=new MySql_Helper01();

private static string[] connection_string={


MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
             (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.User_Database,
           
            true),


};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
     

                                       };

        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;

        private static MySqlCommand[] cmd_ = {  new MySqlCommand("find_email_using_email", conn_[index]),               // 0
                                              new MySqlCommand("find_email_using_username", conn_[index]),            // 1
                                              new MySqlCommand("find_phonenumber_using_email", conn_[index]),         // 2
                                              new MySqlCommand("find_phonenumber_using_username", conn_[index]),      // 3
                                              new MySqlCommand("find_user_location_using_email", conn_[index]),       // 4
                                              new MySqlCommand("find_user_location_using_username", conn_[index]),    // 5
                                              new MySqlCommand("find_username_using_email", conn_[index]),            // 6
                                              new MySqlCommand("find_username_using_username", conn_[index]),         // 7
                                              new MySqlCommand("find_usernmae_using_username", conn_[index]),         // 8
                                              new MySqlCommand("insert_user", conn_[index]),//9
                                              new MySqlCommand("update_user_location_using_email", conn_[index]),     // 10
                                              new MySqlCommand("update_user_location_using_name", conn_[index]),      // 11
                                              new MySqlCommand("update_user_location_using_phonenumber", conn_[index]),//12
                                              new MySqlCommand("update_user_location_using_username", conn_[index]),   //13
                                              new MySqlCommand("update_email_using_email", conn_[index]),   //14
                                              new MySqlCommand("update_email_using_username", conn_[index]),   //15
                                              new MySqlCommand("update_password_using_email", conn_[index]),   //16
                                              new MySqlCommand("update_password_using_phonenumber", conn_[index]),   //17
                                              new MySqlCommand("update_password_using_username", conn_[index]),   //18
                                              new MySqlCommand("update_phonenumber_using_email", conn_[index]),   //19
                                              new MySqlCommand("update_phonenumber_using_username", conn_[index]),   //20
                                              new MySqlCommand("update_username_using_email", conn_[index]),   //21
                                              new MySqlCommand("update_username_using_phonenumber", conn_[index]), //22
                                              new MySqlCommand("update_username_using_username", conn_[index]), //23
                                              new MySqlCommand("delete_user_using_email", conn_[index]), //24
                                              new MySqlCommand("delete_user_using_phonenumber", conn_[index]), //25
                                              new MySqlCommand("delete_user_using_username", conn_[index]), //26
                                              new MySqlCommand("find_phonenumber_using_phonenumber", conn_[index]), //27
                                              new MySqlCommand("find_password_using_email", conn_[index]), //28
                                              new MySqlCommand("find_password_using_username", conn_[index]), //29
                                              new MySqlCommand("find_username_password", conn_[index]), //30
                                              new MySqlCommand("view_all_users", conn_[index]), //31     
                                              new MySqlCommand("view_all_passwords", conn_[index]), //32
                                              new MySqlCommand("view_all_username", conn_[index]), //33
                                              new MySqlCommand("view_all_emails", conn_[index]), //34
                                              new MySqlCommand("view_all_phonenumber", conn_[index]), //35
                                              new MySqlCommand("insert_user_audio_file_using_username", conn_[index]), //36
                                              new MySqlCommand("insert_user_text_file_using_username", conn_[index]), //37 
                                              new MySqlCommand("user_login", conn_[index]), //37 




                                         




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
            view_all_email = 34,
            view_all_phonenumber = 35,
            insert_user_audio_file_using_username=36,
            insert_user_text_file_using_username=37,
            user_login= 38
        }
    }
}