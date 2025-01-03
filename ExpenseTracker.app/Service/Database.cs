using Dapper;
using System.Data.SQLite;

namespace ExpenseTracker.app.Service
{
    internal class Database : IDatabase
    {
        string dbPath = "C:\\Users\\girwa\\source\\repos\\ExpenseTracker.app\\SQLLitedb.db";

        public async Task CreateDatabaseTables()
        {
            try
            {
                using SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + dbPath);
                await sQLiteConnection.OpenAsync();

                string CreateTableScript = @"CREATE TABLE IF NOT EXISTS Tag (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    TagName VARCHAR(255) NOT NULL,
                    TagDescription TEXT
                );";

                // Ensure the table is created
                await sQLiteConnection.ExecuteAsync(CreateTableScript);
            }
            catch (Exception ex)
            {
                // Handle the exception properly here
                Console.WriteLine($"Error creating table: {ex.Message}");
            }
        }

        public SQLiteConnection GetSQLiteConnection()
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + dbPath);
            sQLiteConnection.Open();
            return sQLiteConnection;
        }
    }
}
