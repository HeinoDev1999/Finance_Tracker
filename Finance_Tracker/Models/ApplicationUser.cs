using Microsoft.AspNetCore.Identity;

namespace Finance_Tracker.Models;

public class ApplicationUser : IdentityUser
{
    public string DisplayName { get; set; }
}