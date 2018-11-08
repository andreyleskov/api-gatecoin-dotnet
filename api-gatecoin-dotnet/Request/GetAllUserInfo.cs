using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/User", "GET", Summary = @"Get all user info", Notes = @"")]
    public class GetAllUserInfo : IReturn<AllUserInfoResponse>
    {
    }
}