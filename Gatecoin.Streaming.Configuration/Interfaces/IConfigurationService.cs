using Gatecoin.Streaming.Configuration.Data;

namespace Gatecoin.Streaming.Configuration.Interfaces
{
    public interface IConfigurationService
    {
        RedisSettings GetRedisSettings();

        StreamingSettings GetStreamingSettings();
    }
}