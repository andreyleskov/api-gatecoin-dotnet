using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Balance/Deposits", "GET", Summary = @"Get all account deposits, including wire, okpay and digital currency, of the logged in user", Notes = @"")]
public class GetAllDeposits : IReturn<AllDepositsResponse>
{
}
}

