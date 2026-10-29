using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_NEWS_MODEL.SQLITE_NEWS_GET_MODEL
{
    [Table("NewsTable01")]
    internal class Sqlite_News_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string input { get; set; }
        public string output { get; set; }
        public string error { get; set; }
        public bool success { get; set; }
    }
}
