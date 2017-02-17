using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Balance/Withdrawals", "GET", Summary = @"Get all account withdrawals, including wire, okpay digital currency, of the logged in user", Notes = @"")]
public class GetAllWithdrawals : IReturn<AllWithdrawalsResponse>
{
}
}

