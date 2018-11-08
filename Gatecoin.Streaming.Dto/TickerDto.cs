using Newtonsoft.Json;

namespace Gatecoin.Streaming.Dto
{
    public class TickerDto : BaseDto
    {
        [JsonProperty("currencypair", Order = 1)]
        public string CurrencyPair { get; set; }
        [JsonProperty("ticker")]
        public TickerItemDto Ticker { get; set; }
    }
}