using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service.Interfaces
{
    public interface INotificationService
    {
         int AddNotification(Notification notification);
         int DeleteNotification(Notification notification);
         int EditNotification(Notification notification);
         int GetNotificationNumber();//how many notifications assigned for a  morker
         List<Notification> GetAllNotifications();

    }
}