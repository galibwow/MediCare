using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Medicare.DAL;
using Medicare.Models;

namespace Medicare.BLL
{
    public class GroupsManager
    {

        GroupsGateway groupsGateway=new GroupsGateway();

        public bool IsNameExist(Groups groups)
        {
            return groupsGateway.IsNameExist(groups);
        }
    }
}