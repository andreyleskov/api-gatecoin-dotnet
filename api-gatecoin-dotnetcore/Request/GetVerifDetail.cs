using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/SecuritySettings", "GET", Summary = @"Get verif details of logged in user", Notes = @"")]
    public class GetVerifDetail : IReturn<VerifDetailResponse>
    {
    }
}