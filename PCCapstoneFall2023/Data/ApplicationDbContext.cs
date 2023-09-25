using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCCapstoneFall2023.Models;

namespace PCCapstoneFall2023.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options)
            : base(options)
        {
             
         }
        public DbSet<Drill> drillContext { get; set; }
           public DbSet<MathQuestion> MathQuestions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Drill>().HasKey(d => d.DrillQuestID);

            // Configure the MathQuestion entity
            modelBuilder.Entity<MathQuestion>()
                .HasKey(q => q.QuestionID);
        }

    }

}