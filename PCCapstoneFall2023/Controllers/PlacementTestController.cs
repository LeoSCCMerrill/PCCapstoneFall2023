using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Data;

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
    }
}
