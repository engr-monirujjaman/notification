namespace Notification.Core.Containers.Contracts;

public interface INotificationContainer
{
    void Add(string message);

    IList<BaseNotification> GetAll();

    void Clear();
}