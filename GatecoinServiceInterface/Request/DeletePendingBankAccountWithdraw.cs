using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/Transactions/{RequestID}", "DELETE", Summary = @"Delete pending account withdraw of the logged in user", Notes = @"")]
public class DeletePendingBankAccountWithdraw : IReturn<CommonResponse>
{
[ApiMember(Name = "RequestID", Description = "Request ID", ParameterType = "path", DataType = "long", IsRequired = false)]
public Int64 RequestID {get; set; } 
}
}

