using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using Notification.Containers;
using Notification.Containers.Contracts;
using Notification.Middlewares;
using Notification.Models;
using Notification.Services;
using Notification.Services.Contracts;

namespace Notification.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddNotification(this IServiceCollection services, Action<NotificationConfiguration>? config = null)
    {
        services.AddSingleton<ITempDataService, TempDataService>();
        services.AddSingleton<INotificationMessageContainerFactory, NotificationMessageContainerFactory>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<NotificationMiddleware>();
        services.AddHttpContextAccessor();
        
        if (services.FirstOrDefault(d => d.ServiceType == typeof (ITempDataProvider)) == null)
            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
        
        var notificationConfig = new NotificationConfiguration();

        config?.Invoke(notificationConfig);
        
        services.AddSingleton(notificationConfig.Build());
    }
}