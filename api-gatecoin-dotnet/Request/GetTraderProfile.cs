using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Profile", "GET", Summary = @"Get trader profile", Notes = @"")]
    public class GetTraderProfile : IReturn<ProfileResponse>
    {
    }
}