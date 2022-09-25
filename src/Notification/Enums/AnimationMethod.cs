using Ardalis.SmartEnum;

namespace Notification.Enums;

public class AnimationMethod : SmartEnum<AnimationMethod, string>
{
    public static readonly AnimationMethod FadeIn = new(nameof(FadeIn), "fadeIn");
    public static readonly AnimationMethod FadeOut = new(nameof(FadeOut), "fadeOut");
    public static readonly AnimationMethod SlideDown = new(nameof(SlideDown), "slideDown");
    public static readonly AnimationMethod SlideUp = new(nameof(SlideUp), "slideUp");
    
    public AnimationMethod(string name, string value) : base(name, value)
    {
    }
}