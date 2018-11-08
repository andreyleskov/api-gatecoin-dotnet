using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Info/ReferenceLanguage", "PUT", Summary = @"Update user's reference language", Notes = @"")]
    public class UpdateReferenceLanguage : IReturn<CommonResponse>
    {
        [ApiMember(Name = "language", Description = "language", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string language { get; set; }
    }
}