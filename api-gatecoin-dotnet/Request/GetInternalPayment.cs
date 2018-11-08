using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/InternalPayment/{TxID}", "Get", Summary = @"Get payment", Notes = @"")]
    public class GetInternalPayment : IReturn<GetInternalPaymentResponse>
    {
        [ApiMember(Name = "TxID", Description = "TxID", ParameterType = "Path", DataType = "string", IsRequired = true)]
        public string TxID { get; set; }
    }
}