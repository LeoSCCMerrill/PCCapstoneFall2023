using Microsoft.EntityFrameworkCore.Query;

namespace PCCapstoneFall2023.Models
{
    public class Student : ApplicationUser
    {
        public string parentId { get; set; }
        public string teacherId { get; set; }
    }
}
