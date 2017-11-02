using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ReferralReward", "GET", Summary = @"Get referral reward information", Notes = @"")]
public class GetReferralRewardStatus : IReturn<CommonResponse>
{
}
}

