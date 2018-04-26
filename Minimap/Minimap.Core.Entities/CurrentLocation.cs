using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class CurrentLocation
    {
        public string LocationName { get; set; }
        public string Description { get; set; }
        public double Lati { get; set; }
        public double Longi { get; set; }
    }
}