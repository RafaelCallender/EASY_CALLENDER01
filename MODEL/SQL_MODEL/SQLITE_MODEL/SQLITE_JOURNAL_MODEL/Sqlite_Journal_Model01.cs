using SQLite;


namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_JOURNAL_MODEL
{
    [Table("Journal_Table01")]
    internal class Sqlite_Journal_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; }
        public string upload { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string creation_date { get; set; }
        public string error { get; set; }

    }
}
