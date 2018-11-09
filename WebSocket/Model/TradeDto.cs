using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TradeDto
    {
        [JsonProperty("currencypair", Order = 1)]
        public string CurrencyPair { get; set; }
        [JsonProperty("trade")]
        public TradeItemDto Trade { get; set; }
    }
}