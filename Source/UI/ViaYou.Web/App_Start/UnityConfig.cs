using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ViaYou.Services.Culture;

namespace ViaYou.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICultureService, CultureService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}