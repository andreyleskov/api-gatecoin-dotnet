using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Ticket/Tickets", "GET", Summary = @"Get all tickets for the logged in account. If ticketID is provided, the full tree of that ticket will be returned. Otherwise, the full list of root ticket will be returned", Notes = @"")]
public class GetTickets : IReturn<GetTicketsResponse>
{
}
}

