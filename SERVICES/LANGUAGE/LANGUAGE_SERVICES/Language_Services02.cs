using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_SET_MODEL;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
//https://rapidapi.com/lvwzhen/api/openl-translate/playground/apiendpoint_71403770-db20-46f4-9eb1-e23406269811
namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES
{
    public class Language_Services02
    {
        private static Read_Textfiles READ = new Read_Textfiles();
        private string[] data01 = new string[100];
       private List<string> translatedText = new List<string>();
           

    
        public async Task<string> Translate_text(string input01, string input02)
        {
            return await translate_data01("https://openl-translate.p.rapidapi.com/translate",input01,input02,0);
        }
        public async Task<string> Translate_image(string input01, string input02)
        {
            return await translate_data01("https://openl-translate.p.rapidapi.com/translate/image", input01, input02,1);
        }

        public async Task<string> Translate_speech(string input01, string input02)
        {
            return await translate_data01("https://openl-translate.p.rapidapi.com/translate/speech", input01, input02, 2);
        }

        public async Task<string> Bulk_translate_text(string input01, string input02)
        {
            return await translate_data01("https://openl-translate.p.rapidapi.com/translate/bulk", input01, input02, 0);
        }
        private async Task<string> translate_data01(string input01, string input02, string input03,int index)
        {

            string[] stringcontentArray =
          {
    $"{{\"target_lang\":\"{input02.Trim().ToLower()}\",\"text\":\"{input03}\"}}",
    $"{{\"target_lang\":\"{input02.Trim().ToLower()}\",\"url\":\"{input03}\"}}",
    $"{{\"target_lang\":\"{input02.Trim().ToLower()}\",\"url\":\"{input02.Trim().ToLower()}\",\"output_format\":\"plaintext\"}}"

};


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01.Trim()),
                Headers =
    {
        { "x-rapidapi-key", READ.API[0].Trim()},
        { "x-rapidapi-host", "openl-translate.p.rapidapi.com" },
    },
                Content = new StringContent(stringcontentArray[index].Trim())
                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Language_Get_Model07.Root? resaults= JsonConvert.DeserializeObject<Language_Get_Model07.Root>(body);
                return resaults.translatedText;
            }
        }






    }
}
