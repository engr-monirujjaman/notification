using Microsoft.AspNetCore.Mvc;
using Notification.Core.Enums;

namespace Notification.Core.ViewComponents;

[ViewComponent(Name = "Notification")]
public class NotificationViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("Default", new NotificationViewModel
        {
            Configuration = "Test Notification Configurations",
            Notifications = new List<BaseNotification>
            {
                new NotificationEntity("Warning!", "Test Warning Message", NotificationType.Warning)
            }
        });
    }
    
}