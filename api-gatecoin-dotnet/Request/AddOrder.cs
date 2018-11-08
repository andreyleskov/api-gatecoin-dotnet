using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Orders", "POST", Summary = @"Place an order at the exchange.",
        Notes = @"The account needs to be approved before transfer is possible.")]
    public class AddOrder : IReturn<AddOrderResponse>
    {
        [ApiMember(Name = "Code", Description = "The code of the order of the currency pair. Ex: BTCUSD, BTCJPY etc",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Code { get; set; }

        [ApiMember(Name = "Way", Description = "Ask or Bid", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Way { get; set; }

        [ApiMember(Name = "Amount",
            Description =
                "Amount expressed in the first currency of the currency pair. BTCUSD - both bid and ask orders are expressed in BTC",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "Price",
            Description =
                "Price expressed in the first currency of the currency pair. Ex. Regardless if you place a bid or ask BTCUSD, the price is always expressed in the price of one BTC in USD",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal Price { get; set; }

        [ApiMember(Name = "SpendAmount", Description = "Amount to spend", ParameterType = "query", DataType = "decimal",
            IsRequired = false)]
        public decimal SpendAmount { get; set; }

        [ApiMember(Name = "ExternalOrderID", Description = "External order ID", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ExternalOrderID { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}