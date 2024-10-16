using Microsoft.EntityFrameworkCore;

namespace StudentApp_161024.Models
{
    public class StudentDbContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public StudentDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<CourseUnit> CourseUnits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
