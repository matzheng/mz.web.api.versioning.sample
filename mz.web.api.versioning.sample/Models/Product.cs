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
    [DataContract]
    public class Product
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Qty { get; set; }
    }
}