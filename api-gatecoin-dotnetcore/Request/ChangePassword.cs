using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/ChangePassword", "POST", Summary = @"Change password.", Notes = @"")]
    public class ChangePassword : IReturn<CommonResponse>
    {
        [ApiMember(Name = "OldPassword", Description = "Old password", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string OldPassword { get; set; }

        [ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ConfirmPassword", Description = "Confirm password", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string ConfirmPassword { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}