using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Transactions", "GET", Summary = @"Get okpay transfers", Notes = @"")]
public class GetOkpayTransactions : IReturn<OkpayTransactionResponse>
{
}
}

