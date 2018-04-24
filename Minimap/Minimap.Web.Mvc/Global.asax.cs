using Minimap.Core.Service;
using Minimap.Core.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace Minimap.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            IUnityContainer container = new UnityContainer();
            container.RegisterType<IMarkerService, MarkerService>();
            container.RegisterType<IUserTypeService, UserTypeService>();
            container.RegisterType<INotificationService, NotificationService>();
            container.RegisterType<IChannelService, ChannelService>();
            container.RegisterType<IAccountDetailService, AccountDetailService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
