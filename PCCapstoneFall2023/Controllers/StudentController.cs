using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Student")]
    public class StudentController : Controller
    {
        private DrillContext context {  get; set; }
        public DrillContext(DrillContext ctx)
        {
            context = ctx;
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
