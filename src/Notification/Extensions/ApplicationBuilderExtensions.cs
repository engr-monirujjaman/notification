using Microsoft.AspNetCore.Builder;
using Notification.Middlewares;

namespace Notification.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseNotification(this IApplicationBuilder builder)
    {
        builder.UseMiddleware<NotificationMiddleware>();
        return builder;
    }
}