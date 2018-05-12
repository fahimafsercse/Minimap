using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class UserType
    {
        [Required,Key]
        public int UserTypeId { get; set; }
        [Required]
        public string UserTypeName { get; set; }
    }
}