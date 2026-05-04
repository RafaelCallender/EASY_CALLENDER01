using EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_CLIENTS_MANAGER
{
    public class Sqlite_Client_Maanger01
    {
        private static string[] dbPath_ ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CLIENT01.db"),
                                          Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CLIENT02.db"),

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath_[0]),
                                                 new SQLiteConnection(dbPath_[1])

        };

        public  Sqlite_Client_Maanger01()
        {
            db[0].CreateTable<Sqlite_Chemistry_Get_Model01>();
            db[1].CreateTable<Sqlite_Chemistry_Get_Model02>();
        }

        public static SQLiteConnection data01 = db[0];
        public static SQLiteConnection data02 = db[1];

public static string[] Data_Path => dbPath_; 



    }
}
