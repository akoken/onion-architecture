namespace App.Infrastructure.Interfaces
{
    public interface ICacheService
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string storageKey) where T : class;
    }
}
