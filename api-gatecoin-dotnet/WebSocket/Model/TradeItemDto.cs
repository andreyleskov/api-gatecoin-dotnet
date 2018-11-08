using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TradeItemDto
    {
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("tid")]
        public long Tid { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("askOrderId")]
        public string AskOrderId { get; set; }
        [JsonProperty("bidOrderId")]
        public string BidOrderId { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
    }
}