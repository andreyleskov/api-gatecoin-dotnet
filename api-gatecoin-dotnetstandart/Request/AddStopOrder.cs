using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/StopOrders", "POST", Summary = @"Place a stop order at the exchange.",
        Notes = @"The account needs to be approved before transfer is possible.")]
    public class AddStopOrder : IReturn<AddStopOrderResponse>
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
            ParameterType = "query", DataType = "decimal", IsRequired = true)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "Price",
            Description =
                "Price expressed in the first currency of the currency pair. Ex. Regardless if you place a bid or ask BTCUSD, the price is always expressed in the price of one BTC in USD",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal Price { get; set; }

        [ApiMember(Name = "IsTwoStep",
            Description = "If true, a market/limit order is placed first, with a second step StopLoss/TakeProfit",
            ParameterType = "query", DataType = "bool", IsRequired = true)]
        public bool IsTwoStep { get; set; }

        [ApiMember(Name = "LowerType", Description = "Triggered or Trailing", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string LowerType { get; set; }

        [ApiMember(Name = "LowerPrice", Description = "Price when lower condition is triggered.",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal LowerPrice { get; set; }

        [ApiMember(Name = "LowerTarget", Description = "Trigger price for Triggered type. Trailing price for Trailing",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal LowerTarget { get; set; }

        [ApiMember(Name = "UpperType", Description = "Triggered or Trailing", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string UpperType { get; set; }

        [ApiMember(Name = "UpperPrice", Description = "Price when lower condition is triggered.",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal UpperPrice { get; set; }

        [ApiMember(Name = "UpperTarget", Description = "Trigger price for Triggered type. Trailing price for Trailing",
            ParameterType = "query", DataType = "decimal", IsRequired = false)]
        public decimal UpperTarget { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}