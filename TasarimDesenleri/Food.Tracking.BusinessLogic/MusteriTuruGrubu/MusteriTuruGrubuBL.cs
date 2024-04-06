using Food.Tracking.DataAccess.Repository;

namespace Food.Tracking.BusinessLogic.MusteriTuruGrubu
{
    public class MusteriTuruGrubuBL : IMusteriTuruGrubuBL
    {
        public IMusteriTuruGrubuRepository _musteriTuruGrubuRepository;

        public MusteriTuruGrubuBL(IMusteriTuruGrubuRepository musteriTuruGrubuRepository)
        {
            _musteriTuruGrubuRepository = musteriTuruGrubuRepository;
        }

        public List<Entities.MusteriTuruGrubu> GetMusteriTuruGrubuList()
        {
            return _musteriTuruGrubuRepository.GetAll();
        }
    }
}
