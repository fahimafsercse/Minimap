using Minimap.Core.Entities;
using Minimap.Core.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service
{
    public class UserTypeService: IUserTypeService
    {
        /*//private static UserTypeDataAccess userTypeDataAccess = null;

        public UserTypeService()
        {
            if (UserTypeService.userTypeDataAccess == null)
            {
                UserTypeService.userTypeDataAccess = new UserTypeDataAccess();
            }
        }
        */

        public int Add(UserType userType)
        {
            //return UserTypeService.userTypeDataAccess.Add(userType);
        }

        public int Edit(UserType userType)
        {
            //return UserTypeService.userTypeDataAccess.Edit(userType);
        }

        public List<UserType> GetAll()
        {
            //return UserTypeService.userTypeDataAccess.GetAll();
        }

        public int Remove(string id)
        {
            // return UserTypeService.userTypeDataAccess.Remove(id);
        }
    }
}