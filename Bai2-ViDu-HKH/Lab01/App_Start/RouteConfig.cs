using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "Hello", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "hello",
                url: "{controller}/{action}/{ten}/{id}"
            //defaults: new { controller = "home", action = "index", id = urlparameter.optional }
            //defaults: new { controller = "hello", action = "index", id = urlparameter.optional }
            );

            routes.MapRoute(
                name: "testparameter",
                url: "{haui}/{testpara}/{msg}/{number}",
                defaults: new { controller = "RouteConfigDemo", action = "TestParameter", msg="", number=1 }
            //defaults: new { controller = "Hello", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
