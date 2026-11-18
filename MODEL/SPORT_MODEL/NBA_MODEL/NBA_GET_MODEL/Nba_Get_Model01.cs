using SQLite;
namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    [Table("NbaTable01")]
    internal class Nba_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string input { get; set; }
        public string output { get; set; }
        public string error { get; set; }
        public bool success { get; set; }
    }
}
