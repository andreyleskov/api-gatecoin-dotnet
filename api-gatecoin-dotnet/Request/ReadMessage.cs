using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Notification/Messages/{ID}", "POST", Summary = @"Mark as read", Notes = @"")]
    public class ReadMessage : IReturn<CommonResponse>
    {
        [ApiMember(Name = "ID", Description = "Id of the Notification", ParameterType = "path", DataType = "long",
            IsRequired = false)]
        public long ID { get; set; }
    }
}