using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class PlaceOrder
    {
        public int PlaceOrderId { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}