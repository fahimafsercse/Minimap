using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class Notification
    {
        public DateTime AlertTime { get; set; }
        public string Message { get; set; }
    }
}