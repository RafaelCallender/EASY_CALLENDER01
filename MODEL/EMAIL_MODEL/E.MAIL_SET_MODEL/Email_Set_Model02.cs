namespace EASY_CALLENDER01.MODEL.AI_MODEL.AI_TEXT_TO_TEXT.GET_MODEL
{
    public class Installed
    {
        public string client_id { get; set; } = string.Empty;
        public string project_id { get; set; } = string.Empty;
        public string auth_uri { get; set; } = string.Empty;
        public string token_uri { get; set; } = string.Empty;
        public string auth_provider_x509_cert_url { get; set; } = string.Empty;
        public string client_secret { get; set; } = string.Empty;
        public List<string> redirect_uris { get; set; } = new List<string>();

        public class Root
        {
            public Installed installed { get; set; } = new Installed();
        }
    }


}
