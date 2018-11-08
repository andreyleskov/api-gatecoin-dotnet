using Newtonsoft.Json;

namespace Gatecoin.Streaming.Dto
{
    public class TradeDto : BaseDto
    {
        [JsonProperty("currencypair", Order = 1)]
        public string CurrencyPair { get; set; }
        [JsonProperty("trade")]
        public TradeItemDto Trade { get; set; }
    }
}