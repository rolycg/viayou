using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ViaYou.Adapters.geobytes;
using ViaYou.Data;
using ViaYou.Domain.Users;
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

            //identity injections
            container.RegisterType<DbContext, ViaYouDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<IAuthenticationManager>(new InjectionFactory(o => HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<ICultureService, CultureService>();
            container.RegisterType<ICityProvider, FakeCityProvider>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}