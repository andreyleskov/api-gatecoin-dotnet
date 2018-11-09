using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route ("/Bank/DepositSubmit", "POST", Summary = @"Upload bank deposit", Notes = @"")]
    public class DepositFiat : IReturn<CommonResponse>
    {
        [ApiMember (Name = "BankAccountId", Description = "ID of the bank account", ParameterType = "path", DataType = "long", IsRequired = true)]
        public long BankAccountId { get; set; }
        [ApiMember (Name = "Amount", Description = "Amount", ParameterType = "path", DataType = "decimal", IsRequired = true)]
        public decimal Amount { get; set; }
        [ApiMember (Name = "DepositDate", Description = "Deposit Date", ParameterType = "query", DataType = "datetime", IsRequired = true)]
        public DateTime DepositDate { get; set; }
        [ApiMember (Name = "SenderAccountHolder", Description = "Sender name of the deposit", ParameterType = "query", DataType = "string", IsRequired = true)]
        public String SenderAccountHolder { get; set; }
        [ApiMember (Name = "Comment", Description = "Deposit Comment", ParameterType = "query", DataType = "string", IsRequired = false)]
        public String Comment { get; set; }
        [ApiMember (Name = "FileType", Description = "The mime type of the file", ParameterType = "query", DataType = "string", IsRequired = true)]
        public String FileType { get; set; }
        [ApiMember (Name = "ReceiptContent", Description = "File content in base64", ParameterType = "query", DataType = "string", IsRequired = true)]
        public String ReceiptContent { get; set; }
    }
}
