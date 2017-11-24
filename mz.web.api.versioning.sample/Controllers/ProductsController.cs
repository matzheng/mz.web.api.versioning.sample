using System.Net;
using mz.web.api.versioning.sample.Models;
using Microsoft.Data.OData;
using System.Linq;
using System.Collections.Generic;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.Http;

namespace mz.web.api.versioning.sample.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using mz.web.api.versioning.sample.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Product>("Products");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ProductsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();
        private List<Product> list = new List<Product>() {
                new Product {
                    Id = 101,
                    Name = "p1",
                    Qty = 5
                },
                new Product {
                Id = 102,
                    Name = "p2",
                    Qty = 6
                },
                new Product {
                    Id = 103,
                    Name = "p3",
                    Qty = 6
                }
            };
        // GET: odata/Products
        [EnableQuery]
        public IQueryable<Product> GetProducts()
        {
            return list.AsQueryable();
        }

        // GET: odata/Products(5)
        public IQueryable<Product> GetProduct([FromODataUri] int key, ODataQueryOptions<Product> queryOptions)
        {
            return list.Where(n => n.Id == key).AsQueryable();
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            base.Dispose(disposing);
        }

    }
}
