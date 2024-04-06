using Food.Tracking.BusinessLogic;

namespace Food.Tracking.Test.Portal.Container
{
    public static class BusinessLogicRegister
    {
        public static void BusinessLogicInstall(this IServiceCollection services)
        {
            BusinessLogicContainer.Register(services);
        }
    }
}
