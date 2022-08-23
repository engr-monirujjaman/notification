using Notification.Core.Enums;

namespace Notification.Core.Models;

public abstract class BaseNotification
{
    public BaseNotification(string title, string message, NotificationType type)
    {
        Title = title;
        Message = message;
        Type = type;
    }

    public string? Title { get; set; }
    
    public string? Message { get; set;}

    public NotificationType Type { get; set;}
}