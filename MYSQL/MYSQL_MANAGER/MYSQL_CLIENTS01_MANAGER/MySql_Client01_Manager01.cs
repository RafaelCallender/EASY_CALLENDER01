using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;


namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CLIENTS   
{
    public class MySql_Client_Manager01
    {
      		private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 

MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Clients01_Database,
            true),


    
};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
                                      


                                       };
        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;


        private static MySqlCommand[] cmd_ = {
 new MySqlCommand("delete_client_using_email", conn_[index]),
new MySqlCommand("delete_client_using_name", conn_[index]),
new MySqlCommand("find_client_email_by_email", conn_[index]),
new MySqlCommand("find_client_email_by_name", conn_[index]),
new MySqlCommand("find_client_email_by_phonenumber", conn_[index]),
new MySqlCommand("find_client_name_by_email", conn_[index]),
new MySqlCommand("find_client_name_by_name", conn_[index]),
new MySqlCommand("find_client_name_by_phonenumber", conn_[index]),
new MySqlCommand("find_client_phonenumber_by_email", conn_[index]),
new MySqlCommand("find_client_phonenumber_by_name", conn_[index]),
new MySqlCommand("find_client_phonenumber_by_phonenumber", conn_[index]),
new MySqlCommand("insert_client", conn_[index]),
new MySqlCommand("update_clients_email_using_email", conn_[index]),
new MySqlCommand("update_clients_email_using_name", conn_[index]),
new MySqlCommand("update_clients_email_using_phonenumber", conn_[index]),
new MySqlCommand("update_clients_name_using_email", conn_[index]),
new MySqlCommand("update_clients_name_using_name", conn_[index]),
new MySqlCommand("update_clients_name_using_phonenumber", conn_[index]),
new MySqlCommand("update_clients_phonenumber_using_email", conn_[index]),
new MySqlCommand("update_clients_phonenumber_using_name", conn_[index]),
new MySqlCommand("update_clients_phonenumber_using_phonenumber", conn_[index]),
new MySqlCommand("find_client_emailkey_by_name", conn_[index]),
new MySqlCommand("insert_user01", conn_[index]),
new MySqlCommand("delete_user_using_email", conn_[index]),
new MySqlCommand("delete_user_using_name", conn_[index]),
new MySqlCommand("delete_user_using_phonenumber", conn_[index]),
new MySqlCommand("find_user_email_by_email", conn_[index]),
new MySqlCommand("find_user_email_by_name", conn_[index]),
new MySqlCommand("find_user_email_by_phonenumber", conn_[index]),
new MySqlCommand("find_user_name_by_email", conn_[index]),
new MySqlCommand("find_user_name_by_name", conn_[index]),
new MySqlCommand("find_user_name_by_phonenumber", conn_[index]),
new MySqlCommand("find_user_phonenumber_by_email", conn_[index]),
new MySqlCommand("find_user_phonenumber_by_name", conn_[index]),
new MySqlCommand("find_user_phonenumber_by_phonenumber", conn_[index]),
new MySqlCommand("find_user_message_by_name", conn_[index]),
new MySqlCommand("find_user_message_by_email", conn_[index]),
new MySqlCommand("find_user_message_by_phonenumber", conn_[index]),
new MySqlCommand("find_user_name_by_email_by_name", conn_[index]),

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

            delete_client_using_email = 0,
            delete_client_using_name = 1,
            find_client_email_by_email = 2,
            find_client_email_by_name = 3,
            find_client_email_by_phonenumber = 4,
            find_client_name_by_email = 5,
            find_client_name_by_name = 6,
            find_client_name_by_phonenumber = 7,
            find_client_phonenumber_by_email = 8,
            find_client_phonenumber_by_name = 9,
            find_client_phonenumber_by_phonenumber = 10,
            insert_client = 11,
            update_clients_email_using_email = 12,
            update_clients_email_using_name = 13,
            update_clients_email_using_phonenumber = 14,
            update_clients_name_using_email = 15,
            update_clients_name_using_name = 16,
            update_clients_name_using_phonenumber = 17,
            update_clients_phonenumber_using_email = 18,
            update_clients_phonenumber_using_name = 19,
            update_clients_phonenumber_using_phonenumber = 20,
            find_client_emailkey_by_name = 21,
            insert_user01 = 22,
            delete_user_using_email = 23,
            delete_user_using_name = 24,
            delete_user_using_phonenumber = 25,
            find_user_email_by_email = 26,
            find_user_email_by_name = 27,
            find_user_email_by_phonenumber = 28,
            find_user_name_by_email = 29,
            find_user_name_by_name = 30,
            find_user_name_by_phonenumber = 31,
            find_user_phonenumber_by_email = 32,
            find_user_phonenumber_by_name = 33,
            find_user_phonenumber_by_phonenumber = 34,
            find_user_message_by_name = 35,
            find_user_message_by_email = 36,
            find_user_message_by_phonenumber = 37,
            find_user_name_by_email_by_name = 38
        }
    }
}