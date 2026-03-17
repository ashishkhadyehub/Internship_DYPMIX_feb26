using dotnetcore_training.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }


    }
}
