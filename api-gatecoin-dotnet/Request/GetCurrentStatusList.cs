using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/CurrentStatusList", "GET", Summary = @"Get the current status list.", Notes = @"")]
    public class GetCurrentStatusList : IReturn<ReferenceListResponse>
    {
    }
}