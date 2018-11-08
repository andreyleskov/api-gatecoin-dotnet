namespace GatecoinServiceInterface.Response
{
    public class GetInternalPaymentResponse : CommonResponse
    {
        public string Requester { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
    }
}