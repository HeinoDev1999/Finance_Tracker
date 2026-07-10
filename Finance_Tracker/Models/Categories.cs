namespace Finance_Tracker.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    // Nullable because global categories don't belong to any user
    public string? UserId { get; set; }
    public ApplicationUser? User { get; set; }
}