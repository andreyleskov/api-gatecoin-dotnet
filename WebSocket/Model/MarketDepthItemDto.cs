using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MarketDepthItemDto
    {
        [JsonProperty("p")]
        public decimal Price { get; set; }
        [JsonProperty("q")]
        public decimal Amount { get; set; }
    }
}