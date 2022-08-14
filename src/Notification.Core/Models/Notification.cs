using Notification.Core.Enums;

namespace Notification.Core.Models;

public class BaseNotification
{
    public string? Message { get; set;}

    public string? AlertBackgroundColor { get; set;}

    public string? AlertMessageColor { get; set; }

    public string? AlertIconColor { get; set;}

    public string? AlertLeftBorderColor { get; set;}

    public string? CloseButtonBackgroundColor { get; set; }

    public string? CloseButtonIconColor { get; set; }

    public string? CloseButtonHoverColor { get; set; }

    public string? AlertIcon { get; set; }
    
    public NotificationType Type { get; set;}

    public int Time { get;set; }
}