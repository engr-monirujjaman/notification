using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using Notification.Enums;

namespace Notification.Models;

public abstract class BaseNotification
{
    public BaseNotification( string title, string message, NotificationType type)
    {
        Title = title;
        Message = message;
        Type = type;
    }

    public string Title { get; }
    
    public string Message { get; }

    [JsonConverter(typeof(SmartEnumValueConverter<NotificationType, string>))]
    public NotificationType Type { get; }
}