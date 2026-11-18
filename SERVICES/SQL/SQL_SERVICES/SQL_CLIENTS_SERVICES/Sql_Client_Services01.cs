using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;



namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES
{
    public class Sql_Client_Services01
    {
        private static Sql_Manager01 Sql_M01 = new Sql_Manager01();
        private string[] data01 = new string[100];
        private bool status = true;
        private static int index_data = 0;
        private int[] index_string = {
    (int)Sql_Manager01.connection_strings.connection01,
    (int)Sql_Manager01.connection_strings.connection02,
    (int)Sql_Manager01.connection_strings.connection03};

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

        public bool delete_client_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_phonenumber].Parameters.AddWithValue("@client_emailaddress", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_phonenumber].ExecuteNonQuery();
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
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_client_using_email].Parameters.AddWithValue("@client_emailaddress", input);
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
        public bool find_client_api_key_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_api_key_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_api_key_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_api_key_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_apikey_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_apikey_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_apikey_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_apikey_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_apikey_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_api_key"].ToString()}";
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
        public bool find_client_cashappdata01_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_cashappdata01_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_cashappdata01"].ToString()}";
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
        public bool find_client_colors_using_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_primary_color"].ToString()}\n" +
                             $"{reader["client_secondary_color"].ToString()}\n" +
                             $"{reader["client_tertiary_color"].ToString()}\n";
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
        public bool find_client_colors_using_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_primary_color"].ToString()}\n" +
           $"{reader["client_secondary_color"].ToString()}\n" +
           $"{reader["client_tertiary_color"].ToString()}\n";
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
        public bool find_client_colors_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_colors_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_primary_color"].ToString()}\n" +
         $"{reader["client_secondary_color"].ToString()}\n" +
         $"{reader["client_tertiary_color"].ToString()}\n";
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
        public bool find_client_data_using_email(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_email].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output =

               $"{reader["client_name"].ToString()}\n" +
      $"{reader["client_emailaddress"].ToString()}\n" +
      $"{reader["client_phonenumber"].ToString()}\n" +
      $"{reader["client_api_key"].ToString()}\n" +
      $"{reader["client_cashappdata01"].ToString()}\n" +
      $"{reader["client_zelleappdata01"].ToString()}\n" +
      $"{reader["client_venmoappdata01"].ToString()}\n" +
      $"{reader["client_paypalappdata01"].ToString()}\n" +
      $"{reader["client_logo"].ToString()}\n" +
      $"{reader["client_latitude"].ToString()}\n" +
      $"{reader["client_longitude"].ToString()}\n" +
      $"{reader["client_primary_color"].ToString()}\n" +
      $"{reader["client_secondary_color"].ToString()}\n" +
      $"{reader["client_tertiary_color"].ToString()}\n" +
      $"{reader["client_social_media"].ToString()}\n" +
      $"{reader["client_type"].ToString()}\n" +
      $"{reader["client_date_created"].ToString()}\n";








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
        public bool find_client_data_using_latitude_and_longitude(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_latitude_and_longitude].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_latitude_and_longitude].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_latitude_and_longitude].Parameters.AddWithValue("@client_latitude", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_latitude_and_longitude].Parameters.AddWithValue("@client_longitude", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_latitude_and_longitude].ExecuteReader())
            {
                if (reader.Read())
                {
                    output =

             $"{reader["client_name"].ToString()}\n" +
    $"{reader["client_emailaddress"].ToString()}\n" +
    $"{reader["client_phonenumber"].ToString()}\n" +
    $"{reader["client_api_key"].ToString()}\n" +
    $"{reader["client_cashappdata01"].ToString()}\n" +
    $"{reader["client_zelleappdata01"].ToString()}\n" +
    $"{reader["client_venmoappdata01"].ToString()}\n" +
    $"{reader["client_paypalappdata01"].ToString()}\n" +
    $"{reader["client_logo"].ToString()}\n" +
    $"{reader["client_latitude"].ToString()}\n" +
    $"{reader["client_longitude"].ToString()}\n" +
    $"{reader["client_primary_color"].ToString()}\n" +
    $"{reader["client_secondary_color"].ToString()}\n" +
    $"{reader["client_tertiary_color"].ToString()}\n" +
    $"{reader["client_social_media"].ToString()}\n" +
    $"{reader["client_type"].ToString()}\n" +
    $"{reader["client_date_created"].ToString()}\n";

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
        public bool find_client_data_using_logo(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_logo].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_logo].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_logo].Parameters.AddWithValue("@client_logo", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_logo].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}\n" +
      $"{reader["client_emailaddress"].ToString()}\n" +
      $"{reader["client_phonenumber"].ToString()}\n" +
      $"{reader["client_api_key"].ToString()}\n" +
      $"{reader["client_cashappdata01"].ToString()}\n" +
      $"{reader["client_zelleappdata01"].ToString()}\n" +
      $"{reader["client_venmoappdata01"].ToString()}\n" +
      $"{reader["client_paypalappdata01"].ToString()}\n" +
      $"{reader["client_logo"].ToString()}\n" +
      $"{reader["client_latitude"].ToString()}\n" +
      $"{reader["client_longitude"].ToString()}\n" +
      $"{reader["client_primary_color"].ToString()}\n" +
      $"{reader["client_secondary_color"].ToString()}\n" +
      $"{reader["client_tertiary_color"].ToString()}\n" +
      $"{reader["client_social_media"].ToString()}\n" +
      $"{reader["client_type"].ToString()}\n" +
      $"{reader["client_date_created"].ToString()}\n";
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
        public bool find_client_data_using_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}\n" +
      $"{reader["client_emailaddress"].ToString()}\n" +
      $"{reader["client_phonenumber"].ToString()}\n" +
      $"{reader["client_api_key"].ToString()}\n" +
      $"{reader["client_cashappdata01"].ToString()}\n" +
      $"{reader["client_zelleappdata01"].ToString()}\n" +
      $"{reader["client_venmoappdata01"].ToString()}\n" +
      $"{reader["client_paypalappdata01"].ToString()}\n" +
      $"{reader["client_logo"].ToString()}\n" +
      $"{reader["client_latitude"].ToString()}\n" +
      $"{reader["client_longitude"].ToString()}\n" +
      $"{reader["client_primary_color"].ToString()}\n" +
      $"{reader["client_secondary_color"].ToString()}\n" +
      $"{reader["client_tertiary_color"].ToString()}\n" +
      $"{reader["client_social_media"].ToString()}\n" +
      $"{reader["client_type"].ToString()}\n" +
      $"{reader["client_date_created"].ToString()}\n";
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
        public bool find_client_data_using_number(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_number].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_number].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_number].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_data_using_number].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}\n" +
      $"{reader["client_emailaddress"].ToString()}\n" +
      $"{reader["client_phonenumber"].ToString()}\n" +
      $"{reader["client_api_key"].ToString()}\n" +
      $"{reader["client_cashappdata01"].ToString()}\n" +
      $"{reader["client_zelleappdata01"].ToString()}\n" +
      $"{reader["client_venmoappdata01"].ToString()}\n" +
      $"{reader["client_paypalappdata01"].ToString()}\n" +
      $"{reader["client_logo"].ToString()}\n" +
      $"{reader["client_latitude"].ToString()}\n" +
      $"{reader["client_longitude"].ToString()}\n" +
      $"{reader["client_primary_color"].ToString()}\n" +
      $"{reader["client_secondary_color"].ToString()}\n" +
      $"{reader["client_tertiary_color"].ToString()}\n" +
      $"{reader["client_social_media"].ToString()}\n" +
      $"{reader["client_type"].ToString()}\n" +
      $"{reader["client_date_created"].ToString()}\n";
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
        public bool find_client_emailaddress_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_emailaddress_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_emailaddress"].ToString()}";
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
        public bool find_client_location_using_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_latitude"].ToString()}" +
                             $"{reader["client_longitude"].ToString()}";
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
        public bool find_client_location_using_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_latitude"].ToString()}" +
                             $"{reader["client_longitude"].ToString()}";
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
        public bool find_client_location_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_location_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_latitude"].ToString()}" +
                             $"{reader["client_longitude"].ToString()}";
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
        public bool find_client_logo_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_logo"].ToString()}";
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
        public bool find_client_logo_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_logo"].ToString()}";
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
        public bool find_client_logo_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_logo"].ToString()}";
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
        public bool find_client_name_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_cashappdata01].ExecuteReader())
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
        public bool find_client_name_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_emailaddress].ExecuteReader())
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
        public bool find_client_name_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_paypalappdata01].ExecuteReader())
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
        public bool find_client_name_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_phonnumeber].ExecuteReader())
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
        public bool find_client_name_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_name_by_venmoappdata01].ExecuteReader())
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
        public bool find_client_paypalappdata01_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_paypalappdata01_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_paypalappdata01"].ToString()}";
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
        public bool find_client_phonenumber_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_apikey].ExecuteReader())
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
        public bool find_client_phonenumber_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].ExecuteReader())
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
        public bool find_client_phonenumber_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_emailaddress].ExecuteReader())
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
        public bool find_client_phonenumber_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].ExecuteReader())
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
        public bool find_client_phonenumber_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].ExecuteReader())
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
        public bool find_client_phonenumber_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].ExecuteReader())
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
        public bool find_client_venmoappdata01_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_paypalappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].Parameters.AddWithValue("@client_paypalappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_venmoappdata01_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_venmoappdata01"].ToString()}";
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
        public bool find_client_zellaappdata01_by_zellaappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].Parameters.AddWithValue("@client_zelleappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zellaappdata01_by_apikey(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_apikey].Parameters.AddWithValue("@client_api_key", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zellaappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zelleappdata01_by_cashappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zelleappdata01_by_emailaddress(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].Parameters.AddWithValue("@client_emailaddress", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zelleappdata01_by_name(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zelleappdata01_by_phonnumeber(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool find_client_zelleappdata01_by_venmoappdata01(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].Parameters.AddWithValue("@client_venmoappdata01", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_zelleappdata01"].ToString()}";
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
        public bool insert_client_data(string input01, string input02, string input03,
                                       string input04, string input05, string input06,
                                       string input07, string input08, string input09,
                                       string input10, string input11, string input12,
                                       string input13, string input14, out string output)
        {


            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_name", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_emailaddress", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_phonenumber", input03);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_api_key", input04);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_cashappdata01", input05);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_zelleappdata01", input06);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_venmoappdata01", input07);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_paypalappdata01", input08);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_logo", input09);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_latitude", Location_Manager01.get_latitude);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_longitude", Location_Manager01.get_longitude);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_primary_color", input10);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_secondary_color", input11);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_tertiary_color", input12);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_social_media", input13);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_type", input14);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@client_date_created", Security_Services01.today_date);


            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_client_data].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
                Sql_Manager01.conn[index_string[index_data]].Close();
                return status;
            }
            else
            {
                output = "fail";
                status = false;
                Sql_Manager01.conn[index_string[index_data]].Close();
                return status;
            }

        }
        public bool update_clients_apikey_using_apikey(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_apikey_using_apikey].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_apikey_using_apikey].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_apikey_using_apikey].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_apikey_using_apikey].Parameters.AddWithValue("@client_emailaddress01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_apikey_using_apikey].ExecuteNonQuery();
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
        public bool update_clients_cashappdata01_using_cashappdata01(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01].Parameters.AddWithValue("@client_cashappdata", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01].Parameters.AddWithValue("@client_cashappdata01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01].ExecuteNonQuery();
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
        public bool update_clients_email_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@client_emailaddress01", input01);
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
        public bool update_clients_logo_using_logo(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_logo_using_logo].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_logo_using_logo].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_logo_using_logo].Parameters.AddWithValue("@client_logo", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_logo_using_logo].Parameters.AddWithValue("@client_logo01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_logo_using_logo].ExecuteNonQuery();
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
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@client_name01", input01);
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
        public bool update_clients_paypalappdata01_using_paypalappdata01(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01].Parameters.AddWithValue("@client_emailaddress01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01].ExecuteNonQuery();
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
        public bool update_clients_phnenumber_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phnenumber_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phnenumber_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phnenumber_using_phonenumber].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phnenumber_using_phonenumber].Parameters.AddWithValue("@client_emailaddress01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_phnenumber_using_phonenumber].ExecuteNonQuery();
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
        public bool update_clients_venmoappdata01_using_venmoappdata01(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01].Parameters.AddWithValue("@client_emailaddress01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01].ExecuteNonQuery();
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
        public bool update_clients_zelleappdata01_using_zellappdata01(string input, string input01, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01].Parameters.AddWithValue("@client_emailaddress", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01].Parameters.AddWithValue("@client_emailaddress01", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01].ExecuteNonQuery();
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
        public bool view_all_client_data(out string output)
        {

            output = string.Empty;
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_client_data].CommandType = CommandType.Text;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_client_data].ExecuteReader())
            {
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        output +=
reader["client_name"].ToString() + "\n" +
reader["client_emailaddress"].ToString() + "\n" +
reader["client_phonenumber"].ToString() + "\n" +
reader["client_api_key"].ToString() + "\n" +
reader["client_cashappdata01"].ToString() + "\n" +
reader["client_zelleappdata01"].ToString() + "\n" +
reader["client_venmoappdata01"].ToString() + "\n" +
reader["client_paypalappdata01"].ToString() + "\n" +
reader["client_logo"].ToString() + "\n" +
reader["client_latitude"].ToString() + "\n" +
reader["client_longitude"].ToString() + "\n" +
reader["client_primary_color"].ToString() + "\n" +
reader["client_secondary_color"].ToString() + "\n" +
reader["client_tertiary_color"].ToString() + "\n" +
reader["client_social_media"].ToString() + "\n" +
reader["client_type"].ToString() + "\n" +
reader["client_date_created"].ToString() + "\n";


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





        public bool view_client_database_storedprocedures(out string output)
        {
            output = string.Empty;

            try
            {
                Sql_Manager01.conn[index_string[index_data]].Open();
                if (Sql_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_client_database_storedprocedures].CommandType = CommandType.Text;
                    using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_client_database_storedprocedures].ExecuteReader())
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
                if (Sql_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    Sql_Manager01.conn[index_string[index_data]].Close();
                }
            }

            return status;
        }

        public bool find_client_logo_by_logo(string input, out string output)
        {
            Sql_Manager01.conn[index_string[index_data]].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_logo].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_logo].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_logo].Parameters.AddWithValue("@client_logo", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_client_logo_by_logo].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_logo"].ToString()}";
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