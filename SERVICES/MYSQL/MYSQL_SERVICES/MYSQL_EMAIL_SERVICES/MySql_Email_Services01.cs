using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_EMAIL_MANAGER;
using MySql.Data.MySqlClient; 
using MySql.Data;
using System.Data;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_EMAIL_SERVICES
{
    public class MySql_Email_Services01
    {
        private bool status = false;
              private static int index_data = 0;
        private int[] index_string = {
    (int)MySql_Email_Manager01.Connection_strings.Connection01};

  
        public bool insert_email(string input01, string input02, string input03, string input04
            , out string output)
        {
                  DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@full_name", input01);
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@email", input02);
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@email_creation_date", data01);
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@phone_number", input03);
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@message", input04);
            int rowsAffected = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.insert_email].ExecuteNonQuery();

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

            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_email_using_email(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
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


        public bool find_email_using_name(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
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
        public bool find_email_using_phonenumber(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status=false;       
                }
            }
            return status;
        }


        public bool find_full_name_using_email(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["full_name"].ToString()}";
                    status=true;    

                }
                else
                {
                   output= "cant find";
                    status = false;     
                }
            }
            return status;
        }
        public bool find_full_name_using_full_name(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["full_name"].ToString()}";
                    status = true;      

                }
                else
                {
                    output = "cant find";
                    status=false;       
                }
            }
            return status;
        }

        public bool find_full_name_using_phonenumber(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["full_name"].ToString()}";
                    status=true;

                }
                else
                {
                    output = "cant find";
                    status = false;     
                }
            }
            return status;
        }
        public bool find_phonenumber_using_email(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
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
        public bool find_phonenumber_using_fullname(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                   output = $"{reader["phonenumber"].ToString()}";
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
        public bool find_phonenumber_using_phonenumber(string input01, out string output)
        {
            MySql_Email_Manager01.conn[(int)MySql_Email_Manager01.Connection_strings.Connection01].Open();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                   output = $"{reader["phonenumber"].ToString()}";
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
          public bool view_email_database_storedprocedures(out string output)
        {
            output = string.Empty;

            try
            {
                MySql_Email_Manager01.conn[index_string[index_data]].Open();
                if (MySql_Email_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.view_email_database_storedprocedures].CommandType = CommandType.Text;
                    using (MySqlDataReader reader = MySql_Email_Manager01.cmd[(int)MySql_Email_Manager01.command_strings.view_email_database_storedprocedures].ExecuteReader())
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
                if (MySql_Email_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Email_Manager01.conn[index_string[index_data]].Close();
                }
            }

            return status;
        }


    }
}
