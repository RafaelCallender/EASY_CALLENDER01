using EASYPROJECT01.EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CLIENT_MODEL.SQLITE_CLIENT_GET_MODEL;
using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_CLIENTS_MANAGER
{
    public class Sqlite_Client_Manager01
    {
        private static string[] dbPath_ ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CLIENT01.db")
         
        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath_[0])
                                   
        };
        public Sqlite_Client_Manager01()
        {
            db[0].CreateTable<Sqlite_Client_Get_Model01>();
     
        }
        public static SQLiteConnection data01 = db[0];
        public static string[] Data_Path => dbPath_;

    }
}
