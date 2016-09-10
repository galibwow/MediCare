using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Order
    {

        public int OrderId { get; set; }

        public int ProductId { get; set; }


        public decimal TotalPrice { get; set; }

        public bool Status { get; set; }

        public string OrderNumber { get; set; }

        public virtual ICollection<PlaceOrder> PlaceOrderList { get; set; }  
        
    }
}