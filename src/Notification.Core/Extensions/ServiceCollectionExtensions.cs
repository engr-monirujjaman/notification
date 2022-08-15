using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using Notification.Core.Containers;
using Notification.Core.Containers.Contracts;
using Notification.Core.Enums;
using Notification.Core.Services;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddNotification(this IServiceCollection services, Action<NotificationConfig>? config = null)
    {
        services.AddSingleton<ITempDataService, TempDataService>();
        services.AddSingleton<INotificationMessageContainerFactory, NotificationMessageContainerFactory>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddHttpContextAccessor();
        
        if (services.FirstOrDefault(d => d.ServiceType == typeof (ITempDataProvider)) == null)
            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
        
        var notificationConfig = new NotificationConfig();
 
        if (config is not null)
        {
            config(notificationConfig);
        }
        else
        {
            notificationConfig.Position = NotificationPosition.TopRight;
            notificationConfig.DurationInSeconds = 2;
        }

        services.AddSingleton(notificationConfig);
    }
}