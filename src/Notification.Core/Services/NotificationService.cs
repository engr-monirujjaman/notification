using Notification.Core.Services.Contracts;

namespace Notification.Core.Services;

public class NotificationService : INotificationService
{
    public NotificationService()
    {
        
    }
    
    public void Information(string message)
    {
        throw new NotImplementedException();
    }

    public void Success(string message)
    {
        throw new NotImplementedException();
    }

    public void Warning(string message)
    {
        throw new NotImplementedException();
    }

    public void Error(string message)
    {
        throw new NotImplementedException();
    }
}