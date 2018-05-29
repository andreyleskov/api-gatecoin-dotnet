using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Transactions", "POST", Summary = @"Request a fiat withdrawal from traders account of logged in user", Notes = @"")]
    public class NewBankWithdrawals : IReturn<CommonResponse>
    {
        [ApiMember(Name = "BankAccountName", Description = "Nick of bank account", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankAccountName { get; set; }
        [ApiMember(Name = "Currency", Description = "Withdraw currency", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String Currency { get; set; }
        [ApiMember(Name = "Amount", Description = "Withdraw amount", ParameterType = "query", DataType = "decimal", IsRequired = true)]
        public System.Decimal Amount { get; set; }
        [ApiMember(Name = "Comment", Description = "Withdraw comment", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Comment { get; set; }
        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String ValidationCode { get; set; }
    }
}

