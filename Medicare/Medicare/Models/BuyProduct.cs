using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class BuyProduct
    {
        public int BuyProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string OrderNumber { get; set; }

        

        public decimal Quantity { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime BillDate { get; set; }
        

        

        
        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}