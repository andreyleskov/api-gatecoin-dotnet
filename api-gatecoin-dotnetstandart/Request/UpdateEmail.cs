using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Email", "PUT", Summary = @"Update user email", Notes = @"")]
    public class UpdateEmail : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Email { get; set; }

        [ApiMember(Name = "Email2", Description = "2nd Email", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Email2 { get; set; }
    }
}