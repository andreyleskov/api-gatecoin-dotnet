using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/CurrencyPairs", "GET", Summary = @"Get the currency pair list.", Notes = @"")]
public class GetCurrencyPairs : IReturn<GetCurrencyPairResponse>
{
}
}

