using Newtonsoft.Json;

namespace Gatecoin.Streaming.Dto
{
    public class MarketDepthItemDto
    {
        [JsonProperty("p")]
        public decimal Price { get; set; }
        [JsonProperty("q")]
        public decimal Amount { get; set; }
    }
}