namespace GatecoinServiceInterface.Response
{
    public class MerchantQuoteResponse : CommonResponse
    {
        public string Address { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string TxID { get; set; }
    }
}