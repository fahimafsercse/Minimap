using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface IUserTypeService
    {
        int AddUserType(UserType usertype);


        int DeleteUserType(int id);

        int EditUserType(UserType utype);


        List<UserType> GetAllUserType();

        UserType GetByUserTypeName(string txt);
        
    }
}
