using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mz.web.api.versioning.sample.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderQty { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}