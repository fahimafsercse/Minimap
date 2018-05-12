using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{
    public class RegisterService:IRegisterService
    {
        private DataContext context;
        public RegisterService() {
            this.context = new DataContext();
        }

        public int RegisterUser(User user)
        {
            this.context.Users.Add(user);
            return this.context.SaveChanges();
        }
      
    }
}