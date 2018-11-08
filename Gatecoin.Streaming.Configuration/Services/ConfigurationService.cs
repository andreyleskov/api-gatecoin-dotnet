using Gatecoin.Streaming.Configuration.Data;
using Gatecoin.Streaming.Configuration.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Gatecoin.Streaming.Configuration.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public RedisSettings GetRedisSettings()
        {
            return _configuration
                .GetSection("redis")
                .Get<RedisSettings>();
        }

        public StreamingSettings GetStreamingSettings()
        {
            return _configuration
                .GetSection("streaming")
                .Get<StreamingSettings>();
        }
    }
}