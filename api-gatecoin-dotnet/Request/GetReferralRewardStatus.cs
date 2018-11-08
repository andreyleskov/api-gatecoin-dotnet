using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/ReferralReward", "GET", Summary = @"Get referral reward information", Notes = @"")]
    public class GetReferralRewardStatus : IReturn<CommonResponse>
    {
    }
}