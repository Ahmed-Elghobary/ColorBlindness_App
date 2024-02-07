using Microsoft.EntityFrameworkCore;

namespace ColorBlindness_App.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Test> Tests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
