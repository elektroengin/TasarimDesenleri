using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Tracking.Entities;

namespace Food.Tracking.DataAccess.Repository
{
    public interface IMusteriTuruGrubuRepository
    {
        List<MusteriTuruGrubu> GetAll();
        MusteriTuruGrubu GetById(long id);
        MusteriTuruGrubu Add(MusteriTuruGrubu entity);
        MusteriTuruGrubu Update(MusteriTuruGrubu entity);
        MusteriTuruGrubu Delete(long id);
    }
}
