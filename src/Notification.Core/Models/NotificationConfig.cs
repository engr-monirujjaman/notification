using Notification.Core.Enums;

namespace Notification.Core.Models;

public class NotificationConfig
{
    public int DurationInSeconds { get; set; } = 2;

    public NotificationPosition Position { get; set; } = NotificationPosition.TopRight;
    
    
}