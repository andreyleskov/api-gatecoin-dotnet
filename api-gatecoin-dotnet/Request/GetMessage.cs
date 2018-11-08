using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Notification/Messages", "GET", Summary = @"Get from oldest unread + 3 read message to newest messages",
        Notes = @"")]
    public class GetMessage : IReturn<GetNotificationResponse>
    {
    }
}