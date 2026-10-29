using SQLite;


namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_UPLOAD_MODEL
{
    [Table("Upload_Table01")]
    internal class Sqlite_Upload_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string OriginalName { get; set; } = string.Empty;
        public string StoredName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public string UploadDate { get; set; } = string.Empty;
    }
}
