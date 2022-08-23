using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Notification.Core.Extensions;
using Notification.Core.Services.Contracts;

namespace Notification.Core.ViewComponents;

[ViewComponent(Name = "Notification")]
public class NotificationViewComponent : ViewComponent
{
    private readonly INotificationService _notificationService;
    private readonly NotificationConfig _configuration;

    public NotificationViewComponent(INotificationService notificationService, NotificationConfig configuration)
    {
        _notificationService = notificationService;
        _configuration = configuration;
        _configuration.DurationInSeconds *= 1000;
    }
    
    public IViewComponentResult Invoke()
    {
        return View("Default", new NotificationViewModel
        {
            Configuration = _configuration,
                Notifications = _notificationService.ReadAllNotifications()
        });
    }
    
}