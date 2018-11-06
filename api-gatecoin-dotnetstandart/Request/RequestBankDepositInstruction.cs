using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/DepositInstructions", "POST", Summary = @"Request bank deposit instruction by email", Notes = @"")]
    public class RequestBankDepositInstruction : IReturn<CommonResponse>
    {
        [ApiMember(Name = "BankAccountId", Description = "ID of the bank account", ParameterType = "path",
            DataType = "long", IsRequired = false)]
        public long BankAccountId { get; set; }
    }
}