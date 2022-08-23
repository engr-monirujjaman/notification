using Notification.Core.Enums;

namespace Notification.Core.Models;

public class NotificationConfiguration
{
    public int DurationInSeconds { get; set; } = 5;

    public NotificationPosition Position { get; set; } = NotificationPosition.TopRight;
    
    private NotificationSetting InfoSetting { get; set; } = new();
    
    private NotificationSetting WarningSetting { get; set; } = new();
    
    private NotificationSetting SuccessSetting { get; set; } = new();
    
    private NotificationSetting ErrorSetting { get; set; } = new();

    public NotificationConfiguration AddInformation(NotificationSetting setting)
    {
        InfoSetting = setting;
        InfoSetting.AlertBackgroundColor ??= "#ffdb9b";
        InfoSetting.AlertMessageColor ??= "#ce8500";
        InfoSetting.AlertIconColor ??= "#ce8500";
        InfoSetting.AlertLeftBorderColor ??= "#ffa502";
        InfoSetting.CloseButtonBackgroundColor ??= "#ffd080";
        InfoSetting.CloseButtonIconColor ??= "#ce8500";
        InfoSetting.CloseButtonHoverColor ??= "#ffc766";
        InfoSetting.Icon ??= "fas fa-info-circle";
        return this;
    }
    
    public NotificationConfiguration AddWarning(NotificationSetting setting)
    {
        WarningSetting = setting;
        WarningSetting.AlertBackgroundColor ??= "#ffdb9b";
        WarningSetting.AlertMessageColor ??= "#ce8500";
        WarningSetting.AlertIconColor ??= "#ce8500";
        WarningSetting.AlertLeftBorderColor ??= "#ffa502";
        WarningSetting.CloseButtonBackgroundColor ??= "#ffd080";
        WarningSetting.CloseButtonIconColor ??= "#ce8500";
        WarningSetting.CloseButtonHoverColor ??= "#ffc766";
        WarningSetting.Icon ??= "fas fa-exclamation-circle";
        return this;
    }
    
    public NotificationConfiguration AddSuccess(NotificationSetting setting)
    {
        SuccessSetting = setting;
        SuccessSetting.AlertBackgroundColor ??= "#ffdb9b";
        SuccessSetting.AlertMessageColor ??= "#ce8500";
        SuccessSetting.AlertIconColor ??= "#ce8500";
        SuccessSetting.AlertLeftBorderColor ??= "#ffa502";
        SuccessSetting.CloseButtonBackgroundColor ??= "#ffd080";
        SuccessSetting.CloseButtonIconColor ??= "#ce8500";
        SuccessSetting.CloseButtonHoverColor ??= "#ffc766";
        SuccessSetting.Icon ??= "fas fa-check-circle";
        return this;
    }
    
    
    public NotificationConfiguration AddError(NotificationSetting setting)
    {
        ErrorSetting = ErrorSetting;
        ErrorSetting.AlertBackgroundColor ??= "#ffdb9b";
        ErrorSetting.AlertMessageColor ??= "#ce8500";
        ErrorSetting.AlertIconColor ??= "#ce8500";
        ErrorSetting.AlertLeftBorderColor ??= "#ffa502";
        ErrorSetting.CloseButtonBackgroundColor ??= "#ffd080";
        ErrorSetting.CloseButtonIconColor ??= "#ce8500";
        WarningSetting.CloseButtonHoverColor ??= "#ffc766";
        ErrorSetting.Icon ??= "fas fa-exclamation";
        return this;
    }

    internal NotificationConfig Build()
    {
        AddInformation(new NotificationSetting());
        AddWarning(new NotificationSetting());
        AddSuccess(new NotificationSetting());
        AddError(new NotificationSetting());
        
        return new NotificationConfig
        {
            DurationInSeconds = DurationInSeconds,
            Position = Position,
            WarningSetting = WarningSetting,
            InfoSetting = InfoSetting,
            SuccessSetting = SuccessSetting,
            ErrorSetting = ErrorSetting
        };
    }
}