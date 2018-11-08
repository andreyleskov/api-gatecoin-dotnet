using System;
using System.Collections.Generic;
using GatecoinServiceInterface.WebSocket.Model;

namespace GatecoinServiceInterface.WebSocket.Client
{
    internal static class Channels
    {
        public const string Trade = "trade";
        public const string MarketDepth = "marketdepth";
        public const string Ticker = "ticker";
        private static readonly Dictionary<Type, string> TypeMapping;

        static Channels()
        {
            TypeMapping = new Dictionary<Type, string>
                          {
                              [typeof(MarketDepthDto)] = MarketDepth,
                              [typeof(TradeDto)] = Trade,
                              [typeof(TickerDto)] = Ticker
                          };
        }

        public static string GetChannelHub<TDto>()
        {
            var type = typeof(TDto);

            if (!TypeMapping.ContainsKey(type))
            {
                throw new NotSupportedException($"The model type '{type}' is not supported");
            }

            return $"/v1/hub/{TypeMapping[type]}";
        }
    }
}