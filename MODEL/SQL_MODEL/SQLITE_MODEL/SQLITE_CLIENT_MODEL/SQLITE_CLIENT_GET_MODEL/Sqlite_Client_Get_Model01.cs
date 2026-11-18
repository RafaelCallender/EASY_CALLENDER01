using SQLite;

namespace EASYPROJECT01.EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CLIENT_MODEL.SQLITE_CLIENT_GET_MODEL
{
    [Table("ClientTable01")]
    internal class Sqlite_Client_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string client_name { get; set; } = string.Empty;
        public string client_emailaddress { get; set; } = string.Empty;
        public string client_phonenumber { get; set; } = string.Empty;
        public string client_api_key { get; set; } = string.Empty;
        public string client_cashappdata01 { get; set; } = string.Empty;
        public string client_zelleappdata01 { get; set; } = string.Empty;
        public string client_venmoappdata01 { get; set; } = string.Empty;
        public string client_paypalappdata01 { get; set; } = string.Empty;
        public string client_logo { get; set; } = string.Empty;
        public string client_latitude { get; set; } = string.Empty;
        public string client_longitude { get; set; } = string.Empty;
        public string client_primary_color { get; set; } = string.Empty;
        public string client_secondary_color { get; set; } = string.Empty;
        public string client_tertiary_color { get; set; } = string.Empty;
        public string client_social_media { get; set; } = string.Empty;
        public string client_type { get; set; } = string.Empty;
        public string client_date_created { get; set; } = string.Empty;


    }
}
