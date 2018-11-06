using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentID", "POST", Summary = @"Upload ID document copy", Notes = @"")]
    public class Document_ID : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DocumentNumber", Description = "Document number of the uploaded document",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string DocumentNumber { get; set; }

        [ApiMember(Name = "IssuingCountry", Description = "Issuing country of the uploaded document",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string IssuingCountry { get; set; }

        [ApiMember(Name = "MimeType", Description = "The mime type of the document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string MimeType { get; set; }

        [ApiMember(Name = "Content", Description = "File content in base64", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string Content { get; set; }
    }
}