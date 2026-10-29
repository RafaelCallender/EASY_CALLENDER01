using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_JOURNAL_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_JOURNAL_SERVICES
{
    public class Sql_Journal_Services01
    {
        private bool status = false;
        private static int index_data = 0;
        private int[] index_string = {
    (int)Sql_Journal_Manager01.Connection_strings.Connection01,
    (int)Sql_Journal_Manager01.Connection_strings.Connection02
    };
        public bool insert_journal(string input01, string input02, string input03, string input04
            , string input05, out string output)
        {
            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@username", input01);
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@upload", input02);
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@message", input03);
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@creation_date", input04);
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].Parameters.AddWithValue("@error", input05);
            int rowsAffected = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.insert_journal].ExecuteNonQuery();

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

            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_username_using_username(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_username].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_username].Parameters.AddWithValue("@username", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_username].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }


        public bool find_username_using_upload(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_upload].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_upload].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_upload].Parameters.AddWithValue("@upload", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_upload].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_username_using_message(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_message].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_message].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_message].Parameters.AddWithValue("@message", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_username_using_message].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }


        public bool find_upload_using_username(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_username].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_username].Parameters.AddWithValue("@username", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_username].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_upload_using_upload(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_upload].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_upload].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_upload].Parameters.AddWithValue("@upload", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_upload].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_upload_using_message(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_message].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_message].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_message].Parameters.AddWithValue("@message", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_upload_using_message].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_message_using_username(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_username].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_username].Parameters.AddWithValue("@username", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["message"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status &= false;
                }
            }
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_message_using_upload(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_upload].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_upload].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_upload].Parameters.AddWithValue("@upload", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_upload].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["message"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status |= false;
                }
            }
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_message_using_message(string input01, out string output)
        {
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Open();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_message].CommandType = CommandType.StoredProcedure;
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_message].Parameters.Clear();
            Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_message].Parameters.AddWithValue("@message", input01);
            using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.find_message_using_message].ExecuteReader())
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
            Sql_Journal_Manager01.conn[(int)Sql_Journal_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool view_journal_database_storedprocedures(out string output)
        {

            output = string.Empty;
            try
            {
                Sql_Journal_Manager01.conn[index_string[index_data]].Open();
                Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.view_journal_database_storedprocedures].CommandType = CommandType.Text;
                using (SqlDataReader reader = Sql_Journal_Manager01.cmd[(int)Sql_Journal_Manager01.command_strings.view_journal_database_storedprocedures].ExecuteReader())
                {
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            output += reader["name"].ToString() + Environment.NewLine;
                        }

                        status = true;
                    }
                    else
                    {
                        output = "cant find";
                        status = false;
                    }
                }
                Sql_Journal_Manager01.conn[index_string[index_data]].Close();

            }
            catch (Exception ex)
            {
                output = ex.Message;
                status = false;
            }
            finally
            {
                if (Sql_Journal_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    Sql_Journal_Manager01.conn[index_string[index_data]].Close();
                }
            }
            return status;
        }

    }
}
