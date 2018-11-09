using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Ticket/Tickets/{TicketID}", "GET", Summary = @"Get all tickets for the logged in account. If ticketID is provided, the full tree of that ticket will be returned. Otherwise, the full list of root ticket will be returned", Notes = @"")]
public class GetTicket : IReturn<GetTicketsResponse>
{
[ApiMember(Name = "TicketID", Description = "Id of the ticket", ParameterType = "path", DataType = "long", IsRequired = false)]
public Int64 TicketID {get; set; } 
}
}

