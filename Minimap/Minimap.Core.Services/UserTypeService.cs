using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{

    public class UserTypeService:IUserTypeService
    {
        private DataContext context;
        public UserTypeService() { this.context = new DataContext(); }

        public int AddUserType(UserType usertype)
        {
            this.context.Usertypes.Add(usertype);
            return this.context.SaveChanges();
        }

        public int DeleteUserType(int   id)
        {
            UserType userTypeToDelete = this.context.Usertypes.SingleOrDefault(d => d.UserTypeId == id);
            this.context.Usertypes.Remove(userTypeToDelete);
            return this.context.SaveChanges();
        }
        public int DeleteUserType(UserType uType)
        {
            this.context.Usertypes.Remove(uType);
            return this.context.SaveChanges();
        }

        public int EditUserType(UserType utype)
        {
            UserType userTypeToEdit = new UserType();
            userTypeToEdit = this.context.Usertypes.SingleOrDefault(d => d.UserTypeId == utype.UserTypeId);
            userTypeToEdit.UserTypeName = utype.UserTypeName;
            return this.context.SaveChanges();
        }

        public UserType  GetUserTypeById(int id)
        {
            return this.context.Usertypes.SingleOrDefault(d => d.UserTypeId == id);
        }
        public List<UserType> GetAllUserType()
        {
            return this.context.Usertypes.ToList();
        }

        public UserType GetByUserTypeName(string txt)
        {
            return this.context.Usertypes.SingleOrDefault(d => d.UserTypeName == txt);
        }


    }
}