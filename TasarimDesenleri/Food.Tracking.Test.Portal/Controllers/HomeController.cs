using Food.Tracking.Test.Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Food.Tracking.DataAccess.Concrete.Context;
using Food.Tracking.Test.Portal.DataAccess;

namespace Food.Tracking.Test.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FoodDbContext _dbContext;
        private FoodV2DbContext _dV2DbContext;

        public HomeController(ILogger<HomeController> logger, FoodDbContext dbContext, FoodV2DbContext dV2DbContext)
        {
            _dbContext = dbContext;
            _dV2DbContext = dV2DbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var yetkiList = _dbContext.Yetki.ToList();
            var musterigrubu = _dV2DbContext.MusteriTuruGrubu.ToList();


            return View(yetkiList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}