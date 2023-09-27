using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Data.Migrations;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Student")]
    public class StudentController : Controller
    {
        //private DrillContext _context {  get; set; }
        public  StudentController(/*DrillContext ctx*/)
        {
            //_context = ctx;
            

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Drills()
        {
            return View();
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
    }
}
