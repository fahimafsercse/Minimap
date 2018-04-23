using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class UserType
    {


        public string UserTypeId { get { return this.UserTypeId; } }
        public string UserTypeName { set { this.UserTypeName = value; } get { return this.UserTypeName; } }
        
        
        /*readonly string UserTypeId;//{ get; set; }
        string UserTypeName { get; set; }

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
        */
        //Public Properties

    }
}