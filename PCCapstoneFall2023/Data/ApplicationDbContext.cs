using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options)
            : base(options)
        {
             
         }
        public DbSet<Drill> drillContext { get; set; }
        public DbSet<TestQuestion> testQuestions { get; set; }
        public DbSet<MathQuestion> MathQuestions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the TestQuestion entity
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TestQuestion>().HasKey(t => t.Id);

            // Configure the Drill entity
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Drill>().HasKey(d => d.DrillQuestID);

            // Configure the MathQuestion entity
            modelBuilder.Entity<MathQuestion>()
                .HasKey(q => q.QuestionID);

            // Configure the ApplicationUser entity
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().HasKey(x => x.Id);
        }
    }
}