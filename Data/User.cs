using Microsoft.AspNetCore.Identity;

namespace DotNet8.IdentityManager.Data
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
