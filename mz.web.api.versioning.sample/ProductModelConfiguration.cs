using Microsoft.Web.OData.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.Http;
using System.Web.OData.Builder;
using mz.web.api.versioning.sample.Models;

namespace mz.web.api.versioning.sample
{
    public class ProductModelConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            switch(apiVersion.MajorVersion)
            {
                case 1:
                    {
                        ConfigureV1(builder);
                        break;
                    }
                case 2:
                    {
                        ConfigureV2(builder);
                        break;
                    }
                default:
                    {
                        ConfigureCurrent(builder);
                        break;
                    }
            }

        }

        private void ConfigureV1(ODataModelBuilder builder) =>
            ConfigureCurrent(builder).Ignore(p => p.SKU);
        private void ConfigureV2(ODataModelBuilder builder) =>
            ConfigureCurrent(builder).Ignore(p => p.Qty);

        private EntityTypeConfiguration<Product> ConfigureCurrent(ODataModelBuilder builder)
        {
            var product = builder.EntitySet<Product>("Products").EntityType;
            //product.Ignore(p => p.ProductId);
            return product;
        }
    }

}