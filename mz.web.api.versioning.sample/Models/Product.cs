using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace mz.web.api.versioning.sample.Models
{
    /// <summary>
    /// Products
    /// </summary>
    //[DataContract]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        //[DataMember]
        public string ProductName { get; set; }
        //[DataMember]
        public int Qty { get; set; }
        public string SKU { get; set; }
        public virtual List<Order> Orders {get;set;}
    }
}