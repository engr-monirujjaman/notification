namespace Notification.Core.Models;

public class NotificationViewModel
{
    public NotificationConfig Configuration { get; set; } = new();

    public IEnumerable<NotificationEntity>? Notifications { get; set; }
}