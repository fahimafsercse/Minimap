using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface IRegisterService
    {
        int RegisterUser(User user);
    }
}
