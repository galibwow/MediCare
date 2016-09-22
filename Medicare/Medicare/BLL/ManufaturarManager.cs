using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Medicare.DAL;
using Medicare.Models;

namespace Medicare.BLL
{
    public class ManufaturarManager
    { 
        
        ManufacturerGateway manufacturerGateway=new ManufacturerGateway();

        public bool IsNameExist(Manufacturar manufacturar)
        {
            
            if (manufacturerGateway.IsNameExist(manufacturar))
            {
                return true;
            }
            return false;
        }
    }
}