using mz.web.api.versioning.sample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mz.web.api.versioning.sample.Data
{
    public class CommerceDbContext : DbContext
    {
        public CommerceDbContext() : base("con")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}