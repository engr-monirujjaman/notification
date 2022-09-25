using Notification.Containers.Contracts;
using Notification.Models;
using Notification.Services.Contracts;

namespace Notification.Containers;

public class TempDataNotificationContainer<T> : INotificationContainer<T> where T : BaseNotification
{
    private readonly ITempDataService _tempDataService;
    private const string Key = "5D525C27275A4C9DBEC923995EED8B24NOTIFICATIONKEY";

    public TempDataNotificationContainer(ITempDataService tempDataService)
    {
        _tempDataService = tempDataService;
    }

    public void Add(T notification)
    {
        var notifications = _tempDataService.Get<List<T>>(Key) ?? Enumerable.Empty<T>();

        _tempDataService.Add(Key, notifications.Append(notification));
    }

    public IEnumerable<T> GetAll() => _tempDataService.Peek<List<T>>(Key) ?? Enumerable.Empty<T>();

    public IEnumerable<T> ReadAll()
    {
        var notifications = _tempDataService.Get<List<T>>(Key) ?? Enumerable.Empty<T>();
        Clear();
        return notifications;
    }

    public void Clear() => _tempDataService.Remove(Key);
}