using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Withdrawal/{TxId}", "DELETE", Summary = @"Cancel okpay withdrawal", Notes = @"")]
public class CancelOkpayWithdrawal : IReturn<CommonResponse>
{
[ApiMember(Name = "TxId", Description = "Transaction id to cancel", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String TxId {get; set; } 
}
}

