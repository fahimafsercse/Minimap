using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class AccountDetail
    {

        public string Username;// { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserTypeId { get; set; }
        
        public DateTime JoinDate { get; set; }
        public string Email { get; set; }

        public AccountDetail()
        {
            this.Username = Username;
        }
        //Constructor with all attribute
        public AccountDetail(string accountId, string username, string password, string firstName, string lastName, string userTypeId, float salary, DateTime joinDate)
        {
            
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userTypeId = userTypeId;
            this.joinDate = joinDate;
        }
        //Constructor without nullable attribute
        public AccountDetail(string accountId, string username, string password, string firstName, string userTypeId, float salary, DateTime joinDate)
        {
            
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.userTypeId = userTypeId;
            this.joinDate = joinDate;
        }

        //Properties
        public string Username { set { this.username = value; } get { return this.username; } }
        public string Password { set { this.password = value; } get { return this.password; } }
        public string FirstName { set { this.firstName = value; } get { return this.firstName; } }
        public string LastName { set { this.lastName = value; } get { return this.lastName; } }
        public string UserTypeID { set { this.userTypeId = value; } get { return this.userTypeId; } }
        public DateTime JoinDate { set { this.joinDate = value; } get { return this.joinDate; } }

    }
}
