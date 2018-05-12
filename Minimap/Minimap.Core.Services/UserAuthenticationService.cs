using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{
    public class UserAuthenticationService: IUserAuthenticationService
    {
        private DataContext context;
        public UserAuthenticationService() { this.context = new DataContext(); }

        public User Login(string username, String password)
        {
            User user = this.context.Users.SingleOrDefault(d => d.Username == username && d.Password == password);
            return user;           
        }
       
    }
}