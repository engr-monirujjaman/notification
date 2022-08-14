using Notification.Core.Enums;

namespace Notification.Core.Models;

public class NotificationEntity : BaseNotification
{
    public NotificationEntity(string title, string message, NotificationType type) : base(title, message, type)
    {
        
    }


    internal void Prepare()
    {
        
    }
}