using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/ForgotUserID", "POST", Summary = @"Request user id", Notes = @"")]
    public class ForgotUserId : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Email", Description = "User email", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Email { get; set; }

        [ApiMember(Name = "IDNumber", Description = "Identity document number", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string IDNumber { get; set; }
    }
}