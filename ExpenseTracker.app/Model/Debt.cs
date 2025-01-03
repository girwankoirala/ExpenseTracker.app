using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.app.Model
{
    public class Debt
    {
        public int Id { get; set; }
        public string Creditor { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
}

