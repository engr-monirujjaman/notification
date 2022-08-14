using Notification.Core.Containers.Contracts;
using Notification.Core.Enums;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Services;

public class NotificationService : INotificationService
{
    private readonly INotificationContainer<NotificationEntity> _notificationContainer;

    public NotificationService(INotificationContainer<NotificationEntity> notificationContainer)
    {
        _notificationContainer = notificationContainer;
    }

    public void Information(string message) =>
        _notificationContainer.Add(new NotificationEntity(message, NotificationType.Info));

    public void Success(string message) =>
        _notificationContainer.Add(new NotificationEntity(message, NotificationType.Success));
    
    public void Warning(string message) =>
        _notificationContainer.Add(new NotificationEntity(message, NotificationType.Warning));

    public void Error(string message) =>
        _notificationContainer.Add(new NotificationEntity(message, NotificationType.Error));

}