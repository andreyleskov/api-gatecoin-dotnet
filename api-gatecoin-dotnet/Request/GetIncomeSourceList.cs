using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/IncomeSourceList", "GET", Summary = @"Get the income source list.", Notes = @"")]
    public class GetIncomeSourceList : IReturn<ReferenceListResponse>
    {
    }
}