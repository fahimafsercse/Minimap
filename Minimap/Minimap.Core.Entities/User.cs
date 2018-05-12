using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class User
    {



        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        // public  Blob picture { get; set; }
        public int UserTypeId { get; set; }


        public DateTime JoinDate { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsValid { get; set; }

        public int TotalMarker { get; set; }
        public int TotalChannel { get; set; }
        public int TotalSubscription { get; set; }

    }
}