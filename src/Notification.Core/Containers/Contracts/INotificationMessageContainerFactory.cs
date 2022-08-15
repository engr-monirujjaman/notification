namespace Notification.Core.Containers.Contracts;

public interface INotificationMessageContainerFactory
{
    INotificationContainer<T> Create<T>() where T : BaseNotification;
}