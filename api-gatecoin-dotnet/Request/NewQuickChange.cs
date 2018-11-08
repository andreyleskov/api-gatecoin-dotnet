using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/QuickChange", "POST", Summary = @"Place a quick order to trade again market maker", Notes = @"")]
    public class NewQuickChange : IReturn<QuickOrderResponse>
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

        [ApiMember(Name = "Price", Description = "The price from quote", ParameterType = "query", DataType = "decimal",
            IsRequired = true)]
        public decimal Price { get; set; }

        [ApiMember(Name = "QuoteID", Description = "The quote id from quote", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string QuoteID { get; set; }
    }
}