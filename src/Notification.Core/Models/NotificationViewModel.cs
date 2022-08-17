namespace Notification.Core.Models;

public class NotificationViewModel
{
    public NotificationConfiguration? Configuration { get; set; } = new();

    public IEnumerable<NotificationEntity>? Notifications { get; set; } = new List<NotificationEntity>();
}