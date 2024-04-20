using Food.Tracking.Context.ContextSettings;
using Food.Tracking.DataAccess.Contract.Base;
using Food.Tracking.Entities;

namespace Food.Tracking.DataAccess.Repository
{
    public class MusteriTuruRepository : BaseRepository<MusteriTuru>,IMusteriTuruRepository
    {
        public MusteriTuruRepository(FoodV2DbContext dbContext) : base(dbContext)
        {
        }
    }
}
