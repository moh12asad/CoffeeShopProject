using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CoffeeShopProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Users", action = "HomePage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Products",
                url: "Products/{id}",
                defaults: new { controller = "Products", action = "Menu", id = UrlParameter.Optional }
            );
        }
    }
}
