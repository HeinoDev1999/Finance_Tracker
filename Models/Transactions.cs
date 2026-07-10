using Finance_Tracker.Enums;

namespace Finance_Tracker.Models;

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public TransactionType Type { get; set; }

    // Which account this transaction belongs to
    public int AccountId { get; set; }
    public Account Account { get; set; }

    // Which category this transaction belongs to
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}