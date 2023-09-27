using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PCCapstoneFall2023.Data;
using PCCapstoneFall2023.Models;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PCCapstoneFall2023.Controllers
{
    [Authorize(Roles ="Teacher,Administrator")]
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context; 
        
        public TeacherController(ApplicationDbContext context) {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDrills()
        {
            
            
            //List<Drill> drills = _context.Add(dc)
            return View();
        }
        public IActionResult DrillResults()
        {
            return View();
        }

        public IActionResult TestResults() 
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("DrillDifficulty, DrillLength, DrillRandomized, DrillTime, answer")] Drill dc)
        {
            try
            {
                
                _context.Add(dc);
                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw;
            }
            return View("Index");
            
        }
    }
}
