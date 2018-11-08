using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/LogoutOtherSessions", "POST", Summary = @"Logout other sessions.", Notes = @"")]
    public class LogoutOtherSessions : IReturn<CommonResponse>
    {
    }
}