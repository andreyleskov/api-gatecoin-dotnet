using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Transactions", "GET", Summary = @"Get all digital currency transactions of the logged in user", Notes = @"")]
public class GetElectronicWalletTransactions : IReturn<ElectronicWalletTransactionsResponse>
{
}
}

