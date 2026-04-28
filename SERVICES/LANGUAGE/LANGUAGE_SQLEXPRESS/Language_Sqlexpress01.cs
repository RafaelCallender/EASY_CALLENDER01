using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SQLEXPRESS
{
    public class Language_Sqlexpress01
    {
        private static Sql_Language_Services01 Sql_Serv01 = new Sql_Language_Services01();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        private string update_language_sql()
        {

            string output = string.Empty;
            for (int i = 0; i < Language_H01.code.Count; i++)
            {
                var results = Sql_Serv01.insert_language(Language_H01.language[i], Language_H01.code[i], out output);
            }

            return output;      


        }
        public string pick_language_using_sql(string input) //needs work 
        {
            string output = string.Empty;
            var results01 = Sql_Serv01.find_code_using_code(input, out output);

            var results02 = Sql_Serv01.find_code_using_language(input, out output);


            return output;
        }
    }
}