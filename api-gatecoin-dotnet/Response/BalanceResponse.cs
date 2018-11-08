using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class BalanceResponse : CommonResponse
    {
        public AccountBalance Balance { get; set; }
    }
}