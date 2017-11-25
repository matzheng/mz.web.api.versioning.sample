using mz.web.api.versioning.sample.Data;
using mz.web.api.versioning.sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace mz.web.api.versioning.sample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //using (CommerceDbContext db = new CommerceDbContext())
            //{
            //    var product = new Product() {
            //          ProductName = "P1"
            //          , Qty = 100
            //    };
            //    db.Products.Add(product);
            //    db.SaveChanges();
            //}
        }
    }
}
