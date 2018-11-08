using Serilog.Events;

namespace Gatecoin.Streaming.Configuration.Data
{
    public class LoggerSettings
    {
        public bool IncludeAspNet { get; set; } = false;

        public LogEventLevel LogEventLevel { get; set; } = LogEventLevel.Information;

        public string LogsFolder { get; set; } = @"./logs";

        public static LoggerSettings Default { get; } = new LoggerSettings();
    }
}