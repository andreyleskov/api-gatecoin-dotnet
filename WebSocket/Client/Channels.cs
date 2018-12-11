using System;
using System.Collections.Generic;
using GatecoinServiceInterface.WebSocket.Model;

namespace GatecoinServiceInterface.WebSocket.Client
{
    internal static class Channels
    {
        public const string Trade = "public/trade";
        public const string TradePrivate = "private/trade";
        public const string MarketDepth = "public/marketdepth";
        public const string Ticker = "public/ticker";
        private static readonly Dictionary<Type, string> PublicTypeMapping;
        private static readonly Dictionary<Type, string> PrivateTypeMapping;

        static Channels()
        {
            PublicTypeMapping = new Dictionary<Type, string>
            {
                [typeof(MarketDepthDto)] = MarketDepth,
                [typeof(TradeDto)] = Trade,
                [typeof(TickerDto)] = Ticker
            };

            PrivateTypeMapping = new Dictionary<Type, string>
            {
                [typeof(TradeDto)] = TradePrivate
            };
        }

        public static string GetChannelHub<TDto>()
        {
            var type = typeof(TDto);

            if (!PublicTypeMapping.ContainsKey(type))
            {
                throw new NotSupportedException($"The model type '{type}' is not supported");
            }

            return $"/v1/hub/{PublicTypeMapping[type]}";
        }

        public static string GetPrivateChannelHub<TDto>()
        {
            var type = typeof(TDto);

            if (!PrivateTypeMapping.ContainsKey(type))
            {
                throw new NotSupportedException($"The model type '{type}' is not supported");
            }

            return $"/v1/hub/{PrivateTypeMapping[type]}";
        }
    }
}