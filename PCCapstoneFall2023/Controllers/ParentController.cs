using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles = "Parent,Administrator")]
    public class ParentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
