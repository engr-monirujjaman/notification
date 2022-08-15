namespace Notification.Core.Models;

public class NotificationViewModel
{
    public string? Configuration { get; set; }

    public IEnumerable<BaseNotification>? Notifications { get; set; }
}