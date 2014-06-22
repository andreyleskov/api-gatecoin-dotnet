using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Ticket/GetTickets", "GET", Summary = @"Get all tickets for the logged in account.", Notes = @"")]
public class GetTickets : IReturn<GetTicketsResponse>
{
}
}

