using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Notification.Extensions;
using Notification.Models;
using Notification.Services.Contracts;

namespace Notification.Middlewares;

public class NotificationMiddleware : IMiddleware
{
    private readonly INotificationService _notificationService;
    private readonly NotificationConfig _config;

    public NotificationMiddleware(INotificationService notificationService, NotificationConfig config)
    {
        _notificationService = notificationService;
        _config = config;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        context.Response.OnStarting(() =>
        {
            try
            {
                if (context.Request.IsNotificationAjaxRequest())
                {
                    var notifications = _notificationService.ReadAllNotifications().ToList();
                    if (notifications.Any())
                    {
                        var data = new NotificationViewModel
                        {
                            Options = _config,
                            Notifications = notifications
                        };
                        
                        context.Response.Headers.Add("Access-Control-Expose-Headers",
                            new StringValues(NotificationConstants.NotificationResponseHeaderKey));
                        context.Response.Headers.Add(NotificationConstants.NotificationResponseHeaderKey,
                            new StringValues(WebUtility.UrlEncode(data.ToJson())));
                        
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return Task.CompletedTask;
        });
        await next(context);
    }
}