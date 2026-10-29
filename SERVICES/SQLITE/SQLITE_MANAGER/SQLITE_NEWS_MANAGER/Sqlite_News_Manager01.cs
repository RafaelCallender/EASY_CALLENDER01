using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_NEWS_MODEL.SQLITE_NEWS_GET_MODEL;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQl_NEWS_MANAGER
{
    public class Sqlite_News_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"NEWS01.db")

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0])

        };

        public Sqlite_News_Manager01()
        {
            db[0].CreateTable<Sqlite_News_Get_Model01>();
        }

        public static SQLiteConnection data01 = db[0];

    }
}
