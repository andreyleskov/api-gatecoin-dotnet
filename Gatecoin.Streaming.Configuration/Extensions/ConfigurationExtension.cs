using Gatecoin.Streaming.Configuration.Interfaces;
using Gatecoin.Streaming.Configuration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gatecoin.Streaming.Configuration.Extensions
{
    public static class ConfigurationExtension
    {
        public static void RegisterConfigurationServices(this IServiceCollection services)
        {
            services.AddSingleton<IConfigurationService, ConfigurationService>();
            services.AddSingleton(t => t.GetService<IConfigurationService>().GetRedisSettings());
            services.AddSingleton(t => t.GetService<IConfigurationService>().GetStreamingSettings());
        }
    }
}