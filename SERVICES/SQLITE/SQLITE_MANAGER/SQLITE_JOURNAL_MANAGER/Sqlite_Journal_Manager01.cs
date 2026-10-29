using SQLite;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_JOURNAL_MODEL;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_JOURNAL_MANAGER
{
    public class Sqlite_Journal_Manager01
    {
        private static string dbPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "JOURNAL01.db"
    );
        private static SQLiteConnection db = new SQLiteConnection(dbPath);
        public static SQLiteConnection data01 = db;
        static Sqlite_Journal_Manager01()
        {
            db.CreateTable<Sqlite_Journal_Model01>();
        }
    }
}
