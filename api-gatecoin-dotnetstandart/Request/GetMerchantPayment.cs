using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Payment/{TxID}", "GET", Summary = @"Get payment by txid", Notes = @"")]
    public class GetMerchantPayment : IReturn<OrdersResponse>
    {
        [ApiMember(Name = "TxID", Description = "TxID", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string TxID { get; set; }
    }
}