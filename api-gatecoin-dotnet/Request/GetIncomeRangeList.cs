using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/IncomeRangeList", "GET", Summary = @"Get the income range list.", Notes = @"")]
    public class GetIncomeRangeList : IReturn<ReferenceListResponse>
    {
    }
}