using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_TEST
{
    internal class MySql_Test_Manager01
    {
        private static string[] connectionString_ = {
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Chemistry_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Chat_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=User_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Language_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False;
              Command Timeout=30",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Clients_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False;
              Command Timeout=30",

                @"Data Source=(localdb)\MSSQLLocalDB;
                  Initial Catalog=Nba Database;
                  Integrated Security=True;
                  Connect Timeout=30;
                  Encrypt=True;
                  TrustServerCertificate=False;
                  ApplicationIntent=ReadWrite;
                  MultiSubnetFailover=False;
                  Command Timeout=30"
        }; // 5

        private static MySqlConnection[] conn_ = {
            new MySqlConnection(connectionString_[0]),
            new MySqlConnection(connectionString_[1]),
            new MySqlConnection(connectionString_[2]),
            new MySqlConnection(connectionString_[3]),
            new MySqlConnection(connectionString_[4]),
            new MySqlConnection(connectionString_[5])
        }; // 5

        private static MySqlCommand[] cmd_ = {
            new MySqlCommand("insert_element", conn_[0]),                       // 0
            new MySqlCommand("find_element_using_name", conn_[0]),              // 1
            new MySqlCommand("find_element_using_atomic_number", conn_[0]),     // 2
            new MySqlCommand("find_element_using_symbol", conn_[0]),            // 3
            new MySqlCommand("view_all_elements", conn_[0]),                    // 4
            new MySqlCommand("insert_chat", conn_[1]),                          // 5
            new MySqlCommand("view_chat", conn_[1]),                            // 6
            new MySqlCommand("find_email_using_email", conn_[2]),               // 7
            new MySqlCommand("find_email_using_username", conn_[2]),            // 8
            new MySqlCommand("find_phonenumber_using_email", conn_[2]),         // 9
            new MySqlCommand("find_phonenumber_using_username", conn_[2]),      // 10
            new MySqlCommand("find_user_location_using_email", conn_[2]),       // 11
            new MySqlCommand("find_user_location_using_username", conn_[2]),    // 12
            new MySqlCommand("find_username_using_email", conn_[2]),            // 13
            new MySqlCommand("find_username_using_username", conn_[2]),         // 14
            new MySqlCommand("find_usernmae_using_username", conn_[2]),         // 15
            new MySqlCommand("insert_user", conn_[2]),                          // 16
            new MySqlCommand("find_code_using_code", conn_[3]),                 // 17
            new MySqlCommand("find_code_using_language", conn_[3]),             // 18
            new MySqlCommand("find_language_using_code", conn_[3]),             // 19
            new MySqlCommand("find_language_using_Language", conn_[3]),         // 20
            new MySqlCommand("insert_language", conn_[3]),                      // 21
            new MySqlCommand("view_all_data_from_language_table", conn_[3]),    // 22
            new MySqlCommand("find_username_password", conn_[2]),               // 23
            new MySqlCommand("view_all_client_data", conn_[4]),                 // 24
            new MySqlCommand("find_client_data_using_email", conn_[4]),         // 25
            new MySqlCommand("find_client_data_using_latitude_and_longitude", conn_[4]), // 26
            new MySqlCommand("find_client_data_using_logo", conn_[4]),          // 27
            new MySqlCommand("find_client_data_using_name", conn_[4]),          // 28
            new MySqlCommand("find_client_data_using_number", conn_[4]),        // 29
            new MySqlCommand("insert_client_data", conn_[4]),                   // 30
            new MySqlCommand("find_password_using_username", conn_[2]),         // 31
            new MySqlCommand("find_password_using_email", conn_[2]),            // 32
            new MySqlCommand("find_team_by_name", conn_[5]),                    // 33
            new MySqlCommand("find_team_by_id", conn_[5]),                      // 34
            new MySqlCommand("insert_team_standings", conn_[5]),                // 35 
            new MySqlCommand("find_team_standings_by_teamid", conn_[5]),        // 36
            new MySqlCommand("find_team_standings_by_name", conn_[5]),          // 37 
            new MySqlCommand("view_all_team_standing", conn_[5]),               // 38 
            new MySqlCommand("view_all_players", conn_[5]),                     // 39 
            new MySqlCommand("find_player_by_first_and_last_name", conn_[5]),   // 40 
            new MySqlCommand("find_player_by_id", conn_[5]),                    // 41 
            new MySqlCommand("insert_players", conn_[5]),                       // 42 
            new MySqlCommand("view_all_Referee", conn_[5]),                     // 43 
            new MySqlCommand("find_Referee_by_id", conn_[5]),                   // 44 
            new MySqlCommand("find_Referee_by_name", conn_[5]),                 // 45 
            new MySqlCommand("insert_Stadium", conn_[5]),                       // 46 
            new MySqlCommand("find_Stadium_by_name", conn_[5]),                 // 47 
            new MySqlCommand("find_Stadium_by_id", conn_[5]),                   // 48 
            new MySqlCommand("find_Stadium_by_City", conn_[5]),                 // 49 
            new MySqlCommand("find_Stadium_by_Address", conn_[5]),              // 50 
            new MySqlCommand("insert_Referee", conn_[5]),                       // 51 
            new MySqlCommand("view_all_Stadium", conn_[5]),                     // 52 
            new MySqlCommand("insert_season", conn_[5]),                        // 53 
            new MySqlCommand("view_season", conn_[5]),                          // 54 
            new MySqlCommand("view_team_names", conn_[5]),                      // 55 
            new MySqlCommand("insert_team_all", conn_[5]),                      // 56 
            new MySqlCommand("view_latest_message", conn_[1]),                  // 57
            new MySqlCommand("update_user_location_using_email", conn_[2]),     // 58
            new MySqlCommand("update_user_location_using_name", conn_[2]),      // 59
            new MySqlCommand("update_user_location_using_phonenumber", conn_[2]),//60
            new MySqlCommand("update_user_location_using_username", conn_[2]),   //61
            new MySqlCommand("Find_Actinides", conn_[0]), //62
            new MySqlCommand("find_Alkaline_Earth_Metals", conn_[0]), //63
            new MySqlCommand("find_Lanthanides_Rare_Earth_Metals", conn_[0]), //64
            new MySqlCommand("find_Noble_Gases", conn_[0]), //65
            new MySqlCommand("find_Nonmetal_Gases_at_Room_Temperature", conn_[0]), //66
            new MySqlCommand("find_Transition_Metals", conn_[0]), //67
            new MySqlCommand("view_catagory_type", conn_[0]), //68   
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

        }
    }
}