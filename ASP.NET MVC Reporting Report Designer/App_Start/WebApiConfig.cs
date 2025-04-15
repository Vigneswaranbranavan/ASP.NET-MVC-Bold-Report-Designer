using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BoldReports.Web;

namespace ASP.NET_MVC_Reporting_Report_Designer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Register extensions assembly into report designer
            ReportConfig.DefaultSettings = new ReportSettings().RegisterExtensions(new List<string> { "BoldReports.Data.WebData" });
        }

    }
}
