using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/DepositRequest", "DELETE", Summary = @"Cancel okpay deposit", Notes = @"")]
    public class CancelOkpayDeposit : IReturn<CommonResponse>
    {
        [ApiMember(Name = "TxId", Description = "Transaction id to cancel", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string TxId { get; set; }
    }
}