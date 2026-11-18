using EASYPROJECT01.EASY_CALLENDER01.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SPORTS_MANAGER.SQLITE_NBA_MANAGER
{
    public class Sqlite_Nba_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"NBA01.db")
        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0])

        };

        public Sqlite_Nba_Manager01()
        {
            db[0].CreateTable<Nba_Get_Model01>();
    
        }

        public static SQLiteConnection data01 = db[0];
    }
}
