using Food.Tracking.Test.Portal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Food.Tracking.Test.Portal.DataAccess
{
    public class FoodDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTrackingV2; Integrated Security = True;TrustServerCertificate=Yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Yetki> Yetki { get; set; }

    }
}
