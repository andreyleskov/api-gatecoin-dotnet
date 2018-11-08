using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetMerchantGatewayResponse : CommonResponse
    {
        public List<MerchantGateway> Gateways { get; set; }
    }
}