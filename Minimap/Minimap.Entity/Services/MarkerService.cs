﻿using Minimap.Entity.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class MarkerService: IMarkerService
    {
        

        public int AddMarkers(List<Marker> markerList)
        {
            return 1;
        }
        public int DeleteMarker(Marker marker)
        {
            return 1;
        }
        public int EditMarker(Marker marker)
        {
            return 1;
        }
        public List<Marker> GetAllMarkers()
        {
            return ;
        }
        public List<Marker> GetMyMarkers()
        {
            return;
        }
    }
}