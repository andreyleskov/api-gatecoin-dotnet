using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/UserTrades", "GET", Summary = @"Gets all transactions of logged in user", Notes = @"")]
    public class UserTrades : IReturn<UserTransactionsResponse>
    {
        [ApiMember(Name = "after", Description = "Get 50 transactions each time", ParameterType = "query",
            DataType = "long", IsRequired = false)]
        public int? after { get; set; }
    }
}