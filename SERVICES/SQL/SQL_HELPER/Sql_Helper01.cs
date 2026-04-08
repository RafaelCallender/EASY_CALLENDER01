using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using Microsoft.Data.SqlClient;



namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER
{
    public class Sql_Helper01
    {

          private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static string client_info01 = Read_T01.Client_Textfile01.Split('\n')[0];
        private static string client_info02 = Read_T01.Client_Textfile01.Split('\n')[1];
        private static string client_info03 = Read_T01.Client_Textfile01.Split('\n')[2];
        private static string client_info04 = Read_T01.Client_Textfile01.Split('\n')[3];
        private static string client_info05 = Read_T01.Client_Textfile01.Split('\n')[4];

        private static string[] server_name_ =
        {

            @"(localdb)\ProjectModels",
	   	   @"GWTC116-2\SQLEXPRESS",
            "easycallenderserver.database.windows.net"
        };

        private static string[] database_name_ =
        {
            "Chat_Database",
            "Chemistry_Database",
            "Clients_Database",
            "Clients01_Database",
            "easycallenderDB",
            "Email_Database",
            "FILE_PATH_DATABASE",
            "Movies_Database",
            "Nba_Database",
            "Nba_Database01",
            "User_Database",
            "Language_Database"
          
        };
		

        public enum connectionStringServer
        {
            local_server = 0,
            local_server01 = 1,        
            Azure_server = 2
        }

        public enum connectionStringdatabase
        {
            Chat_Database = 0,
            Chemistry_Database = 1,
            Clients_Database = 2,
            Clients01_Database = 3,
            easycallenderDB = 4,
            Email_Database = 5,
            FILE_PATH_DATABASE = 6,
            Movies_Database = 7,
            Nba_Database = 8,
            Nba_Database01 = 9,
            User_Database = 10,
            Language_Database=11
   
        }

        public string build_connection_string(int input01, int input02, bool input03)
        {
            return $@"Data Source={server_name_[input01].Trim()};
            Initial Catalog={database_name_[input02].Trim()};
            Integrated Security={input03};
    Persist Security Info=False;
Pooling=False;
MultipleActiveResultSets=False;
Encrypt=True;
TrustServerCertificate=True;
Application Name=SQL Server Management Studio;
Command Timeout=0";
        }
        public string build_connection_string01(int input01, int input02, bool input03)
        {
            return $@"Server=tcp:{client_info03};
Initial Catalog={client_info04};
Persist Security Info=False;
User ID={client_info05};
Password={client_info02};
MultipleActiveResultSets=False;
Encrypt=True;
TrustServerCertificate=False;
Connection Timeout=30";
        }
        public string build_connection_string02(int input01, int input02, bool input03)
        {


            return $@"Data Source={server_name_[input01]};
Initial Catalog={database_name_[input02]};
Integrated Security={input03};
Connect Timeout=30;Encrypt=True;
Trust Server Certificate=False;
Application Intent=ReadWrite;
Multi Subnet Failover=False;
Command Timeout=30";
        }
            

    }
}


    