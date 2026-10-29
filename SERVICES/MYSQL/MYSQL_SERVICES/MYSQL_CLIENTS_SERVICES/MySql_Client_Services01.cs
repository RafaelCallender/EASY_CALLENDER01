using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_HELPER;
using MySql.Data.MySqlClient;
using System.Data;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_CLIENTS_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using System.IO;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_CLIENTS_SERVICES
{
    public class MySql_Client_Services01
    {

        private bool status = true;
        private static int index_data = 0;
        private int[] index_string = {
    (int)MySql_Client_Manager01.Connection_strings.Connection01
    };

        public bool delete_client_using_name(string input, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.delete_client_using_name];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_username", input);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "success";
                return true;
            }
            else
            {
                output = "failed";
                return false;
            }

        }

        public bool delete_client_using_phonenumber(string input, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.delete_client_using_phonenumber];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_phonenumber", input);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "success";
                return true;
            }
            else
            {
                output = "failed";
                return false;
            }

        }

        public bool delete_client_using_email(string input, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.delete_client_using_email];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_phonenumber", input);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "success";
                return true;
            }
            else
            {
                output = "failed";
                return false;
            }

        }
        public bool find_client_phonenumber_by_phonenumber(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonenumber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.AddWithValue("p_phonenumber", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonenumber].ExecuteReader())
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
        public bool find_client_api_key_by_emailaddress(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["emailaddress"].ToString()}";

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
        public bool find_client_api_key_by_name(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_api_key_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_api_key_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_apikey_by_apikey(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_apikey_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_apikey_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty;
            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_apikey_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_apikey_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_cashappdata01_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_cashappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_colors_using_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_colors_using_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_colors_using_phonenumber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_phonenumber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_phonenumber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_phonenumber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_colors_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_data_using_email(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_email].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_email].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_email].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_data_using_latitude_and_longitude(string input, string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_latitude_and_longitude].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_latitude_and_longitude].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_latitude_and_longitude].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_latitude_and_longitude].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_data_using_logo(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_logo].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_logo].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_logo].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_logo].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_data_using_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_data_using_number(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_number].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_number].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_number].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_data_using_number].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_emailaddress_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_emailaddress_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_location_using_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_location_using_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_location_using_phonenumber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_phonenumber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_phonenumber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_phonenumber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_location_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_logo_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_logo_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_logo_by_phonenumber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_phonenumber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_phonenumber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_phonenumber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_name_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_name_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_paypalappdata01_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_paypalappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_phonenumber_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_phonenumber_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_paypalappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_paypalappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_venmoappdata01_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_venmoappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zellaappdata01_by_apikey(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_apikey].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_apikey].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_apikey].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_apikey].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zelleappdata01_by_cashappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_cashappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zelleappdata01_by_emailaddress(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_emailaddress].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zelleappdata01_by_name(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_name].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_name].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_name].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zelleappdata01_by_phonnumeber(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_phonnumeber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool find_client_zelleappdata01_by_venmoappdata01(string input01, out string output)
        {
            output = string.Empty; MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].Parameters.AddWithValue("@p_organization_email", input01);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zelleappdata01_by_venmoappdata01].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["organization_address"].ToString()}";

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
        public bool insert_client_data(string input01, string input02, string input03,
                                               string input04, string input05, string input06,
                                               string input07, string input08, string input09,
                                               string input10, string input11, string input12,
                                               string input13, string input14, out string output)
        {


            MySql_Client_Manager01.conn[index_string[index_data]].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_name", input01);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_emailaddress", input02);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_phonenumber", input03);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_api_key", input04);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_cashappdata01", input05);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_zelleappdata01", input06);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_venmoappdata01", input07);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_paypalappdata01", input08);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_logo", input09);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_latitude", Location_Manager01.get_latitude);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_longitude", Location_Manager01.get_longitude);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_primary_color", input10);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_secondary_color", input11);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_tertiary_color", input12);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_social_media", input13);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_type", input14);
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].Parameters.AddWithValue("@p_client_date_created", Security_Services01.today_date);

            int rowsAffected = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.insert_client_data].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
                MySql_Client_Manager01.conn[index_string[index_data]].Close();
                return status;
            }
            else
            {
                output = "fail";
                status = false;
                MySql_Client_Manager01.conn[index_string[index_data]].Close();
                return status;
            }
        }

        public bool update_clients_apikey_using_apikey(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_apikey_using_apikey];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_cashappdata01_using_cashappdata01(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_cashappdata01_using_cashappdata01];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_email_using_email(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_email_using_email];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_logo_using_logo(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_logo_using_logo];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_name_using_name(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_name_using_name];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_paypalappdata01_using_paypalappdata01(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_paypalappdata01_using_paypalappdata01];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_phnenumber_using_phonenumber(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_phnenumber_using_phonenumber];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_venmoappdata01_using_venmoappdata01(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_venmoappdata01_using_venmoappdata01];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool update_clients_zelleappdata01_using_zellappdata01(string input, string input01, out string output)
        {

            MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Open();
            var cmd = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.update_clients_zelleappdata01_using_zellappdata01];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_apikey", input);
            cmd.Parameters.AddWithValue("@p_apikey", input01);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                output = $"success";

                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return true;
            }
            else
            {
                output = $"failed";
                MySql_Client_Manager01.conn[(int)MySql_Client_Manager01.Connection_strings.Connection01].Close();
                return false;
            }

        }
        public bool view_all_client_data(out string output)
        {

            output = string.Empty;
            MySql_Client_Manager01.conn[index_string[index_data]].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.view_all_client_data].CommandType = CommandType.Text;
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.view_all_client_data].ExecuteReader())
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
            MySql_Client_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool view_client_database_storedprocedures(out string output)
        {
            output = string.Empty;

            try
            {
                MySql_Client_Manager01.conn[index_string[index_data]].Open();
                if (MySql_Client_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.view_client_database_storedprocedures].CommandType = CommandType.Text;
                    using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.view_client_database_storedprocedures].ExecuteReader())
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
                if (MySql_Client_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Client_Manager01.conn[index_string[index_data]].Close();
                }
            }
            return status;
        }
        public bool find_client_logo_by_logo(string input, out string output)
        {
            MySql_Client_Manager01.conn[index_string[index_data]].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_logo].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_logo].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_logo].Parameters.AddWithValue("p_client_logo", input);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_logo_by_logo].ExecuteReader())
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
            MySql_Client_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_client_zellaappdata01_by_zellaappdata01(string input, out string output)
        {
            MySql_Client_Manager01.conn[index_string[index_data]].Open();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].CommandType = CommandType.StoredProcedure;
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].Parameters.Clear();
            MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].Parameters.AddWithValue("@client_zelleappdata01", input);
            using (MySqlDataReader reader = MySql_Client_Manager01.cmd[(int)MySql_Client_Manager01.command_strings.find_client_zellaappdata01_by_zellaappdata01].ExecuteReader())
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
            MySql_Client_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
    }
}
