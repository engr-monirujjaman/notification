using Notification.Core.Enums;

namespace Notification.Core.Models;

public class NotificationConfig
{
    public int DurationInSeconds { get; set; } = 5;

    public NotificationPosition Position { get; set; } = NotificationPosition.TopRight;
    
    public NotificationSetting InfoSetting { get; set; } = new();
    
    public NotificationSetting WarningSetting { get; set; } = new();
    
    public NotificationSetting SuccessSetting { get; set; } = new();
    
    public NotificationSetting ErrorSetting { get; set; } = new();

    public string PositionClass() => Position == NotificationPosition.TopRight ? "column-reverse" : "column";
}