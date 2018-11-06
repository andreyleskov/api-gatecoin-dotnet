using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/StopOrders", "DELETE", Summary = @"Cancels all existing stop orders", Notes = @"")]
    public class CancelStopOrders : IReturn<CommonResponse>
    {
    }
}