using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Ping", "POST", Summary = @"Post a string, then get it back.", Notes = @"Implementation notes...")]
    public class PingPost : IReturn<PingResponse>
    {
        [ApiMember(Name = "Message", Description = "Message that will be reflected on the Get", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Message { get; set; }
    }
}