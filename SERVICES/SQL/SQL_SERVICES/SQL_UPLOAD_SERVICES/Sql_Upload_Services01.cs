using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_UPLOAD_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_UPLOAD_SERVICES
{
    public class Sql_Upload_Services01
    {
        private bool status = false;
        private static int index_data = 0;
        private int[] index_string = {
    (int)Sql_Upload_Manager01.Connection_strings.Connection01,
};

        public bool insert_data(string input01, string input02, string input03, string input04, string input05, string input06, string input07
          , out string output)
        {
            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@Username", input01);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@OriginalName", input02);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@StoredName", input03);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@FilePath", input04);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@ContentType", input05);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@FileSize", input06);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].Parameters.AddWithValue("@UploadDate", input07);
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.insert_data].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                output = "success";
                status = true;
            }

            else
            {
                output = "fail";
                status = false;
            }

            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_username_using_username(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_username].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_username].Parameters.AddWithValue("@Username", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.view_database_storedprocedures].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["Username"].ToString()}";

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






        public bool delete_FilePath_using_FilePath(string input, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_FilePath_using_FilePath].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_FilePath_using_FilePath].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_FilePath_using_FilePath].Parameters.AddWithValue("@filepath", input.ToString().Trim());
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_FilePath_using_FilePath].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_OriginalName_using_OriginalName(string input, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_OriginalName_using_OriginalName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_OriginalName_using_OriginalName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_OriginalName_using_OriginalName].Parameters.AddWithValue("@orginalname", input.ToString().Trim());
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_OriginalName_using_OriginalName].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_StoredName_using_StoredName(string input, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_StoredName_using_StoredName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_StoredName_using_StoredName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_StoredName_using_StoredName].Parameters.AddWithValue("@storedname", input.ToString().Trim());
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_StoredName_using_StoredName].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_Username_using_Username(string input, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_Username_using_Username].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_Username_using_Username].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_Username_using_Username].Parameters.AddWithValue("@username", input.ToString().Trim());
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.delete_Username_using_Username].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_OriginalName_using_FilePath(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_FilePath].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_FilePath].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_FilePath].Parameters.AddWithValue("@filepath", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_FilePath].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["OriginalName"].ToString()}";

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

        public bool find_OriginalName_using_OriginalName(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_OriginalName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_OriginalName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_OriginalName].Parameters.AddWithValue("@orginalname", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_OriginalName].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["OriginalName"].ToString()}";

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

        public bool find_OriginalName_using_StoredName(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_StoredName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_StoredName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_StoredName].Parameters.AddWithValue("@storedname", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_StoredName].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["Username"].ToString()}";

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

        public bool find_OriginalName_using_Username(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_Username].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_Username].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_Username].Parameters.AddWithValue("@Username", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_OriginalName_using_Username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["OriginalName"].ToString()}";

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

        public bool find_StoredName_using_StoredName(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_StoredName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_StoredName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_StoredName].Parameters.AddWithValue("@storedname", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_StoredName].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["StoredName"].ToString()}";

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

        public bool find_StoredName_using_Username(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_Username].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_Username].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_Username].Parameters.AddWithValue("@username", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_StoredName_using_Username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["StoredName"].ToString()}";

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

        public bool find_username_using_FilePath(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_FilePath].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_FilePath].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_FilePath].Parameters.AddWithValue("@filepath", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_FilePath].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["Username"].ToString()}";

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

        public bool find_username_using_OriginalName(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_OriginalName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_OriginalName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_OriginalName].Parameters.AddWithValue("@orginalname", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_OriginalName].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["Username"].ToString()}";

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

        public bool find_username_using_StoredName(string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_StoredName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_StoredName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_StoredName].Parameters.AddWithValue("@storedname", input01);
            using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.find_username_using_StoredName].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["Username"].ToString()}";

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




        public bool update_OriginalName_using_OriginalName(string input, string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_OriginalName_using_OriginalName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_OriginalName_using_OriginalName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_OriginalName_using_OriginalName].Parameters.AddWithValue("@orignalname", input);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_OriginalName_using_OriginalName].Parameters.AddWithValue("@orignalname01", input01);
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_OriginalName_using_OriginalName].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_StoredName_using_StoredName(string input, string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_StoredName_using_StoredName].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_StoredName_using_StoredName].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_StoredName_using_StoredName].Parameters.AddWithValue("@storedname", input);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_StoredName_using_StoredName].Parameters.AddWithValue("@storedname01", input01);
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_StoredName_using_StoredName].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_username_using_username(string input, string input01, out string output)
        {
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Open();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_username_using_username].Parameters.Clear();
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@username", input);
            Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@username01", input01);
            int rowsAffected = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.update_username_using_username].ExecuteNonQuery();
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
            Sql_Upload_Manager01.conn[(int)Sql_Upload_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool view_database_storedprocedures(out string output)
        {
            output = string.Empty;
            try
            {
                Sql_Upload_Manager01.conn[0].Open();
                if (Sql_Upload_Manager01.conn[0].State == ConnectionState.Open)
                {
                    Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.view_database_storedprocedures].CommandType = CommandType.Text;
                    using (SqlDataReader reader = Sql_Upload_Manager01.cmd[(int)Sql_Upload_Manager01.command_strings.view_database_storedprocedures].ExecuteReader())
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
                if (Sql_Upload_Manager01.conn[0].State == ConnectionState.Open)
                {
                    Sql_Upload_Manager01.conn[0].Close();
                }
            }
            return status;

        }
    }
}

