using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicare.Models
{
    public class Groups
    {

        public int GroupsId { get; set; }
        [DisplayName("Group Name")]
         [Remote("IsNameExist", "Groups", ErrorMessage = "Groups Name Already Exist")]
        public string GroupName { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}