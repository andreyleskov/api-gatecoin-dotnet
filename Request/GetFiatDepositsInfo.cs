using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Deposits", "GET", Summary = @"Gets Fiat Deposits Info", Notes = @"")]
    public class GetFiatDepositsInfo : IReturn<FiatDepositsResponse>
    {
    }
}
