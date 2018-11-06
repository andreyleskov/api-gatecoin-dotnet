using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Transactions", "GET", Summary = @"Get all account transactions of the logged in user", Notes = @"")]
    public class GetBankAccountTransactions : IReturn<BankAccountTransfersResponse>
    {
    }
}