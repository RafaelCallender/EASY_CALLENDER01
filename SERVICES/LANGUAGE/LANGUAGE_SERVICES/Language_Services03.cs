
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;

namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES
{
    public class Language_Services03
    {
        private static Read_Textfiles READ = new Read_Textfiles();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static Ai_Text_To_Text06 Ai_Text_To_T06 = new Ai_Text_To_Text06();

        private static Language_Services01 Language_Serv01 = new Language_Services01(); 
        public async Task<string> Translate_using_Ai(string input, string input01)
        {
            string select_lang = input.Trim();
            string detct_lang = await Language_Serv01.Detect_Language(input01);
            return await Ai_Text_To_T06.text_to_text_translate01(detct_lang.Trim(), select_lang.Trim(), input01.Trim());

        }




    }
}
