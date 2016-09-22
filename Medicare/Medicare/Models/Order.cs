using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int PaymentId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal SalesTax { get; set; }

        public string ErrorLog { get; set; }

        public string ErrorMessage { get; set; }

        public bool PaidStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
        

        public virtual ICollection<BuyProduct> BuyProductList { get; set; } 
        
    }
}