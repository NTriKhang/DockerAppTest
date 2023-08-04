using DockerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> _context) : base(_context)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
