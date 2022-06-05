using Microsoft.Extensions.Caching.Memory;

namespace DotNet7Demos.Demos
{
    public static class MemoryCacheMatrices
    {
        // Read more - https://github.com/dotnet/runtime/issues/50406
        public static void Demo()
        {
            // Set cache options
            var cacheOptions = new MemoryCacheOptions();
            // Make TrackStatistics flag enabled
            // For DI `services.AddMemoryCache(options => options.TrackStatistics = true);`
            cacheOptions.TrackStatistics = true;

            IMemoryCache cache = new MemoryCache(cacheOptions);
            var repository = new UserRepository(cache);
            
            var result1 = repository.GetUsersCacheAsync(); 
            var result2 = repository.GetUsersCacheAsync();
        }
    }

    public class UserRepository
    {
        private readonly IMemoryCache _memoryCache;

        public UserRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public List<User> GetUsersCacheAsync()
        {
            var output = _memoryCache.Get<List<User>>("users");

            // Available metrics for Microsoft.Extensions.Caching
            var stats = _memoryCache.GetCurrentStatistics();
            Console.WriteLine(stats?.TotalHits);
            Console.WriteLine(stats?.TotalMisses);
            Console.WriteLine(stats?.CurrentEntryCount);
            Console.WriteLine(stats?.CurrentEstimatedSize);

            if (output is not null) return output;

            output = new()
            {
                new() { FirstName = "John M.", LastName = "Harshman" },
                new() { FirstName = "Robert", LastName = "Howley" },
                new() { FirstName = "Mike", LastName = "Gold" }
            };

            _memoryCache.Set("users", output, TimeSpan.FromMinutes(1));
            return output;
        }
    }

    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}