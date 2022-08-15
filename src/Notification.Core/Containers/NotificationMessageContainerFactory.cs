using Microsoft.AspNetCore.Http;
using Notification.Core.Containers.Contracts;
using Notification.Core.Extensions;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Containers;

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
        => _httpContextAccessor.HttpContext!.Request.IsAjaxRequest()
            ? new InMemoryNotificationContainer<T>()
            : new TempDataNotificationContainer<T>(_tempDataService);
}