using Microsoft.AspNetCore.Mvc;
using PCCapstoneFall2023.Models;
using System.Diagnostics;

namespace PCCapstoneFall2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentHome()
        {
            return View();
        }

        public IActionResult StudentDrills()
        {
            return View();
        }

        public IActionResult StudentDrillResults()
        {
            return View();
        }
        public IActionResult StudentRank()
        {
            return View();
        }
        public IActionResult TeacherHome()
        {
            return View();
        }
        public IActionResult CreateDrills()
        {
            return View();
        }
        public IActionResult TeacherDrillResults() 
        {
            return View();
        }
        public IActionResult AdminHome()
        {
            return View();
        }
        public IActionResult CreateAccounts()
        {
            return View();
        }
        public IActionResult DeleteAccounts()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}