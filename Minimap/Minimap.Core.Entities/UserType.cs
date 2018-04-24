using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class UserType
    {
        public string UserTypeId { get { return this.UserTypeId; } }
        public string UserTypeName { set { this.UserTypeName = value; } get { return this.UserTypeName; } }

    }
}