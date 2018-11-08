using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetInternalPaymentsResponse : CommonResponse
    {
        public List<InternalPayment> Payments { get; set; }
    }
}