using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/TransactionsHistory/{CurrencyPair}", "GET", Summary = @"Gets all transactions", Notes = @"")]
public class GetTransactionsHistory : IReturn<TransactionsResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String CurrencyPair {get; set; } 
[ApiMember(Name = "Count", Description = "Number of transactions to get. Max 10000", ParameterType = "query", DataType = "int", IsRequired = false)]
public System.Int32? Count {get; set; } 
[ApiMember(Name = "TransactionId", Description = "Get transactions from specific transaction id", ParameterType = "query", DataType = "long", IsRequired = false)]
public System.Int64? TransactionId {get; set; } 
}
}

