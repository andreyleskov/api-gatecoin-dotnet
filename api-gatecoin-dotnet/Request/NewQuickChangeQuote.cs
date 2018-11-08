using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/QuickChange/Quote", "POST", Summary = @"Request a quote for quick order", Notes = @"")]
    public class NewQuickChangeQuote : IReturn<RequestForQuoteResponse>
    {
        [ApiMember(Name = "CurrencyFrom", Description = "Request for quote from currency, Ex: USD, HKD, BTC",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string CurrencyFrom { get; set; }

        [ApiMember(Name = "CurrencyTo", Description = "Request for quote to currency, Ex: USD, HKD, BTC",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string CurrencyTo { get; set; }

        [ApiMember(Name = "Amount", Description = "Amount expressed in the currency From if not specified",
            ParameterType = "query", DataType = "decimal", IsRequired = true)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "IsAmountInCurrencyFrom", Description = "Indicate whether the amount in currency from",
            ParameterType = "query", DataType = "bool", IsRequired = false)]
        public bool? IsAmountInCurrencyFrom { get; set; }
    }
}