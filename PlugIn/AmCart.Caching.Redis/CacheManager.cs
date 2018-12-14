using Microsoft.Extensions.Caching.Distributed;
using ProtoBuf;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AmCart.Caching.Redis
{
    public sealed class CacheManager
    {
        private readonly IDistributedCache _cache;

        public CacheManager(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<T> SetAsync<T>(string key, T value)
        {
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, value);
                //string stringBase64 = Convert.ToBase64String(stream.ToArray());
                //new BinaryFormatter().Serialize(stream, value);
                var setbytes = stream.ToArray();

                await _cache.SetAsync(key, setbytes);

            }
            return value;
        }

        public async Task<T> GetAsync<T>(string key)
        {
            var bytes = await _cache.GetAsync(key);
            if (bytes == null)
            {
                return default;
            }
            T value;
            using (var stream = new MemoryStream(bytes))
            {
                //var obj = new BinaryFormatter().Deserialize(stream);
                value = Serializer.Deserialize<T>(stream);
                // value = (T)obj;

            }
            return value;


        }
    }
}
