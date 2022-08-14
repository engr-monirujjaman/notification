using Microsoft.Extensions.DependencyInjection;

namespace Notification.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddNotification(this IServiceCollection services, Action<NotificationConfig> config)
    {
        
    }
}