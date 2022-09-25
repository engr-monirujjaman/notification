using Ardalis.SmartEnum;

namespace Notification.Enums;

public class NotificationPosition : SmartEnum<NotificationPosition, string>
{
    public static readonly NotificationPosition TopRight = new(nameof(TopRight), "toast-top-right");
    public static readonly NotificationPosition TopLeft = new(nameof(TopLeft), "toast-top-left");
    public static readonly NotificationPosition TopCenter = new(nameof(TopCenter), "toast-top-center");

    public static readonly NotificationPosition BottomRight = new(nameof(BottomRight), "toast-bottom-right");
    public static readonly NotificationPosition BottomLeft = new(nameof(BottomLeft), "toast-bottom-left");
    public static readonly NotificationPosition BottomCenter = new(nameof(BottomCenter), "toast-bottom-center");

    public NotificationPosition(string name, string value) : base(name, value)
    {
    }
}