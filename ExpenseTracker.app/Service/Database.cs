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
                SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + dbPath);
                sQLiteConnection.Open();
                string CreateTableScript = @"CREATE TABLE Tag (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TagName VARCHAR(255) NOT NULL,
    TagDescription TEXT
);
";


                var result = sQLiteConnection.ExecuteAsync(CreateTableScript);
            } catch(Exception ex)
            {

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
