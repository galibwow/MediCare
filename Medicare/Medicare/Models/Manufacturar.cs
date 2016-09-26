using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicare.Models
{
    public class Manufacturar
    {
        [Key]
        public int ManufacturerId { get; set; }
        [DisplayName("Manufacturer Name")]
        [Remote("IsNameExist","Manufacturars",ErrorMessage = "Manufacturer Name Already Exist")]
        public string ManufacturarName { get; set; }
        [DisplayName("Company Details")]
        public string CompanyDetails { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}