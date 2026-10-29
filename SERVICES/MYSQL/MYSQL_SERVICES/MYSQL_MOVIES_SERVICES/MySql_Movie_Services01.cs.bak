using EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MOVIES_MANAGER;
using MySql.Data.MySqlClient; 
using System.Data;


namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_MOVIES_SERVICES
{
    public class MySql_Movie_Services01
    {
        private bool status = false;

        private static string[] data01 = new string[100 ];
        private List<string> File_Location = new List<string>();
        private List<string> File_Name = new List<string>();
        public string[] data_array = {
                                      "view all Movies using SQL",//0
                                      "find movies using SQL",//1
                                      "view all Movies using SQLITE" };//2
        public bool insert_movies(string input01, string input02,out string output)
        {

            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Open();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.insert_movies].Parameters.Clear();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.insert_movies].CommandType = CommandType.StoredProcedure;
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.insert_movies].Parameters.AddWithValue("@file_location", input01);
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.insert_movies].Parameters.AddWithValue("@file_name", input02);
            int rowsAffected = MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.insert_movies].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                output = "sucess";

                status = true;
            }

            else
            {
                output = "fail";
                status = false;
            }

            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_location_using_file_name(string input, out string output)
        {
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Open();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_location_using_file_name].CommandType = CommandType.StoredProcedure;
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_location_using_file_name].Parameters.Clear();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_location_using_file_name].Parameters.AddWithValue("@file_name", input);
            using (MySqlDataReader reader = MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_location_using_file_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["file_name"].ToString()}";

                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;

                }
            }
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_name_using_file_loaction(string input, out string output)
        {
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Open();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_file_name_using_file_location].CommandType = CommandType.StoredProcedure;
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_file_name_using_file_location].Parameters.Clear();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_file_name_using_file_location].Parameters.AddWithValue("@file_location", input);
            using (MySqlDataReader reader = MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.find_file_name_using_file_location].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["file_location"].ToString()}";
                    status = true;

                }
                else
                {
                output = "cant find";
                    status = false;
                }
            }
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public string view_all_movies_using_sql()
        {
            File_Location.Clear();
            File_Name.Clear();
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Open();
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.view_all_movies].CommandType = CommandType.StoredProcedure;
            MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.view_all_movies].Parameters.Clear();
            using (MySqlDataReader reader = MySql_Movies_Manager01.cmd[(int)MySql_Movies_Manager01.command_strings.view_all_movies].ExecuteReader())
            {
                while (reader.Read())
                {
                    File_Location.Add(reader["file_location"]?.ToString() ?? string.Empty);
                    File_Name.Add(reader["file_name"]?.ToString() ?? string.Empty);
                }
            }
            MySql_Movies_Manager01.conn[(int)MySql_Movies_Manager01.Connection_strings.Connection01].Close();
            data01[0] = string.Join(",", File_Location);
            data01[1] = string.Join(",", File_Name);
            return $"{data01[0]}|{data01[1]}";
        }
    }
}