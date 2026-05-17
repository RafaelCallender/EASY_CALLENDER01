using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using MySql.Data;

namespace EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER
{
    public class MySql_Helper01
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

    
         "localhost,1433"
        
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
                private static string[] user_name_ =
        {
   
                  "root"

          
        };
		

        public enum connectionStringServer
        {
            MySql_server = 0,
  
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
        public enum connectionStringUser
        {

root=0

        }

   
    public string build_connection_string01(int input01, int input02,int input03, bool input04)
    {


return $"server={server_name_[input01]};user={user_name_[input02]};database={database_name_[input03]};password={Read_T01.admin_path01.Split("\n")[1].Trim()};";

    }        

    }
}


    