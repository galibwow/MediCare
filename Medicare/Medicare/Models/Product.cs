using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public decimal ProductQuantity { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductTypeId { get; set; }

        public int ManufacturerId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Manufacturar Manufacturar { get; set; }
        public virtual ICollection<BuyProduct> BuyProductList { get; set; }

        public virtual ICollection<PlaceOrder> PlaceOrderList { get; set; } 
    }
}