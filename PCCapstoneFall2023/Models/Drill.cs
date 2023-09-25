using System.ComponentModel.DataAnnotations;

namespace PCCapstoneFall2023.Models
{
    public class Drill
    {
        public int DrillQuestID { get; set; } //Primary key

        [Required(ErrorMessage = "Please select drill difficulty.")]
        public string DrillDifficulty { get; set; }

        [Required(ErrorMessage = "Please enter drill length.")]
        public int DrillLength { get; set; }

        [Required(ErrorMessage = "Please select if you want randomized questions")]
        public string DrillRandomized {  get; set; }

        public DateTime DrillTime { get; set; }

        public int? answer { get; set; }

        public Drill (int drillQuestID, string drillDifficulty, int drillLength, string drillRandomized, DateTime drillTime, int? answer)
        {
            DrillQuestID = drillQuestID;
            DrillDifficulty = drillDifficulty;
            DrillLength = drillLength;
            DrillRandomized = drillRandomized;
            DrillTime = drillTime;
            this.answer = answer;
        }
    }

}
