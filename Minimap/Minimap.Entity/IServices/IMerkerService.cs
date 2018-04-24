﻿using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.IServices
{
    public interface IMarkerService
    {
        int AddMarkers(List<Marker> markerList);
        int DeleteMarker(Marker marker);
        int EditMarker(Marker marker);
         List<Marker> GetAllMarkers();
        List<Marker> GetMyMarkers();
    }
}

