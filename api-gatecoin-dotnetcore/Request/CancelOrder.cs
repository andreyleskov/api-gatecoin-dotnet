using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Orders/{OrderID}", "DELETE", Summary = @"Cancels an existing order", Notes = @"")]
    public class CancelOrder : IReturn<CommonResponse>
    {
        [ApiMember(Name = "OrderID", Description = "Client order Id. Use as order Id", ParameterType = "path",
            DataType = "string", IsRequired = true)]
        public string OrderID { get; set; }
    }
}