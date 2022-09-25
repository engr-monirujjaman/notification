using Microsoft.AspNetCore.Http;

namespace Notification.Extensions;

public static class HttpRequestExtensions
{
    public static bool IsNotificationAjaxRequest(this HttpRequest request)
    {
        if (request is null) throw new ArgumentNullException(nameof(request));

        if (request.Headers.TryGetValue(NotificationConstants.NotificationResponseHeaderKey, out var value1))
        {
            return !string.IsNullOrWhiteSpace(value1);
        }
        
        return request.Headers.TryGetValue(NotificationConstants.RequestHeaderKey, out var value) && !string.IsNullOrWhiteSpace(value);
    }
}