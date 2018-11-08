using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetMerchantPaymentResponse : CommonResponse
    {
        public MerchantPayment Payment { get; set; }
    }
}