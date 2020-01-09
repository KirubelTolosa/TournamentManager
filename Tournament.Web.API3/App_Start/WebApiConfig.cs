using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Tournament.Web.API3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

          

            config.Routes.MapHttpRoute("MyMemberRoute", "api/teammembers/{id}", defaults: new { controller = "Members", id = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
              name: "DefaultApi",
              routeTemplate: "api/{controller}/{id}",
              defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
