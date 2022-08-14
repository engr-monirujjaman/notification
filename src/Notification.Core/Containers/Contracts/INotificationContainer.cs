namespace Notification.Core.Containers.Contracts;

public interface INotificationContainer<T> where T : BaseNotification
{
    void Add(T message);

    IEnumerable<T> GetAll();

    IEnumerable<T> ReadAll();
    
    void Clear();
}