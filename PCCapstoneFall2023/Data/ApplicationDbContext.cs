using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCCapstoneFall2023.Models;
using System.Security.Cryptography;

namespace PCCapstoneFall2023.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
             
         }
        public DbSet<Drill> DrillContext { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<MathQuestion> MathQuestions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Score> Scores { get; set; }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

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
            const string ADMIN_USER_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ADMIN_ROLE_ID = ADMIN_USER_ID;
            const string STUDENT_ROLE_ID = "22d6208e-e968-487e-a8f6-59a1c3ce94d7";
            const string TEACHER_ROLE_ID = "4998520f-93b5-46c9-818c-122ae6a3796c";
            const string PARENT_ROLE_ID = "e46f5809-0636-41b8-ba7a-f1f7d808769c";
            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            },
            new IdentityRole
            {
                Id = STUDENT_ROLE_ID,
                Name = "Student",
                NormalizedName = "STUDENT",
            },
            new IdentityRole
            {
                Id = TEACHER_ROLE_ID,
                Name = "Teacher",
                NormalizedName = "TEACHER",
            },
            new IdentityRole
            {
                Id = PARENT_ROLE_ID,
                Name = "Parent",
                NormalizedName = "PARENT",
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_USER_ID,
                UserName = "admin@myemail.com",
                NormalizedUserName = "ADMIN@MYEMAIL.COM",
                Email = "admin@myemail.com",
                NormalizedEmail = "ADMIN@MYEMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEALfXOO0MYDpnaWi+2TO6u67hE3xzrew03QVb8Vb3wTOdiKZzWGSm42SscHBRPRT0g==", // Password1!
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_USER_ID
            });
        }
    }
}