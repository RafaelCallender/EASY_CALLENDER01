using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;  

namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_TEXTFILES
{
    public class Language_Textfiles01
    {
        private static Read_Textfiles READ = new Read_Textfiles();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        private List<string> lowercase01 = new List<string>();
        private List<string> lowercase02 = new List<string>();
        private static Security_Services01 Security_Serv01 = new Security_Services01();         
        public string view_language_using_text_file()
        {

            return $"{string.Join("\n", Language_H01.language)}\n";
        }

        public string pick_languge_using_text_file(string input)

        {

            string lowerInput = input.Trim().ToLower();
            string output = string.Empty;       

            for (int i = 0; i < READ.Language_Name.Length; i++)

            {

                lowercase01.Add(READ.Language_Name[i].Trim().ToLower());

                lowercase02.Add(READ.Language_Abbreviation[i].Trim().ToLower());

            }



            if (lowercase01.Contains(lowerInput))

            {

                int index = lowercase01.IndexOf(lowerInput);

                return lowercase01[index];

            }

            else if (lowercase02.Contains(lowerInput))

            {

                int index = lowercase01.IndexOf(lowerInput);

                return lowercase01[index];

            }

            else if (Security_Serv01.string_only_digit(lowerInput, out output))

            {

                int inputIndex = int.Parse(lowerInput);

                if (inputIndex >= 0 && inputIndex < lowercase01.Count)

                {

                    return lowercase01[inputIndex];

                }

            }

            return "cant find";
        }


    }
}