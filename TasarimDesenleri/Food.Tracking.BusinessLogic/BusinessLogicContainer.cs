using Food.Tracking.BusinessLogic.MusteriTuruGrubu;
using Microsoft.Extensions.DependencyInjection;

namespace Food.Tracking.BusinessLogic
{
    public static class BusinessLogicContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IMusteriTuruGrubuBL, MusteriTuruGrubuBL>();
        }
    }
}
