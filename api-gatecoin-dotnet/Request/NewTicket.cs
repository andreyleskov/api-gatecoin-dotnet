using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Ticket/Tickets", "POST", Summary = @"Create a ticket", Notes = @"")]
    public class NewTicket : IReturn<CreateTicketResponse>
    {
        [ApiMember(Name = "Subject", Description = "Subject of the ticket", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Subject { get; set; }

        [ApiMember(Name = "Message", Description = "Message of the ticket", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Message { get; set; }

        [ApiMember(Name = "TicketID", Description = "Answer ticket ID", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public long? TicketID { get; set; }

        [ApiMember(Name = "MimeType", Description = "The mime type of the document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string MimeType { get; set; }

        [ApiMember(Name = "Content", Description = "File content in base64", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string Content { get; set; }
    }
}