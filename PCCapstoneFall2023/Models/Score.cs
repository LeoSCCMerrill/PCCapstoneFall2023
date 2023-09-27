using System.ComponentModel.DataAnnotations;

namespace PCCapstoneFall2023.Models
{
    public class Score
    {
        public int ScoreID { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public MathQuestion MathQuestion { get; set; }

    }
}
