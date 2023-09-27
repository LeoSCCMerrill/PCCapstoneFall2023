using Humanizer.Localisation.TimeToClockNotation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _context;
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await GetViewModel());
        }

        public async Task<IActionResult> CreateUser()
        {            
            return View(new ApplicationUser());
        }

        public async Task<IActionResult> AddUser(ApplicationUser applicationUser)
        {
            applicationUser.EmailConfirmed = true;
            await userManager.CreateAsync(applicationUser, "Password1!");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteUser(string userId)
        {
            await userManager.DeleteAsync(await userManager.FindByIdAsync(userId));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> CreateRole()
        {
            return View(new IdentityRole());
        }

        public async Task<IActionResult> AddRole(IdentityRole identityRole)
        {
            await roleManager.CreateAsync(identityRole);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteRole(string roleId)
        {
            await roleManager.DeleteAsync(await roleManager.FindByIdAsync(roleId));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveUserRole(string roleId, string userId)
        {
            IdentityRole identityRole = await roleManager.FindByIdAsync(roleId);
            ApplicationUser applicationUser = await userManager.FindByIdAsync(userId);
            await userManager.RemoveFromRoleAsync(applicationUser, identityRole.Name);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AddUserRole(string roleId, string userId)
        {
            IdentityRole identityRole = await roleManager.FindByIdAsync(roleId);
            ApplicationUser applicationUser = await userManager.FindByIdAsync(userId);
            await _context.SaveChangesAsync();
            await userManager.AddToRoleAsync(applicationUser, identityRole.Name);
            return RedirectToAction("Index");
        }

        private async Task<UserViewModel> GetViewModel()
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
            return viewModel;
        }
    }
}
