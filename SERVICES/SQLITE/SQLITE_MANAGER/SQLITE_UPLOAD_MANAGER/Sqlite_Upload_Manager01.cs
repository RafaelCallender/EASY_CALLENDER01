using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_UPLOAD_MODEL;
using SQLite;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_UPLOAD_MANAGER
{
    public class Sqlite_Upload_Manager01
    {
        private static string dbPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "UPLOAD01.db"
    );

        private static SQLiteConnection db = new SQLiteConnection(dbPath);

        public static SQLiteConnection data01 = db;


        static Sqlite_Upload_Manager01()
        {
            db.CreateTable<Sqlite_Upload_Model01>();
        }
    }
}
