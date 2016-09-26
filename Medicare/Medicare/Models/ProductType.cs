using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicare.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        [DisplayName("ProductType Name")]
        [Remote("IsNameExist", "ProductTypes", ErrorMessage = "Product Type Name Already Exist")]
        public string ProductTypeName { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}