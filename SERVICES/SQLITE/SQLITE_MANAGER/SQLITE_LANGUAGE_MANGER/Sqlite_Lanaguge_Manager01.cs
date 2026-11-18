using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_LANGUAGE_MODEL.SQLITE_LANGUAGE_GET_MODEL;




namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_LANGUAGE_MANGER
{
    public class Sqlite_Lanaguge_Manager01
    {
        private static string[] dbPath_ ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"LANGUAGE01.db")
,
        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath_[0]),


        };

        public Sqlite_Lanaguge_Manager01()
        {
            db[0].CreateTable<Sqlite_Language_Get_Model01>();

        }

        public static SQLiteConnection[] data01 = { db[0] };


        public static string[] Data_Path => dbPath_;
    }
}
