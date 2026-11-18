using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_LANGUAGE_MODEL.SQLITE_LANGUAGE_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_LANGUAGE_MANGER;
using SQLite;



namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_LANGUAGE_SERVICES
{
    public class Sqlite_Language_Services01
    {
        private static string[] data01 = new string[100];
        public bool find_code_using_code(string input, out string output)
        {
            var res = Sqlite_Lanaguge_Manager01.data01[0].Table<Sqlite_Language_Get_Model01>()
               .Where(i => i.code == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.code.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_code_using_language(string input, out string output)
        {
            var res = Sqlite_Lanaguge_Manager01.data01[0].Table<Sqlite_Language_Get_Model01>()
                .Where(i => i.language == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.code.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_language_using_code(string input, out string output)
        {
            var res = Sqlite_Lanaguge_Manager01.data01[0].Table<Sqlite_Language_Get_Model01>()
                .Where(i => i.code == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.language.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_language_using_Language(string input, out string output)
        {
            var res = Sqlite_Lanaguge_Manager01.data01[0].Table<Sqlite_Language_Get_Model01>()
                .Where(i => i.language == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.language.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool insert_language(string input01, string input02, out string output)
        {
            if (Sqlite_Lanaguge_Manager01.data01[0].Insert(
                     new Sqlite_Language_Get_Model01
                     {
                         code = input01,
                         language = input02

                     }) > 0)
            {
                output = "Data Inserted Successfully";
                return true;

            }
            else
            {

                output = "Data Insertion Failed";
                return false;


            }

        }
        public bool view_all_data_from_language_table(out string output)
        {
            output = string.Empty;
            var res = Sqlite_Lanaguge_Manager01.data01[0].Table<Sqlite_Language_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output +=
        $"{a.code.ToString()}" +
        $"{a.language.ToString()}";
            }
            return true;


        }
        public bool view_language_database_storedprocedures(out string output)
        {
            output = $"find_code_using_code\n" +
    $"find_code_using_language\n" +
    $"find_language_using_code\n" +
    $"find_language_using_Language\n" +
    $"insert_language\n" +
    $"view_all_data_from_language_table\n";
            return true;
        }
    }
}