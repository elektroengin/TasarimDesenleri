﻿using Food.Tracking.Context.ContextSettings;
using Food.Tracking.DataAccess.Contract.Base;
using Food.Tracking.Entities;

namespace Food.Tracking.DataAccess.Repository
{
    public class MusteriTuruGrubuRepository : BaseRepository<MusteriTuruGrubu>, IMusteriTuruGrubuRepository
    {
        public MusteriTuruGrubuRepository(FoodV2DbContext dbContext) : base(dbContext)
        {
        }

    }
}
