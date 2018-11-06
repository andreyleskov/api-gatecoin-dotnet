namespace GatecoinServiceInterface.Response
{
    public class AddStopOrderResponse : CommonResponse
    {
        public string OrderId { get; set; }
        public string OrderStatus { get; set; }
    }
}