using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class RequestForQuoteResponse : CommonResponse
    {
        public QuickOrderQuote Quote { get; set; }
    }
}