using Ardalis.SmartEnum;

namespace Notification.Enums;

public class EasingType : SmartEnum<EasingType, string>
{
    public static readonly EasingType Swing = new(nameof(Swing), "swing");
    public static readonly EasingType Linear = new(nameof(Linear), "linear");
    public static readonly EasingType EaseOutBounce = new(nameof(EaseOutBounce), "easeOutBounce");
    public static readonly EasingType EaseInBack = new(nameof(EaseInBack), "easeInBack");
    
    public EasingType(string name, string value) : base(name, value)
    {
    }
}