using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/TransactionsHistory/{CurrencyPair}", "GET", Summary = @"Gets all transactions", Notes = @"")]
    public class GetTransactionsHistory : IReturn<TransactionsResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string CurrencyPair { get; set; }

        [ApiMember(Name = "Count", Description = "Number of transactions to get. Max 10000", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int? Count { get; set; }

        [ApiMember(Name = "TransactionId", Description = "Get transactions from specific transaction id",
            ParameterType = "query", DataType = "long", IsRequired = false)]
        public long? TransactionId { get; set; }
    }
}