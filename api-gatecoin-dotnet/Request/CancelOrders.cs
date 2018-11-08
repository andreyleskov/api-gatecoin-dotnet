using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Orders", "DELETE", Summary = @"Cancels all existing order", Notes = @"")]
    public class CancelOrders : IReturn<CommonResponse>
    {
    }
}