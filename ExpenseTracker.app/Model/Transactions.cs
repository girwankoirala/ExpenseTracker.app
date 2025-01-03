namespace ExpenseTracker.app.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Type { get; set; } // e.g., Income, Expense, Debt
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
