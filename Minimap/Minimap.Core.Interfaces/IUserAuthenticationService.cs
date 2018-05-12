using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Interfaces
{
    public interface IUserAuthenticationService
    {
         User Login(string email, String password);
        
    }
}