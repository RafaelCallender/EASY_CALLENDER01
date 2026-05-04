using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_EMAIL_MANAGER
{
    internal class MySql_Email_Manager01
    {
      			private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 



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
                            new MySqlCommand("insert_email", conn_[index]),
                            new MySqlCommand("find_email_using_email", conn_[index]),
                            new MySqlCommand("find_email_using_name", conn_[index]),
                            new MySqlCommand("find_email_using_phonenumber", conn_[index]),
                            new MySqlCommand("find_full_name_using_email", conn_[index]),
                            new MySqlCommand("find_full_name_using_full_name", conn_[index]),
                            new MySqlCommand("find_full_name_using_phonenumber", conn_[index]),
                            new MySqlCommand("find_phonenumber_using_email", conn_[index]),
                            new MySqlCommand("find_phonenumber_using_fullname", conn_[index]),
                            new MySqlCommand("find_phonenumber_using_phonenumber", conn_[index]),



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
            insert_email = 0,
            find_email_using_email = 1,
            find_email_using_name = 2,
            find_email_using_phonenumber = 3,
            find_full_name_using_email = 4,
            find_full_name_using_full_name = 5,
            find_full_name_using_phonenumber = 6,
            find_phonenumber_using_email = 7,
            find_phonenumber_using_fullname = 8,
            find_phonenumber_using_phonenumber = 9,
        }


    }
}
