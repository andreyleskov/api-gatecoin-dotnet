using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentInformation", "PUT", Summary = @"Update Step3 Data", Notes = @"")]
    public class PutDocumentInformation : IReturn<CommonResponse>
    {
        [ApiMember(Name = "IDDocumentNumber", Description = "IDDocumentNumber", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string IDDocumentNumber { get; set; }

        [ApiMember(Name = "IDIssuingCountry", Description = "IDIssuingCountry", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string IDIssuingCountry { get; set; }

        [ApiMember(Name = "IDMimeType", Description = "The mime type of the id document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string IDMimeType { get; set; }

        [ApiMember(Name = "IDContent", Description = "File content in base64 of id document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string IDContent { get; set; }

        [ApiMember(Name = "ProofMimeType", Description = "The mime type of the proof document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ProofMimeType { get; set; }

        [ApiMember(Name = "ProofContent", Description = "File content in base64 of proof document",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string ProofContent { get; set; }
    }
}