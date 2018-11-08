using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/Contact", "POST", Summary = @"Post a contact", Notes = @"Implementation notes...")]
    public class RecaptchaPost : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Subject", Description = "Subject", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Subject { get; set; }

        [ApiMember(Name = "Name", Description = "Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Name { get; set; }

        [ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Email { get; set; }

        [ApiMember(Name = "Message", Description = "Message that will be reflected on the Get", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Message { get; set; }

        [ApiMember(Name = "Response", Description = "Response code", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Response { get; set; }
    }
}