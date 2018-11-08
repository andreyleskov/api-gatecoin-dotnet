using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentID", "PUT", Summary = @"Update ID document meta data", Notes = @"")]
    public class UpdateDocument_ID : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DocumentNumber", Description = "Document number of the uploaded document",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string DocumentNumber { get; set; }

        [ApiMember(Name = "IssuingCountry", Description = "Issuing country of the uploaded document",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string IssuingCountry { get; set; }
    }
}