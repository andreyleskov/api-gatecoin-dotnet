using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Withdrawal/{TxId}", "DELETE", Summary = @"Cancel okpay withdrawal", Notes = @"")]
    public class CancelOkpayWithdrawal : IReturn<CommonResponse>
    {
        [ApiMember(Name = "TxId", Description = "Transaction id to cancel", ParameterType = "path", DataType = "string",
            IsRequired = true)]
        public string TxId { get; set; }
    }
}