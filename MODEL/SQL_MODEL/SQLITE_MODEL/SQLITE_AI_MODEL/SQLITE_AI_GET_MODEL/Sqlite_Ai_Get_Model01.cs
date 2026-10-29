using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_AI_MODEL.SQLITE_AI_GET_MODEL
{
    [Table("Ai01")]
    internal class Sqlite_Ai_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string input { get; set; }
        public string output { get; set; }
        public string error { get; set; }
        public bool success { get; set; }
    }
}
