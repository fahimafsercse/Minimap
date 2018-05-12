using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface IMarkerService
    {

        int AddMarkerList(List<Marker> markerList);
        void EditMarkerList(List<Marker> markerList);
        List<Marker> GetAllMarkers(int id);
        Marker GetMarkerById(int id);
        int DeleteMarkerById(int id);
        /*List<Marker> GetMyMarkers(int id);
        Marker GetMarkerById(int id);
        List<Marker> GetAllMarkers();

         
        void DeleteMarkerById(int id);
        void DeleteMarker(Marker marker);

        List<Marker> SearchMarkerByName(string txt);*/


    }
}
