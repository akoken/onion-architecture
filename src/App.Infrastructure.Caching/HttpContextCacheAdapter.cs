using OnionArchitecture.Core.ApplicationServices;
using System.Web;

namespace OnionArchitecture.Infrastructure.Caching
{
    public class HttpContextCacheAdapter : ICacheService
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public T Retrieve<T>(string storageKey) where T : class
        {
            T item = HttpContext.Current.Cache.Get(storageKey) as T;          

            return item;
        }
    }
}