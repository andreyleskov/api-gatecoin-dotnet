using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Orders/{OrderID}", "GET", Summary = @"Gets an order for the logged in trader.", Notes = @"")]
    public class GetOrder : IReturn<OrderResponse>
    {
        [ApiMember(Name = "OrderID", Description = "Order ID", ParameterType = "path", DataType = "string",
            IsRequired = true)]
        public string OrderId { get; set; }
    }
}