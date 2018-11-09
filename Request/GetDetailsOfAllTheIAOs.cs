using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/InitialAssetOffering/Sales/", "GET", Summary = @"Gets detailed information of all the presales", Notes = @"")]
    public class GetIAOInfo : IReturn<SalesResponse>
    {
    }

    [Route("/preview/InitialAssetOffering/Sales/", "GET", Summary = @"Gets detailed information of all the presales", Notes = @"")]
    public class GetIAOInfoPreview : IReturn<SalesResponsePreview>
    {
    }
}