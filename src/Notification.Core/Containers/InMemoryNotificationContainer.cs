using Notification.Core.Containers.Contracts;

namespace Notification.Core.Containers;

public class InMemoryNotificationContainer<T> : INotificationContainer<T> where T : BaseNotification
{
    private readonly List<T> _messages;

    public InMemoryNotificationContainer() => _messages = new List<T>();

    public void Add(T notification) => _messages.Add(notification);


    public IEnumerable<T> GetAll() => _messages;

    public IEnumerable<T> ReadAll()
    {
        var notifications = _messages.ToList();
        Clear();
        return notifications;
    }

    public void Clear() => _messages.Clear();
}