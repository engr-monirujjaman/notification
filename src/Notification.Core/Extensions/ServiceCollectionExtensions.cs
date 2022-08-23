using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using Notification.Core.Containers;
using Notification.Core.Containers.Contracts;
using Notification.Core.Services;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddNotification(this IServiceCollection services, Action<NotificationConfiguration>? config = null)
    {
        services.AddSingleton<ITempDataService, TempDataService>();
        services.AddSingleton<INotificationMessageContainerFactory, NotificationMessageContainerFactory>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddHttpContextAccessor();
        
        if (services.FirstOrDefault(d => d.ServiceType == typeof (ITempDataProvider)) == null)
            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
        
        var notificationConfig = new NotificationConfiguration();

        config?.Invoke(notificationConfig);

        services.AddSingleton(notificationConfig.Build());
    }
}