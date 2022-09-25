using Ardalis.SmartEnum;

namespace Notification.Enums;

public class NotificationType : SmartEnum<NotificationType, string>
{
    public static readonly NotificationType Info = new(nameof(Info), "info");
    public static readonly NotificationType Success = new(nameof(Success), "success");
    public static readonly NotificationType Warning = new(nameof(Warning), "warning");
    public static readonly NotificationType Error = new(nameof(Error), "error");

    public NotificationType(string name, string value) : base(name, value)
    {
    }
}