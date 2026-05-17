using MySql.Data.MySqlClient; 
using MySql.Data;
using System.Data;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_LANGUAGE;
namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_LANGUAGE_SERVICES
{
    public class MySql_Language_Services01
    {
        private bool status = false;
        private static string[] data01 = new string[3];
        private List<string> code = new List<string>();
        private List<string> language = new List<string>();
        public string[] data_array = {
                                      "Language Code",//0
                                      "Language name",//1
                                      "select language",//2
        
        };
        public bool insert_language(string input01, string input02, out string output)
        {
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.insert_language].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.insert_language].CommandType = CommandType.StoredProcedure;
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.insert_language].Parameters.AddWithValue("@code", input01);
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.insert_language].Parameters.AddWithValue("@language", input02);
            int rowsAffected = MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.insert_language].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }

            else
            {
               output = "fail";
               status= false;      
            }

            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_code_using_code(string input, out string output)
        {
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_code].CommandType = CommandType.StoredProcedure;
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_code].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_code].Parameters.AddWithValue("@code", input);
            using (MySqlDataReader reader = MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_code].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_code_using_language(string input, out string output)
        {
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_language].CommandType = CommandType.StoredProcedure;
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_language].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_language].Parameters.AddWithValue("@language", input);
            using (MySqlDataReader reader = MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_code_using_language].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = true;
                }
            }
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_language_using_code(string input, out string output)
        {
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_code].CommandType = CommandType.StoredProcedure;
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_code].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_code].Parameters.AddWithValue("@code", input);
            using (MySqlDataReader reader = MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_code].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["language"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_language_using_Language(string input, out string output)
        {
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_Language].CommandType = CommandType.StoredProcedure;
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_Language].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_Language].Parameters.AddWithValue("@language", input);
            using (MySqlDataReader reader = MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.find_language_using_Language].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["language"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public string view_all_data_from_language_table()
        {


            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Open();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.view_all_data_from_language_table].Parameters.Clear();
            MySql_Language_Manager01.cmd[(int)MySql_Language_Manager01.command_strings.view_all_data_from_language_table].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Language_Manager01.cmd[22].ExecuteReader())
            {
                while (reader.Read())
                {

                    data01[0] += $"{reader["code"]}\n" +
                                 $"{reader["language"]}\n";
                    code.Add(reader["code"]?.ToString() ?? string.Empty);
                    language.Add(reader["language"]?.ToString() ?? string.Empty);
                }
            }
            data01[1] += $"{string.Join(" ", code)}\n" +
                         $"{string.Join(" ", language)}\n";

            MySql_Language_Manager01.conn[(int)MySql_Language_Manager01.Connection_strings.Connection01].Close();
            return data01[0];

        }

    }
}