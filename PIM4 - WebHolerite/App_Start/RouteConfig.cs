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
                defaults: new { controller = "WebHolerite", action = "LoginWebHolerite", id = UrlParameter.Optional }
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
               name: "LoginWebHolerite",
               url: "LoginWebHolerite",
               defaults: new { controller = "WebHolerite", action = "LoginWebHolerite", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "EsqueceuSenha",
              url: "EsqueceuSenha",
              defaults: new { controller = "WebHolerite", action = "EsqueceuSenha", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "EsqueceuSenhaConfirmacao",
             url: "EsqueceuSenhaConfirmacao",
             defaults: new { controller = "WebHolerite", action = "EsqueceuSenhaConfirmacao", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "VerificacaoEmail",
             url: "VerificacaoEmail",
             defaults: new { controller = "WebHolerite", action = "VerificacaoEmail", id = UrlParameter.Optional }
         );
            routes.MapRoute(
              name: "VerificacaoLogin",
              url: "VerificacaoLogin",
              defaults: new { controller = "WebHolerite", action = "VerificacaoLogin", id = UrlParameter.Optional }
          );
        }
    }
}
