using Notification.Enums;

namespace Notification.Models;

public class NotificationConfiguration
{
    public bool CloseButton { get; set; }

    public bool Debug { get; set; }

    public bool NewestOnTop { get; set; }

    public bool ProgressBar { get; set; } = true;

    public NotificationPosition PositionClass { get; set; } = NotificationPosition.TopRight;

    public bool PreventDuplicates { get; set; }

    public int TimeOutInSecond { get; set; }

    public EasingType ShowEasing { get; set; } = EasingType.Swing;

    public EasingType HideEasing { get; set; } = EasingType.Linear;

    public EasingType CloseEasing { get; set; } = EasingType.Linear;

    public AnimationMethod ShowMethod { get; set; } = AnimationMethod.SlideDown;

    public AnimationMethod HideMethod { get; set; } = AnimationMethod.SlideUp;
    
    public AnimationMethod CloseMethod { get; set; } = AnimationMethod.SlideUp;

    internal NotificationConfig Build()
    {
        return new NotificationConfig
        {
            TimeOut = TimeOutInSecond > 0 ? TimeOutInSecond * 1000 : 5000,
            CloseButton = CloseButton,
            Debug = Debug,
            NewestOnTop = NewestOnTop,
            ProgressBar = ProgressBar,
            PositionClass = PositionClass,
            PreventDuplicates = PreventDuplicates,
            ShowDuration = 300,
            HideDuration = 1000,
            ExtendedTimeOut = 1000,
            ShowEasing = ShowEasing,
            HideEasing = HideEasing,
            CloseEasing = CloseEasing,
            ShowMethod = ShowMethod,
            HideMethod = HideMethod,
            CloseMethod = CloseMethod
        };
    }
}