using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface IUserService
    {
        int AddUser(User user);

        string  Deactivate(int id);

        int EditUser(User user);


        int DeleteAccount(int Id);


        User GetById(int Id);

        User GetByUsername(string txt);
        User GetByName(string txt);
        List<User> GetAllUser();
       

       




    }
}
