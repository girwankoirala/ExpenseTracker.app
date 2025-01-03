using Microsoft.EntityFrameworkCore;
using ExpenseTracker.app.Model;

namespace ExpenseTracker.app.Service
{
    public class ExpenseTrackerDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options) { }
    }
}
