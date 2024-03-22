using Microsoft.EntityFrameworkCore;

namespace MainProject.Configuration
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog = Test ;Integrated Security=True; ");
 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        

    }
}
