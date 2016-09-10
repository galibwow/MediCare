using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class Groups
    {

        public int GroupsId { get; set; }

        public string GroupName { get; set; }

        public virtual ICollection<Product> ProductList { get; set; } 
    }
}