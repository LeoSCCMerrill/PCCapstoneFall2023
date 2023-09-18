using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Teacher")]
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDrills()
        {
            return View();
        }
        public IActionResult DrillResults()
        {
            return View();
        }
    }
}
