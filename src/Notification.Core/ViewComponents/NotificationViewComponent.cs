using Microsoft.AspNetCore.Mvc;
using Notification.Core.Services.Contracts;

namespace Notification.Core.ViewComponents;

[ViewComponent(Name = "Notification")]
public class NotificationViewComponent : ViewComponent
{
    private readonly INotificationService _notificationService;
    private readonly NotificationConfiguration _configuration;

    public NotificationViewComponent(INotificationService notificationService, NotificationConfiguration configuration)
    {
        _notificationService = notificationService;
        _configuration = configuration;
        _configuration.DurationInSeconds *= 1000;
    }
    
    public IViewComponentResult Invoke(Action<NotificationConfiguration>? configuration)
    {
        return View("Default", new NotificationViewModel
        {
            Configuration = _configuration,
                Notifications = _notificationService.ReadAllNotifications()
        });
    }
    
}