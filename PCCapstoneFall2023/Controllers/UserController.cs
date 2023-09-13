using Microsoft.AspNetCore.Mvc;

namespace PCCapstoneFall2023.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
