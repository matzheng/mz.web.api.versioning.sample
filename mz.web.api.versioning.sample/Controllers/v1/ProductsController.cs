using System.Net;
using mz.web.api.versioning.sample.Models;
using Microsoft.Data.OData;
using System.Linq;
using System.Collections.Generic;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.Http;
using mz.web.api.versioning.sample.Data;
using Microsoft.Web.Http;
using System.Web.OData.Routing;

namespace mz.web.api.versioning.sample.Controllers.v1
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
    [ApiVersion("1.0")]
    public class ProductsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();
        private CommerceDbContext db = new CommerceDbContext();
        // GET: odata/Products
        [EnableQuery]
        [ODataRoute]
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: odata/Products(5)
        public IQueryable<Product> GetProduct([FromODataUri] int key, ODataQueryOptions<Product> queryOptions)
        {
            return db.Products.Where(n => n.ProductId == key).AsQueryable();
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
