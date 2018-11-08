using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/LiveTickers", "GET", Summary = @"Get live ticker for all currency", Notes = @"")]
    public class GetTicker24h : IReturn<TickersResponse>
    {
    }
}