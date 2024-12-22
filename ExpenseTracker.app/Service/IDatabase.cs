
using ExpenseTracker.app.Model;
using System.Data.SQLite;

namespace ExpenseTracker.app.Service
{
    public interface IDatabase
    {
        public Task CreateDatabaseTables();
        public SQLiteConnection GetSQLiteConnection();
    }
}
