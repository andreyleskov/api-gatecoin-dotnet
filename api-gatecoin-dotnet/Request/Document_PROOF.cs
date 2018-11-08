using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentAddress", "POST", Summary = @"Upload address proof document", Notes = @"")]
    public class Document_PROOF : IReturn<CommonResponse>
    {
        [ApiMember(Name = "MimeType", Description = "The mime type of the document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string MimeType { get; set; }

        [ApiMember(Name = "Content", Description = "File content in base64", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string Content { get; set; }
    }
}