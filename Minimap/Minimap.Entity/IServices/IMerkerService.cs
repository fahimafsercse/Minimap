using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.IServices
{
    public class IMarkerService
    {
        int AddMarker(Marker marker);
        int RemoveMarker(Marker marker);
        int EditMarker(Marker marker);
         List<Marker> GetAllMarker();
    }
}

