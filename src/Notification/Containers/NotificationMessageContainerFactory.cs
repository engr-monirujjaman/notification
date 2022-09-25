using Microsoft.AspNetCore.Http;
using Notification.Containers.Contracts;
using Notification.Extensions;
using Notification.Models;
using Notification.Services.Contracts;

namespace Notification.Containers;

public class NotificationMessageContainerFactory : INotificationMessageContainerFactory
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ITempDataService _tempDataService;

    public NotificationMessageContainerFactory(
        IHttpContextAccessor httpContextAccessor,
        ITempDataService tempDataService)
    {
        _httpContextAccessor = httpContextAccessor;
        _tempDataService = tempDataService;
    }

    public INotificationContainer<T> Create<T>() where T : BaseNotification
        => _httpContextAccessor.HttpContext!.Request.IsNotificationAjaxRequest()
            ? new InMemoryNotificationContainer<T>()
            : new TempDataNotificationContainer<T>(_tempDataService);
}