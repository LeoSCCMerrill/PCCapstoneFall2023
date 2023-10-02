using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Data.Migrations;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Student,Administrator")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public  StudentController(ApplicationDbContext ctx)
        {
            _context = ctx;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Drills()
        {

            List<Drill> drills = _context.drillContext.ToList();
            return View(drills);

        }

        public IActionResult DrillResults()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult TestResults()
        {
            return View();
        }

        public IActionResult ChooseDifficulty()
        {
            return View();
        }

        public IActionResult ChooseLength()
        {
            return View();
        }

        public IActionResult IsRandomized()
        {
            return View();
        }

    }
}
