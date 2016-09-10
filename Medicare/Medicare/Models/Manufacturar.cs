using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Manufacturar
    {
        [Key]
        public int ManufacturerId { get; set; }

        public string ManufacturarName { get; set; }

        public string CompanyDetails { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}