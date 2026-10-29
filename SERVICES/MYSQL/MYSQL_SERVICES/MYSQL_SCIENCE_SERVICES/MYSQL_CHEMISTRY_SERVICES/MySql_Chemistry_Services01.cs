using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQL_MODEL.SQL_CHEMISTRY_MODEL.SQL_CHEMISTRY_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL.MYSQL_MANAGER.MYSQL_MANAGER_CHEMISTRY;
using MySql.Data.MySqlClient;
using System.Data;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES
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
        private List<int> atomic_number = new List<int>();
        private List<string> element_name = new List<string>();
        private List<string> element_symboles = new List<string>();
        private List<string> atomic_mass = new List<string>();
        private List<int> protons = new List<int>();
        private List<int> electons = new List<int>();
        private List<int> neutrons = new List<int>();
        private static int index_data = 0;
        private int[] index_string = {
    (int)MySql_Chemistry_Manager01.connection_strings.connection01,
    (int)MySql_Chemistry_Manager01.connection_strings.connection02,
    (int)MySql_Chemistry_Manager01.connection_strings.connection03};


        public bool insert_element_category(string input01, string input02, string input03, string input04,
                                         string input05, string input06, string input07, out string output)
        {

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
                status = false;
            }

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return status;

        }

        public async Task<string> find_Alkali_Metals()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }


        public async Task<string> Find_Actinides()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }

        public async Task<string> find_Alkaline_Earth_Metals()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public async Task<string> find_Lanthanides_Rare_Earth_Metals()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public async Task<string> find_Noble_Gases()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public async Task<string> find_Nonmetal_Gases_at_Room_Temperature()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public async Task<string> find_Transition_Metals()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public async Task<string> view_catagory_type()
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
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
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[0];
        }
        public bool insert_element(int input01, string input02,
                                    string input03, double input04,
                                    int input05, int input06, int input07, out string output)
        {
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.Clear();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].CommandType = CommandType.StoredProcedure;
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@atomic_number", input01.ToString());
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@element_name", input02);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@element_symboles", input03);
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@atomic_mass", input04.ToString());
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@protons ", input05.ToString());
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@electons", input06.ToString());
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@neutrons", input07.ToString());
            object result = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.insert_element].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                output = "Record already exists";
                status = true;
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                output = "success";
                status = true;
            }
            else
            {

                output = "Unknown result from database";
                status = false;
            }

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public bool find_element_using_name(string input, out string output)
        {

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_name].CommandType = CommandType.StoredProcedure;
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_name].Parameters.Clear();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_name].Parameters.AddWithValue("@element_name", input);
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),

                    };


                    status = true;
                }
                else
                {
                    output = "failed";
                    status = false;
                }
            }
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return status;
        }

        public bool find_element_using_atomic_number(string input, out string output)
        {

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].CommandType = CommandType.StoredProcedure;
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].Parameters.Clear();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].Parameters.AddWithValue("@atomic_number", input);
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };

                    status = true;
                }
                else
                {
                    output = "failed";
                    status = false;
                }
            }
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return (status);
        }

        public bool find_element_using_symbol(string input, out string output)
        {

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_symbol].CommandType = CommandType.StoredProcedure;
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_symbol].Parameters.Clear();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_symbol].Parameters.AddWithValue("@element_symboles", input.Trim());
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.find_element_using_symbol].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };


                }
                else
                {
                    output = "failed";

                }
            }
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return status;
        }
        public string view_all_elements()
        {

            MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
            MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_all_elements].CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_all_elements].ExecuteReader())
            {
                while (reader.Read())
                {
                    atomic_number.Add(int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty));
                    element_name.Add(reader["element_name"]?.ToString() ?? string.Empty);
                    element_symboles.Add(reader["element_symboles"]?.ToString() ?? string.Empty);
                    atomic_mass.Add(reader["atomic_mass"]?.ToString() ?? string.Empty);
                    protons.Add(int.Parse(reader["protons"]?.ToString() ?? string.Empty));
                    electons.Add(int.Parse(reader["electons"]?.ToString() ?? string.Empty));
                    neutrons.Add(int.Parse(reader["neutrons"]?.ToString() ?? string.Empty));
                    data01[0] += $"{reader["atomic_number"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["element_name"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["element_symboles"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["atomic_mass"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["protons"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["electons"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["neutrons"]?.ToString() ?? string.Empty}\n";




                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };

                }
            }
            data01[0] += $"{string.Join(" ", atomic_number)}\n" +
                         $"{string.Join(" ", element_name)}\n" +
                         $"{string.Join(" ", element_symboles)}\n" +
                         $"{string.Join(" ", atomic_mass)}\n" +
                         $"{string.Join(" ", protons)}\n" +
                         $"{string.Join(" ", electons)}\n" +
                         $"{string.Join(" ", neutrons)}\n";
            MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
            return data01[1];
        }
        public bool view_chemistry_database_storedprocedures(out string output)
        {

            output = string.Empty;
            try
            {
                MySql_Chemistry_Manager01.conn[index_string[index_data]].Open();
                MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_chemistry_database_storedprocedures].CommandType = CommandType.Text;
                using (MySqlDataReader reader = MySql_Chemistry_Manager01.cmd[(int)MySql_Chemistry_Manager01.command_strings.view_chemistry_database_storedprocedures].ExecuteReader())
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
                MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();

            }
            catch (Exception ex)
            {
                output = ex.Message;
                status = false;
            }
            finally
            {
                if (MySql_Chemistry_Manager01.conn[index_string[index_data]].State == ConnectionState.Open)
                {
                    MySql_Chemistry_Manager01.conn[index_string[index_data]].Close();
                }
            }
            return status;
        }

    }
}

