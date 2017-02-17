using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/DepositRequest", "DELETE", Summary = @"Cancel okpay deposit", Notes = @"")]
public class CancelOkpayDeposit : IReturn<CommonResponse>
{
[ApiMember(Name = "TxId", Description = "Transaction id to cancel", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String TxId {get; set; } 
}
}

