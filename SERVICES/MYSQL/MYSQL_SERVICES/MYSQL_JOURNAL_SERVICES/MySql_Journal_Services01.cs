using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_JOURNAL_MANAGER;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_JOURNAL_SERVICES
{
    public class MySql_Journal_Services01
    {
        private bool status = false;
        private static int index_data = 0;
        private int[] index_string = {
    (int)MySql_Journal_Manager01.Connection_strings.Connection01};


        public bool insert_journal(string input01, string input02, string input03, string input04
            , out string output)
        {
            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@full_name", input01);
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@email", input02);
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@email_creation_date", data01);
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@phone_number", input03);
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@message", input04);
            int rowsAffected = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.insert_journal].ExecuteNonQuery();

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

            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_message_using_message(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_message].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_message].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_message].Parameters.AddWithValue("_message", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_message].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["message"].ToString()}";

                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }


        public bool find_message_using_upload(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_upload].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_upload].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_upload].Parameters.AddWithValue("@phone_number", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_upload].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }


        public bool find_message_using_username(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_username].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_username].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_username].Parameters.AddWithValue("_username", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_message_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["message"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }
        public bool find_username_using_username(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_username].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_username].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_username].Parameters.AddWithValue("@upload", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["upload"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }

        public bool find_upload_using_message(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_message].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_message].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_message].Parameters.AddWithValue("_message", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_message].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["upload"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }
        public bool find_upload_using_upload(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_upload].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_upload].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_upload].Parameters.AddWithValue("_upload", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_upload].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["upload"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status &= false;
                }
            }
            return status;
        }
        public bool find_upload_using_username(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_username].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_username].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_username].Parameters.AddWithValue("_username", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_upload_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["upload"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status |= false;
                }
            }
            return status;
        }
        public bool find_username_using_message(string input01, out string output)
        {
            MySql_Journal_Manager01.conn[(int)MySql_Journal_Manager01.Connection_strings.Connection01].Open();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_message].CommandType = CommandType.StoredProcedure;
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_message].Parameters.Clear();
            MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_message].Parameters.AddWithValue("_message", input01);
            using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.find_username_using_message].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["username"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            return status;
        }
        public bool view_journal_database_storedprocedures(out string output)
        {
            output = string.Empty;

            try
            {
                MySql_Journal_Manager01.conn[index_string[index_data]].Open();
                if (MySql_Journal_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.view_journal_database_storedprocedures].CommandType = CommandType.Text;
                    using (MySqlDataReader reader = MySql_Journal_Manager01.cmd[(int)MySql_Journal_Manager01.command_strings.view_journal_database_storedprocedures].ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output += $"{reader["name"].ToString()}\n";
                        }
                        status = true;
                    }
                }
                else
                {
                    output = "Connection is closed.";
                    status = false;
                }
            }
            catch (Exception ex)
            {
                output = ex.Message;
                status = false;
            }
            finally
            {
                if (MySql_Journal_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Journal_Manager01.conn[index_string[index_data]].Close();
                }
            }

            return status;
        }


    }
}
