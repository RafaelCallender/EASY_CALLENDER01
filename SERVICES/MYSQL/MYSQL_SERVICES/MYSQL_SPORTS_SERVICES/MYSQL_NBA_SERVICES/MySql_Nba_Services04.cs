using EASY_CALLENDER01.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_NBA;
using MySql.Data.MySqlClient;  
using System.Data;
using MySql.Data;

namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SPORTS_SERVICES.MYSQL_NBA_SERVICES
{

    public class MySql_Nba_Services04
    {


        private static string[] data01 = new string[100];
        private List<int> TeamID = new List<int>();
        private List<string> Keys = new List<string>();
        private List<bool> Active = new List<bool>();
        private List<string> City = new List<string>();
        private List<string> Name = new List<string>();
        private List<int> LeagueID = new List<int>();
        private List<int> StadiumID = new List<int>();
        private List<string> Conference = new List<string>();
        private List<string> Division = new List<string>();
        private List<string> PrimaryColor = new List<string>();
        private List<string> SecondaryColor = new List<string>();
        private List<string> TertiaryColor = new List<string>();
        private List<string> QuaternaryColor = new List<string>();
        private List<string> WikipediaLogoUrl = new List<string>();
        private List<string> WikipediaWordMarkUrl = new List<string>();
        private List<int> GlobalTeamID = new List<int>();
        private List<int> NbaDotComTeamID = new List<int>();
        private List<string> HeadCoach = new List<string>();




        public string insert_team_all(string input00, string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            input12 = input12 ?? "";
            input13 = input13 ?? "";
            input14 = input14 ?? "";
            input15 = input15 ?? "";
            input16 = input16 ?? "";
            input17 = input17 ?? "";
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[56].Parameters.Clear();
            MySql_Nba_Manager01.cmd[56].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@TeamID", input00);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@Keys", input01);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@Active", input02);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@City", input03);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@Name", input04);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@LeagueID", input05);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@StadiumID", input06);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@Conference", input07);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@Division", input08);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@PrimaryColor", input09);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@SecondaryColor", input10);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@TertiaryColor", input11);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@QuaternaryColor", input12);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaLogoUrl", input13);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaWordMarkUrl", input14);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@GlobalTeamID", input15);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@NbaDotComTeamID", input16);
            MySql_Nba_Manager01.cmd[56].Parameters.AddWithValue("@HeadCoach", input17);
            object result = MySql_Nba_Manager01.cmd[56].ExecuteScalar();

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


        public string find_team_by_id(string input)
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[34].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[34].Parameters.Clear();
            MySql_Nba_Manager01.cmd[34].Parameters.AddWithValue("@TeamID", input);
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[34].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Keys = reader["Keys"]?.ToString() ?? string.Empty,
                        Active = bool.Parse(reader["Active"]?.ToString() ?? string.Empty),
                        City = reader["City"]?.ToString() ?? string.Empty,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        LeagueID = int.Parse(reader["LeagueID"]?.ToString() ?? string.Empty),
                        StadiumID = int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty),
                        Conference = reader["Conference"]?.ToString() ?? string.Empty,
                        Division = reader["Division"]?.ToString() ?? string.Empty,
                        PrimaryColor = reader["PrimaryColor"]?.ToString() ?? string.Empty,
                        SecondaryColor = reader["SecondaryColor"]?.ToString() ?? string.Empty,
                        TertiaryColor = reader["TertiaryColor"]?.ToString() ?? string.Empty,
                        QuaternaryColor = reader["QuaternaryColor"]?.ToString() ?? string.Empty,
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"]?.ToString() ?? string.Empty,
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"]?.ToString() ?? string.Empty,
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"]?.ToString() ?? string.Empty),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"]?.ToString() ?? string.Empty),
                        HeadCoach = reader["HeadCoach"]?.ToString() ?? string.Empty,

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
        public string find_team_by_name(string input)
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[33].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[33].Parameters.Clear();
            MySql_Nba_Manager01.cmd[33].Parameters.AddWithValue("@Name", input);
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[33].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["@Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Keys = reader["Keys"]?.ToString() ?? string.Empty,
                        Active = bool.Parse(reader["Active"]?.ToString() ?? string.Empty),
                        City = reader["City"]?.ToString() ?? string.Empty,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        LeagueID = int.Parse(reader["LeagueID"]?.ToString() ?? string.Empty),
                        StadiumID = int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty),
                        Conference = reader["Conference"]?.ToString() ?? string.Empty,
                        Division = reader["Division"]?.ToString() ?? string.Empty,
                        PrimaryColor = reader["PrimaryColor"]?.ToString() ?? string.Empty,
                        SecondaryColor = reader["SecondaryColor"]?.ToString() ?? string.Empty,
                        TertiaryColor = reader["TertiaryColor"]?.ToString() ?? string.Empty,
                        QuaternaryColor = reader["QuaternaryColor"]?.ToString() ?? string.Empty,
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"]?.ToString() ?? string.Empty,
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"]?.ToString() ?? string.Empty,
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"]?.ToString() ?? string.Empty),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"]?.ToString() ?? string.Empty),
                        HeadCoach = reader["HeadCoach"]?.ToString() ?? string.Empty,

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
        public string view_team_names()
        {
            MySql_Nba_Manager01.conn[5].Open();
            MySql_Nba_Manager01.cmd[55].CommandType = CommandType.StoredProcedure;

            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[55].ExecuteReader())
            {
                while (reader.Read())
                {
                    TeamID.Add(int.Parse(reader["TeamID"]?.ToString() ?? "0"));
                    Keys.Add(reader["Keys"]?.ToString() ?? string.Empty);
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? "false"));
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    LeagueID.Add(int.Parse(reader["LeagueID"]?.ToString() ?? "0"));
                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? "0"));
                    Conference.Add(reader["Conference"]?.ToString() ?? string.Empty);
                    Division.Add(reader["Division"]?.ToString() ?? string.Empty);
                    PrimaryColor.Add(reader["PrimaryColor"]?.ToString() ?? string.Empty);
                    SecondaryColor.Add(reader["SecondaryColor"]?.ToString() ?? string.Empty);
                    TertiaryColor.Add(reader["TertiaryColor"]?.ToString() ?? string.Empty);
                    QuaternaryColor.Add(reader["QuaternaryColor"]?.ToString() ?? string.Empty);
                    WikipediaLogoUrl.Add(reader["WikipediaLogoUrl"]?.ToString() ?? string.Empty);
                    WikipediaWordMarkUrl.Add(reader["WikipediaWordMarkUrl"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(int.Parse(reader["GlobalTeamID"]?.ToString() ?? "0"));
                    NbaDotComTeamID.Add(int.Parse(reader["NbaDotComTeamID"]?.ToString() ?? "0"));
                    HeadCoach.Add(reader["HeadCoach"]?.ToString() ?? string.Empty);

                    data01[0] +=
                        $"{reader["TeamID"]}\n" +
                        $"{reader["Keys"]}\n" +
                        $"{reader["Active"]}\n" +
                        $"{reader["City"]}\n" +
                        $"{reader["Name"]}\n" +
                        $"{reader["LeagueID"]}\n" +
                        $"{reader["StadiumID"]}\n" +
                        $"{reader["Conference"]}\n" +
                        $"{reader["Division"]}\n" +
                        $"{reader["PrimaryColor"]}\n" +
                        $"{reader["SecondaryColor"]}\n" +
                        $"{reader["TertiaryColor"]}\n" +
                        $"{reader["QuaternaryColor"]}\n" +
                        $"{reader["WikipediaLogoUrl"]}\n" +
                        $"{reader["WikipediaWordMarkUrl"]}\n" +
                        $"{reader["GlobalTeamID"]}\n" +
                        $"{reader["NbaDotComTeamID"]}\n" +
                        $"{reader["HeadCoach"]}\n";

                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"]?.ToString() ?? "0"),
                        Keys = reader["Keys"]?.ToString() ?? string.Empty,
                        Active = bool.Parse(reader["Active"]?.ToString() ?? "false"),
                        City = reader["City"]?.ToString() ?? string.Empty,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        LeagueID = int.Parse(reader["LeagueID"]?.ToString() ?? "0"),

                        StadiumID = int.Parse(reader["StadiumID"]?.ToString() ?? "0"),

                        Conference = reader["Conference"]?.ToString() ?? string.Empty,

                        Division = reader["Division"]?.ToString() ?? string.Empty,

                        PrimaryColor = reader["PrimaryColor"]?.ToString() ?? string.Empty,

                        SecondaryColor = reader["SecondaryColor"]?.ToString() ?? string.Empty,

                        TertiaryColor = reader["TertiaryColor"]?.ToString() ?? string.Empty,

                        QuaternaryColor = reader["QuaternaryColor"]?.ToString() ?? string.Empty,

                        WikipediaLogoUrl = reader["WikipediaLogoUrl"]?.ToString() ?? string.Empty,

                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"]?.ToString() ?? string.Empty,

                        GlobalTeamID = int.Parse(reader["GlobalTeamID"]?.ToString() ?? "0"),

                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"]?.ToString() ?? "0"),
                        HeadCoach = reader["WikipediaWordMarkUrl"]?.ToString() ?? string.Empty,

                    };
   
                }

                MySql_Nba_Manager01.conn[5].Close();

                data01[1] +=
                    $"{string.Join(" ", TeamID)}\n" +
                    $"{string.Join(" ", Keys)}\n" +
                    $"{string.Join(" ", Active)}\n" +
                    $"{string.Join(" ", City)}\n" +
                    $"{string.Join(" ", Name)}\n" +
                    $"{string.Join(" ", LeagueID)}\n" +
                    $"{string.Join(" ", StadiumID)}\n" +
                    $"{string.Join(" ", Conference)}\n" +
                    $"{string.Join(" ", Division)}\n" +
                    $"{string.Join(" ", PrimaryColor)}\n" +
                    $"{string.Join(" ", SecondaryColor)}\n" +
                    $"{string.Join(" ", TertiaryColor)}\n" +
                    $"{string.Join(" ", QuaternaryColor)}\n" +
                    $"{string.Join(" ", WikipediaLogoUrl)}\n" +
                    $"{string.Join(" ", WikipediaWordMarkUrl)}\n" +
                    $"{string.Join(" ", GlobalTeamID)}\n" +
                    $"{string.Join(" ", NbaDotComTeamID)}\n" +
                    $"{string.Join(" ", HeadCoach)}\n";

                return data01[1];
            }
        }
    }
}

