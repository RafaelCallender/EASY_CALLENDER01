using EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CLIENTS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES
{
    public class Sql_Client_Services01
    {
        private static Sql_Manager01 Sql_M01 = new Sql_Manager01();
        private string[] data01 = new string[100];
        private bool status = true;
        private static int index_data = 0;
        private int[] index_string = {
    (int)Sql_Manager01.Connection_strings.Connection01,
    (int)Sql_Manager01.Connection_strings.Connection02,
    (int)Sql_Manager01.Connection_strings.Connection03};



        public bool insert_client(string input01, string input02, string input03,
                                  string input04, string input05, string input06,
                                  string input07, string input08, string input09,
                                  out string output)
        {

            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_name", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_email_key", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_api_key", input03);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_email_address", input04);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_phonenumber", input05);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_cashapp", input06);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_paypal", input07);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_zelle", input08);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_venmo", input09);



            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }

        public bool delete_client_using_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_email].Parameters.AddWithValue("@client_email_address", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_email].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool delete_client_using_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_name].Parameters.AddWithValue("@client_name", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_name].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }

        public bool find_client_email_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_email].Parameters.AddWithValue("@client_email_address", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_email_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_email_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_email_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_name_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_email].Parameters.AddWithValue("@client_email", input.Trim());
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_name_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_name_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_phonenumber_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_email].Parameters.AddWithValue("@client_email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_phonenumber_by_name(string input, out string output)
        {

            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_name].ExecuteReader())
            {

                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;


        }
        public bool find_client_phonenumber_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_email_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@client_email01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_email_using_name(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_name].Parameters.AddWithValue("@client_email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_name].Parameters.AddWithValue("@client_name", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_name].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_email_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.AddWithValue("@client_email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_phonenumber].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_name_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_email].Parameters.AddWithValue("@client_email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_email].Parameters.AddWithValue("@client_name", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_email].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_name_using_name(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@client_name", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@client_name", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_name_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.AddWithValue("@clent_email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_phonenumber].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.AddWithValue("@client_email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.AddWithValue("@client_phonenumber", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_email].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_name(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.AddWithValue("@client_name", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.AddWithValue("@client_phonenumber", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_name].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input01);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].ExecuteNonQuery();
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_cashapp_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashapp"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_cashapp_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_phonenumber].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashapp"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_cashapp_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_email].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashapp_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashapp"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }





        public bool find_client_emailkey_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailkey_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailkey_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailkey_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailkey_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_key"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }

        public bool find_client_zelle_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_email].Parameters.AddWithValue("@client_email_addres", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelle"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_zelle_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelle"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_zelle_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelle_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelle"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_paypal_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypal"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_paypal_using_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_using_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypal"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_paypal_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_email].Parameters.AddWithValue("@client_email_address", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypal_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypal"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_venmo_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmo"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_venmo_by_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_email].Parameters.AddWithValue("@client_email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmo"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_venmo_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmo_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmo"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool view_client_database_storedprocedures(out string output)
        {

            output = string.Empty;
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_client_database_storedprocedures].CommandType = CommandType.Text;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_client_database_storedprocedures].ExecuteReader())
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
            Sql_Manager01.conn[index_string[index_data]].Close();
            return status;
        }

    }
}