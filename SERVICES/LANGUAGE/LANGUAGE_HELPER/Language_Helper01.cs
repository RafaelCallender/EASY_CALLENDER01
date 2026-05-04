using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;





namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER
{
    public class Language_Helper01
    {
        private static Read_Textfiles READ = new Read_Textfiles();
        private string[] data01 = new string[100];
        public List<string> code = new List<string>();
        public List<string> language = new List<string>();
        public string[] data_array01 = { "Tranlate Text", "select language" };
        public Language_Helper01()
        {
            load_language_data();
        }

        private void load_language_data()
        {
            for (int i = 0; i < READ.Language_Abbreviation.Length; i++)
            {
                code.Add(READ.Language_Abbreviation[i]);
            }
            for (int i = 0; i < READ.Language_Name.Length; i++)
            {
                language.Add(READ.Language_Name[i]);
            }
        }
    }
}