using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Teacher,Administrator")]
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDrills()
        {
            
            
            //List<Drill> drills = _context.Add(dc)
            return View();
        }
        public IActionResult DrillResults()
        {
            return View();
        }
        public IActionResult CreateTest()
        {
            var testQuestions = _context.TestQuestions.ToList();
            return View(testQuestions);
        }

        public IActionResult ReviewTest()
        {
            List<TestQuestion> questions = _context.TestQuestions.ToList();
            return View(questions);
        }
        public IActionResult TestResults() 
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Teacher, Administrator")]
        public IActionResult Add(TestQuestion model)
        {
            if (ModelState.IsValid)
            {
                // Add the math question to the database
                _context.TestQuestions.Add(model);
                _context.SaveChanges();

                return RedirectToAction("ReviewTest"); // Redirect to the review test page
            }

            return View("CreateTest", model); // Show the form with validation errors
        }

        [HttpPost]
        [Authorize(Roles = "Teacher, Administrator")]
        public IActionResult RemoveQuestion(int Id)
        {
            var question = _context.TestQuestions.Find(Id);

            if (question != null)
            {
                _context.TestQuestions.Remove(question);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Question removed successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Question not found or already removed.";
            }

            return RedirectToAction("CreateTest");
        }
    }
}
