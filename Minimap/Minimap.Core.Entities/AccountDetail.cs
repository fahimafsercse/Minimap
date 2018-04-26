using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class AccountDetail
    {

        public static int AccountCounter { get; set; }
        public CurrentLocation CurrentLoc { get; set; }


        
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
       // public  Blob picture { get; set; }
        public string UserTypeId { get; set; }
        

        public DateTime JoinDate { get; set; }
        public string Email { get; set; }
        

        public int TotalMarker { get; set; }
        public int TotalChaneel { get; set; }
        public int TotalSubscription { get; set; }


        public AccountDetail(){
            AccountCounter += 1;
        }
    }
}