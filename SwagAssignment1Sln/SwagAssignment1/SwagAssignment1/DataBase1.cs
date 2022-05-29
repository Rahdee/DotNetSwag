using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SwagAssignment1
{
    public class DataBase1
    {
        private readonly SQLiteAsyncConnection _database;

        public DataBase1( string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<PersonClass1>();
        }

        public Task<List<PersonClass1>> GetPeopleAsync()
        { 
            return _database.Table<PersonClass1>().ToListAsync();
        }

        public Task<int> SavePersonAsynch(PersonClass1 person)
        {
            return _database.InsertAsync(person);
        }
    }
}
