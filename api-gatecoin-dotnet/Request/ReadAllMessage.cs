using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Notification/Messages", "POST", Summary = @"Mark all as read", Notes = @"")]
    public class ReadAllMessage : IReturn<CommonResponse>
    {
    }
}