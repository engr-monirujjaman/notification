using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Notification.Core.Extensions;
using Notification.Core.Services.Contracts;

namespace Notification.Core.Services;

public class TempDataService : ITempDataService
{
    private readonly ITempDataDictionary _tempData;
    
    public TempDataService(
        IHttpContextAccessor httpContextAccessor,
        ITempDataDictionaryFactory tempDataDictionaryFactory)
    {
       _tempData = tempDataDictionaryFactory.GetTempData(httpContextAccessor.HttpContext);
    }

    public T? Get<T>(string key) where T : class => _tempData.Get<T>(key);

    public T? Peek<T>(string key) where T : class => _tempData.Peek<T>(key);

    public void Add<T>(string key, T value) where T : class => _tempData.Put(key, value);

    public bool Remove(string key) => _tempData.Remove(key);
}