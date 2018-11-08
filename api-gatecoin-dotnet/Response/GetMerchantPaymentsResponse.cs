using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetMerchantPaymentsResponse : CommonResponse
    {
        public List<MerchantPayment> Payments { get; set; }
    }
}