using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/Trades", "GET", Summary = @"Gets all transactions of logged in user", Notes = @"")]
public class UserTransactions : IReturn<UserTransactionsResponse>
{
[ApiMember(Name = "Count", Description = "Number of transactions to get. Max 1000", ParameterType = "query", DataType = "int", IsRequired = false)]
public System.Int32? Count {get; set; } 
[ApiMember(Name = "TransactionID", Description = "Get transactions from specific transaction id", ParameterType = "query", DataType = "long", IsRequired = false)]
public System.Int64? TransactionID {get; set; } 
}
}

