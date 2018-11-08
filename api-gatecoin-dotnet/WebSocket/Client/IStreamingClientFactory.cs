using System.Threading.Tasks;
using GatecoinServiceInterface.WebSocket.Model;
using JetBrains.Annotations;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public interface IStreamingClientFactory
    {
        /// <summary>
        /// Builds and creates Gatecoin streaming client
        /// </summary>
        /// <returns>return Gatecoin streaming client</returns>
        [PublicAPI]
        [Pure]
        Task<IStreamingClient<TradeDto>> CreateTradeClient();

        /// <summary>
        /// Builds and creates Gatecoin streaming client
        /// </summary>
        /// <returns>return Gatecoin streaming client</returns>
        [PublicAPI]
        [Pure]
        Task<IStreamingClient<TickerDto>> CreateTickerClient();

        /// <summary>
        /// Builds and creates Gatecoin streaming client
        /// </summary>
        /// <returns>return Gatecoin streaming client</returns>
        [PublicAPI]
        [Pure]
        Task<IStreamingClient<MarketDepthDto>> CreateMarketDepthClient();
    }
}