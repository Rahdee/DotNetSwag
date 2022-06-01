using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using SQLite;
// using Todo.Models;
​
namespace OrderedItemsDatabase
{
    public class OrderedItemsDataBase1
    {
        static SQLiteConnection Database;
​
        public static OrderedItemsDataBase1 Instance
        {
            get
            {
                var instance = new OrderedItemsDataBase1();
                CreateTableResult result = Database.CreateTable<OrderedItemsDataBase1>();
                return instance;
            }
        }

        public int ID { get; private set; }

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
​​
        public OrderedItemsDataBase1()
        {
            Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        }
​
        public List<OrderedItemsDataBase1> GetItems()
        {
            return Database.Table<OrderedItemsDataBase1>().ToList();
        }
​
        public List<OrderedItemsDataBase1> GetItemsNotDone()
        {
            return Database.Query<OrderedItemsDataBase1>("SELECT * FROM [OrederedItems] WHERE [Done] = 0");
        }
​
        public OrderedItemsDataBase1 GetItem(int id)
        {
            return Database.Table<OrderedItemsDataBase1>().Where(i => i.ID == id).FirstOrDefault();
        }
​
        public int SaveItem(OrderedItemsDataBase1 item)
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
​
        public int DeleteItem(OrderedItemsDataBase1 item)
        {
            return Database.Delete(item);
        }
    }
}
