using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;
using System.Diagnostics;
using System.Linq;

namespace PCCapstoneFall2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            context = _context;
        }
       

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult DisplayTest()
        {
           
            return View();
            
        }

        public IActionResult CreatePlacementTestView()
        {

            return View();

        }


        public IActionResult StudentRanks()
        {
            return View();
        }     
        public IActionResult AdminHome()

        {
            return View();
        }

        public IActionResult TestResult()
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