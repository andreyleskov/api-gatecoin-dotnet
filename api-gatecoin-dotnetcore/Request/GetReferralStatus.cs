using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Referral", "GET", Summary = @"Get referral information", Notes = @"")]
    public class GetReferralStatus : IReturn<CommonResponse>
    {
    }
}