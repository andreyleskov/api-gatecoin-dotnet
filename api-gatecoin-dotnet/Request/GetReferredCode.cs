using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/ReferredCode", "GET", Summary = @"Get referral code", Notes = @"")]
    public class GetReferredCode : IReturn<ReferredCodeResponse>
    {
    }
}