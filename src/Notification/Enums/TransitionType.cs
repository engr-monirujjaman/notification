using Ardalis.SmartEnum;

namespace Notification.Enums;

public class TransitionType : SmartEnum<TransitionType, string>
{
    public static readonly TransitionType Slide = new(nameof(Slide), "slide");
    public static readonly TransitionType Plain = new(nameof(Plain), "plain");
    public static readonly TransitionType Fade = new(nameof(Fade), "fade");
    
    public TransitionType(string name, string value) : base(name, value)
    {
    }
}