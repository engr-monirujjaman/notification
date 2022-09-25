using Notification.Models;

namespace Notification.Containers.Contracts;

public interface INotificationMessageContainerFactory
{
    INotificationContainer<T> Create<T>() where T : BaseNotification;
}