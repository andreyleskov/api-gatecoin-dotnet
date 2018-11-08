using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/Logout", "POST", Summary = @"Logout from the current session.", Notes = @"")]
    public class Logout : IReturn<CommonResponse>
    {
    }
}