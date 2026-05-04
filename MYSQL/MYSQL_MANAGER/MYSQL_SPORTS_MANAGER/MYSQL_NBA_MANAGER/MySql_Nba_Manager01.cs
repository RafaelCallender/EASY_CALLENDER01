using MySql.Data.MySqlClient;  
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_NBA
{
    internal class MySql_Nba_Manager01
    {
      	private static MySql_Helper01 MySql_H01=new MySql_Helper01();
		
private static string[] connection_string={


MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Nba_Database,
            true),



};
					
private static MySqlConnection[] conn_ = { new MySqlConnection(connection_string[0]),
                  

                                       };

        private static int index = (int)MySql_Helper01.connectionStringServer.MySql_server;



        private static MySqlCommand[] cmd_ = {  new MySqlCommand("find_team_by_name", conn_[index]),                    // 01
                                              new MySqlCommand("find_team_by_id", conn_[index]),                      // 02
                                              new MySqlCommand("insert_team_standings", conn_[index]),                // 03 
                                              new MySqlCommand("find_team_standings_by_teamid", conn_[index]),        // 04
                                              new MySqlCommand("find_team_standings_by_name", conn_[index]),          // 05 
                                              new MySqlCommand("view_all_team_standing", conn_[index]),               // 06 
                                              new MySqlCommand("view_all_players", conn_[index]),                     // 07 
                                              new MySqlCommand("find_player_by_first_and_last_name", conn_[index]),   // 08 
                                              new MySqlCommand("find_player_by_id", conn_[index]),                    // 09 
                                              new MySqlCommand("insert_players", conn_[index]),                       // 10 
                                              new MySqlCommand("view_all_Referee", conn_[index]),                     // 11 
                                              new MySqlCommand("find_Referee_by_id", conn_[index]),                   // 12 
                                              new MySqlCommand("find_Referee_by_name", conn_[index]),                 // 13 
                                              new MySqlCommand("insert_Stadium", conn_[index]),                       // 14 
                                              new MySqlCommand("find_Stadium_by_name", conn_[index]),                 // 15 
                                              new MySqlCommand("find_Stadium_by_id", conn_[index]),                   // 16 
                                              new MySqlCommand("find_Stadium_by_City", conn_[index]),                 // 17 
                                              new MySqlCommand("find_Stadium_by_Address", conn_[index]),              // 18 
                                              new MySqlCommand("insert_Referee", conn_[index]),                       // 19 
                                              new MySqlCommand("view_all_Stadium", conn_[index]),                     // 20 
                                              new MySqlCommand("insert_season", conn_[index]),                        // 21 
                                              new MySqlCommand("view_season", conn_[index]),                          // 22 
                                              new MySqlCommand("view_team_names", conn_[index]),                      // 23 
                                              new MySqlCommand("insert_team_all", conn_[index]),                      // 24 
        
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
            User_Connection01 = 0
        }
        public enum command_strings
        {
            find_team_by_name = 0,
            find_team_by_id = 1,
            insert_team_standings = 2,
            find_team_standings_by_teamid = 3,
            find_team_standings_by_name = 4,
            view_all_team_standing = 5,
            view_all_players = 6,
            find_player_by_first_and_last_name = 7,
            find_player_by_id = 8,
            insert_players = 9,
            view_all_Referee = 10,
            find_Referee_by_id = 11,
            find_Referee_by_name = 12,
            insert_Stadium = 13,
            find_Stadium_by_name = 14,
            find_Stadium_by_id = 15,
            find_Stadium_by_City = 16,
            find_Stadium_by_Address = 17,
            insert_Referee = 18,
            view_all_Stadium = 19,
            insert_season = 20,
            view_season = 21,
            view_team_names = 22,
            insert_team_all = 23,
        }
    }
}