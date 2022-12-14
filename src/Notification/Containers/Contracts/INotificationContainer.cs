using Notification.Models;

namespace Notification.Containers.Contracts;

public interface INotificationContainer<T> where T : BaseNotification
{
    void Add(T message);

    IEnumerable<T> GetAll();

    IEnumerable<T> ReadAll();
    
    void Clear();
}