namespace Notification.Core.Services.Contracts;

public interface ITempDataService
{
    T? Get<T>(string key) where T : class;

    T? Peek<T>(string key) where T : class;

    void Add<T>(string key, T value) where T : class;

    bool Remove(string key);
}