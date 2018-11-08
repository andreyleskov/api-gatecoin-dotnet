using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/BusinessNatureList", "GET", Summary = @"Get the business nature list.", Notes = @"")]
    public class GetBusinessNatureList : IReturn<ReferenceListResponse>
    {
    }
}