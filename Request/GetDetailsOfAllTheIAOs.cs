using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/InitialAssetOffering/Sales/", "GET", Summary = @"Gets detailed information of all the presales", Notes = @"")]
    public class GetIAOInfo : IReturn<SalesResponse>
    {
    }
}