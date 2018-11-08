using Gatecoin.Streaming.Dto;
using System;
using System.Collections.Generic;

namespace Gatecoin.Streaming.Common
{
    public static class Channels
    {
        public const string Trade = "trade";
        //public const string Order = "order";
        public const string MarketDepth = "marketdepth";
        public const string Ticker = "ticker";
        private static readonly Dictionary<Type, string> TypeMapping;

        static Channels()
        {
            TypeMapping = new Dictionary<Type, string>
                          {
                              [typeof(MarketDepthDto)] = MarketDepth,
                              [typeof(TradeDto)] = Trade,
                             // [typeof(OrderDto)] = Order,
                              [typeof(TickerDto)] = Ticker
                          };
        }

        public static string GetChannelHub<TDto>() where TDto : BaseDto
        {
            return $"/v1/hub/{TypeMapping[typeof(TDto)]}";
        }

        public static string GetChannelHub(string channel)
        {
            return $"/v1/hub/{channel}";
        }

        public static string GetChannelController(string channel)
        {
            return $"/v1/{channel}";
        }
    }
}