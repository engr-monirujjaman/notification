using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Notification.Core.Extensions;

public static class TempDataExtensions
{
    public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
    => tempData[key] =  value as string ?? JsonSerializer.Serialize(value);
    

    public static T? Get<T>(this ITempDataDictionary tempData, string key) where T : class
    => tempData.TryGetValue(key, out var value)
            ? value is string str ? JsonSerializer.Deserialize<T>(str) : default
            : default;
    

    public static T? Peek<T>(this ITempDataDictionary tempData, string key) where T : class
    => tempData.ContainsKey(key) && tempData.Peek(key) is string str
            ? JsonSerializer.Deserialize<T>(str)
            : default;

    public static bool Remove(this ITempDataDictionary tempData, string key) =>
        tempData.ContainsKey(key) && tempData.Remove(key);
}