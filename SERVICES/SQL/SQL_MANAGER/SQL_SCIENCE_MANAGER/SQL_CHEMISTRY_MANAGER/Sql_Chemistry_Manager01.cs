using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;


namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY
{
    internal class Sql_Chemistry_Manager01
    {
		
		private static Sql_Helper01 Sql_H01=new Sql_Helper01();
		
private static string[] connection_string={


Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.local_server,
            (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.local_server01,
            (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
            true),
Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
            true)

    };
					
private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),
                                         new SqlConnection(connection_string[2])

                                       };

        private static int index = (int)Sql_Helper01.connectionStringServer.local_server;


        private static SqlCommand[] cmd_ = {  new SqlCommand("insert_element", conn_[index]),                       // 0
                                              new SqlCommand("find_element_using_name", conn_[index]),              // 1
                                              new SqlCommand("find_element_using_atomic_number", conn_[index]),     // 2
                                              new SqlCommand("find_element_using_symbol", conn_[index]),            // 3
                                              new SqlCommand("Find_Actinides", conn_[index]), //04
                                              new SqlCommand("find_Alkaline_Earth_Metals", conn_[index]), //05
                                              new SqlCommand("find_Lanthanides_Rare_Earth_Metals", conn_[index]), //06
                                              new SqlCommand("find_Noble_Gases", conn_[index]), //07
                                              new SqlCommand("find_Nonmetal_Gases_at_Room_Temperature", conn_[index]), //08
                                              new SqlCommand("find_Transition_Metals", conn_[index]), //09
                                              new SqlCommand("view_catagory_type", conn_[index]), //10
                                              new SqlCommand("view_all_elements", conn_[index]),  //11        
                                              new SqlCommand("insert_catagory_type", conn_[index]),  //12
                                              new SqlCommand("find_Alkali_Metals", conn_[index]),  //13



        };

        public static SqlCommand[] cmd
        {
   get   { return cmd_; }
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