using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCCapstoneFall2023.Models
{
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }

    }
}
