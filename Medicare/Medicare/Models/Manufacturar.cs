using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Manufacturar
    {
        [Key]
        public int ManufacturerId { get; set; }
        [DisplayName("Manufacturer Name")]
        public string ManufacturarName { get; set; }
        [DisplayName("Company Details")]
        public string CompanyDetails { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}