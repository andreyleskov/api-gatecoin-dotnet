using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/StopOrders/{ID}", "DELETE", Summary = @"Cancels an existing stop order", Notes = @"")]
    public class CancelStopOrder : IReturn<CommonResponse>
    {
        [ApiMember(Name = "ID", Description = "Client order Id. Use as order Id", ParameterType = "path",
            DataType = "int", IsRequired = true)]
        public long ID { get; set; }
    }
}