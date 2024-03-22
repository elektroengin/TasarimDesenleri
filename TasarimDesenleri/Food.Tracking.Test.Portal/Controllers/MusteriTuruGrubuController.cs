using Food.Tracking.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food.Tracking.Test.Portal.Controllers
{
    public class MusteriTuruGrubuController : Controller
    {
        private IMusteriTuruGrubuRepository _musteriTuruGrubuRepository;

        public MusteriTuruGrubuController(IMusteriTuruGrubuRepository musteriTuruGrubuRepository)
        {
            _musteriTuruGrubuRepository = musteriTuruGrubuRepository;
        }

        public IActionResult Index()
        {
            var musteriList = _musteriTuruGrubuRepository.GetAll();
            return View(musteriList);
        }

        public IActionResult GetMusteriTuruGrubu()
        {
            var msuteri = _musteriTuruGrubuRepository.GetById(1);
            return View(msuteri);
        }
    }
}
