using Newtonsoft.Json;

namespace Gatecoin.Streaming.Dto
{
    public class MarketDepthDto : BaseDto
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