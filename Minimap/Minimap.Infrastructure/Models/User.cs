using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minimap.Infrastructure.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set;}

    }
}