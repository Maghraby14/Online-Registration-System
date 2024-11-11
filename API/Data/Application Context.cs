using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class Application_Context:DbContext
    {
        public Application_Context(DbContextOptions<Application_Context> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<TA> TAs { get; set; }

        
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Section> Sections { get; set; }

        public DbSet<LectSect> LectSects { get; set; }
        public DbSet<FinishedCourses> FinishedCourses { get; set; }
        public DbSet<Registered> Registred { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<College>()
                .HasKey(c => new { c.Id, c.Name }); // Define composite key


            
        }


    }
}
