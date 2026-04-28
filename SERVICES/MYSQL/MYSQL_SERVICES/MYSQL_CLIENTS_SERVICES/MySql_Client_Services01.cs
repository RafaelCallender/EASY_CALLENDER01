using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;
using MySql.Data.MySqlClient;  
using System.Data;
using EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CLIENTS;
namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_CLIENTS01_SERVICES
{
    public class MySql_Client01_Services01
    {

private bool status=true;

public bool find_client_address_by_email(string input01, out string output)
        {
            MySql_Client01_Manager01.conn[(int)MySql_Client01_Manager01.Connection_strings.Connection01].Open();
            MySql_Client01_Manager01.cmd[(int)MySql_Client01_Manager01.command_strings.find_client_address_by_email].CommandType = CommandType.StoredProcedure;
            MySql_Client01_Manager01.cmd[(int)MySql_Client01_Manager01.command_strings.find_client_address_by_email].Parameters.Clear();
            MySql_Client01_Manager01.cmd[(int)MySql_Client01_Manager01.command_strings.find_client_address_by_email].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client01_Manager01.cmd[(int)MySql_Client01_Manager01.command_strings.find_client_address_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                   output = $"{reader["organization_address"].ToString()}";

                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }
    }
}