using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Product
    {

        public int ProductId { get; set; }
         [DisplayName("Product Name")]
        public string ProductName { get; set; }

         [DisplayName("Product Price")]
        public decimal ProductPrice { get; set; }
         [DisplayName("Product Quantity")]
        public decimal ProductQuantityperUnit { get; set; }

         public decimal UnitePrice { get; set; }

         [DisplayName("Entry Date")]
         [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

         [DisplayName("Product Type")]
        public int ProductTypeId { get; set; }
         [DisplayName("Manufacturer Name")]
        public int ManufacturerId { get; set; }

         public string Picture { get; set; }

         public string BatchNo { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Manufacturar Manufacturar { get; set; }
        public virtual ICollection<BuyProduct> BuyProductList { get; set; }

        
    }
}