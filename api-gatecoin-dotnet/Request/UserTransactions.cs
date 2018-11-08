using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Trades", "GET", Summary = @"Gets all transactions of logged in user", Notes = @"")]
    public class UserTransactions : IReturn<UserTransactionsResponse>
    {
        [ApiMember(Name = "Count", Description = "Number of transactions to get. Max 1000", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int? Count { get; set; }

        [ApiMember(Name = "TransactionID", Description = "Get transactions from specific transaction id",
            ParameterType = "query", DataType = "long", IsRequired = false)]
        public long? TransactionID { get; set; }
    }
}