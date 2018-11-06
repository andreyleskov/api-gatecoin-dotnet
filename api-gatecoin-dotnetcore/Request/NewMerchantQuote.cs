using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Payment/Quote", "POST", Summary = @"Request a quote for quick order", Notes = @"")]
    public class NewMerchantQuote : IReturn<MerchantQuoteResponse>
    {
        [ApiMember(Name = "Label", Description = "Label", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Label { get; set; }

        [ApiMember(Name = "CurrencyTo", Description = "Request for quote to currency, Ex: USD, HKD, EUR",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string CurrencyTo { get; set; }

        [ApiMember(Name = "Amount", Description = "Amount expressed in the currency From if not specified",
            ParameterType = "query", DataType = "decimal", IsRequired = true)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "IsAmountInCurrencyFrom",
            Description =
                "If true, convert xxx amount of BTC to CurrencyTo. If false, convert xxx amount of CurrencyTo to BTC ",
            ParameterType = "query", DataType = "bool", IsRequired = false)]
        public bool IsAmountInCurrencyFrom { get; set; }

        [ApiMember(Name = "Reference",
            Description = "Reference number. for slock.it token sale, this is the contract address",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string Reference { get; set; }

        [ApiMember(Name = "ExtraData", Description = "for slock.it token sale, this is the data for the contract",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string ExtraData { get; set; }
    }
}