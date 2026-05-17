using EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_EMAIL_MODEL;
using SQLite;

namespace EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_EMAIL_MANAGER
{
    public class Sqlite_Email_Manager01
    {
        private static string dbPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "EMAIL01.db"
    );

    private static SQLiteConnection db = new SQLiteConnection(dbPath);

    public static SQLiteConnection data01 = db;

    
    static Sqlite_Email_Manager01()
    {
        db.CreateTable<Sqlite_Email_Model01>();
    }
    }
}
