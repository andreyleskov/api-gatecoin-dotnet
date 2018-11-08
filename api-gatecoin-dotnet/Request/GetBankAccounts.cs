using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/UserAccounts", "GET", Summary = @"Gets all the bank accounts related to the logged in user.",
        Notes = @"")]
    [Route("/Bank/Account", "GET", Summary = @"Gets all the bank accounts related to the logged in user.", Notes = @"")]
    [Route("/Bank/Account/{Currency}", "GET", Summary = @"Gets all the bank accounts related to the logged in user.",
        Notes = @"")]
    public class GetBankAccounts : IReturn<BankAccountsResponse>
    {
    }
}