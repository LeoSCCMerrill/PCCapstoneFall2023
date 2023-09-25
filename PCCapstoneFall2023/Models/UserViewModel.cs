using Microsoft.AspNetCore.Identity;

namespace PCCapstoneFall2023.Models
{
    public class UserViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
