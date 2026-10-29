using Microsoft.Data.SqlClient;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER
{
    public class Sql_Helper01
    {

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
            "Language_Database",
            "Upload_Database",
            "Language_Database"
        };

        private static string[] user_id =
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
            Language_Database = 11,
            Upload_Database = 12

        }

        public string build_connection_string01(int input01, int input02, bool input03)
        {

            return $@"Server=localhost,1433;Database={database_name_[input02]};User Id=SA;Password={File_Manger01.Client_Textfile02};TrustServerCertificate=True;";
        }
        public string build_connection_string02(int input01, int input02, bool input03)
        {
            return $@"Server=tcp:{File_Manger01.Client_Textfile03};
Initial Catalog={File_Manger01.Client_Textfile04};
Persist Security Info=False;
User ID={File_Manger01.Client_Textfile05};
Password={File_Manger01.Client_Textfile02};
MultipleActiveResultSets=False;
Encrypt=True;
TrustServerCertificate=False;
Connection Timeout=30";
        }

    }
}


