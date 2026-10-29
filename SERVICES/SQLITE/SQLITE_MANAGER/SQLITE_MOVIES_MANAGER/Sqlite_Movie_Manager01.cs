using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_MOVIES_MODEL.SQLITE_MOVIES_GET_MODEL;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

        
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_MOVIES_MANAGER
{
    public class Sqlite_Movie_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"MOVIES01.db"),
                           

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0])
                                                 

        };

        public Sqlite_Movie_Manager01()
        {
            db[0].CreateTable<Sqlite_Movies_Get_Model01>();
     
        }

        public static SQLiteConnection data01 = db[0];

    }
}
