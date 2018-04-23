using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.IServices
{
    public interface IUserTypeService
    {
        int Add(UserType userType);
        int Remove(string id);
        int Edit(UserType userType);
        List<UserType> GetAll();
    }
}