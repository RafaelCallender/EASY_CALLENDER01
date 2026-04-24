
namespace EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL
{
    internal class Chemistry_Get_Model01
    {
        public int atomic_number { get; set; }
        public string element_name { get; set; } = string.Empty;
        public string element_symboles { get; set; } = string.Empty;
        public double atomic_mass { get; set; }
        public int electons { get; set; }
        public int protons { get; set; }
        public int neutrons { get; set; }
        public string SqlExpressOutString{get;set;}= string.Empty;
          public string SqliteOutString{get;set;}= string.Empty;
            public string MySqlOutString{get;set;}= string.Empty;
    }
}