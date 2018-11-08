using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class InternalBankAccountResponse : CommonResponse
    {
        public InternalBankAccount Account { get; set; }
    }
}