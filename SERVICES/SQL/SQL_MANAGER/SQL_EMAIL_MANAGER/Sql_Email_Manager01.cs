using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_EMAIL_MANAGER
{
    internal class Sql_Email_Manager01
    {
      		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={ 



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
                            new SqlCommand("insert_email", conn_[index]),
                            new SqlCommand("find_email_using_email", conn_[index]),
                            new SqlCommand("find_email_using_name", conn_[index]),
                            new SqlCommand("find_email_using_phonenumber", conn_[index]),
                            new SqlCommand("find_full_name_using_email", conn_[index]),
                            new SqlCommand("find_full_name_using_full_name", conn_[index]),
                            new SqlCommand("find_full_name_using_phonenumber", conn_[index]),
                            new SqlCommand("find_phonenumber_using_email", conn_[index]),
                            new SqlCommand("find_phonenumber_using_fullname", conn_[index]),
                            new SqlCommand("find_phonenumber_using_phonenumber", conn_[index]),



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
