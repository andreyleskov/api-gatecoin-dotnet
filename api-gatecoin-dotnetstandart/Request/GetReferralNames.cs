using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/ReferralNames", "GET", Summary = @"Get names of referred traders", Notes = @"")]
    public class GetReferralNames : IReturn<CommonResponse>
    {
    }
}