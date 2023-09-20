using System.ComponentModel.DataAnnotations;


namespace PCCapstoneFall2023.Models
{
    public class MathQuestion
    {
        public int QuestionID { get; set; } // this will be my primary key

        [Required(ErrorMessage = "Please enter a question to ask the student.")]
        public string AskedQuestion { get; set; }

        [Required(ErrorMessage = "Enter the correct answer to the question stated.")]
        public int CorrectAnswer { get; set; }

        [Required(ErrorMessage ="Please enter the number of points this question is worth.")]
        public int PointsWorth { get; set; }
        public int? Answer { get; set; }
    }
   
}
