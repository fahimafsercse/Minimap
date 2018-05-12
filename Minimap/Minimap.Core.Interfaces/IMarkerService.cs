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
        //List<Marker> SearchMarkerByName(string txt);
        //List<Marker> SearchMarkerById(string id);


        //List<Marker> GetMyMarkers(int myId);










    }
}
