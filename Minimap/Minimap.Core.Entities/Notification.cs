using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Notification
    {
        public DateTime AlertTime { get; set; }
        public string Message { get; set; }
    }
}