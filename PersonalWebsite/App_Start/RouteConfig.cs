using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonalWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Blog", "blog",
                new { controller = "Blog", action = "Posts", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                "About", "about",
                new { controller = "About", action = "About" });

            routes.MapRoute(
                "Contact", "contact",
                new { controller = "Contact", action = "Contact" });

            routes.MapRoute(
                "Resume", "resume",
                new { controller = "Resume", action = "Resume" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
