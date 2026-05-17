using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CHEMISTRY
{
    internal class MySql_Chemistry_Manager01
    {
		private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={


MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Chemistry_Database,
            true),




    };
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
                     
                                       };

        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;


        private static MySqlCommand[] cmd_ = {  new MySqlCommand("insert_element", conn_[index]),                       // 0
                                              new MySqlCommand("find_element_using_name", conn_[index]),              // 1
                                              new MySqlCommand("find_element_using_atomic_number", conn_[index]),     // 2
                                              new MySqlCommand("find_element_using_symbol", conn_[index]),            // 3
                                              new MySqlCommand("Find_Actinides", conn_[index]), //04
                                              new MySqlCommand("find_Alkaline_Earth_Metals", conn_[index]), //05
                                              new MySqlCommand("find_Lanthanides_Rare_Earth_Metals", conn_[index]), //06
                                              new MySqlCommand("find_Noble_Gases", conn_[index]), //07
                                              new MySqlCommand("find_Nonmetal_Gases_at_Room_Temperature", conn_[index]), //08
                                              new MySqlCommand("find_Transition_Metals", conn_[index]), //09
                                              new MySqlCommand("view_catagory_type", conn_[index]), //10
                                              new MySqlCommand("view_all_elements", conn_[index]),  //11        
                                              new MySqlCommand("insert_catagory_type", conn_[index]),  //12
                                              new MySqlCommand("find_Alkali_Metals", conn_[index]),  //13



        };

        public static MySqlCommand[] cmd
        {
   get   { return cmd_; }
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
            insert_element = 0,
            find_element_using_name = 1,
            find_element_using_atomic_number = 2,
            find_element_using_symbol = 3,
            Find_Actinides = 4,
            find_Alkaline_Earth_Metals = 5,
            find_Lanthanides_Rare_Earth_Metals = 6,
            find_Noble_Gases = 7,
            find_Nonmetal_Gases_at_Room_Temperature = 8,
            find_Transition_Metals = 9,
            view_catagory_type = 10,
            view_all_elements = 11,
            insert_catagory_type = 12,
            find_Alkali_Metals = 13,
        }


    }
}