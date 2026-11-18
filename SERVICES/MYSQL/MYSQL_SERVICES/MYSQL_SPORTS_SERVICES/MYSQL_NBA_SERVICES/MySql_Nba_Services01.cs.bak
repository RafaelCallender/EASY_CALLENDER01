using EASY_CALLENDER01.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using  EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_NBA;
using MySql.Data;
using MySql.Data.MySqlClient;  
using System.Data;


namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SPORTS_SERVICES.MYSQL_NBA_SERVICES
{

    public class MySql_Nba_Services01
    {
      
     
        private List<string> get = new List<string>();
        private List<object> parameters = new List<object>();
        private List<object> errors = new List<object>();
        private List<int> results = new List<int>();
        private List<string> response01 = new List<string>();

        private string[] data01 = new string[100];

        public string insert_Leagues(string input01, string input02,
                                            string input03, string input04,
                                            string input05)
        {
            MySql_Nba_Manager01.conn[0].Open();
            MySql_Nba_Manager01.cmd[0].Parameters.Clear();
            MySql_Nba_Manager01.cmd[0].CommandType = CommandType.StoredProcedure;
            MySql_Nba_Manager01.cmd[0].Parameters.AddWithValue("@get01", input01.ToString());
            MySql_Nba_Manager01.cmd[0].Parameters.AddWithValue("@parameters01", input02);
            MySql_Nba_Manager01.cmd[0].Parameters.AddWithValue("@errors", input03);
            MySql_Nba_Manager01.cmd[0].Parameters.AddWithValue("@results", input04);
            MySql_Nba_Manager01.cmd[0].Parameters.AddWithValue("@response01", input05);

            object result = MySql_Nba_Manager01.cmd[0].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = "success"; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            MySql_Nba_Manager01.conn[0].Close();
            return data01[0];
        }

        public string view_all_Leagues()
        {
 
            MySql_Nba_Manager01.conn[0].Open();
            MySql_Nba_Manager01.cmd[1].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Nba_Manager01.cmd[1].ExecuteReader())
            {
                while (reader.Read())
                {
                    get.Add(reader["get01"]?.ToString() ?? string.Empty);
                    parameters.Add(reader["parameters01"]?.ToString() ?? string.Empty);
                    errors.Add(reader["errors"]?.ToString() ?? string.Empty);
                    results.Add(int.Parse(reader["results"]?.ToString() ?? string.Empty));
                    response01.Add(reader["response01"]?.ToString() ?? string.Empty);

                    data01[0] += $"{reader["get01"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["parameters01"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["errors"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["response01"]?.ToString() ?? string.Empty}\n";



                    var collection_set = new Sql_Nba_Get_Model01
                    {
                        get01 = (reader["get01"]?.ToString() ?? string.Empty),
                        parameters01 = new List<object> { reader["parameters01"]?.ToString() ?? string.Empty },
                        errors = new List<object> { reader["errors"]?.ToString() ?? string.Empty },
                        response01 = new List<string> { reader["response01"]?.ToString() ?? string.Empty },
                    };

      

                }
            }
            data01[1] += $"{string.Join(" ", get)}\n" +
                         $"{string.Join(" ", parameters)}\n" +
                         $"{string.Join(" ", errors)}\n" +
                         $"{string.Join(" ", results)}\n";
            MySql_Nba_Manager01.conn[0].Close();
            return data01[1];
        }


    }
}