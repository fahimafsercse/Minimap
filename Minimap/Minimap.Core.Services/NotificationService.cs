using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{
    public class NotificationService:INotificationService
    {
        private DataContext context;
        public NotificationService() { this.context = new DataContext(); }

        /*void AddNotification(string txt)
        {

        }
        void EditNotification(int Id)
        {

        }
        void DeleteNotificationById(int Id)
        {

        }
        Notification GetNotificationById(int Id)
        {

        }*/
    }
}