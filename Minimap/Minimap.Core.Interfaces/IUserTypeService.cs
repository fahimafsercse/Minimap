using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Interfaces
{
    public interface IUserTypeService
    {
        int Add(UserType userType);
        int Edit(UserType userType);
        //List<UserType> GetAll();
        int Remove(string id);
        
    }
}