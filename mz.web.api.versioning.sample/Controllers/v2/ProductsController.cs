using mz.web.api.versioning.sample.Models;
using System.Linq;
using System.Web.OData;
using System.Web.OData.Query;
using mz.web.api.versioning.sample.Data;
using Microsoft.Web.Http;
using System.Web.OData.Routing;

namespace mz.web.api.versioning.sample.Controllers.v2
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using mz.web.api.versioning.sample.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Product>("Products2");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    [ApiVersion("2.0")]
    public class ProductsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();
        private CommerceDbContext db = new CommerceDbContext();

        [EnableQuery]
        [ODataRoute]
        public IQueryable<Product> GetProducts()
        {
            return db.Products.Take(1);
        }
    }
}
