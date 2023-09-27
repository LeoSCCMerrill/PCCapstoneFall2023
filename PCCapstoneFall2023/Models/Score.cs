using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCCapstoneFall2023.Models
{
    public class Score
    {
        public int ScoreID { get; set; }
        public int PossiblePoints { get; set; }
        public int CorrectPoints { get; set; }


        public string UserID { get; set; }
        public ApplicationUser User { get; set; }

    }
}
