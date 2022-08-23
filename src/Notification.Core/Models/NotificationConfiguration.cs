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
        InfoSetting.AlertBackgroundColor ??= "#CDE2FF";
        InfoSetting.AlertMessageTitleColor ??= "#3d75e5";
        InfoSetting.AlertMessageColor ??= "#3d75e5";
        InfoSetting.AlertIconColor ??= "#3d75e5";
        InfoSetting.AlertLeftBorderColor ??= "#3D84E5";
        InfoSetting.CloseButtonBackgroundColor ??= "#83a4f2";
        InfoSetting.CloseButtonIconColor ??= "#3d75e5";
        InfoSetting.CloseButtonHoverColor ??= "#83B2F2";
        InfoSetting.Icon ??= "fa-solid fa-circle-info";
        return this;
    }
    
    public NotificationConfiguration AddWarning(NotificationSetting setting)
    {
        WarningSetting = setting;
        WarningSetting.AlertBackgroundColor ??= "#ffdb9b";
        WarningSetting.AlertMessageTitleColor ??= "#ce8500";
        WarningSetting.AlertMessageColor ??= "#ce8500";
        WarningSetting.AlertIconColor ??= "#ce8500";
        WarningSetting.AlertLeftBorderColor ??= "#ffa502";
        WarningSetting.CloseButtonBackgroundColor ??= "#ffd080";
        WarningSetting.CloseButtonIconColor ??= "#ce8500";
        WarningSetting.CloseButtonHoverColor ??= "#ffc766";
        WarningSetting.Icon ??= "fa-solid fa-triangle-exclamation";
        return this;
    }
    
    public NotificationConfiguration AddSuccess(NotificationSetting setting)
    {
        SuccessSetting = setting;
        SuccessSetting.AlertBackgroundColor ??= "#C5F7DC";
        SuccessSetting.AlertMessageTitleColor ??= "#3ac273";
        SuccessSetting.AlertMessageColor ??= "#3ac273";
        SuccessSetting.AlertIconColor ??= "#3ac273";
        SuccessSetting.AlertLeftBorderColor ??= "#3ac248";
        SuccessSetting.CloseButtonBackgroundColor ??= "#84d197";
        SuccessSetting.CloseButtonIconColor ??= "#3ac273";
        SuccessSetting.CloseButtonHoverColor ??= "#a4dbb2";
        SuccessSetting.Icon ??= "fa-solid fa-circle-check";
        return this;
    }
    
    
    public NotificationConfiguration AddError(NotificationSetting setting)
    {
        ErrorSetting = ErrorSetting;
        ErrorSetting.AlertBackgroundColor ??= "#FFCFCB";
        ErrorSetting.AlertMessageTitleColor ??= "#a3180b";
        ErrorSetting.AlertMessageColor ??= "#a3180b";
        ErrorSetting.AlertIconColor ??= "#a3180b";
        ErrorSetting.AlertLeftBorderColor ??= "#E9594C";
        ErrorSetting.CloseButtonBackgroundColor ??= "#ed817e";//
        ErrorSetting.CloseButtonIconColor ??= "#a3180b";
        ErrorSetting.CloseButtonHoverColor ??= "#e66763";
        ErrorSetting.Icon ??= "fa-solid fa-circle-exclamation";
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
            DurationInSeconds = DurationInSeconds > 0 ? DurationInSeconds * 1000 : 5000,
            Position = Position,
            WarningSetting = WarningSetting,
            InfoSetting = InfoSetting,
            SuccessSetting = SuccessSetting,
            ErrorSetting = ErrorSetting
        };
    }
}