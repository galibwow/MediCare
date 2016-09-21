﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}