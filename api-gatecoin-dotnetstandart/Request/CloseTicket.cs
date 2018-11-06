using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Ticket/Tickets/{TicketID}", "DELETE", Summary = @"Close a ticket for the logged in account.", Notes = @"")]
    public class CloseTicket : IReturn<CommonResponse>
    {
        [ApiMember(Name = "TicketID", Description = "Id of the ticket", ParameterType = "path", DataType = "int",
            IsRequired = true)]
        public long TicketID { get; set; }
    }
}