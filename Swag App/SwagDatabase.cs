using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using Swag_App;

namespace Swag_App
{
    public class SwagDatabase
    {
        private SQLiteConnection _database;

        public static SwagDatabase Instance = new SwagDatabase();

        public SwagDatabase()
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string filePath = Path.Combine(path, "swagdata.db");

            _database = new SQLiteConnection(filePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<SwagItem>();

        }

        public List<SwagItem>  GetSwagItems()
        {
            return _database.Table<SwagItem>().ToList();

        }


        public void SaveSwagItem(SwagItem item)
        {

            _database.Insert(item);
        }

    }
}
