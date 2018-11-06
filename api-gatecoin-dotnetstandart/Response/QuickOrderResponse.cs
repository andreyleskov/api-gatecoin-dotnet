namespace GatecoinServiceInterface.Response
{
    public class QuickOrderResponse : CommonResponse
    {
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
}