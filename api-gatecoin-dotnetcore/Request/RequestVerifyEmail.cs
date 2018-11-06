using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Email/RequestVerify", "POST", Summary = @"Request for verification email", Notes = @"")]
    public class RequestVerifyEmail : IReturn<CommonResponse>
    {
        [ApiMember(Name = "IsPrimary", Description = "Primary or secondary email", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool IsPrimary { get; set; }
    }
}