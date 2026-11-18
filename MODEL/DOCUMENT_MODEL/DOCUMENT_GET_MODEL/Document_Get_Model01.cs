
namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.DOCUMENT_MODEL.DOCUMENT_GET_MODEL

{
    internal class Document_Get_Model01
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public string filename { get; set; } = string.Empty;
            public string filelocation { get; set; } = string.Empty;
            public string filetext { get; set; } = string.Empty;
        }

    }
}
