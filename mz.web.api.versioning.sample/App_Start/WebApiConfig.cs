//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Http;
//using System.Web.Http.OData.Builder;
//using System.Web.OData.Extensions;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;


namespace mz.web.api.versioning.sample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();

            config.AddODataQueryFilter();

            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Models.Product>("Products");
            
            config.MapODataServiceRoute(routeName : "odata", routePrefix: "api", model: builder.GetEdmModel());
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
