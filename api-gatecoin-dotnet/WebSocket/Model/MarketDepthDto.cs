using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MarketDepthDto
    {
        [JsonProperty("currencypair", Order = 1)]
        public string CurrencyPair { get; set; }
        [JsonProperty("asks")]
        public MarketDepthItemDto[] Asks { get; set; }
        [JsonProperty("bids")]
        public MarketDepthItemDto[] Bids { get; set; }
        [JsonProperty("last")]
        public decimal Last { get; set; }
    }
}