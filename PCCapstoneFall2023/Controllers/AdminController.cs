using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
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
    }
}
