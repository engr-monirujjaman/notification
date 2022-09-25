using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Notification.Extensions;

public static class TempDataExtensions
{
    public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
    => tempData[key] =  value as string ?? JsonSerializer.Serialize(value);
    
    public static T? Get<T>(this ITempDataDictionary tempData, string key) where T : class
    {
        if (tempData.TryGetValue(key, out var value))
        {
            return typeof(T) == typeof(string) ? (T) value! : value is string str ? JsonSerializer.Deserialize<T>(str) : default;
        }

        return default;
    }

    public static T? Peek<T>(this ITempDataDictionary tempData, string key) where T : class
    {
        if (tempData.ContainsKey(key))
        {
            var value = tempData.Peek(key);
            
            return typeof(T) == typeof(string) ? (T) value! : value is string str
                ? JsonSerializer.Deserialize<T>(str)
                : default;
        }

        return default;
    }

    public static bool Remove(this ITempDataDictionary tempData, string key) =>
        tempData.ContainsKey(key) && tempData.Remove(key);
}