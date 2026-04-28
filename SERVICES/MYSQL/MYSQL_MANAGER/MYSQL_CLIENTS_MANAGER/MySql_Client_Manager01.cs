using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CLIENTS
{
    public class MySql_Client01_Manager01
    {


      		private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={ 

MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Clients01_Database,
            true),
};

private static MySqlConnection[] conn_ = new MySqlConnection[]
{
    new MySqlConnection(connection_string[0])   
};

        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;

        private static MySqlCommand[] cmd_ = {
            new MySqlCommand("insert_Leagues", conn_[index]), // 0


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

find_client_address_by_email=0


        }
    }
}