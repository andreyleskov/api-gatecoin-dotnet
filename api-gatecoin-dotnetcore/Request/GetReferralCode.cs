using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/ReferralCode", "GET", Summary = @"Get the referral code of the logged in user", Notes = @"")]
    public class GetReferralCode : IReturn<ReferralCodeResponse>
    {
    }
}