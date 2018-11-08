using System.Threading.Tasks;
using GatecoinServiceInterface.WebSocket.Model;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public class StreamingClientFactory : IStreamingClientFactory
    {
        private readonly IStreamingClientTypeBuilder _builder;

        public StreamingClientFactory()
        {
            _builder = new StreamingClientTypeBuilder();
        }

        public async Task<IStreamingClient<TradeDto>> CreateTradeClient()
        {
            var buildTradeClient = _builder.BuildClient<TradeDto>();
            await buildTradeClient.Start();
            return buildTradeClient;
        }

        public async Task<IStreamingClient<TickerDto>> CreateTickerClient()
        {
            var streamingClient = _builder.BuildClient<TickerDto>();
            await streamingClient.Start();
            return streamingClient;
        }

        public async Task<IStreamingClient<MarketDepthDto>> CreateMarketDepthClient()
        {
            var marketDepthClient = _builder.BuildClient<MarketDepthDto>();
            await marketDepthClient.Start();
            return marketDepthClient;
        }
    }
}