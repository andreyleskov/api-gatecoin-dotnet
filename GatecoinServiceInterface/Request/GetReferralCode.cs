using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ReferralCode", "GET", Summary = @"Get the referral code of the logged in user", Notes = @"")]
public class GetReferralCode : IReturn<ReferralCodeResponse>
{
}
}

