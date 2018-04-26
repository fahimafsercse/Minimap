using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Marker
    {
        public string MarkerName { get; set; }
        public string Location { get; set; }
        public double Lat { get; set; }
        public double longi { get; set; }
        public int MarkerId { get; set; }
        public DateTime CreationDate { get; set; }

        public int TotalUser { get; set; }
        public int TotalView { get; set; }
    }
}