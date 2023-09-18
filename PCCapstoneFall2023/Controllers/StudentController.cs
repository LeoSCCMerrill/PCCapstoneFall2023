using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Student")]
    public class StudentController : Controller
    {
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
    }
}
