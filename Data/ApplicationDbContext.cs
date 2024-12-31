using Microsoft.EntityFrameworkCore;
using CRUDFormBackend.Models;

namespace CRUDFormBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
