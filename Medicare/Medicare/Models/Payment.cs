using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Payment
    {

        public int PaymentId { get; set; }

        public string PaymentType { get; set; }

        public bool Allowed { get; set; }

        public ICollection<Order> OrderList { get; set; } 
    }
}