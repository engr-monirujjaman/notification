using Microsoft.AspNetCore.Mvc;
using Notification.Models;
using Notification.Services.Contracts;

namespace Notification.ViewComponents;

[ViewComponent(Name = "Notification")]
public class NotificationViewComponent : ViewComponent
{
    private readonly INotificationService _notificationService;
    private readonly NotificationConfig _configuration;

    public NotificationViewComponent(INotificationService notificationService, NotificationConfig configuration)
    {
        _notificationService = notificationService;
        _configuration = configuration;
    }
    
    public IViewComponentResult Invoke()
    {
        return View("Default", new NotificationViewModel
        {
            Options = _configuration,
            Notifications = _notificationService.ReadAllNotifications()
        });
    }
    
}