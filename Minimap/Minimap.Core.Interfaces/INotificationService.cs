using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface INotificationService
    {
        void AddNotification(string txt);
        void EditNotification(int Id);
        void DeleteNotificationById(int Id);
        Notification GetNotificationById(int Id);
    }
}
