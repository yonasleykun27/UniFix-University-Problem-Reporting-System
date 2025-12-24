using Microsoft.EntityFrameworkCore;

namespace UniFix.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UniFixDb;Trusted_Connection=True;");
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}