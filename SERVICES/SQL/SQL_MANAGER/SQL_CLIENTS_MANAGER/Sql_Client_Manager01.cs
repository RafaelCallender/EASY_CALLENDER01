using Microsoft.Data.SqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER
{
    internal class Sql_Manager01
    {

        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();

        private static string[] connection_string ={


Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.Clients_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.Clients_Database,
            true)

};

        private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1]),

                                       };

        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;

        private static int count = 0;
        private static SqlCommand[] cmd_ = {

               new SqlCommand("delete_client_using_name", conn_[index]),
               new SqlCommand("delete_client_using_phonenumber", conn_[index]),

new SqlCommand("find_client_api_key_by_emailaddress", conn_[index]),
new SqlCommand("find_client_api_key_by_name", conn_[index]),
new SqlCommand("find_client_api_key_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_apikey_by_apikey", conn_[index]),
new SqlCommand("find_client_apikey_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_apikey_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_apikey_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_apikey", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_emailaddress", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_name", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_cashappdata01_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_colors_using_emailaddress", conn_[index]),
new SqlCommand("find_client_colors_using_name", conn_[index]),
new SqlCommand("find_client_colors_using_phonenumber", conn_[index]),
new SqlCommand("find_client_data_using_email", conn_[index]),
new SqlCommand("find_client_data_using_latitude_and_longitude", conn_[index]),
new SqlCommand("find_client_data_using_logo", conn_[index]),
new SqlCommand("find_client_data_using_name", conn_[index]),
new SqlCommand("find_client_data_using_number", conn_[index]),
new SqlCommand("find_client_emailaddress_by_apikey", conn_[index]),
new SqlCommand("find_client_emailaddress_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_emailaddress_by_emailaddress", conn_[index]),
new SqlCommand("find_client_emailaddress_by_name", conn_[index]),
new SqlCommand("find_client_emailaddress_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_emailaddress_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_emailaddress_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_location_using_emailaddress", conn_[index]),
new SqlCommand("find_client_location_using_name", conn_[index]),
new SqlCommand("find_client_location_using_phonenumber", conn_[index]),
new SqlCommand("find_client_logo_by_emailaddress", conn_[index]),
new SqlCommand("find_client_logo_by_name", conn_[index]),
new SqlCommand("find_client_logo_by_phonenumber", conn_[index]),
new SqlCommand("find_client_name_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_name_by_emailaddress", conn_[index]),
new SqlCommand("find_client_name_by_name", conn_[index]),
new SqlCommand("find_client_name_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_name_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_name_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_apikey", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_emailaddress", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_name", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_paypalappdata01_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_phonenumber_by_apikey", conn_[index]),
new SqlCommand("find_client_phonenumber_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_phonenumber_by_emailaddress", conn_[index]),
new SqlCommand("find_client_phonenumber_by_name", conn_[index]),
new SqlCommand("find_client_phonenumber_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_phonenumber_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_phonenumber_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_apikey", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_emailaddress", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_name", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_paypalappdata01", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_venmoappdata01_by_venmoappdata01", conn_[index]),
new SqlCommand("find_client_zellaappdata01_by_apikey", conn_[index]),
new SqlCommand("find_client_zelleappdata01_by_cashappdata01", conn_[index]),
new SqlCommand("find_client_zelleappdata01_by_emailaddress", conn_[index]),
new SqlCommand("find_client_zelleappdata01_by_name", conn_[index]),
new SqlCommand("find_client_zelleappdata01_by_phonnumeber", conn_[index]),
new SqlCommand("find_client_zelleappdata01_by_venmoappdata01", conn_[index]),
new SqlCommand("insert_client_data", conn_[index]),
new SqlCommand("update_clients_apikey_using_apikey", conn_[index]),
new SqlCommand("update_clients_cashappdata01_using_cashappdata01", conn_[index]),
new SqlCommand("update_clients_email_using_email", conn_[index]),
new SqlCommand("update_clients_logo_using_logo", conn_[index]),
new SqlCommand("update_clients_name_using_name", conn_[index]),
new SqlCommand("update_clients_paypalappdata01_using_paypalappdata01", conn_[index]),
new SqlCommand("update_clients_phnenumber_using_phonenumber", conn_[index]),
new SqlCommand("update_clients_venmoappdata01_using_venmoappdata01", conn_[index]),
new SqlCommand("update_clients_zelleappdata01_using_zellappdata01", conn_[index]),
new SqlCommand("view_all_client_data", conn_[index]),
                new SqlCommand("SELECT name FROM sys.procedures ORDER BY name", conn_[index]),
                new SqlCommand("find_client_logo_by_logo", conn_[index]),
                                new SqlCommand("find_client_zellaappdata01_by_zellaappdata01", conn_[index]),
            new SqlCommand("delete_client_using_email", conn_[index])
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

        public enum connection_strings
        {
            connection01 = 0,
            connection02 = 1,
            connection03 = 2
        }


        public enum command_strings
        {
            delete_client_using_name = 0,
            delete_client_using_phonenumber = 1,
            find_client_api_key_by_emailaddress = 2,
            find_client_api_key_by_name = 3,
            find_client_api_key_by_phonnumeber = 4,
            find_client_apikey_by_apikey = 5,
            find_client_apikey_by_cashappdata01 = 6,
            find_client_apikey_by_paypalappdata01 = 7,
            find_client_apikey_by_venmoappdata01 = 8,
            find_client_cashappdata01_by_apikey = 9,
            find_client_cashappdata01_by_cashappdata01 = 10,
            find_client_cashappdata01_by_emailaddress = 11,
            find_client_cashappdata01_by_name = 12,
            find_client_cashappdata01_by_paypalappdata01 = 13,
            find_client_cashappdata01_by_phonnumeber = 14,
            find_client_cashappdata01_by_venmoappdata01 = 15,
            find_client_colors_using_emailaddress = 16,
            find_client_colors_using_name = 17,
            find_client_colors_using_phonenumber = 18,
            find_client_data_using_email = 19,
            find_client_data_using_latitude_and_longitude = 20,
            find_client_data_using_logo = 21,
            find_client_data_using_name = 22,
            find_client_data_using_number = 23,
            find_client_emailaddress_by_apikey = 24,
            find_client_emailaddress_by_cashappdata01 = 25,
            find_client_emailaddress_by_emailaddress = 26,
            find_client_emailaddress_by_name = 27,
            find_client_emailaddress_by_paypalappdata01 = 28,
            find_client_emailaddress_by_phonnumeber = 29,
            find_client_emailaddress_by_venmoappdata01 = 30,
            find_client_location_using_emailaddress = 31,
            find_client_location_using_name = 32,
            find_client_location_using_phonenumber = 33,
            find_client_logo_by_emailaddress = 34,
            find_client_logo_by_name = 35,
            find_client_logo_by_phonenumber = 36,
            find_client_name_by_cashappdata01 = 37,
            find_client_name_by_emailaddress = 38,
            find_client_name_by_name = 39,
            find_client_name_by_paypalappdata01 = 40,
            find_client_name_by_phonnumeber = 41,
            find_client_name_by_venmoappdata01 = 42,
            find_client_paypalappdata01_by_apikey = 43,
            find_client_paypalappdata01_by_cashappdata01 = 44,
            find_client_paypalappdata01_by_emailaddress = 45,
            find_client_paypalappdata01_by_name = 46,
            find_client_paypalappdata01_by_paypalappdata01 = 47,
            find_client_paypalappdata01_by_phonnumeber = 48,
            find_client_paypalappdata01_by_venmoappdata01 = 49,
            find_client_phonenumber_by_apikey = 50,
            find_client_phonenumber_by_cashappdata01 = 51,
            find_client_phonenumber_by_emailaddress = 52,
            find_client_phonenumber_by_name = 53,
            find_client_phonenumber_by_paypalappdata01 = 54,
            find_client_phonenumber_by_phonnumeber = 55,
            find_client_phonenumber_by_venmoappdata01 = 56,
            find_client_venmoappdata01_by_apikey = 57,
            find_client_venmoappdata01_by_cashappdata01 = 58,
            find_client_venmoappdata01_by_emailaddress = 59,
            find_client_venmoappdata01_by_name = 60,
            find_client_venmoappdata01_by_paypalappdata01 = 61,
            find_client_venmoappdata01_by_phonnumeber = 62,
            find_client_venmoappdata01_by_venmoappdata01 = 63,
            find_client_zellaappdata01_by_apikey = 64,
            find_client_zelleappdata01_by_cashappdata01 = 65,
            find_client_zelleappdata01_by_emailaddress = 66,
            find_client_zelleappdata01_by_name = 67,
            find_client_zelleappdata01_by_phonnumeber = 68,
            find_client_zelleappdata01_by_venmoappdata01 = 69,
            insert_client_data = 70,
            update_clients_apikey_using_apikey = 71,
            update_clients_cashappdata01_using_cashappdata01 = 72,
            update_clients_email_using_email = 73,
            update_clients_logo_using_logo = 74,
            update_clients_name_using_name = 75,
            update_clients_paypalappdata01_using_paypalappdata01 = 76,
            update_clients_phnenumber_using_phonenumber = 77,
            update_clients_venmoappdata01_using_venmoappdata01 = 78,
            update_clients_zelleappdata01_using_zellappdata01 = 79,
            view_all_client_data = 80,
            view_client_database_storedprocedures = 81,
            find_client_logo_by_logo = 82,
            find_client_zellaappdata01_by_zellaappdata01 = 83,
            delete_client_using_email = 84
        }

    }
}