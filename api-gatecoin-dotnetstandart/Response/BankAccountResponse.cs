using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class BankAccountResponse : CommonResponse
    {
        public BankAccount Account { get; set; }
    }
}