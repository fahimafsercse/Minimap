using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Interfaces
{
    public interface IAdminService
    {
        IEnumerable<AccountDetail> GetAllUser();

        //int AddChannel(Channel channel);
        //IEnumerable<Channel> ShowAllChannel();
        //int DeleteChannel(Channel channel);
        /*IEnumerable<Student> GetAll();
       
        IEnumerable<Student> GetById(int id);
        bool Insert(Student student);
        bool Update(Student student);
        bool Delete(int id);

        IEnumerable<Student> GetByName(string name);
        bool DeleteByName(string name);*/

    }
}