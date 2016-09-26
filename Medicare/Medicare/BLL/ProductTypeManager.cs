using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Medicare.DAL;
using Medicare.Models;

namespace Medicare.BLL
{
    public class ProductTypeManager
    {

        ProductTypeGateway productTypeGateway=new ProductTypeGateway();

        public bool IsNameExist(ProductType productType)
        {
            return productTypeGateway.IsNameExist(productType);
        }
    }
}