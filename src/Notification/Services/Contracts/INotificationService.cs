using Notification.Models;

namespace Notification.Services.Contracts;

public interface INotificationService
{
    void Information(string message, string? title = null);

    void Success(string message, string? title = null);
    
    void Warning(string message, string? title = null);
    
    void Error(string message, string? title = null);
    
    IEnumerable<NotificationEntity> GetNotifications();

    IEnumerable<NotificationEntity> ReadAllNotifications();

    void RemoveAll();
}