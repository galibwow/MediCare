using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Medicare.DAL;
using Medicare.Models;


namespace Medicare.BLL
{
    public class GroupsManager
    {


        GroupsGateway groupsGateway=new GroupsGateway();

        public bool IsNameExist(Groups group)
        {

            if (groupsGateway.IsNameExist(group))
            {
                return true;
            }
            return false;
        }
    }
}