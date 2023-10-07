using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PIM4___WebHolerite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "WebHolerite", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Index",
               url: "Index",
               defaults: new { controller = "WebHolerite", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Login",
               url: "Login",
               defaults: new { controller = "WebHolerite", action = "Login", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "VerificacaoLogin",
              url: "VerificacaoLogin",
              defaults: new { controller = "WebHolerite", action = "VerificacaoLogin", id = UrlParameter.Optional }
          );
        }
    }
}
