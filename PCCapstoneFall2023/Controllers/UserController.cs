using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;
using System.Text.RegularExpressions;

namespace PCCapstoneFall2023.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            IList<ApplicationUser> users = new List<ApplicationUser>();
            foreach (ApplicationUser user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }
            UserViewModel viewModel = new UserViewModel
            {
                Users = users,
                Roles = roleManager.Roles
            };
            return View(viewModel);
        }

        public async Task<IActionResult> CreateUser()
        {
            return View(new ApplicationUser());
        }

        public async Task<IActionResult> Add(ApplicationUser applicationUser)
        {
            
            return View();
        }

        public async Task<IActionResult> CreateRole()
        {
            return View();
        }
    }
}
