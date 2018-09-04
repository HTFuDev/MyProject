using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Mvc5;
using PACL.ServiceLayer.Services;
using PACL.ServiceLayer.ServiceModels;
using System.Web.Mvc;

namespace PACL
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IRegistrationService, RegistrationService>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            
        }
    }
}