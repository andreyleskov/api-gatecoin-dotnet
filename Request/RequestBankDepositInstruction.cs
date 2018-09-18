using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route ("/Bank/DepositInstructions", "POST", Summary = @"Request bank deposit instruction by email", Notes = @"")]
    public class RequestBankDepositInstruction : IReturn<CommonResponse>
    {
        [ApiMember (Name = "BankAccountId", Description = "ID of the bank account", ParameterType = "path", DataType = "long", IsRequired = false)]
        public long BankAccountId { get; set; } 
    }
}
