using SQLite;
using SwagAssignment1;
using System.Collections.Generic;
using System.IO;

namespace OrderedItemsDatabase
{
    public static class Constants
    {
        public const string DatabaseFilename = "SwagAssignment1SQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }

    public class OrderedItemsDataBase1
    {
        static SQLiteConnection Database;
        
        public static OrderedItemsDataBase1 Instance
        {
            get
            {
                var instance = new OrderedItemsDataBase1();
                CreateTableResult result = Database.CreateTable<OrderedItems>();
                return instance;
            }
        }

        public int ID { get; set; }
        
        public List<OrderedItems> GetItems()
        {
            return Database.Table<OrderedItems>().ToList();
        }
        
        public List<OrderedItems> GetItemsNotDone()
        {
            return Database.Query<OrderedItems>("SELECT * FROM [OrederedItems] WHERE [Done] = 0");
        }
        
        public OrderedItems GetItem(int id)
        {
            return Database.Table<OrderedItems>().Where(i => i.ID == id).FirstOrDefault();
        }

        public int SaveItem(OrderedItems item)
        {
            if (item.ID != 0)
            {
                return Database.Update(item);
            }
            else
            {
                return Database.Insert(item);
            }
        }
        public int DeleteItem(OrderedItems item)
        {
            return Database.Delete(item);
        }
        
        public OrderedItemsDataBase1()
        {
            Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        }
    }
}
