using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;


namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER
{
    public class Sql_Helper01
    {
private static string[] data01 = new string[100];     
          private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static string client_info01 = Read_T01.Client_Textfile01.Split('\n')[0];
        private static string client_info02 = Read_T01.Client_Textfile01.Split('\n')[1];
        private static string client_info03 = Read_T01.Client_Textfile01.Split('\n')[2];
        private static string client_info04 = Read_T01.Client_Textfile01.Split('\n')[3];
        private static string client_info05 = Read_T01.Client_Textfile01.Split('\n')[4];

        private static string[] server_name_ =
        {
          "localhost,1433",
            "easycallenderserver.database.windows.net",
           
           
    
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

        private static string[]user_id=
        {
            "SA"
        };
		

        public enum connectionStringServer
        {
          SqlExpress_server = 0, 
            Azure_server = 1
              
     
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

        public string build_connection_string01(int input01, int input02, bool input03)
        {
        

           return $@"Server=localhost,1433;Database={database_name_[input02]};User Id=SA;Password={client_info02};TrustServerCertificate=True;";
        }
        public string build_connection_string02(int input01, int input02, bool input03)
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

    }
}


    