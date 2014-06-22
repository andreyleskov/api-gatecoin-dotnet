using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/QuickOrders_user", "GET", Summary = @"Get all executed quick orders of logged in user", Notes = @"")]
public class UserQuickOrders : IReturn<TransactionsResponse>
{
}
}

