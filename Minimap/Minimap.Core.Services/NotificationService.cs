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

        public void AddNotification(string txt)
        {

        }
        public void EditNotification(int Id)
        {

        }
        public void DeleteNotificationById(int Id)
        {

        }
        public Notification GetNotificationById(int Id)
        {
            Notification not = new Notification();
            return not;
        }
    }
}