using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER_MANAGER
{

    public class Sqlite_User_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"User01.db"),//user info
                                        
        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0]),
                                            
        };

        public Sqlite_User_Manager01()
        {
            db[0].CreateTable<Sqlite_User_Get_Model01>();
  

        }

        public static SQLiteConnection[] data01 = { db[0],
                                                

        };
        public enum command_strings
        {
            User01=0,
     
        }


    }
}
