
using EASY_CALLENDER01.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_NBA;
using MySql.Data.MySqlClient;  
using System.Data;
using MySql.Data;

namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SPORTS_SERVICES.MYSQL_NBA_SERVICES
{

    public class MySql_Nba_Services05
    {
       
     
        private static string[] data01 = new string[100];
        private List<int> RefereeID = new List<int>();
        private List<string> Name = new List<string>();
        private List<int> Number = new List<int>();
        private List<string> Position = new List<string>();
        private List<string> College = new List<string>();

        public string find_Referee_by_id(string input)
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[44].Parameters.Clear();
            MySql_Nba_Manager01.cmd[44].Parameters.AddWithValue("@RefereeID", input);
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[44].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Number.Add(int.Parse(reader["Number"]?.ToString() ?? string.Empty));
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    College.Add(reader["College"]?.ToString() ?? string.Empty);

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Sql_Nba_Get_Model05
                    {
                        RefereeID = int.Parse(reader["RefereeID"]?.ToString() ?? string.Empty),
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Number = int.Parse(reader["Number"]?.ToString() ?? string.Empty),
                        Position = reader["Position"]?.ToString() ?? string.Empty,
                        College = reader["College"]?.ToString() ?? string.Empty,
                    };
                }
                else
                {
                    data01[0] = "failed";
                }
            }
            MySql_Nba_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_Referee_by_name(string input)
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[45].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[45].Parameters.Clear();
            MySql_Nba_Manager01.cmd[45].Parameters.AddWithValue("@Name", input);
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[45].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Number.Add(int.Parse(reader["Number"]?.ToString() ?? string.Empty));
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    College.Add(reader["College"]?.ToString() ?? string.Empty);

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Sql_Nba_Get_Model05
                    {
                        RefereeID = int.Parse(reader["RefereeID"]?.ToString() ?? string.Empty),
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Number = int.Parse(reader["Number"]?.ToString() ?? string.Empty),
                        Position = reader["Position"]?.ToString() ?? string.Empty,
                        College = reader["College"]?.ToString() ?? string.Empty,
                    };
                }
                else
                {
                    data01[0] = "failed";
                }
                return data01[0];
            }
        }
        public string insert_Referee(string input00, string input01, string input02, string input03, string input04)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";

            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[51].Parameters.Clear();
            MySql_Nba_Manager01.cmd[51].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[51].Parameters.AddWithValue("@RefereeID", input00);
            MySql_Nba_Manager01.cmd[51].Parameters.AddWithValue("@Name", input01);
            MySql_Nba_Manager01.cmd[51].Parameters.AddWithValue("@Number", input02);
            MySql_Nba_Manager01.cmd[51].Parameters.AddWithValue("@Position", input03);
            MySql_Nba_Manager01.cmd[51].Parameters.AddWithValue("@College", input04);
            object result = MySql_Nba_Manager01.cmd[51].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = "success";
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            MySql_Nba_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_all_Referee()
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[44].ExecuteReader())
            {
                while (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Number.Add(int.Parse(reader["Number"]?.ToString() ?? string.Empty));
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    College.Add(reader["College"]?.ToString() ?? string.Empty);

                    data01[0] +=
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model05
                    {

                        RefereeID = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Name = reader["TeamID"]?.ToString() ?? string.Empty,
                        Number = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Position = reader["TeamID"]?.ToString() ?? string.Empty,
                        College = reader["TeamID"]?.ToString() ?? string.Empty,

                    };

     

                }
            }


            data01[1] +=
           
                      $"{string.Join(" ", RefereeID)}\n" +
                      $"{string.Join(" ", Name)}\n" +
                      $"{string.Join(" ", Number)}\n" +
                      $"{string.Join(" ", Position)}\n" +
                      $"{string.Join(" ", College)}\n";


            return data01[1];
        }






    }
}
