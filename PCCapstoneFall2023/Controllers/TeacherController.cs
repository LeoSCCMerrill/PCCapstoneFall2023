using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Controllers
{
    //[Authorize(Roles ="Teacher")]
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context; 
        public TeacherController(ApplicationDbContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDrills()
        {
            Drill dc = new Drill(1, "Test", 2, "yes", DateTime.Now, 2);
            //List<Drill> drills = _context.Add(dc)
            return View();
        }
        public IActionResult DrillResults()
        {
            return View();
        }

        public IActionResult TestResults() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDrills([Bind]Drill dc)
        {
            
            if (ModelState.IsValid)
            {
                
            }
            return View("DrillResults");
        }
    }
}
