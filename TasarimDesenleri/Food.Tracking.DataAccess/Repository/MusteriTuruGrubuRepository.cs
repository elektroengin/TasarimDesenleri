using Food.Tracking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Tracking.DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Food.Tracking.DataAccess.Repository
{
    public class MusteriTuruGrubuRepository : IMusteriTuruGrubuRepository
    {
        private readonly FoodV2DbContext _dbContext;

        public MusteriTuruGrubuRepository(FoodV2DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MusteriTuruGrubu Add(MusteriTuruGrubu entity)
        {
            _dbContext.Set<MusteriTuruGrubu>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public MusteriTuruGrubu Delete(long id)
        {
            var entity = _dbContext.Set<MusteriTuruGrubu>().Find(id);

            if (entity == null)
            {
                return entity;
            }

            _dbContext.Set<MusteriTuruGrubu>().Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public List<MusteriTuruGrubu> GetAll()
        {
            return _dbContext.Set<MusteriTuruGrubu>().ToList();
        }

        public MusteriTuruGrubu GetById(long id)
        {
            return _dbContext.Set<MusteriTuruGrubu>().Find(id);
        }

        public MusteriTuruGrubu Update(MusteriTuruGrubu entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
