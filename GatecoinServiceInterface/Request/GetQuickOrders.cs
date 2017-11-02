using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/QuickChange", "GET", Summary = @"Get all executed quick orders of logged in user", Notes = @"")]
public class GetQuickOrders : IReturn<TransactionsResponse>
{
}
}

