namespace GatecoinServiceInterface.Response
{
    public class AddOrderResponse : CommonResponse
    {
        public string ClOrderId { get; set; }
        public string OrderStatus { get; set; }
    }
}