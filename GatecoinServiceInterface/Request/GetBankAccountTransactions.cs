using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/Transactions", "GET", Summary = @"Get all account transactions of the logged in user", Notes = @"")]
public class GetBankAccountTransactions : IReturn<BankAccountTransfersResponse>
{
}
}

