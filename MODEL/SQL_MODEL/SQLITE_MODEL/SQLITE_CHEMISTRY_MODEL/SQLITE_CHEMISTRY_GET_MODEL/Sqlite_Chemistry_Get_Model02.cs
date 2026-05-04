using SQLite;

namespace EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL
{
    [Table("Chemistry02")]
    internal class Sqlite_Chemistry_Get_Model02
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Alkali_Metals { get; set; }= string.Empty;
        public string Alkaline_Earth_Metals { get; set; } = string.Empty;
        public string Transition_Metals { get; set; } = string.Empty;
        public string Lanthanides_Rare_Earth_Metals { get; set; } = string.Empty;
        public string Noble_Gases { get; set; } = string.Empty;
        public string Actinides { get; set; } = string.Empty;
        public string Nonmetal_Gases_at_Room_Temperature { get; set; } = string.Empty; 
    }
}
