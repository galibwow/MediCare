using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class User
    {
        public int UserId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Compare Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<BuyProduct> BuyProductList { get; set; } 
    }
}