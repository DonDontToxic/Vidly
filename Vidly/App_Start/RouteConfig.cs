using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // Attribute route
            routes.MapMvcAttributeRoutes();
            
            // Custom route
            // routes.MapRoute(
            //     "CustomerDetail",
            //     "customers/details/{id}",
            //     new {controller = "Customers", action="CustomerDetail"}
            //     );
            
            // Default route
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}