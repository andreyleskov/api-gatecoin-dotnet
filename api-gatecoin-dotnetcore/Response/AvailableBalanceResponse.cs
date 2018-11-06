using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class AvailableBalanceResponse : CommonResponse
    {
        public AccountBalance Balance { get; set; }
    }
}