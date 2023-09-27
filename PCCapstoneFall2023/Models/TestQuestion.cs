using System.ComponentModel.DataAnnotations;

namespace PCCapstoneFall2023.Models
{
    public class TestQuestion
    {
        public int Id { get; set; } //This is the primary key, database will generate this value
        [Required (ErrorMessage ="Select Random, or a Subject.")]
        public bool IsRandom { get; set; } // determines if the test is random
        [Required(ErrorMessage ="Please enter a question.")]
        public string Difficulty { get; set; } // select how difficult the question is
        public string Question { get; set; }
        [Required(ErrorMessage ="Enter the correct answer, for the answer-key.")]
        public string CorrectAnswer { get; set; }
        public int? Answer { get; set; } // this is the answer given by the student

        public int PointsWorth { get; set; } // how many points the question is worth
    }
}
