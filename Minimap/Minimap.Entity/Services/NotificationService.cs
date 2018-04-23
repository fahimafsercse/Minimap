using Minimap.Entity.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Models
{
    public class NotificationService:INotificationService
    {
        public int AddNotification(Notification notification)
        {
            return 1;
        }
        public int DeleteNotification(Notification notification)
        {
            return 1;
        }
        public int EditNotification(Notification notification)
        {
            return 1;
        }
        public int GetNotificationNumber()
        {
            return 1;
        }
        public List<Notification> GetAllNotifications()
        {
            return;
        }
    }
}