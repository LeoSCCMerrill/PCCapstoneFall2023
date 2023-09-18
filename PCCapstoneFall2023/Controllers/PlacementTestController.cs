using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Controllers
{
    public class PlacementTestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlacementTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var mathQuestions = _context.MathQuestions.ToList();
            return View(mathQuestions);
        }

        public IActionResult StudentPlacementView()
        {
            var mathQuestions = _context.MathQuestions.ToList();
            return View(mathQuestions);
        }

        [HttpPost]
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
