using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_LANGUAGE_MODEL.SQLITE_LANGUAGE_GET_MODEL
{
    [Table("LangugeTable01")]
    internal class Sqlite_Language_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string code { get; set; } = string.Empty;
        public string language { get; set; } = string.Empty;
    }
}