using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Interfaces
{
    public interface IMarkerService
    {
        int AddMarkerList(List<Marker> markerList);
        int DeleteMarker(Marker marker);
        int EditMarker(Marker marker);
        /* List<Marker> GetAllMarkers();
        List<Marker> GetMyMarkers();*/
    }
}

