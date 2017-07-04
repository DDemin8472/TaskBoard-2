using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TaskBoardWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute (
				name: "ControllerOnly" ,
				routeTemplate: "api/{controller}"
			);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
