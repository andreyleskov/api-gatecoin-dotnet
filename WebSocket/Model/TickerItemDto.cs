using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TickerItemDto
    {
        [JsonProperty("timeframe")]
        public string Timeframe { get; set; }
        [JsonProperty("high")]
        public decimal High { get; set; }
        [JsonProperty("low")]
        public decimal Low { get; set; }
        [JsonProperty("vol")]
        public decimal Vol { get; set; }
        [JsonProperty("vwap")]
        public decimal Vwap { get; set; }
        [JsonProperty("open")]
        public decimal Open { get; set; }
        [JsonProperty("last")]
        public decimal Last { get; set; }
        [JsonProperty("now")]
        public long Now { get; set; }
    }
}