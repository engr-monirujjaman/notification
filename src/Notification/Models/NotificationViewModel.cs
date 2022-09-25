namespace Notification.Models;

public class NotificationViewModel
{
    public NotificationConfig Options { get; set; } = default!;
    
    public IEnumerable<NotificationEntity>? Notifications { get; set; }
}