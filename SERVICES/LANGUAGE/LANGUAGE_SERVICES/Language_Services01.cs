using EASY_CALLENDER01.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
//https://rapidapi.com/robust-api-robust-api-default/api/google-translate113/playground/apiendpoint_a13bd40a-5212-4f25-b997-f8bb30db6e5f
namespace EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES
{
    public class Language_Services01
    {

        private string[] data01 = new string[100];
        private List<string> trans = new List<string>();
        private List<string> source_language_code = new List<string>();
        private List<string> source_language = new List<string>();
        private List<int> trust_level = new List<int>();
        public List<string> code = new List<string>();
        public List<string> language = new List<string>();
        private List<string> source_lang = new List<string>();
        private List<int> trust_level01 = new List<int>();
        private List<string> source_lang_code = new List<string>();
        private static Read_Textfiles READ = new Read_Textfiles();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        
        
    

        private static string[] Headers_ ={ "x-rapidapi-key",READ.API[0].Trim(),
                                                 "x-rapidapi-host", "google-translate113.p.rapidapi.com" };




        public Language_Services01()
        {



        }

        public async Task<string> Tranlate_Text(string input01, string input02)
        {
            return await language_data01(input01, input02, "https://google-translate113.p.rapidapi.com/api/v1/translator/text");

        }
        public async Task<string> Batch_Translation()
        {

            return await language_data02("https://google-translate113.p.rapidapi.com/api/v1/translator/json");

        }
        public async Task<string> Translate_JSON()
        {

            return await language_data03("https://google-translate113.p.rapidapi.com/api/v1/translator/json");

        }
        public async Task<string> Translate_HTML()
        {
            return await language_data04("https://google-translate113.p.rapidapi.com/api/v1/translator/html");

        }
        public async Task<string> Detect_Language(string input01)
        {
            return await language_data05(input01, "https://google-translate113.p.rapidapi.com/api/v1/translator/detect-language");

        }
        public async Task<string> Supported_languages()
        {
            return await language_data06("https://google-translate113.p.rapidapi.com/api/v1/translator/support-languages");

        }


        private async Task<string> language_data01(string input01, string input02, string input03)
        {

            //input01= language apprivation en,vi,fr,jp,cn
            //input02= text need to translate
            string detct_lang = await Detect_Language(input02);
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(input03),
                    Headers =
    {
     { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
                    Content = new StringContent($"{{\"from\":\"{detct_lang.ToLower()}\",\"to\":\"{input01.ToLower()}\",\"text\":\"{input02.Trim()}\"}}", Encoding.UTF8, "application/json")

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
                    Language_Get_Model01.Root? resaults = JsonConvert.DeserializeObject<Language_Get_Model01.Root>(body);

                    if (resaults != null)
                    {
                        trans.Add(resaults.trans);
                        source_language_code.Add(resaults.source_language_code);
                        source_language.Add(resaults.source_language);
                        trust_level.Add(resaults.trust_level);
                    }
                    else
                    {
                        trans.Add(" ");
                        source_language_code.Add(" ");
                        source_language.Add(" ");
                        trust_level.Add(0);
                    }

                    /* data01[3] = $"{string.Join(" ", trans)}\n" +
                                 $"{string.Join(" ", source_language_code)}\n" +
                                 $" {string.Join(" ", source_language)}\n" +
                                 $"{string.Join(" ", trust_level)}";*/

                    data01[3] = $"{string.Join(" ", trans)}\n";
                }
            }
            catch (Exception ex)
            {
                data01[3] = $"{ex}\n";
            }


            return data01[3];
        }


        private async Task<string> language_data02(string input01)//needs work
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
       { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
                Content = new StringContent("{\"from\":\"auto\",\"to\":\"vi\",\"protected_paths\":[\"extra.last_comment.author\"],\"common_protected_paths\":[\"image\"],\"json\":[\"Batch Translation\",\"Mutiple Text\"]}")
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
                data01[0] = body;
                return data01[0];
            }
        }



        private async Task<string> language_data03(string input01)
        {
            object jsonToTranslate = "";
            string targetLang = "vi";
            var client = new HttpClient();

            var bodyObject = new
            {
                from = "auto",
                to = targetLang,
                protected_paths = new[] { "extra.last_comment.author" },
                common_protected_paths = new[] { "image" },
                json = jsonToTranslate
            };
            string jsonPayload = JsonConvert.SerializeObject(bodyObject);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
        {
          { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
        },
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                data01[0] = body;
            }

            return data01[0];
        }
        private async Task<string> language_data04(string input01)//idk what this does
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
         { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
                Content = new StringContent("{\"from\":\"en\",\"to\":\"vi\",\"html\":\"<ul><li>Hello</li><li>This is Translate HTML endpoint</li></ul>\"}")
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
                data01[0] = body;

            }
            return data01[0];
        }

        private async Task<string> language_data05(string input01, string input02)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input02),
                Headers =
        {
           { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
        },
                Content = new StringContent($"{{\"text\":\"{input01.Trim()}\"}}", Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Language_Get_Model04.Root? results = JsonConvert.DeserializeObject<Language_Get_Model04.Root>(body);
                source_lang.Add(results?.source_lang ?? "");
                trust_level01.Add(results.trust_level);
                source_lang_code.Add(results?.source_lang_code ?? "");
                data01[0] = $"{string.Join(" ", source_lang)}\n" +
                            $"{string.Join(" ", trust_level01)}\n" +
                            $"{string.Join(" ", source_lang_code)}";
                data01[1] = source_lang_code[0];
                return data01[1];
            }
        }
        private async Task<string> language_data06(string input01)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input01),
                Headers =
    {
       { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var resaults = JsonConvert.DeserializeObject<List<Language_Get_Model05.Root>>(body)
                               ?? new List<Language_Get_Model05.Root>();

                foreach (var a in resaults)
                {
                    code.Add(a.code);
                    language.Add(a.language);
                }

                data01[0] = $"{string.Join(" ", code)}\n" +
                            $"{string.Join(" ", language)}";


                return data01[0];
            }


        }

    }
}