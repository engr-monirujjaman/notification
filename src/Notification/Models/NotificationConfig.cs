using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using Notification.Enums;

namespace Notification.Models;

public class NotificationConfig
{
    public bool CloseButton { get; set; }

    public bool Debug { get; set; }

    public bool NewestOnTop { get; set; }

    public bool ProgressBar { get; set; }

    [JsonConverter(typeof(SmartEnumValueConverter<NotificationPosition, string>))]
    public NotificationPosition PositionClass { get; set; } = default!;

    public bool PreventDuplicates { get; set; }

    public int ShowDuration { get; set; }

    public int HideDuration { get; set; }

    public int TimeOut { get; set; }

    public int ExtendedTimeOut { get; set; }

    [JsonConverter(typeof(SmartEnumValueConverter<EasingType, string>))]
    public EasingType ShowEasing { get; set; } = default!;

    [JsonConverter(typeof(SmartEnumValueConverter<EasingType, string>))]
    public EasingType HideEasing { get; set; } = default!;
    
    [JsonConverter(typeof(SmartEnumValueConverter<EasingType, string>))]
    public EasingType CloseEasing { get; set; } = default!;

    [JsonConverter(typeof(SmartEnumValueConverter<AnimationMethod, string>))]
    public AnimationMethod ShowMethod { get; set; } = default!;

    [JsonConverter(typeof(SmartEnumValueConverter<AnimationMethod, string>))]
    public AnimationMethod HideMethod { get; set; } = default!;    
    
    [JsonConverter(typeof(SmartEnumValueConverter<AnimationMethod, string>))]
    public AnimationMethod CloseMethod { get; set; } = default!;
}