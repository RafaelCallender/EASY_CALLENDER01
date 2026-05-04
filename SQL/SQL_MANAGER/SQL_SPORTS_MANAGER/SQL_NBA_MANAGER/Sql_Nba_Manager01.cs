using Microsoft.Data.SqlClient;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;

namespace EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA
{
    internal class Sql_Manager01
    {
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();

        private static string[] connection_string ={


Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.Nba_Database,
            true),

Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.Azure_server,
            (int)Sql_Helper01.connectionStringdatabase.Nba_Database,
            true)




};

        private static SqlConnection[] conn_ = { new SqlConnection(connection_string[0]),
                                         new SqlConnection(connection_string[1])



                                       };

        private static int index = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;



        private static SqlCommand[] cmd_ = {  new SqlCommand("find_team_by_name", conn_[index]),                    // 01
                                              new SqlCommand("find_team_by_id", conn_[index]),                      // 02
                                              new SqlCommand("insert_team_standings", conn_[index]),                // 03 
                                              new SqlCommand("find_team_standings_by_teamid", conn_[index]),        // 04
                                              new SqlCommand("find_team_standings_by_name", conn_[index]),          // 05 
                                              new SqlCommand("view_all_team_standing", conn_[index]),               // 06 
                                              new SqlCommand("view_all_players", conn_[index]),                     // 07 
                                              new SqlCommand("find_player_by_first_and_last_name", conn_[index]),   // 08 
                                              new SqlCommand("find_player_by_id", conn_[index]),                    // 09 
                                              new SqlCommand("insert_players", conn_[index]),                       // 10 
                                              new SqlCommand("view_all_Referee", conn_[index]),                     // 11 
                                              new SqlCommand("find_Referee_by_id", conn_[index]),                   // 12 
                                              new SqlCommand("find_Referee_by_name", conn_[index]),                 // 13 
                                              new SqlCommand("insert_Stadium", conn_[index]),                       // 14 
                                              new SqlCommand("find_Stadium_by_name", conn_[index]),                 // 15 
                                              new SqlCommand("find_Stadium_by_id", conn_[index]),                   // 16 
                                              new SqlCommand("find_Stadium_by_City", conn_[index]),                 // 17 
                                              new SqlCommand("find_Stadium_by_Address", conn_[index]),              // 18 
                                              new SqlCommand("insert_Referee", conn_[index]),                       // 19 
                                              new SqlCommand("view_all_Stadium", conn_[index]),                     // 20 
                                              new SqlCommand("insert_season", conn_[index]),                        // 21 
                                              new SqlCommand("view_season", conn_[index]),                          // 22 
                                              new SqlCommand("view_team_names", conn_[index]),                      // 23 
                                              new SqlCommand("insert_team_all", conn_[index]),
                                                  new SqlCommand("SELECT name FROM sys.procedures ORDER BY name", conn_[index]),                // 24 
        
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
            view_nba_database_storedprocedures = 24
        }
    }
}