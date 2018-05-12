using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{
    public class MarkerService:IMarkerService
    {
        private DataContext context;
        public MarkerService() { this.context = new DataContext(); }

        public int  AddMarkerList(List<Marker> markerList)
        {           
            foreach(var marker in markerList)
            {
                this.context.Markers.Add(marker);              
            }
             this.context.SaveChanges();
             return markerList.Count();            
        }

        //click on save button and  delete button
        public void EditMarkerList(List<Marker> markerList)
        {
            List<Marker> markers = this.context.Markers.ToList();
            foreach(var m in markers)
            {
                this.context.Markers.Remove(m);
                this.context.SaveChanges();
            }
            
            foreach(var m in markerList)
            {
                this.context.Markers.Add(m);
                this.context.SaveChanges();
            }
                   
        }

        //done
        public List<Marker> GetAllMarkers(int userId)
        {
            List<Marker> markers = this.context.Markers.ToList();
            List<Marker> Mymarkers = new List<Marker>();
            foreach (var m in markers)
            { 
                if(m.UserId== userId)
                {
                    Mymarkers.Add(m);
                }
            }
            return Mymarkers;
        }


        public Marker GetMarkerById(int markerid)
        {
            return this.context.Markers.SingleOrDefault(d => d.MarkerId == markerid);
        }
        public int DeleteMarkerById(int id)
        {
            Marker marker =  this.context.Markers.SingleOrDefault(d => d.MarkerId == id);
            this.context.Markers.Remove(marker);
            return this.context.SaveChanges();
        }

    }
    
}