using EASYPROJECT01.EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;




namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER
{
    public class Language_Helper01
    {
   
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
            string []a = File_Manger01.Language_Abbreviation.Split("\n");
             string []b = File_Manger01.Language_Name.Split("\n");
            for (int i = 0; i < a.Length; i++)
            {
                code.Add(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                language.Add(b[i]);
            }
        }
    }
}