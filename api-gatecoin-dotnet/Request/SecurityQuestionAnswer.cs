using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/SecurityQuestionAnswer", "POST", Summary = @"Set security question and answer for reset password",
        Notes = @"")]
    public class SecurityQuestionAnswer : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Question", Description = "Security question (Max 80 char)", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Question { get; set; }

        [ApiMember(Name = "Answer", Description = "Security answer (Max 80 char)", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Answer { get; set; }

        [ApiMember(Name = "Password", Description = "Password is required to set security question and answer",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }
    }
}