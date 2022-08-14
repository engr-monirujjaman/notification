using Notification.Core.Containers.Contracts;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Containers;

public class TempDataNotificationContainer : INotificationContainer<NotificationEntity>
{
    private readonly ITempDataService _tempDataService;
    private const string Key = "5D525C27275A4C9DBEC923995EED8B24NOTIFICATIONKEY";

    public TempDataNotificationContainer(ITempDataService tempDataService)
    {
        _tempDataService = tempDataService;
    }

    public void Add(NotificationEntity notification)
    {
        var notifications = _tempDataService.Get<List<NotificationEntity>>(Key) ??
                            Enumerable.Empty<NotificationEntity>();

        _tempDataService.Add(Key, notifications.Append(notification));
    }

    public IEnumerable<NotificationEntity> GetAll() => _tempDataService.Peek<List<NotificationEntity>>(Key) ??
                                                 Enumerable.Empty<NotificationEntity>();

    public IEnumerable<NotificationEntity> ReadAll()
    {
        var notifications = _tempDataService.Get<List<NotificationEntity>>(Key) ??
                            Enumerable.Empty<NotificationEntity>();
        Clear();
        return notifications;
    }

    public void Clear() => _tempDataService.Remove(Key);
}