using GatecoinServiceInterface.Response;

namespace GatecoinServiceInterface.Model
{
    public class TradesResponse : CommonResponse
    {
        public Trades[] Response { get; set; }
    }
}