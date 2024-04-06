using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Tracking.BusinessLogic.MusteriTuruGrubu
{
    public interface IMusteriTuruGrubuBL
    {
        List<Entities.MusteriTuruGrubu> GetMusteriTuruGrubuList();
    }
}
