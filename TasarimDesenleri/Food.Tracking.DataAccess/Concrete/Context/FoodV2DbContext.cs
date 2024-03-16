using Food.Tracking.Entities;
using Microsoft.EntityFrameworkCore;

namespace Food.Tracking.DataAccess.Concrete.Context
{
    public class FoodV2DbContext : DbContext
    {
        public FoodV2DbContext(DbContextOptions<FoodV2DbContext> options) : base(options)
        {

        }

        public DbSet<MusteriTuruGrubu> MusteriTuruGrubu { get; set; }

    }
}
