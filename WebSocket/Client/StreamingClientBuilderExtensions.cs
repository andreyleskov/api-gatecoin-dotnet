using GatecoinServiceInterface.WebSocket.Model;
using JetBrains.Annotations;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public static class StreamingClientBuilderExtensions
    {
        [PublicAPI]
        [Pure]
        public static IStreamingClient<TradeDto> BuildTraderClient(
            [NotNull] this IStreamingClientBuilder builder)
        {
            return builder.BuildClient<TradeDto>();
        }

        [PublicAPI]
        [Pure]
        public static IStreamingClient<TickerDto> BuildTickerClient(
            [NotNull] this IStreamingClientBuilder builder)
        {
            return builder.BuildClient<TickerDto>();
        }

        [PublicAPI]
        [Pure]
        public static IStreamingClient<MarketDepthDto> BuildMarketDepthClient(
            [NotNull] this IStreamingClientBuilder builder)
        {
            return builder.BuildClient<MarketDepthDto>();
        }
    }
}