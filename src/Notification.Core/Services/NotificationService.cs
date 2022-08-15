using Notification.Core.Containers.Contracts;
using Notification.Core.Enums;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Services;

public class NotificationService : INotificationService
{
    private readonly INotificationContainer<NotificationEntity> _notificationContainer;

    public NotificationService(INotificationMessageContainerFactory messageContainerFactory)
    {
        _notificationContainer = messageContainerFactory.Create<NotificationEntity>();
    }

    public void Information(string message, string? title = null) =>
        _notificationContainer.Add(new NotificationEntity(title??"Information!" , message, NotificationType.Info));

    public void Success(string message, string? title = null) =>
        _notificationContainer.Add(new NotificationEntity(title??"Success!", message, NotificationType.Success));
    
    public void Warning(string message, string? title = null) =>
        _notificationContainer.Add(new NotificationEntity(title??"Warning!", message, NotificationType.Warning));

    public void Error(string message, string? title = null) =>
        _notificationContainer.Add(new NotificationEntity(title??"Error!", message, NotificationType.Error));

}