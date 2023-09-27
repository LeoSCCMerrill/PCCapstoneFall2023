using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Controllers
{
    public class PlacementTestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlacementTestController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var mathQuestions = _context.MathQuestions.ToList();
            return View(mathQuestions);
        }


        [Authorize(Roles = "Student")]
        public IActionResult StudentPlacementView()
        {
            List<MathQuestion> questions = _context.MathQuestions.ToList();
            return View(questions);
        }
        //In this controller action, we receive the submitted answers, correct answers, 
        //and points worth for each question. We then calculate the total score 
        //by iterating through the answers and comparing them to the correct answers.

        [HttpPost]
        public IActionResult SubmitTest(List<MathQuestion> questions, Score model)
        {
            int totalPoints = 0;
            int possiblePoints = 0;
            var user = _userManager.GetUserAsync(HttpContext.User);
            // Iterate through the list of questions and compare user answers to correct answers
            foreach (var question in questions)
            {
                possiblePoints += question.PointsWorth;
                if (question.Answer != question.CorrectAnswer)
                {
                   
                    // If the user's answer is incorrect, subtract the points
                    //totalPoints -= question.PointsWorth;
                }
                else
                {
                    // If the user's answer is correct, add the points
                    totalPoints += question.PointsWorth;
                }
            }

            // Pass the totalPoints and questions data to the TestResult view
            ViewBag.TotalPoints = totalPoints;
            ViewBag.PossiblePoints = possiblePoints;
            model.PossiblePoints = possiblePoints;
            model.CorrectPoints = totalPoints;
            model.UserID = _userManager.GetUserId(User);

            _context.Scores.Add(model);
            _context.SaveChanges();

            // Redirect to the TestResult view
            return View("TestResult");
        }


        public IActionResult TestResult()
        {
            int? totalScore = HttpContext.Session.GetInt32("TotalScore");

            if (!totalScore.HasValue)
            {
                // Handle the case where the total score is not available in the session.
                return RedirectToAction("Index"); // Redirect to home page.
            }

            ViewBag.TotalScore = totalScore;
            return View();
        }



        [HttpPost]
        [Authorize(Roles = "Teacher")]
        public IActionResult Add(MathQuestion model)
        {
            if (ModelState.IsValid)
            {
                // Add the math question to the database
                _context.MathQuestions.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index"); // Redirect to the placement test page
            }

            return View("CreatePlacementTest", model); // Show the form with validation errors
        }

        [HttpPost]
        [Authorize(Roles = "Teacher")]
        public IActionResult RemoveQuestion(int questionId)
        {
            var question = _context.MathQuestions.Find(questionId);

            if (question != null)
            {
                _context.MathQuestions.Remove(question);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Question removed successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Question not found or already removed.";
            }

            return RedirectToAction("Index");
        }


    }
}
