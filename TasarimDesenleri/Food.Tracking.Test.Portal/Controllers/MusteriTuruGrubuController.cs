using Food.Tracking.BusinessLogic.MusteriTuruGrubu;
using Food.Tracking.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food.Tracking.Test.Portal.Controllers
{
    public class MusteriTuruGrubuController : Controller
    {
        //private IMusteriTuruGrubuRepository _musteriTuruGrubuRepository;

        //public MusteriTuruGrubuController(IMusteriTuruGrubuRepository musteriTuruGrubuRepository)
        //{
        //    _musteriTuruGrubuRepository = musteriTuruGrubuRepository;
        //}

        //public IActionResult Index()
        //{
        //    var musteriList = _musteriTuruGrubuRepository.GetAll();
        //    return View(musteriList);
        //}

        //public IActionResult GetMusteriTuruGrubu()
        //{
        //    var msuteri = _musteriTuruGrubuRepository.GetById(1);
        //    return View(msuteri);
        //}

        //public IActionResult Add()
        //{
            
        //    /////

        //    return View();
        //}

        private IMusteriTuruGrubuBL _musteriTuruGrubuBl;

        public MusteriTuruGrubuController(IMusteriTuruGrubuBL musteriTuruGrubuBl)
        {
            _musteriTuruGrubuBl = musteriTuruGrubuBl;
        }

        public IActionResult Index()
        {
            var musteriList = _musteriTuruGrubuBl.GetMusteriTuruGrubuList();
            return View(musteriList);
        }

    }
}
