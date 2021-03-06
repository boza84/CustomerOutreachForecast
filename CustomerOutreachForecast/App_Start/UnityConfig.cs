using Services;
using Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CustomerOutreachForecast
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
                        
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IOpenWeatherApiService, OpenWeatherApiService>();
            container.RegisterType<IHomeControllerMapper, HomeControllerMapper>();
        }
    }
}