using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SCIENCE_MANAGER.SQLITE_CHEMISTRY_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES
{
    public class Sqlite_Chemistry_Services01
    {
        private static string[] data01 = new string[100];
        private static string menu_string01 = $"insert_element_category\n" +
        $"find_Alkali_Metals\n" +
        $"Find_Actinides\n" +
        $"find_Alkaline_Earth_Metals\n" +
        $"find_Lanthanides_Rare_Earth_Metals\n" +
        $"find_Noble_Gases\n" +
        $"find_Nonmetal_Gases_at_Room_Temperature\n" +
        $"find_Transition_Metals\n" +
        $"insert_element\n" +
        $"find_element_using_atomic_number\n" +
        $"find_element_using_symbol\n" +
        $"find_element_using_name\n" +
        $"view_all_elements\n";

        public static string[] menu_array01 = menu_string01.Split("\n");
        public string load_menu()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[80] += $"{i}.){menu_array01}\n";
            }
            return data01[80];
        }

        public async Task<(bool success, string output)> insert_element_category(string input01, string input02, string input03,
                                                          string input04, string input05, string input06, string input07)
        {
            var existing = Sqlite_Chemistry_Manager01.data02
.Table<Sqlite_Chemistry_Get_Model02>()
.FirstOrDefault(x => x.Alkali_Metals == input01);

            if (existing != null)
            {
                return (true, "Data already exists");

            }
            else
            {
                if (Sqlite_Chemistry_Manager01.data02.Insert(
                    new Sqlite_Chemistry_Get_Model02
                    {
                        Alkali_Metals = input01,
                        Alkaline_Earth_Metals = input02,
                        Transition_Metals = input03,
                        Lanthanides_Rare_Earth_Metals = input04,
                        Noble_Gases = input05,
                        Actinides = input06,
                        Nonmetal_Gases_at_Room_Temperature = input07,
                    }) > 0)
                {

                    return (true, "Data Inserted Successfully");
                }
                else
                {
                    return (false, "Data Insertion Failed");

                }
            }

        }
        public async Task<(bool success, string output)> find_Alkali_Metals(string input)
        {
            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Alkali_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                return (true, $"{data02.Alkali_Metals}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> Find_Actinides(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Actinides == input).FirstOrDefault();
            if (data02 != null)
            {
                return (true, $"{data02.Actinides}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> find_Alkaline_Earth_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Alkaline_Earth_Metals == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.Alkaline_Earth_Metals}\n");
            }
            else
            {

                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> find_Lanthanides_Rare_Earth_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Lanthanides_Rare_Earth_Metals == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.Lanthanides_Rare_Earth_Metals}\n");
            }
            else
            {

                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> find_Noble_Gases(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Noble_Gases == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.Noble_Gases}\n");
            }
            else
            {

                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> find_Nonmetal_Gases_at_Room_Temperature(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Nonmetal_Gases_at_Room_Temperature == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.Nonmetal_Gases_at_Room_Temperature}\n");
            }
            else
            {

                return (false, $"Data Not Found");
            }
        }

        public async Task<(bool success, string output)> find_Transition_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data02.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Transition_Metals == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.Transition_Metals}\n");
            }
            else
            {

                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool success, string output)> insert_element(int input01, string input02, string input03,
                                                    double input04, int input05, int input06,
                                                    int input07)
        {
            var existing = Sqlite_Chemistry_Manager01.data01
        .Table<Sqlite_Chemistry_Get_Model01>()
        .FirstOrDefault(x => x.atomic_number == input01);

            if (existing != null)
            {
                return (true, "Data already exists");
            }
            else
            {
                if (Sqlite_Chemistry_Manager01.data01.Insert(
               new Sqlite_Chemistry_Get_Model01
               {
                   atomic_number = input01,
                   element_name = input02,
                   element_symboles = input03,
                   atomic_mass = input04,
                   protons = input05,
                   electons = input06,
                   neutrons = input07
               }) > 0)
                {

                    return (true, "Data Inserted Successfully");

                }
                else
                {
                    return (false, $"Data Not Found");

                }
            }


        }
        public async Task<(bool success, string output)> find_element_using_atomic_number(int input)
        {
            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.atomic_number == input).FirstOrDefault();
            if (data02 != null)
            {

                return (true, $"{data02.atomic_number.ToString()}\n" +
                              $"{data02.element_name}\n" +
                              $"{data02.element_symboles}\n" +
                              $"{data02.atomic_mass.ToString()}\n" +
                              $"{data02.protons.ToString()}\n" +
                              $"{data02.electons.ToString()}\n" +
                              $"{data02.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool success, string output)> find_element_using_symbol(string input)
        {
            var data03 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.element_symboles == input).FirstOrDefault();
            if (data03 != null)
            {
                return (true, $"{data03.atomic_number.ToString()}\n" +
                                  $"{data03.element_name}\n" +
                                  $"{data03.element_symboles}\n" +
                                  $"{data03.atomic_mass.ToString()}\n" +
                                  $"{data03.protons.ToString()}\n" +
                                  $"{data03.electons.ToString()}\n" +
                                  $"{data03.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool success, string output)> insert_catagory_type(string input01, string input02, string input03,
                                           string input04, string input05, string input06,
                                           string input07)
        {
            var existing = Sqlite_Chemistry_Manager01.data01
        .Table<Sqlite_Chemistry_Get_Model02>()
        .FirstOrDefault(x => x.Alkali_Metals == input01);

            if (existing != null)
            {
                return (true, "Data already exists");
            }
            else
            {
                if (Sqlite_Chemistry_Manager01.data01.Insert(
               new Chemistry_Get_Model02
               {

                   Alkali_Metals = input01,
                   Alkaline_Earth_Metals = input02,
                   Transition_Metals = input03,
                   Lanthanides_Rare_Earth_Metals = input04,
                   Noble_Gases = input05,
                   Actinides = input06,
                   Nonmetal_Gases_at_Room_Temperature = input07
               }) > 0)
                {

                    return (true, "Data Inserted Successfully");

                }
                else
                {
                    return (false, $"Data Not Found");

                }
            }


        }
        public async Task<(bool success, string output)> find_element_using_name(string input)
        {
            var data04 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.element_name == input).FirstOrDefault();
            if (data04 != null)
            {
                return (true, $"{data04.atomic_number.ToString()}\n" +
                                       $"{data04.element_name}\n" +
                                       $"{data04.element_symboles}\n" +
                                       $"{data04.atomic_mass.ToString()}\n" +
                                       $"{data04.protons.ToString()}\n" +
                                       $"{data04.electons.ToString()}\n" +
                                       $"{data04.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool success, string output)> view_all_elements()
        {
            string res = "";
            var data05 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>().ToList();
            foreach (var a in data05)
            {
                res += $"{a.atomic_number.ToString()}\n" +
                       $"{a.element_name}\n" +
                       $"{a.element_symboles}\n" +
                       $"{a.atomic_mass.ToString()}\n" +
                       $"{a.protons.ToString()}\n" +
                       $"{a.electons.ToString()}\n" +
                       $"{a.neutrons.ToString()}\n\n";


            }
            return (true, res);
        }
        public async Task<(bool success, string output)> view_catagory_type()
        {
            string res = "";
            var data05 = Sqlite_Chemistry_Manager01.data01.Table<Chemistry_Get_Model02>().ToList();
            foreach (var a in data05)
            {
                res +=
                   $"{a.Alkali_Metals}\n" +
                   $"{a.Alkaline_Earth_Metals}\n" +
                   $"{a.Transition_Metals}\n" +
                   $"{a.Lanthanides_Rare_Earth_Metals}\n" +
                   $"{a.Noble_Gases}\n" +
                   $"{a.Actinides}\n" +
                   $"{a.Nonmetal_Gases_at_Room_Temperature}\n";


            }
            return (true, res);
        }


        public bool view_chemistry_database_storedprocedures(out string input)
        {
            input = menu_string01;
            return true;
        }
    }
}
