using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Balance/Balances/{Currency}", "GET",
        Summary = @"Gets the available balance for s currency for the logged in account.", Notes = @"")]
    public class GetBalance : IReturn<BalanceResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency to query", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string Currency { get; set; }
    }
}