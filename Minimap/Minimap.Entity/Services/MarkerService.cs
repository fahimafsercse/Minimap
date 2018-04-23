using Minimap.Entity.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class MarkerService:IMarkerService
    {
        public int AddMarker(Marker marker)
        {
            return 1;
        }
        public int RemoveMarker(Marker marker)
        {
            return 1;
        }
        public int EditMarker(Marker marker)
        {
            return 1;
        }
        public List<Marker> GetAllMarker()
        {
            return ;
        }
    }
}