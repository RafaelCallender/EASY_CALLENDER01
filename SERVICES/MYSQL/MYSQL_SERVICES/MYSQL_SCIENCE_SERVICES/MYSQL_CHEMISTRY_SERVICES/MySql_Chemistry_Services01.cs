using EASY_CALLENDER01.MODEL.SQL_MODEL.SQL_MODEL.SQL_CHEMISTRY_MODEL.SQL_CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CHEMISTRY;
using MySql.Data.MySqlClient;  
using System.Data;


namespace EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES
{

    public class MySql_Chemistry_Services01
    {
        private bool status = false;
        private string output = string.Empty;   
        private static string[] data01 = new string[3];
        private List<string> Alkali_Metals = new List<string>();
        private List<string> Alkaline_Earth_Metals = new List<string>();
        private List<string> Transition_Metals = new List<string>();
        private List<string> Lanthanides_Rare_Earth_Metals = new List<string>();
        private List<string> Noble_Gases = new List<string>();
        private List<string> Actinides = new List<string>();
        private List<string> Nonmetal_Gases_at_Room_Temperature = new List<string>();
    




        public bool insert_element_category(string input01, string input02, string input03, string input04,
                                         string input05, string input06, string input07, out string output)
        {

            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].CommandType = CommandType.StoredProcedure;
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Alkali_Metals", input01);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Alkaline_Earth_Metals", input02);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Transition_Metals", input03);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Lanthanides_Rare_Earth_Metals", input04);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Noble_Gases", input05);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Actinides", input06);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].Parameters.AddWithValue("@Nonmetal_Gases_at_Room_Temperature", input07);
            int rowsAffected = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_catagory_type].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }

            else
            {
                output = "failed";
                status= false;      
            }

            MySql_Chemistry_Manager01.conn[0].Close();
            return status;

        }

        public async Task<string> find_Alkali_Metals()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Alkali_Metals].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Alkali_Metals].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Alkali Metals: {reader.GetString(1)}\n";
                    Alkali_Metals.Add(reader["Alkali_Metals"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
     
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }


        public async Task<string> Find_Actinides()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.Find_Actinides].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.Find_Actinides].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Actinides: {reader.GetString(1)}\n";
                    Actinides.Add(reader["Actinides"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
                 
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }

        public async Task<string> find_Alkaline_Earth_Metals()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Alkaline_Earth_Metals].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Alkaline_Earth_Metals].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {



                    data01[0] += $"Alkaline Earth Metals: {reader.GetString(1)}\n";
                    Alkaline_Earth_Metals.Add(reader["Alkaline_Earth_Metals"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
               
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
        public async Task<string> find_Lanthanides_Rare_Earth_Metals()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Lanthanides_Rare_Earth_Metals].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Lanthanides_Rare_Earth_Metals].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {



                    data01[0] += $"Lanthanides Rare Earth Metals: {reader.GetString(1)}\n";
                    Lanthanides_Rare_Earth_Metals.Add(reader["Lanthanides_Rare_Earth_Metals"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
                 
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
        public async Task<string> find_Noble_Gases()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Noble_Gases].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Noble_Gases].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Noble Gases: {reader.GetString(1)}\n";
                    Noble_Gases.Add(reader["Noble_Gases"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
             
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
        public async Task<string> find_Nonmetal_Gases_at_Room_Temperature()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Nonmetal_Gases_at_Room_Temperature].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Nonmetal_Gases_at_Room_Temperature].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Nonmetal Gases at Room Temperature: {reader.GetString(1)}\n";
                    Nonmetal_Gases_at_Room_Temperature.Add(reader["Nonmetal_Gases_at_Room_Temperature"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
             
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
        public async Task<string> find_Transition_Metals()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Transition_Metals].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_Transition_Metals].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Transition Metals: {reader.GetString(1)}\n";
                    Transition_Metals.Add(reader["Transition_Metals"]?.ToString() ?? string.Empty);
                    var collection_set = new Sql_Chemistry_Get_Model01
                    {

                    };
           
                }

            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
        public async Task<string> view_catagory_type()
        {
            MySql_Chemistry_Manager01.conn[0].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_catagory_type].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_catagory_type].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Alkali Metals: {reader.GetString(1)}\n" +
                                 $"Alkaline Earth Metals: {reader.GetString(2)}\n" +
                                 $"Transition Metals: {reader.GetString(3)}\n" +
                                 $"Lanthanides Rare Earth Metals: {reader.GetString(4)}\n" +
                                 $"Noble Gases: {reader.GetString(5)}\n" +
                                 $"Actinides: {reader.GetString(6)}\n" +
                                 $"Nonmetal Gases at Room Temperature: {reader.GetString(7)}\n";
                }
            }
            MySql_Chemistry_Manager01.conn[0].Close();
            return data01[0];
        }
    }
}