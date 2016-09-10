using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string MobileNo { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<BuyProduct> BuyProductList { get; set; } 
    }
}