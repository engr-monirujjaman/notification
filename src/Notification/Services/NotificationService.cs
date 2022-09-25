using Notification.Containers.Contracts;
using Notification.Enums;
using Notification.Models;
using Notification.Services.Contracts;

namespace Notification.Services;

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

    public IEnumerable<NotificationEntity> GetNotifications() => _notificationContainer.GetAll();

    public IEnumerable<NotificationEntity> ReadAllNotifications() => _notificationContainer.ReadAll();

    public void RemoveAll() => _notificationContainer.Clear();
}