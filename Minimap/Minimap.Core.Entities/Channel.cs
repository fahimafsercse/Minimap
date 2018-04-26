using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Channel
    {
        public string   ChannelOwner { get; set; }
        public Marker ChannelMarkers { get; set; }
        public string ChannelName { get; set; }
        public int ChannelId { get; set; }
        public string ChannelDescription { get; set; }

        public DateTime CreationDate { get; set; }
        public int TotaMarker { get; set; }
        public int TotalSubscriber { get; set; }
        public int TotalView { get; set; }
    }
}