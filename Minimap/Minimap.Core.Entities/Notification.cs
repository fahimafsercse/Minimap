using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Notification
    {
        [Required]
        public string NotName { get; set; }
        [Required, Key]
        public int NotId { get; set; }
    }
}