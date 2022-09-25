using Notification.Enums;

namespace Notification.Models;

public class NotificationEntity : BaseNotification
{
    public NotificationEntity(string title, string message, NotificationType type) : base(title, message, type)
    {
    }
}