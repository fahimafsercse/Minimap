using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class UserType
    {
        readonly string UserTypeId { get; set; }
        string userTypeName;

        public UserType()
        {

        }
        public UserType(string userTypeId)
        {
            this.UserTypeId = userTypeId;
        }
        //Constructor with all attribute
        public UserType(string userTypeId, string userTypeName)
        {
            this.UserTypeId = userTypeId;
            this.userTypeName = userTypeName;
        }

        //Public Properties
        public string UserTypeId { get { return this.UserTypeId; } }
        public string UserTypeName { set { this.userTypeName = value; } get { return this.userTypeName; } }
    }
}