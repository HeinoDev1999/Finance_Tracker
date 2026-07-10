using Finance_Tracker.Enums;

namespace Finance_Tracker.Models;

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public AccountType AccountType { get; set; }

    // Foreign key - the actual ID stored in the database
    public string UserId { get; set; }
    
    // Navigation property
    public ApplicationUser User { get; set; }
    
    // One account can have many transactions
    public ICollection<Transaction> Transactions { get; set; }
}