using ExpenseTracker.app.Model;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.app.Service
{
    public class DatabaseService
    {
        private readonly ExpenseTrackerDbContext _dbContext;

        public DatabaseService(ExpenseTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Transaction>> GetTransactionsAsync(string type)
        {
            return await _dbContext.Transactions
                .Where(t => t.Type == type)
                .OrderByDescending(t => t.Date)
                .ToListAsync();
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            _dbContext.Transactions.Add(transaction);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<decimal> GetTotalAsync(string type)
        {
            return await _dbContext.Transactions
                .Where(t => t.Type == type)
                .SumAsync(t => t.Amount);
        }
    }
}
