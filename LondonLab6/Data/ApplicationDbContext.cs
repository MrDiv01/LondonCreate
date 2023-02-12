using LondonLab6.Models;
using Microsoft.EntityFrameworkCore;

namespace LondonLab6.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
